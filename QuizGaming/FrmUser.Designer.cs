
namespace QuizGaming
{
    partial class FrmUser
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
            this.btnStartMarching = new Guna.UI2.WinForms.Guna2Button();
            this.txtUuserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnScore = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblAdmin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblState = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartMarching
            // 
            this.btnStartMarching.BackColor = System.Drawing.Color.Transparent;
            this.btnStartMarching.BorderRadius = 20;
            this.btnStartMarching.CheckedState.Parent = this.btnStartMarching;
            this.btnStartMarching.CustomImages.Parent = this.btnStartMarching;
            this.btnStartMarching.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartMarching.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartMarching.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartMarching.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartMarching.DisabledState.Parent = this.btnStartMarching;
            this.btnStartMarching.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnStartMarching.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnStartMarching.ForeColor = System.Drawing.Color.White;
            this.btnStartMarching.HoverState.Parent = this.btnStartMarching;
            this.btnStartMarching.Location = new System.Drawing.Point(98, 208);
            this.btnStartMarching.Name = "btnStartMarching";
            this.btnStartMarching.ShadowDecoration.Parent = this.btnStartMarching;
            this.btnStartMarching.Size = new System.Drawing.Size(262, 42);
            this.btnStartMarching.TabIndex = 19;
            this.btnStartMarching.Text = "Start Game Matching";
            this.btnStartMarching.Click += new System.EventHandler(this.btnStartMarching_Click);
            // 
            // txtUuserName
            // 
            this.txtUuserName.BorderColor = System.Drawing.Color.Yellow;
            this.txtUuserName.BorderRadius = 15;
            this.txtUuserName.BorderThickness = 0;
            this.txtUuserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUuserName.DefaultText = "User Name";
            this.txtUuserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUuserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUuserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUuserName.DisabledState.Parent = this.txtUuserName;
            this.txtUuserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUuserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.txtUuserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUuserName.FocusedState.Parent = this.txtUuserName;
            this.txtUuserName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.txtUuserName.ForeColor = System.Drawing.Color.White;
            this.txtUuserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUuserName.HoverState.Parent = this.txtUuserName;
            this.txtUuserName.Location = new System.Drawing.Point(98, 132);
            this.txtUuserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUuserName.Name = "txtUuserName";
            this.txtUuserName.PasswordChar = '\0';
            this.txtUuserName.PlaceholderText = "";
            this.txtUuserName.SelectedText = "";
            this.txtUuserName.ShadowDecoration.Parent = this.txtUuserName;
            this.txtUuserName.Size = new System.Drawing.Size(262, 35);
            this.txtUuserName.TabIndex = 18;
            this.txtUuserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUuserName_MouseClick);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BorderRadius = 20;
            this.btnScore.CheckedState.Parent = this.btnScore;
            this.btnScore.CustomImages.Parent = this.btnScore;
            this.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScore.DisabledState.Parent = this.btnScore;
            this.btnScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnScore.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.HoverState.Parent = this.btnScore;
            this.btnScore.Location = new System.Drawing.Point(98, 347);
            this.btnScore.Name = "btnScore";
            this.btnScore.ShadowDecoration.Parent = this.btnScore;
            this.btnScore.Size = new System.Drawing.Size(262, 40);
            this.btnScore.TabIndex = 17;
            this.btnScore.Text = "Score ";
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 20;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(98, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(262, 40);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start Game MultipleChoice";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(29, 411);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(298, 29);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "Click Here To Login With Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblState.Location = new System.Drawing.Point(110, 171);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(69, 27);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "label1";
            this.lblState.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Aqua;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(362, 37);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(56, 54);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 88;
            this.iconPictureBox1.Location = new System.Drawing.Point(125, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(188, 88);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 23;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 48;
            this.iconPictureBox2.Location = new System.Drawing.Point(29, 132);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 52);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 452);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnStartMarching);
            this.Controls.Add(this.txtUuserName);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStartMarching;
        public Guna.UI2.WinForms.Guna2TextBox txtUuserName;
        private Guna.UI2.WinForms.Guna2Button btnScore;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdmin;
        private System.Windows.Forms.Label lblState;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}