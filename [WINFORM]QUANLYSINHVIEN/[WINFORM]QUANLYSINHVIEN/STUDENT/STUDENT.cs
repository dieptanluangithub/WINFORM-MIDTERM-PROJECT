using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public bool insertStd(int ID, string FName, string LName, DateTime BDate, string Gender, string Phone, string Address, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.hocsinh (Id, FName, LName, BDate, Gender, Phone, Address, Picture)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = Picture.ToArray();
            mydb.openConnection();
            try
            {
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
            catch (SqlException)
            {
                return false;
            }
            
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deteleStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM hocsinh WHERE id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE hocsinh SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn,ad" + "dress=@adrs, picture=@pic WHERE id=@ID", mydb.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM hocsinh");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM hocsinh WHERE gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM hocsinh WHERE gender='Female'");
        }
           
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
    }
}
