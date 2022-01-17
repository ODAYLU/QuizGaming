using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGaming
{
    public partial class FrmAddQuestion : Form
    {
        Connection connect = new Connection();
        public FrmAddQuestion()
        {
            InitializeComponent();
        }

        
        private void FrmAddQuestion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.GetQuestion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuestion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtChoice1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtChoice2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtChoice3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtChoice4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCorrectAnswer.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if(txtCorrectAnswer.Text == txtChoice1.Text)
            {
                btnRChoice1.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice2.Text)
            {
                btnRChoice2.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice3.Text)
            {
                btnRChoice3.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice4.Text)
            {
                btnRChoice4.Checked = true;
            }
        }

        

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuestion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtChoice1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtChoice2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtChoice3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtChoice4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCorrectAnswer.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (txtCorrectAnswer.Text == txtChoice1.Text)
            {
                btnRChoice1.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice2.Text)
            {
                btnRChoice2.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice3.Text)
            {
                btnRChoice3.Checked = true;
            }
            if (txtCorrectAnswer.Text == txtChoice4.Text)
            {
                btnRChoice4.Checked = true;
            }
        }

        private void btnIcoSave_Click(object sender, EventArgs e)
        {
            if(txtQuestion.Text != "" && txtChoice1.Text != "" && txtChoice2.Text != "" && txtChoice3.Text != "" && txtChoice4.Text != "" && txtCorrectAnswer.Text != "")
            {
                if (btnRChoice1.Checked)
                {

                    txtCorrectAnswer.Text = txtChoice1.Text;
                }
                if (btnRChoice2.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice2.Text;
                }
                if (btnRChoice3.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice3.Text;
                }
                if (btnRChoice4.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice4.Text;
                }
                connect.con.Open();
                string query = "INSERT INTO tblQuestion (Question , Choice1 , Choice2 , Choice3 , Choice4 , CorrectAnswer) VALUES(@Question , @Choice1 , @Choice2 , @Choice3 , @Choice4 , @CorrectAnswer)";
                SqlCommand cmd = new SqlCommand(query, connect.con);
                cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@Choice1", txtChoice1.Text);
                cmd.Parameters.AddWithValue("@Choice2", txtChoice2.Text);
                cmd.Parameters.AddWithValue("@Choice3", txtChoice3.Text);
                cmd.Parameters.AddWithValue("@Choice4", txtChoice4.Text);
                cmd.Parameters.AddWithValue("@CorrectAnswer", txtCorrectAnswer.Text);
                cmd.ExecuteNonQuery();
                connect.con.Close();
                Program.GetQuestion();
                dataGridView1.DataSource = Program.GetQuestion();
            }
            else
            {
                MessageBox.Show("Please Enter All TextBox");
            }
            
        }

        private void btnIcoAddNew_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnIcoUpdate_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != "" && txtChoice1.Text != "" && txtChoice2.Text != "" && txtChoice3.Text != "" && txtChoice4.Text != "" && txtCorrectAnswer.Text != "")
            {
                if (btnRChoice1.Checked)
                {

                    txtCorrectAnswer.Text = txtChoice1.Text;
                }
                if (btnRChoice2.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice2.Text;
                }
                if (btnRChoice3.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice3.Text;
                }
                if (btnRChoice4.Checked)
                {
                    txtCorrectAnswer.Text = txtChoice4.Text;
                }
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string q = txtQuestion.Text;
                string c1 = txtChoice1.Text;
                string c2 = txtChoice2.Text;
                string c3 = txtChoice3.Text;
                string c4 = txtChoice4.Text;
                string cA = txtCorrectAnswer.Text;
                Program.UpdateQuestion(id, q, c1, c2, c3, c4, cA);
                dataGridView1.DataSource = Program.GetQuestion();
            }
            else
            {
                MessageBox.Show("Please Select the Question You want Update");
            }
        }

        private void btnIcoDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
            {
                var result = MessageBox.Show($"Are you sure for delete the Question number {dataGridView1.CurrentRow.Cells[0].Value.ToString()}", "delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int x = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Program.DeleteQuestion(x);
                    MessageBox.Show("The Question Deleted Successfuly");
                    dataGridView1.DataSource = Program.GetQuestion();
                }
            }
        }

        private void btnIcoExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnEnterOpertation(object sender, EventArgs e)
        {
            var btnSender = (IconButton)sender;
            btnSender.ForeColor = Color.Black;
            btnSender.IconColor = Color.Black;
        }

        private void btnLeaveOpertation(object sender, EventArgs e)
        {
            var btnSender = (IconButton)sender;
            btnSender.ForeColor = Color.White;
            btnSender.IconColor = Color.White;
        }
    }
}
