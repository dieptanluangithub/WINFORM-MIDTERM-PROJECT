using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _WINFORM_QUANLYSINHVIEN
{
    public class SCORE
    {
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_id, course_id, student_score, description)" +
                " VALUES (@sid, @cid, @scr, @descr)", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

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
        public DataTable getResult()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;

            command.CommandText = ("SELECT score.student_id, hocsinh.Fname, hocsinh.Lname, course.label, score." +
                "student_score FROM hocsinh INNER JOIN score on hocsinh.Id = score.student_id INNER JOIN course on score.course_id = course.Id");
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentScores()
        {
            //INNER JOIN course on score.course_id = course.Id
            //score.student_id, hocsinh.Fname, hocsinh.Lname, score.course_id, course.label, score.
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT score.student_id, hocsinh.Fname, hocsinh.Lname, score.course_id, course.label, score."+
                "student_score FROM hocsinh INNER JOIN score on hocsinh.Id = score.student_id INNER JOIN course on score.course_id = course.Id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id = @sid And course_id = @cid", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

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

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = "SELECT Course.label, AVG(score.student_score) As AverageGrade FROM Course, score WHERE Course.Id =" +
                " score.course_id GROUP BY Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id = @sid AND course_id = @cid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public DataTable getCourseScores(int courseId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT score.student_id, hocsinh.Fname, hocsinh.Lname, score.course_id, course.label, score." +
            "student_score FROM hocsinh INNER JOIN score on hocsinh.student_id INNER JOIN course on score.course_id = course.Id WHERE score.course_id = " + courseId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

}
