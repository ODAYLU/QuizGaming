using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.IO;

namespace QuizGaming
{
    public partial class FrmQuestions : Form
    {
        int mis = 0;
        int correct = 0;
        int sec = 0;
        int min = 0;
        int count = 1;
        bool vis;
        int NumQuestion = 0;
        public FrmQuestions()
        {
            InitializeComponent();
        }
       
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
            
            if (min == 1) lblTimer.Visible = vis;
            if (min == 5) timer1.Stop();
            vis = true;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure of End the Game","!!",MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                string m = Program.user.Mount = lblMount.Text;
                int c = Program.user.NumCorrect = correct;
                int mi = Program.user.NumMistakes = mis;
                Program.InsertToUsers(Program.user.UserName, m, c, mi);
                this.Hide();
                timer1.Stop();
                Program.PlaySound();
                this.Close();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
          
        }
        
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            
            Program.GetQuestion();
            var senderObject = (Guna2Button)sender;
            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            
           
            
            string z = Program.GetQuestion().Rows[result[x]][6].ToString().Trim();
            x++;
            if (senderObject.Text.Trim() == z)
            {
                Program.PlayCorrectSound();
                Program.PlaySound();
                lblState.Text = "true";
                
                lblMount.Text = (int.Parse((lblMount.Text.Split('$')[0])) + 100+"$").ToString();
                correct++;
            }
            else
            {
                lblState.Text = "False";
                lblCorrectAns.Text = z;
                mis++;
            }
        }
        List<QuestionData> lst = new List<QuestionData>();
        
        
        private void FrmQuestions_Load(object sender, EventArgs e)
        {
            Program.PlaySound();
            var data =  Program.GetQuestion();

            lblQuestions.Text = $"Q{count }"+(string)data.Rows[0][1].ToString();
            btnChoice1.Text =   (string)data.Rows[0][2].ToString();
            btnChoice2.Text =   (string)data.Rows[0][3].ToString();
            btnChoice3.Text =   (string)data.Rows[0][4].ToString();
            btnChoice4.Text =   (string)data.Rows[0][5].ToString();
            
        }
        
        int num = 0;
        int x = 0;
        bool[] range = new bool[10];
        int[] result = new int[10];
        void RandomNum()
        {
            //int remaining = 10;

            int i = 0;
            Random rnd = new Random();
            int  data = Program.GetQuestion().Rows.Count;
            if(data > 8)
                while (i < 9)
                {
                    int index = rnd.Next(0, 10);
                    if (range[index] == true)
                        continue;
                    range[index] = true;
                    result[i++] = index;
                }
            else
                while (i < data)
                {
                    int index = rnd.Next(0, 10);
                    if (range[index] == true)
                        continue;
                    range[index] = true;
                    result[i++] = index;
                }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(NumQuestion == 8)
            {
              var resl = MessageBox.Show($"The Question Ended And Your Score{lblMount.Text} ,Are You Want To Try The Game ?","🎉🎉🎉",MessageBoxButtons.YesNo);
                if(resl == DialogResult.Yes)
                {
                    string m = Program.user.Mount = lblMount.Text;
                    int c = Program.user.NumCorrect = correct;
                    int mi = Program.user.NumMistakes = mis;
                    Program.InsertToUsers(Program.user.UserName, m, c, mi);
                    this.Hide();
                    timer1.Stop();
                    Program.PlaySound();
                    this.Hide();
                    FrmQuestions frmQ = new FrmQuestions();
                    frmQ.ShowDialog();
                }
                else
                {
                    string m = Program.user.Mount = lblMount.Text;
                    int c = Program.user.NumCorrect = correct;
                    int mi = Program.user.NumMistakes = mis;
                    Program.InsertToUsers(Program.user.UserName, m, c, mi);
                    this.Hide();
                    timer1.Stop();
                    Program.PlaySound();
                    this.Hide();
                    FrmUser frm = new FrmUser();
                    frm.ShowDialog();
                }
            }
            if (num < 1)
            {
                RandomNum();
                num++;
            }           
            lblState.Text = "";
            lblCorrectAns.Text = "";
            btnChoice1.Enabled = true;
            btnChoice2.Enabled = true;
            btnChoice3.Enabled = true;
            btnChoice4.Enabled = true;
            
            var data = Program.GetQuestion();

            count++;
                lblQuestions.Text = $"Q{count} " + (string)data.Rows[result[x]][1].ToString();
                btnChoice1.Text = (string)data.Rows[result[x]][2].ToString();
                btnChoice2.Text = (string)data.Rows[result[x]][3].ToString();
                btnChoice3.Text = (string)data.Rows[result[x]][4].ToString();
                btnChoice4.Text = (string)data.Rows[result[x]][5].ToString();
            NumQuestion++;
        }

        private void lblMount_Click(object sender, EventArgs e)
        {

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (Program.flag)
                btnSound.Text = "🔊";
            else
                btnSound.Text = "🔈";
            Program.PlaySound();
            
        }

        private void ChoiceMouseEnter(object sender, EventArgs e)
        {

        }
    }
}
