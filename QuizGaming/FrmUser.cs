using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGaming
{
    public partial class FrmUser : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FrmUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnStartMarching_Click(object sender, EventArgs e)
        {
            if(txtUuserName.Text.Length > 0)
            {
                Program.user.UserName = txtUuserName.Text;
                this.Hide();
                FrmQuestionMatching frm = new FrmQuestionMatching();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                lblState.Text = "Please Enter User Name";
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (txtUuserName.Text.Length > 0)
            {
                
                Program.user.UserName = txtUuserName.Text;
                this.Hide();
                
                FrmQuestions frm = new FrmQuestions();
                
                frm.ShowDialog();
                
                Program.GetQuestion();
                this.Close();
            }
            else
            {
                lblState.Text = "Please Enter User Name";
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.Red;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(0,64,64);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUuserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUuserName.Text = "";
        }
    }
}
