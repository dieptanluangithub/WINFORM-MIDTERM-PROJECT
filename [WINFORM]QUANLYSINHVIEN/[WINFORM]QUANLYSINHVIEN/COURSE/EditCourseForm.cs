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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            string name = TextBox_Label.Text;
            int hrs = (int)NumericUpDown_Period.Value;
            string descr = TextBox_Description.Text;
            int id = (int)comboBox_Select.SelectedValue;

            if (!course.checkCourseName(name, Convert.ToInt32(comboBox_Select.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBox_Select.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void fillCombo(int index)
        {
            comboBox_Select.DataSource = course.getAllCourses();
            comboBox_Select.DisplayMember = "label";
            comboBox_Select.ValueMember = "id";
            comboBox_Select.SelectedIndex = index;
        }
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBox_Select.DataSource = course.getAllCourses();
            comboBox_Select.DisplayMember = "label";
            comboBox_Select.ValueMember = "id";
            comboBox_Select.SelectedItem = null;
        }

        private void comboBox_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox_Select.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                TextBox_Label.Text = table.Rows[0][1].ToString();
                NumericUpDown_Period.Value = int.Parse(table.Rows[0][2].ToString());
                TextBox_Description.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }

    }
}
