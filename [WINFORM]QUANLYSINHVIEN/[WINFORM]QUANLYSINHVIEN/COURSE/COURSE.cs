using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class COURSE
    {
        MY_DB mydb = new MY_DB();

        //tim trung ten
        public bool checkCourseName(string label, int Id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@cName And Id <> @cID", mydb.GetConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool insertCourse(int Id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (Id, label, period, description)" +
                " VALUES (@cID, @cName, @hrs, @descr)", mydb.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = period;
            command.Parameters.Add("@descr", SqlDbType.Text).Value = description;

            mydb.openConnection();
            try 
            {
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
            catch
            {
                return false;
            }
            
        }

        public bool deleteCourse(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE Id = @cID", mydb.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
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

        public bool updateCourse(int Id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET label=@cName, period=@hrs, description=@descr WHERE Id=@cID", mydb.GetConnection);

            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = period;
            command.Parameters.Add("@descr", SqlDbType.Text).Value = description;

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

        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseById(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE Id=@cID", mydb.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int totalCourse()
        {
            SqlCommand command = new SqlCommand("select * from course");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }

        public bool checkCourseID(int Id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE Id <> @cid", mydb.GetConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = Id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;
        }
     
    }
}
