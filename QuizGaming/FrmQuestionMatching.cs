using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGaming
{
    public partial class FrmQuestionMatching : Form
    {
        int Correct = 0;
        int Mistakes = 0;
        public FrmQuestionMatching()
        {
            InitializeComponent();
        }
        int sec = 0;
        int min = 0;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 10 && min == 0)
                lblTimer.Text = $"00:0{++sec}";
            if (sec >= 10 && sec <= 60 && min == 0)
                lblTimer.Text = $"00:{++sec}";
            if (sec > 60)
            {
                sec = 0;
                lblTimer.Text = $"0{++min}:0{++sec}";
            }
            if (min > 0 && sec < 10)
            {

                lblTimer.Text = $"0{min}:0{++sec}";
            }
            if (min > 0 && sec >= 10 && sec <= 60)
            {

                lblTimer.Text = $"0{min}:{++sec}";
            }
            
            
            if (min == 1) 
            { 
                timer1.Stop();
                btnCheck_Click(null, null);
                Choice1.Enabled = false;
                Choice2.Enabled = false;
                Choice3.Enabled = false;
                Choice4.Enabled = false;
                Choice5.Enabled = false;
                Choice6.Enabled = false;
                Choice7.Enabled = false;
            }
            
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAns1.Text = "";
            lblAns2.Text = "";
            lblAns3.Text = "";
            lblAns4.Text = "";
            lblAns5.Text = "";
            lblAns6.Text = "";
            lblAns7.Text = "";
            btnCheck1.Visible = false;
            btnCheck2.Visible = false;
            btnCheck3.Visible = false;
            btnCheck4.Visible = false;
            btnCheck5.Visible = false;
            btnCheck6.Visible = false;
            btnCheck7.Visible = false;
            Choice1.Enabled = true;
            Choice2.Enabled = true;
            Choice3.Enabled = true;
            Choice4.Enabled = true;
            Choice5.Enabled = true;
            Choice6.Enabled = true;
            Choice7.Enabled = true;
            sec = 0;
            min = 0;
            timer1.Start();
        }
        int x = 0;
        bool[] range = new bool[10];
        int[] result = new int[10];
        void RandomNum()
        {
            //int remaining = 10;

            int i = 0;
            Random rnd = new Random();
            while (i < 10)
            {
                int index = rnd.Next(0,10);
                if (range[index] == true)
                    continue;
                range[index] = true;
                result[i++] = int.Parse(index.ToString());
            }
            Console.WriteLine(result);
        }
        public void RandomQuestion()
        {
            RandomNum();
            var data = Program.GetQuestion();
            
            lblQues1.Text = data.Rows[result[x]][1].ToString();
            Choice1.Text = data.Rows[result[x]][6].ToString();
            lblCA1.Text = data.Rows[result[x]][6].ToString();
            ///////////////////////////////
            x++;
            lblQues2.Text = data.Rows[result[x]][1].ToString();
            Choice2.Text = data.Rows[result[x]][6].ToString();
            lblCA2.Text = data.Rows[result[x]][6].ToString();
            //////////////////////////////
            x++;
            lblQues3.Text = data.Rows[result[x]][1].ToString();
            Choice3.Text = data.Rows[result[x]][6].ToString();
            lblCA3.Text = data.Rows[result[x]][6].ToString();
            ////////////////////////////////
            x++;
            lblQues4.Text = data.Rows[result[x]][1].ToString();
            Choice4.Text = data.Rows[result[x]][6].ToString();
            lblCA4.Text = data.Rows[result[x]][6].ToString();
            ////////////////////////////////////
            x++;
            lblQues5.Text = data.Rows[result[x]][1].ToString();
            Choice5.Text = data.Rows[result[x]][6].ToString();
            lblCA5.Text = data.Rows[result[x]][6].ToString();
            ////////////////////////////////////
            x++;
            lblQues6.Text = data.Rows[result[x]][1].ToString();
            Choice6.Text = data.Rows[result[x]][6].ToString();
            lblCA6.Text = data.Rows[result[x]][6].ToString();
            /////////////////////////////////////
            x++;
            lblQues7.Text = data.Rows[result[x]][1].ToString();
            Choice7.Text = data.Rows[result[x]][6].ToString();
            lblCA7.Text = data.Rows[result[x]][6].ToString();     
        }
        private void FrmQuestionMatching_Load(object sender, EventArgs e)
        {
            Program.PlaySound();
            //ControlExtension.Draggable(controlname,bool);
            RandomQuestion();
        }

       
        
        private void lblAns6_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Choice8_MouseDown(object sender, MouseEventArgs e)
        {
            var senderObject = (Guna2Button)sender;
            senderObject.DoDragDrop(senderObject.Text, DragDropEffects.Copy);
        }

        private void AllAnsDragDrop(object sender, DragEventArgs e)
        {
            var senderObject = (Label)sender;
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                senderObject.Text = (e.Data.GetData(DataFormats.Text)).ToString();
            }
        }

        private void DeleteAns(object sender, EventArgs e)
        {
            var senderObject = (Label)sender;
            senderObject.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure of End the Game", "!!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string name = Program.user.UserName;
                string m = Program.user.Mount = lblMount.Text;
                int c = Program.user.NumCorrect = Correct;
                int mi = Program.user.NumMistakes = Mistakes;
                Program.InsertToUsers(name, m, c, mi);
                this.Hide();
                timer1.Stop();
                this.Close();
                FrmUser frm = new FrmUser();
                frm.ShowDialog();
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (lblCA1.Text == lblAns1.Text)
            {
                btnCheck1.Text = "✔";
                btnCheck1.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck1.Text = "❌";
                btnCheck1.Visible = true;
                Mistakes++;
            }
            ///////////////
            if (lblCA2.Text == lblAns2.Text)
            {
                btnCheck2.Text = "✔";
                btnCheck2.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck2.Text = "❌";
                btnCheck2.Visible = true;
                Mistakes++;
            }
            ///////////////
            if (lblCA3.Text == lblAns3.Text)
            {
                btnCheck3.Text = "✔";
                btnCheck3.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck3.Text = "❌";
                btnCheck3.Visible = true;
                Mistakes++;
            }
            ///////////////
            if (lblCA4.Text == lblAns4.Text)
            {
                btnCheck4.Text = "✔";
                btnCheck4.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck4.Text = "❌";
                btnCheck4.Visible = true;
                Mistakes++;
            }
            //////////////
            if (lblCA5.Text == lblAns5.Text)
            {
                btnCheck5.Text = "✔";
                btnCheck5.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck5.Text = "❌";
                btnCheck5.Visible = true;
                Mistakes++;
            }
            ///////////////////
            if (lblCA6.Text == lblAns6.Text)
            {
                btnCheck6.Text = "✔";
                btnCheck6.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck6.Text = "❌";
                btnCheck6.Visible = true;
                Mistakes++;
            }
            /////////////
            if (lblCA7.Text == lblAns7.Text)
            {
                btnCheck7.Text = "✔";
                btnCheck7.Visible = true;
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100 + "$").ToString();
                Correct++;
            }
            else
            {
                btnCheck7.Text = "❌";
                btnCheck7.Visible = true;
                Mistakes++;
            }

        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck6_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck7_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {

        }
    }
}
