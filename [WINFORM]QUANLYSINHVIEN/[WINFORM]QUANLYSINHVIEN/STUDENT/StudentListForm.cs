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
    public partial class StudentListForm : Form
    {
        STUDENT student = new STUDENT();
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_LoginDataSet.hocsinh' table. You can move, or remove it, as needed.
            this.hocsinhTableAdapter.Fill(this.dB_LoginDataSet.hocsinh);
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh");
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            updateDeletStdF.Textbox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.Textbox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.Textbox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            updateDeletStdF.dateTimePicker1.Value = date;

            string sex = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            if (sex == "Female")
            {
                updateDeletStdF.Radiobt_Female.Checked = true;
            }
            
            if (sex == "Male")
            {
                updateDeletStdF.Radiobt_Male.Checked = true;
            }

            updateDeletStdF.Textbox_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.Textbox_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.PictureboxStudentImage.Image = Image.FromStream(picture);
            updateDeletStdF.Show();

        }
    }
}
