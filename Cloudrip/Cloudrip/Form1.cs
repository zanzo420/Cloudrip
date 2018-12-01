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

            Cloudrip_Client.Connect(this);
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void border_selected_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox_Register_Enter(object sender, EventArgs e)
        {

        }

        private void register_textBox_Password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox_Login_Enter(object sender, EventArgs e)
        {

        }

        private void login_textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Search_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Favorites_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Home_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
