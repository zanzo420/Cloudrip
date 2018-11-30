using System.Windows.Forms;

namespace Cloudrip
{
    class WindowlessMove
    {
        public Control GUI { get; private set; }

        public static void Register_MouseHandler(Form form)
        {
            WindowlessMove newObj = new WindowlessMove();
            newObj.GUI = form;
            form.MouseDown += newObj.MoveWindowless;

            foreach (Control control in form.Controls)
            {
                newObj.Register_OnControl(control);
            }
        }
        private void Register_OnControl(Control control)
        {
            if (control.GetType() != typeof(Button))
            {
                control.MouseDown += MoveWindowless;
            }

            if (control.Controls.Count > 0)
            {
                foreach (Control child in control.Controls)
                {
                    Register_OnControl(child);
                }
            }
        }

        public void MoveWindowless(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                User32.ReleaseCapture();
                User32.SendMessage(GUI.Handle, User32.WM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
            }
        }
    }
}
