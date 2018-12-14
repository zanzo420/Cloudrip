using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cloudrip.Properties;
using HtmlAgilityPack;

namespace Cloudrip
{

    public partial class Form1 : Form
    {
        public CloudripUser user = null;
        private Dictionary<string, string> allSeries = new Dictionary<string, string>();
        private Dictionary<string, string> currentSeasons = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomMessageBox.NewMessageBox(Resources.About, ResultSet.OK, Resources.SoftwareName + " v" + Resources.VERSION);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowlessMove.Register_MouseHandler(this);

            foreach (Button button in sidePanel.Controls.OfType<Button>())
            {
                if (button.Name.ToLower().StartsWith("sidebutton"))
                {
                    button.Click += Register_Sidebar_Selection;
                }
            }

            Cloudrip_Client.Connect(this);
        }

        internal void UpdateSeasonTabs()
        {
            TabControl cntrl = tabControl_Seasons;
            cntrl.TabPages.Clear();

            foreach (string seasonName in currentSeasons.Keys)
            {
                //New TabPage
                TabPage newPage = new TabPage(currentSeasons[seasonName]);
                cntrl.TabPages.Add(newPage);

                //New ListView
                ListView listView = new ListView();
                listView.View = View.Details;
                listView.Size = new Size(newPage.Width, newPage.Height);
                listView.Width = newPage.Width;
                listView.Location = new Point(0, 0);
                listView.MultiSelect = false;
                listView.FullRowSelect = true;

                //2 new ColumnHeaders
                ColumnHeader firstCol = new ColumnHeader();
                firstCol.Text = "#";
                firstCol.Width = 30;

                ColumnHeader secondCol = new ColumnHeader();
                secondCol.Text = "Name";
                secondCol.Width = listView.Width - firstCol.Width;

                //Add everything together
                listView.Columns.Add(firstCol);
                listView.Columns.Add(secondCol);
                newPage.Controls.Add(listView);

                //ToDo: Staffeln asynchron laden
                string episodesDump = HTTPClient.SendGET("https://bs.to/" + seasonName);

                //Fetching episodetable
                HtmlNode episodeTable = HTTPClient.GetElementsByTag(episodesDump, "table")[0];

                //Fetching episodes
                HtmlNodeCollection episodes = HTTPClient.GetElementsByTag(episodeTable.OuterHtml, "tr");

                //Parsing episodes
                foreach (HtmlNode episode in episodes)
                {
                    string episodeName = HTTPClient.GetElementsByTag(episode.OuterHtml, "a")[1].InnerText;
                    string episodeNr = HTTPClient.GetElementsByTag(episode.OuterHtml, "a")[0].InnerText;
                    string episodeURL = HTTPClient.GetElementsByTag(episode.OuterHtml, "a")[0].GetAttributeValue("href", "");

                    if (episodeURL != "")
                    {
                        ListViewItem episodeItm = new ListViewItem(episodeNr);
                        episodeItm.SubItems.Add(episodeName);
                        episodeItm.Tag = episodeURL;
                        listView.Items.Add(episodeItm);
                    }
                }
            }
        }

        internal void RefreshSeasonList(string seriesName)
        {
            if (seriesName != null)
            {
                string episodesURL = "https://bs.to/" + seriesName;
                string htmlDump = HTTPClient.SendGET(episodesURL);
                HtmlNodeCollection seasons = HTTPClient.GetElementsByClassInName(htmlDump, "s", "li");

                foreach (HtmlNode seasonNode in seasons)
                {
                    string seasonName = seasonNode.InnerText;
                    string seasonURL = HTTPClient.GetElementsByTag(seasonNode.OuterHtml, "a")[0].GetAttributeValue("href", "");

                    if (seasonURL != "")
                    {
                        currentSeasons.Add(seasonURL, seasonName);
                    }
                }
            }
        }

        internal void UpdateSeriesList()
        {
            Invoker.ClearList(Search_listView_Series);
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (string seriesURL in allSeries.Keys)
            {
                ListViewItem itm = new ListViewItem(allSeries[seriesURL]);
                itm.Tag = seriesURL;
                items.Add(itm);
            }

            Invoker.AddListItems(Search_listView_Series, items);
        }

        internal void RefreshSeriesList()
        {
            allSeries.Clear();

            string url = "https://bs.to/andere-serien";
            string htmlDump = HTTPClient.SendGET(url);
            HtmlNodeCollection catNodes = HTTPClient.GetElementsByClass(htmlDump, "genre", "div");

            foreach (HtmlNode cat in catNodes)
            {
                HtmlNodeCollection tmpSeries = HTTPClient.GetElementsByTag(cat.OuterHtml, "a");
                foreach (HtmlNode catSeries in tmpSeries)
                {
                    string href = catSeries.GetAttributeValue("href", "");
                    string seriesName = catSeries.InnerText;

                    if (href != "")
                    {
                        allSeries.Add(href, seriesName);
                    }
                }
            }
        }

        private void Register_Sidebar_Selection(object sender, EventArgs e)
        {
            BindSelectionToButton((Button)sender);
        }

        private void BindSelectionToButton(Button button)
        {
            border_selected.Top = button.Top;
        }

        public void Change_MainControl(GroupBox visibleControl)
        {
            foreach (Control control in this.Controls.OfType<GroupBox>())
            {
                Invoker.ChangeVisible(control, false);
            }

            Invoker.ChangeVisible(visibleControl, true);
        }

        private void sideButton_Login_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text.ToLower())
            {
                case "login":
                    Change_MainControl(groupBox_Login);
                    break;

                case "home":
                    Change_MainControl(groupBox_Home);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change_MainControl(groupBox_Register);
        }

        private void sideButton_Search_Click(object sender, EventArgs e)
        {
            Change_MainControl(groupBox_Search);
        }

        private void sideButton_Favorites_Click(object sender, EventArgs e)
        {
            Change_MainControl(groupBox_Favorites);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cloudrip_Client.Login(login_textBox_Username.Text, login_textBox_Password.Text);
        }

        private void register_button_Register_Click(object sender, EventArgs e)
        {
            Cloudrip_Client.Register(register_textBox_Username.Text, register_textBox_Password.Text, register_textBox_Password2.Text);
        }

        private void Search_button_search_Click(object sender, EventArgs e)
        {
            //Debug only
            RefreshSeriesList();
            UpdateSeriesList();
        }

        private void Search_listView_Series_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem itm = Search_listView_Series.SelectedItems.Count > 0 ? Search_listView_Series.SelectedItems[0] : null;

            RefreshSeasonList(itm.Tag.ToString());
            UpdateSeasonTabs();
        }
    }
}