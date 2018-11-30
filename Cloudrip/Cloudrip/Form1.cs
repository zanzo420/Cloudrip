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
            CustomMessageBox aboutBox = new CustomMessageBox();
            aboutBox.Show(Resources.About, ResultSet.OK, Resources.SoftwareName + " v" + Resources.VERSION );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowlessMove.Register_MouseHandler(this);
        }
    }
}
