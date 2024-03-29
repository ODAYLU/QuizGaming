﻿using System;
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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        

        

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
       

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUPassword.Text.Trim() == Properties.Settings.Default.Password&&txtAdminUserName.Text.ToLower() == "admin")
            {
                this.Hide();
                FrmAddQuestion frm = new FrmAddQuestion();
                frm.ShowDialog();
            }
            else
            {
                lblState.Visible = true;
                lblState.Text = "Error in UserName or Password";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUPassword.PasswordChar = '*';
        }

        private void txtAdminUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAdminUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdminUserName.Text = "";
        }

        private void txtUPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtUPassword.Text = "";
        }
    }
}
