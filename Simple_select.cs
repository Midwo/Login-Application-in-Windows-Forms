using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Application
{
    class Simple_select
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connect);

        public DataSet select(string zapytanie, string baza)
        {
            DataSet testowe3 = new DataSet();
            SqlDataAdapter adapter_testowe3 = new SqlDataAdapter(" " + zapytanie + "", con);
            adapter_testowe3.Fill(testowe3, "" + baza + "");
            return testowe3;
          
        }
    }
}
