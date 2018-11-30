namespace Cloudrip
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.border_selected = new System.Windows.Forms.Panel();
            this.sideButton_Favorites = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideButton_Search = new System.Windows.Forms.Button();
            this.sideButton_Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.register1 = new Cloudrip.Register();
            this.login1 = new Cloudrip.Login();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidePanel.Controls.Add(this.border_selected);
            this.sidePanel.Controls.Add(this.sideButton_Favorites);
            this.sidePanel.Controls.Add(this.button4);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.sideButton_Search);
            this.sidePanel.Controls.Add(this.sideButton_Login);
            this.sidePanel.ForeColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(210, 576);
            this.sidePanel.TabIndex = 0;
            // 
            // border_selected
            // 
            this.border_selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.border_selected.Location = new System.Drawing.Point(0, 50);
            this.border_selected.Name = "border_selected";
            this.border_selected.Size = new System.Drawing.Size(10, 55);
            this.border_selected.TabIndex = 4;
            // 
            // sideButton_Favorites
            // 
            this.sideButton_Favorites.BackColor = System.Drawing.Color.Transparent;
            this.sideButton_Favorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideButton_Favorites.FlatAppearance.BorderSize = 0;
            this.sideButton_Favorites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.sideButton_Favorites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.sideButton_Favorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideButton_Favorites.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideButton_Favorites.ForeColor = System.Drawing.Color.White;
            this.sideButton_Favorites.Image = global::Cloudrip.Properties.Resources.star;
            this.sideButton_Favorites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideButton_Favorites.Location = new System.Drawing.Point(10, 160);
            this.sideButton_Favorites.Name = "sideButton_Favorites";
            this.sideButton_Favorites.Size = new System.Drawing.Size(200, 55);
            this.sideButton_Favorites.TabIndex = 4;
            this.sideButton_Favorites.Text = "Favorites";
            this.sideButton_Favorites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sideButton_Favorites.UseVisualStyleBackColor = false;
            this.sideButton_Favorites.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Cloudrip.Properties.Resources.information;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "About Cloudrip";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cloudrip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideButton_Search
            // 
            this.sideButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.sideButton_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideButton_Search.FlatAppearance.BorderSize = 0;
            this.sideButton_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.sideButton_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.sideButton_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideButton_Search.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideButton_Search.ForeColor = System.Drawing.Color.White;
            this.sideButton_Search.Image = global::Cloudrip.Properties.Resources.search;
            this.sideButton_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideButton_Search.Location = new System.Drawing.Point(10, 105);
            this.sideButton_Search.Name = "sideButton_Search";
            this.sideButton_Search.Size = new System.Drawing.Size(200, 55);
            this.sideButton_Search.TabIndex = 2;
            this.sideButton_Search.Text = "Search";
            this.sideButton_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sideButton_Search.UseVisualStyleBackColor = false;
            this.sideButton_Search.Visible = false;
            // 
            // sideButton_Login
            // 
            this.sideButton_Login.BackColor = System.Drawing.Color.Transparent;
            this.sideButton_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideButton_Login.FlatAppearance.BorderSize = 0;
            this.sideButton_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(99)))), ((int)(((byte)(100)))));
            this.sideButton_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.sideButton_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideButton_Login.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideButton_Login.ForeColor = System.Drawing.Color.White;
            this.sideButton_Login.Image = global::Cloudrip.Properties.Resources.login;
            this.sideButton_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideButton_Login.Location = new System.Drawing.Point(10, 50);
            this.sideButton_Login.Name = "sideButton_Login";
            this.sideButton_Login.Size = new System.Drawing.Size(200, 55);
            this.sideButton_Login.TabIndex = 1;
            this.sideButton_Login.Text = "Login";
            this.sideButton_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sideButton_Login.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 3);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 50);
            this.panel3.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(115)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Cloudrip.Properties.Resources.settings;
            this.button5.Location = new System.Drawing.Point(924, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(115)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Cloudrip.Properties.Resources.shutdown;
            this.button3.Location = new System.Drawing.Point(974, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.register1.Location = new System.Drawing.Point(210, 100);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(677, 191);
            this.register1.TabIndex = 6;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.login1.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.login1.Location = new System.Drawing.Point(210, 100);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(668, 173);
            this.login1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button sideButton_Login;
        private System.Windows.Forms.Button sideButton_Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sideButton_Favorites;
        private Login login1;
        private Register register1;
        private System.Windows.Forms.Panel border_selected;
    }
}

