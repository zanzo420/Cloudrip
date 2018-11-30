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

namespace Cloudrip
{

    public partial class Form1 : Form
    {
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

            TcpClient.Start();
        }
        private void Register_Sidebar_Selection(object sender, EventArgs e)
        {
            BindSelectionToButton((Button)sender);
        }
        private void BindSelectionToButton(Button button)
        {
            border_selected.Top = button.Top;
        }
        private void Change_MainControl(GroupBox visibleControl)
        {
            foreach (Control control in this.Controls.OfType<GroupBox>())
            {
                control.Visible = false;
            }

            visibleControl.Visible = true;
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
            TcpClient.Send("LOGIN");

            //sideButton_Login.Text = "Home";
            //sideButton_Login.Image = Cloudrip.Properties.Resources.home;
            //sideButton_Search.Visible = true;
            //sideButton_Favorites.Visible = true;
            //Change_MainControl(groupBox_Home);
        }
    }
}
