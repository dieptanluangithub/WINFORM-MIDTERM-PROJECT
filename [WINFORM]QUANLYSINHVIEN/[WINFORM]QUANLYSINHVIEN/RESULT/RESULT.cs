using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class RESULT
    {

        MY_DB mydb = new MY_DB();

        public DataTable GetListCourse()
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT Id, label FROM [Course]", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            mydb.closeConnection();
            return ds.Tables[0];
        }
        public DataTable GetListStudent(string keyword)
        {
            DataTable dt = new DataTable();
            DataTable allCourse = GetListCourse();
            
            Dictionary<int, string> courseID = new Dictionary<int, string>();
            dt.Columns.Add("Student ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            
            foreach (DataRow item in allCourse.Rows)
            {
                dt.Columns.Add(item[1].ToString());
                courseID.Add(Convert.ToInt32(item[0]), item[1].ToString());
            }
            dt.Columns.Add("Average Score");
            dt.Columns.Add("Result");
           
            mydb.openConnection();
            string query = "SELECT s.student_id, fname, lname, s.average FROM hocsinh INNER JOIN " +
                "(SELECT student_id, AVG(student_score) as average FROM Score GROUP BY student_id) as s " +
                "ON hocsinh.Id = s.student_id";
            if (keyword != "")
            {
                query = "SELECT s.student_id, fname, lname, s.average FROM hocsinh INNER JOIN " +
                "(SELECT student_id, AVG(student_score) as average FROM Score GROUP BY student_id) as s " +
                "ON hocsinh.Id = s.student_id WHERE s.student_id LIKE '%" + keyword + "%' OR fname LIKE '%" + keyword + "%'";
            }
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            mydb.closeConnection();
            
            foreach (DataRow student in ds.Tables[0].Rows)
            {
                DataRow dataRow = dt.NewRow();
                
                dataRow["Student ID"] = student["student_id"];
                dataRow["First Name"] = student["fname"];
                dataRow["Last Name"] = student["lname"];
                dataRow["Average Score"] = student["average"];
                if (Convert.ToDouble(student["average"])>0)
                {
                    if (Convert.ToDouble(student["average"]) > 5)
                    {
                        if (Convert.ToDouble(student["average"]) > 8)
                        {
                            dataRow["Result"] = "GIOI";
                        }
                        else { dataRow["Result"] = "KHA"; }
                    }
                    else { dataRow["Result"] = "YEU"; }

                }    
                
                foreach (var id in courseID)
                {
                    mydb.openConnection();
                    
                    SqlCommand c = new SqlCommand("select student_score from Score where course_id=@cID and student_id=@sID", mydb.GetConnection);
                    c.Parameters.Add("@cID", SqlDbType.Int).Value = id.Key;
                    c.Parameters.Add("@sID", SqlDbType.Int).Value = student["student_id"];
                    SqlDataAdapter a = new SqlDataAdapter(c);
                    DataSet set = new DataSet();
                    a.Fill(set);

                    if (set.Tables[0].Rows.Count > 0)
                    {
                        DataRow score = set.Tables[0].Rows[0];
                        
                        dataRow[id.Value] = score[0].ToString();
                    }

                    mydb.closeConnection();
                }
                
                dt.Rows.Add(dataRow);
            }
            return dt;
        }
    }
}
    
