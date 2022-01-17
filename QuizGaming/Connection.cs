using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGaming
{
    class Connection
    {
        static string sql = "Data Source=DESKTOP-MMNPUJK;Initial Catalog=QuizGame;Integrated Security=True";
        public SqlConnection con = new SqlConnection(sql);
    }
}
