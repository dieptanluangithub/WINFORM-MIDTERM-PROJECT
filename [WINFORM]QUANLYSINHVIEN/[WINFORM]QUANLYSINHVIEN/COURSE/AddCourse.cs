using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class AddCourse : Form
    {
        COURSE course = new COURSE();
        public AddCourse()
        {
            InitializeComponent();
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bt_addCourse_Click(object sender, EventArgs e)
        {
            int Cid = Convert.ToInt32(Textbox_IDCourse.Text);
            string name = Textbox_Label.Text;
            int hrs = Convert.ToInt32(Textbox_Period.Text);
            string descr = Textbox_Description.Text;

            if (hrs <= 10)
            {
                MessageBox.Show("The Period Hours Must Be More Than 10 Hours!", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(name))
            {
                if (course.insertCourse(Cid, name, hrs, descr))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted, Id Course Already", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
           
        
    }
}
