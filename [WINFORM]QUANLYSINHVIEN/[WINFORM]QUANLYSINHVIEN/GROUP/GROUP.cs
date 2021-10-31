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
    public class GROUP
    {
        MY_DB mydb = new MY_DB();
        //public bool insertGroup(int id, string gname, int userid)
        //{
        //    SqlCommand command = new SqlCommand("INSERT INTO dbo.mygroups (id, name, userid)" +
        //        "VALUES (@id, @gn, @uid)", mydb.GetConnection);

        //    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //    command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
        //    command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

        //    mydb.openConnection();
        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        mydb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        mydb.closeConnection();
        //        return false;
        //    }
        //}
        public bool insertGroup(string gname)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.mygroups (name)" +
                "VALUES (@gn)", mydb.GetConnection);

            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            

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
        public bool updateContact(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.mygroups SET name=@name, WHERE id=@id", mydb.GetConnection);
            
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
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
        public bool deleteContact(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.mygroups WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;

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

        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid=@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getGroups2()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool GroupExit(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE name = @name", mydb.GetConnection);

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        //public bool GroupExit(string name, string operation, int userid = 0 , int groupid = 0)
        //{
        //    string query = "";
        //    SqlCommand command = new SqlCommand();
        //    if (operation == "add")
        //    {
        //        query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid AND id <> @gid";
        //        command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        //        command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
        //    }
        //    else if (operation == "edit")
        //    {
        //        query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid AND Id <>@gid";
        //        command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        //        command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
        //        command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
        //    }
        //    command.Connection = mydb.GetConnection;
        //    command.CommandText = query;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
