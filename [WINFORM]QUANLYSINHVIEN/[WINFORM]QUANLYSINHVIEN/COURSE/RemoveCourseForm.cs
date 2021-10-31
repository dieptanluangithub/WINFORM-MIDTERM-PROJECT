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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            COURSE crs = new COURSE();
            try
            {
                int cid = Convert.ToInt32(TextBox_CourseID.Text);
                if ((MessageBox.Show("Are you sure you want to remove this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (crs.deleteCourse(cid))
                    {
                        MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBox_CourseID.Text = "";
                    }
                    else
                        MessageBox.Show("Course Not Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
