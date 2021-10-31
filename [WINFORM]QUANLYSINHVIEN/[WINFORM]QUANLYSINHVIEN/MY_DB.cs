using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace _WINFORM_QUANLYSINHVIEN
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=DB_Login;Integrated Security=True");

        public SqlConnection GetConnection
        {
            get { return con; }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            { con.Close(); }
        }
        
    }
}
