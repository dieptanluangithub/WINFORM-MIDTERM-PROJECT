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
    public class CONTACT
    {
        MY_DB mydb = new MY_DB();
        public DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertContact(int contactID,string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            //inser sao ko cos id,  kol aimf dtho tahayf maf? lam theo thay
            //:)) thầy ổng thiếu đó, iser thêm id vào là đc
           //ok
            SqlCommand command = new SqlCommand("INSERT INTO dbo.mycontact (id, fname, lname, group_id, phone, email, address, pic, userid)" +
                "VALUES (@cID, @fn, @ln, @grp, @phn, @mail,@adrs,@pic,@uid)", mydb.GetConnection);

            command.Parameters.Add("@cID", SqlDbType.Int).Value = contactID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
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
        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.mycontact SET fname=@fn, lname=@ln, group_id=@grp, phone=@phn, email=@mail, address=@adrs, pic=@pic WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
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
        
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.mycontact WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;

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
        //NAP DU LIEU
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetContactByID(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT fname, lname, group_id, phone, email, address, pic, userid FROM mycontact WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool ContactExist(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mycontact  WHERE Id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
