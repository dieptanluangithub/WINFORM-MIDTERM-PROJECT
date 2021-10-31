using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class USER
    {
        MY_DB mydb = new MY_DB();

        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM ACCOUNT WHERE Id = @uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }

        //Them user
        public bool insertUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.ACCOUNT (Id, f_name, l_name, uname, pwd, fig)" +
                "VALUES (@uid, @fn, @ln, @un, @pass,@pic)", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //update
        public bool updateUser(int usreid,string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE ACCOUNT SET fname=@fn, lname=@ln, uname=@un, pwd=@pass,fig=@pic WHERE Id=@uid", mydb.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = usreid;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        //Kiem tra ton tai
        public bool usernameExist(string username, int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ACCOUNT WHERE uname = @un AND Id <> @uid", mydb.GetConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            
                if (table.Rows.Count == 0)
                {
                    return false;
                }
                else
                    return true;
            

            //string query = "";
            //if (operation == "regiter")
            //{
            //    query = "SELECT * FROM ACCOUNT WHERE uname = @un";
            //}
            //else if (operation == "edit")
            //{
            //    query = "SELECT * FROM ACCOUNT WHERE uname = @un AND Id <>@uid";
            //}
            //SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            //command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            //command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();
            //adapter.SelectCommand = command;
            //int v = adapter.Fill(table);
            //if (table.Rows.Count > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
