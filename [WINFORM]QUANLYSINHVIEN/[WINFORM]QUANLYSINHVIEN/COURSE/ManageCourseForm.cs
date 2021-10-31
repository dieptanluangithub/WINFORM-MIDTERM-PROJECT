using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class ManageCourseForm : Form
    {
        COURSE course = new COURSE();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int Cid = Convert.ToInt32(TextBox_ID.Text);
            string name = TextBox_Label.Text;
            int hrs = (int)numericUpDown_HoursNum.Value;
            string descr = TextBox_Description.Text;

            if (hrs <= 10)
            {
                MessageBox.Show("The Period Hours Must Be More Than 10 Hours!", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (course.checkCourseName(name))
            {
                if (course.insertCourse(Cid, name, hrs, descr))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        void reloadListBoxData()
        {
            listBox_TotalCourse.DataSource = course.getAllCourses();
            listBox_TotalCourse.ValueMember = "id";
            listBox_TotalCourse.DisplayMember = "label";

            listBox_TotalCourse.SelectedItem = null;

            label_TotalCourse.Text = ("Total Courses: " + course.totalCourse());
        }

        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBox_TotalCourse.SelectedIndex = index;
            TextBox_ID.Text = dr.ItemArray[0].ToString();
            TextBox_Label.Text = dr.ItemArray[1].ToString();
            numericUpDown_HoursNum.Value = int.Parse(dr.ItemArray[2].ToString());
            TextBox_Description.Text = dr.ItemArray[3].ToString();
        }

        private void bt_first_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void bt_last_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string name = TextBox_Label.Text;
            int hrs = (int)numericUpDown_HoursNum.Value;
            string descr = TextBox_Description.Text;
            int id = int.Parse(TextBox_ID.Text);

            if (!course.checkCourseName(name, Convert.ToInt32(TextBox_ID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(TextBox_ID.Text);

                if ((MessageBox.Show("Are you sure you want to delete this course ?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextBox_ID.Text = "";
                        TextBox_Label.Text = "";
                        numericUpDown_HoursNum.Value = 11;
                        TextBox_Description.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid course ID !", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        
    }
}
