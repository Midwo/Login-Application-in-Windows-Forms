using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Application
{
    class Insert_delete
    {
        public string Komenda;


        public void dane_do_edycji()
        {
            System.Data.SqlClient.SqlConnection M1conn;
            M1conn = new SqlConnection();
            M1conn.ConnectionString = Properties.Settings.Default.agent2214_db1portfolioConnectionString1;
            M1conn.Open();
            System.Data.SqlClient.SqlCommand M1command = new SqlCommand();
            M1command.Connection = M1conn;
            M1command.CommandText = "" + Komenda + "";
            M1command.ExecuteNonQuery();
            M1conn.Close();
        }

    }
}
