using System.Windows.Forms;
using System.Linq;

namespace Cloudrip
{

    public enum ResultSet
    {
        YES_NO = 0,
        OK = 1
    }

    public partial class CustomMessageBox : Form
    {

        private readonly int BUTTON_HEIGHT_OFFSET = 20;
        private readonly int FORM_HEIGHT_OFFSET = 20;

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult Show(string msg, ResultSet results = ResultSet.OK, string title = "")
        {
            label_title.Text = title;
            label_msg.Text = msg;
            
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Location = new System.Drawing.Point(button.Location.X, label_msg.Bottom + BUTTON_HEIGHT_OFFSET);
            }

            this.Size = new System.Drawing.Size(this.Size.Width, button_main.Bottom + FORM_HEIGHT_OFFSET);
            border_bottom.Location = new System.Drawing.Point(0, this.Height - border_bottom.Height);

            border_left.Size = new System.Drawing.Size(border_left.Width, this.Height);
            border_right.Size = new System.Drawing.Size(border_right.Width, this.Height);

            switch (results)
            {
                case ResultSet.OK:
                    button_main.Text = "OK";
                    button_main.DialogResult = DialogResult.OK;
                    break;

                case ResultSet.YES_NO:
                    button_yes.Visible = true;
                    break;
            }

            return this.ShowDialog();
        }

        private void CustomMessageBox_Load(object sender, System.EventArgs e)
        {
            WindowlessMove.Register_MouseHandler(this);
        }
    }
}
