namespace Cloudrip
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_msg = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_yes = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.border_top = new System.Windows.Forms.Panel();
            this.border_bottom = new System.Windows.Forms.Panel();
            this.border_left = new System.Windows.Forms.Panel();
            this.border_right = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(10, 52);
            this.label_msg.MaximumSize = new System.Drawing.Size(430, 0);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(0, 14);
            this.label_msg.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.DarkRed;
            this.label_title.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(10, 10);
            this.label_title.MaximumSize = new System.Drawing.Size(430, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(0, 15);
            this.label_title.TabIndex = 1;
            // 
            // button_yes
            // 
            this.button_yes.BackColor = System.Drawing.Color.Transparent;
            this.button_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.button_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yes.ForeColor = System.Drawing.Color.White;
            this.button_yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_yes.Location = new System.Drawing.Point(10, 120);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(200, 55);
            this.button_yes.TabIndex = 2;
            this.button_yes.Text = "YES";
            this.button_yes.UseVisualStyleBackColor = false;
            this.button_yes.Visible = false;
            // 
            // button_main
            // 
            this.button_main.BackColor = System.Drawing.Color.Transparent;
            this.button_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.button_main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_main.ForeColor = System.Drawing.Color.White;
            this.button_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_main.Location = new System.Drawing.Point(240, 120);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(200, 55);
            this.button_main.TabIndex = 3;
            this.button_main.Text = "NO";
            this.button_main.UseVisualStyleBackColor = false;
            // 
            // border_top
            // 
            this.border_top.BackColor = System.Drawing.Color.DarkRed;
            this.border_top.Location = new System.Drawing.Point(0, 0);
            this.border_top.Name = "border_top";
            this.border_top.Size = new System.Drawing.Size(450, 35);
            this.border_top.TabIndex = 5;
            // 
            // border_bottom
            // 
            this.border_bottom.BackColor = System.Drawing.Color.DarkRed;
            this.border_bottom.Location = new System.Drawing.Point(0, 190);
            this.border_bottom.Name = "border_bottom";
            this.border_bottom.Size = new System.Drawing.Size(450, 5);
            this.border_bottom.TabIndex = 6;
            // 
            // border_left
            // 
            this.border_left.BackColor = System.Drawing.Color.DarkRed;
            this.border_left.Location = new System.Drawing.Point(0, 0);
            this.border_left.Name = "border_left";
            this.border_left.Size = new System.Drawing.Size(5, 195);
            this.border_left.TabIndex = 7;
            // 
            // border_right
            // 
            this.border_right.BackColor = System.Drawing.Color.DarkRed;
            this.border_right.Location = new System.Drawing.Point(445, 0);
            this.border_right.Name = "border_right";
            this.border_right.Size = new System.Drawing.Size(5, 195);
            this.border_right.TabIndex = 8;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(450, 195);
            this.Controls.Add(this.border_right);
            this.Controls.Add(this.border_left);
            this.Controls.Add(this.border_bottom);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.border_top);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Panel border_top;
        private System.Windows.Forms.Panel border_bottom;
        private System.Windows.Forms.Panel border_left;
        private System.Windows.Forms.Panel border_right;
    }
}