using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScores();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        MY_DB mydb = new MY_DB();
        string data = "score";
        string IdStudent;
        string IdCourse;
        private void button1_Click(object sender, EventArgs e)
        {
            //SCORE score = new SCORE();
            //try
            //{
            //    int courseID = Convert.ToInt32(IdCourse);
            //    int studentID = Convert.ToInt32(IdStudent);
            //    if ((MessageBox.Show("Are you sure want to delete this course", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            //    {
            //        if (score.deleteScore(studentID, courseID))
            //        {
            //            MessageBox.Show("Course deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Course not deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Enter a valid numeric id", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            int studentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (MessageBox.Show("Do Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentScores();

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }
        void getDataFromDatagridView()
        {
            if (data == "hocsinh")
            {
                IdStudent = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                IdStudent = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                IdCourse = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
