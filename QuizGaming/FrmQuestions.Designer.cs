
namespace QuizGaming
{
    partial class FrmQuestions
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
            this.components = new System.ComponentModel.Container();
            this.btnChoice2 = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuestions = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnChoice3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChoice1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChoice4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCorrectAns = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblState = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEndGame = new Guna.UI2.WinForms.Guna2Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.Transparent;
            this.btnChoice2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice2.BorderRadius = 5;
            this.btnChoice2.BorderThickness = 3;
            this.btnChoice2.CheckedState.Parent = this.btnChoice2;
            this.btnChoice2.CustomImages.Parent = this.btnChoice2;
            this.btnChoice2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoice2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoice2.DisabledState.Parent = this.btnChoice2;
            this.btnChoice2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnChoice2.ForeColor = System.Drawing.Color.SeaShell;
            this.btnChoice2.HoverState.Parent = this.btnChoice2;
            this.btnChoice2.Location = new System.Drawing.Point(508, 230);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.ShadowDecoration.Parent = this.btnChoice2;
            this.btnChoice2.Size = new System.Drawing.Size(180, 45);
            this.btnChoice2.TabIndex = 0;
            this.btnChoice2.Tag = "2";
            this.btnChoice2.Text = "guna2Button1";
            this.btnChoice2.Click += new System.EventHandler(this.checkAnswerEvent);
            this.btnChoice2.MouseEnter += new System.EventHandler(this.ChoiceMouseEnter);
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = false;
            this.lblQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestions.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.Color.White;
            this.lblQuestions.Location = new System.Drawing.Point(185, 79);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(402, 118);
            this.lblQuestions.TabIndex = 1;
            this.lblQuestions.Text = null;
            this.lblQuestions.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.Transparent;
            this.btnChoice3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice3.BorderRadius = 5;
            this.btnChoice3.BorderThickness = 3;
            this.btnChoice3.CheckedState.Parent = this.btnChoice3;
            this.btnChoice3.CustomImages.Parent = this.btnChoice3;
            this.btnChoice3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoice3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoice3.DisabledState.Parent = this.btnChoice3;
            this.btnChoice3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnChoice3.ForeColor = System.Drawing.Color.SeaShell;
            this.btnChoice3.HoverState.Parent = this.btnChoice3;
            this.btnChoice3.Location = new System.Drawing.Point(40, 306);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.ShadowDecoration.Parent = this.btnChoice3;
            this.btnChoice3.Size = new System.Drawing.Size(180, 45);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.Tag = "3";
            this.btnChoice3.Text = "guna2Button2";
            this.btnChoice3.Click += new System.EventHandler(this.checkAnswerEvent);
            this.btnChoice3.MouseEnter += new System.EventHandler(this.ChoiceMouseEnter);
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice1.BorderRadius = 5;
            this.btnChoice1.BorderThickness = 3;
            this.btnChoice1.CheckedState.Parent = this.btnChoice1;
            this.btnChoice1.CustomImages.Parent = this.btnChoice1;
            this.btnChoice1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoice1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoice1.DisabledState.Parent = this.btnChoice1;
            this.btnChoice1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnChoice1.ForeColor = System.Drawing.Color.SeaShell;
            this.btnChoice1.HoverState.Parent = this.btnChoice1;
            this.btnChoice1.Location = new System.Drawing.Point(40, 230);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.ShadowDecoration.Parent = this.btnChoice1;
            this.btnChoice1.Size = new System.Drawing.Size(180, 45);
            this.btnChoice1.TabIndex = 3;
            this.btnChoice1.Tag = "1";
            this.btnChoice1.Text = "guna2Button3";
            this.btnChoice1.Click += new System.EventHandler(this.checkAnswerEvent);
            this.btnChoice1.MouseEnter += new System.EventHandler(this.ChoiceMouseEnter);
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.Transparent;
            this.btnChoice4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice4.BorderRadius = 5;
            this.btnChoice4.BorderThickness = 3;
            this.btnChoice4.CheckedState.Parent = this.btnChoice4;
            this.btnChoice4.CustomImages.Parent = this.btnChoice4;
            this.btnChoice4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoice4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoice4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoice4.DisabledState.Parent = this.btnChoice4;
            this.btnChoice4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnChoice4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnChoice4.ForeColor = System.Drawing.Color.SeaShell;
            this.btnChoice4.HoverState.Parent = this.btnChoice4;
            this.btnChoice4.Location = new System.Drawing.Point(508, 306);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.ShadowDecoration.Parent = this.btnChoice4;
            this.btnChoice4.Size = new System.Drawing.Size(180, 45);
            this.btnChoice4.TabIndex = 4;
            this.btnChoice4.Tag = "4";
            this.btnChoice4.Text = "guna2Button4";
            this.btnChoice4.Click += new System.EventHandler(this.checkAnswerEvent);
            this.btnChoice4.MouseEnter += new System.EventHandler(this.ChoiceMouseEnter);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 23);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(141, 39);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "The amount : ";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMount
            // 
            this.lblMount.AutoSize = false;
            this.lblMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblMount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMount.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblMount.ForeColor = System.Drawing.Color.White;
            this.lblMount.Location = new System.Drawing.Point(185, 23);
            this.lblMount.Name = "lblMount";
            this.lblMount.Size = new System.Drawing.Size(90, 39);
            this.lblMount.TabIndex = 7;
            this.lblMount.Text = "0";
            this.lblMount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMount.Click += new System.EventHandler(this.lblMount_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNext.BorderRadius = 5;
            this.btnNext.BorderThickness = 3;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.DisabledState.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SeaShell;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(671, 55);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(49, 42);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = false;
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(329, 275);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(78, 34);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.lblCorrectAns);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.lblState);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btnEndGame);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 407);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(766, 78);
            this.guna2Panel1.TabIndex = 10;
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = false;
            this.lblCorrectAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblCorrectAns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrectAns.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblCorrectAns.ForeColor = System.Drawing.Color.White;
            this.lblCorrectAns.Location = new System.Drawing.Point(432, 24);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.Size = new System.Drawing.Size(154, 30);
            this.lblCorrectAns.TabIndex = 4;
            this.lblCorrectAns.Text = null;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(264, 24);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(162, 29);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = "Correct Answer :  ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = false;
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(157, 24);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(90, 30);
            this.lblState.TabIndex = 2;
            this.lblState.Text = null;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(139, 29);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "State Answer :  ";
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Transparent;
            this.btnEndGame.BorderRadius = 15;
            this.btnEndGame.CheckedState.Parent = this.btnEndGame;
            this.btnEndGame.CustomImages.Parent = this.btnEndGame;
            this.btnEndGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEndGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEndGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEndGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEndGame.DisabledState.Parent = this.btnEndGame;
            this.btnEndGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEndGame.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.btnEndGame.ForeColor = System.Drawing.Color.White;
            this.btnEndGame.HoverState.Parent = this.btnEndGame;
            this.btnEndGame.Location = new System.Drawing.Point(604, 14);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.ShadowDecoration.Parent = this.btnEndGame;
            this.btnEndGame.Size = new System.Drawing.Size(159, 40);
            this.btnEndGame.TabIndex = 0;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSound.Location = new System.Drawing.Point(677, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(43, 37);
            this.btnSound.TabIndex = 11;
            this.btnSound.Text = "🔊";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // FrmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 486);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblMount);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.btnChoice2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuestions";
            this.Load += new System.EventHandler(this.FrmQuestions_Load);
            this.MouseEnter += new System.EventHandler(this.ChoiceMouseEnter);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnChoice2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuestions;
        private Guna.UI2.WinForms.Guna2Button btnChoice3;
        private Guna.UI2.WinForms.Guna2Button btnChoice1;
        private Guna.UI2.WinForms.Guna2Button btnChoice4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMount;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEndGame;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblState;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCorrectAns;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.Button btnSound;
    }
}