using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class ManageCoursesForm : Form
    {
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        string data = "score";
        public ManageCoursesForm()
        {
            InitializeComponent();
        }
        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            DGV_StudentScore.DataSource = score.getStudentScores();
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "Id";
        }

        private void bt_avgScore_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avg = new AvgScoreByCourse();
            avg.Show(this);
        }

        private void bt_addScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textStudentID.Text);
                int courseID = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(textScore.Text);
                string description = textDescription.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_showstd_Click(object sender, EventArgs e)
        {
            data = "hocsinh";
            SqlCommand command = new SqlCommand("SELECT Id, Fname, Lname, BDate FROM hocsinh");
            DGV_StudentScore.DataSource = student.getStudents(command);
        }

        private void bt_showscr_Click(object sender, EventArgs e)
        {
            data = "score";
            DGV_StudentScore.DataSource = score.getStudentScores();
        }

        private void DGV_StudentScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getdata();
        }
        void getdata()
        {
            if(data == "hocsinh")
            {
                textStudentID.Text = DGV_StudentScore.CurrentRow.Cells[0].Value.ToString();
            }    
            else if (data == "score")
            {
                textStudentID.Text = DGV_StudentScore.CurrentRow.Cells[0].Value.ToString();
                comboBoxCourse.SelectedValue = DGV_StudentScore.CurrentRow.Cells[3].Value;
            }    
        }

        private void bt_removeScore_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(DGV_StudentScore.CurrentRow.Cells[0].Value.ToString());
            int courseID = int.Parse(DGV_StudentScore.CurrentRow.Cells[3].Value.ToString());
            if(MessageBox.Show("Do Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_StudentScore.DataSource = score.getStudentScores();

                }    
            }    

        }
    }
}
