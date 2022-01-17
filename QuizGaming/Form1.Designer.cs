
namespace QuizGaming
{
    partial class Form1
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
            this.txtUPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAdmin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdminUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblState = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUPassword
            // 
            this.txtUPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtUPassword.BorderColor = System.Drawing.Color.Yellow;
            this.txtUPassword.BorderRadius = 20;
            this.txtUPassword.BorderThickness = 0;
            this.txtUPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUPassword.DefaultText = "Password";
            this.txtUPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUPassword.DisabledState.Parent = this.txtUPassword;
            this.txtUPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtUPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUPassword.FocusedState.Parent = this.txtUPassword;
            this.txtUPassword.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.txtUPassword.ForeColor = System.Drawing.Color.MintCream;
            this.txtUPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUPassword.HoverState.Parent = this.txtUPassword;
            this.txtUPassword.Location = new System.Drawing.Point(93, 205);
            this.txtUPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.PasswordChar = '\0';
            this.txtUPassword.PlaceholderText = "";
            this.txtUPassword.SelectedText = "";
            this.txtUPassword.ShadowDecoration.Parent = this.txtUPassword;
            this.txtUPassword.Size = new System.Drawing.Size(241, 49);
            this.txtUPassword.TabIndex = 9;
            this.txtUPassword.TextChanged += new System.EventHandler(this.txtUPassword_TextChanged);
            this.txtUPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUPassword_MouseClick);
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(12, 372);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(284, 29);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Click Here To Login With User";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtAdminUserName.BorderColor = System.Drawing.Color.Yellow;
            this.txtAdminUserName.BorderRadius = 20;
            this.txtAdminUserName.BorderThickness = 0;
            this.txtAdminUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminUserName.DefaultText = "User Name";
            this.txtAdminUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminUserName.DisabledState.Parent = this.txtAdminUserName;
            this.txtAdminUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtAdminUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminUserName.FocusedState.Parent = this.txtAdminUserName;
            this.txtAdminUserName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.txtAdminUserName.ForeColor = System.Drawing.Color.MintCream;
            this.txtAdminUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminUserName.HoverState.Parent = this.txtAdminUserName;
            this.txtAdminUserName.Location = new System.Drawing.Point(93, 134);
            this.txtAdminUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.PasswordChar = '\0';
            this.txtAdminUserName.PlaceholderText = "";
            this.txtAdminUserName.SelectedText = "";
            this.txtAdminUserName.ShadowDecoration.Parent = this.txtAdminUserName;
            this.txtAdminUserName.Size = new System.Drawing.Size(241, 49);
            this.txtAdminUserName.TabIndex = 13;
            this.txtAdminUserName.TextChanged += new System.EventHandler(this.txtAdminUserName_TextChanged);
            this.txtAdminUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdminUserName_MouseClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(108, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(216, 49);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(33, 271);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(69, 27);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "label1";
            this.lblState.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 94;
            this.iconPictureBox1.Location = new System.Drawing.Point(54, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(280, 94);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(54, 134);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 40);
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(54, 214);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 40);
            this.iconPictureBox3.TabIndex = 19;
            this.iconPictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 422);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAdminUserName);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.txtUPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminUserName;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblState;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}

