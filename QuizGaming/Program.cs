using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGaming
{
     
    static class Program
    {
        public static Users user = new Users();
       public static bool flag = true;
       public static bool flag2 = true;

        public static WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wmp2 = new WMPLib.WindowsMediaPlayer();
        public static void PlayCorrectSound()
        {
           wmp2.URL = "TrueChoiceSound.mp3";
            if (File.Exists(wmp2.URL))
            {
                wmp2.controls.play();
            }
           
        }
        public static void PlaySound()
        {
            
            if (flag)
            {
                 wmp.URL = "Mp3Sound.mp3";
                if (File.Exists(wmp.URL))
                {
                    wmp.controls.play();
                    flag = false;
                }
                
            }
            else
            {
                wmp.controls.stop();
                flag = true;
            }
        }
        public static DataTable GetQuestion()
        {
            Connection connect = new Connection();
            DataTable dt = new DataTable();
            connect.con.Open();
            string query = "SELECT * FROM tblQuestion";
            SqlCommand cmd = new SqlCommand(query, connect.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connect.con.Close();
            return dt;
        }
        public static DataTable GetUsers()
        {
            Connection connect = new Connection();
            DataTable dt = new DataTable();
            connect.con.Open();
            string query = "SELECT * FROM Users order by Date desc";
            SqlCommand cmd = new SqlCommand(query, connect.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connect.con.Close();
            return dt;
        }
        public static void InsertToUsers(string username,string mount,int numcorrect , int nummistakes)
        {
            Connection connect = new Connection();
            connect.con.Open();
            string query = "INSERT INTO Users (UserName , Mount , NumCorrect , NumMistakes) VALUES(@UserName , @Mount , @NumCorrect , @NumMistakes)";
            SqlCommand cmd = new SqlCommand(query, connect.con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Mount", mount);
            cmd.Parameters.AddWithValue("@NumCorrect", numcorrect);
            cmd.Parameters.AddWithValue("@NumMistakes", nummistakes);
           
            cmd.ExecuteNonQuery();
            connect.con.Close();
        }
        public static void UpdateQuestion(int id ,string question,string choice1, string choice2, string choice3, string choice4, string correctChoice)
        {
            Connection connect = new Connection();
            connect.con.Open();
            string query = "UPDATE tblQuestion SET Question = @Question,Choice1 = @Choice1,Choice2 = @Choice2,Choice3 = @Choice3,Choice4 = @Choice4,CorrectAnswer = @CorrectAnswer WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, connect.con);
            cmd.Parameters.AddWithValue("@Question", question);
            cmd.Parameters.AddWithValue("@Choice1", choice1);
            cmd.Parameters.AddWithValue("@Choice2", choice2);
            cmd.Parameters.AddWithValue("@Choice3", choice3);
            cmd.Parameters.AddWithValue("@Choice4", choice4);
            cmd.Parameters.AddWithValue("@CorrectAnswer", correctChoice);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.con.Close();
        }
        public static void DeleteQuestion(int id)
        {
            Connection connect = new Connection();
            connect.con.Open();
            string query = "DELETE tblQuestion WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, connect.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.con.Close();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmUser());
           
        }
    }
}
