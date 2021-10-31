using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class AddScoreForm : Form
    {
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            SqlCommand command = new SqlCommand("SELECT Id, Fname, Lname FROM hocsinh");
            DGVAddScore.DataSource = student.getStudents(command);



        }

        private void DGVAddScore_Click(object sender, EventArgs e)
        {
            textStudentID.Text = DGVAddScore.CurrentRow.Cells[0].Value.ToString();
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

        
    }
}
