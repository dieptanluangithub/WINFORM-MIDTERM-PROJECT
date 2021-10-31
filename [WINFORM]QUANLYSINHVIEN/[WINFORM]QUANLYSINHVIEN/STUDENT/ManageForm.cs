using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(Textbox_ID.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deteleStudent(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Textbox_ID.Text = "";
                        Textbox_Fname.Text = "";
                        Textbox_Lname.Text = "";
                        Textbox_Address.Text = "";
                        Textbox_Phone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        PictureboxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool verif()
        {
            if ((Textbox_ID.Text.Trim() == "")
                || (Textbox_Fname.Text.Trim() == "")
                || (Textbox_Lname.Text.Trim() == "")
                || (Textbox_Address.Text.Trim() == "")
                || (Textbox_Phone.Text.Trim() == "")
                || (PictureboxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = Textbox_Phone.Text;
            string adrs = Textbox_Address.Text;
            string gender = "Male";
            if (Radiobt_Female.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((((this_year - born_year) < 15) || ((this_year - born_year) > 30)))
            {
                MessageBox.Show("The Student Age Must Be Between 15 and 30 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(Textbox_ID.Text);
                    PictureboxStudentImage.Image.Save(pic, PictureboxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureboxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            int Id = Convert.ToInt32(Textbox_ID.Text);
            string FName = Textbox_Fname.Text;
            string LName = Textbox_Lname.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            string Gender = "Male";
            if (Radiobt_Female.Checked)
            {
                Gender = "Female";
            }
            string Phone = Textbox_Phone.Text;
            string Address = Textbox_Address.Text;

            MemoryStream Picture = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((((this_year - born_year) < 15) || ((this_year - born_year) > 30)))
            {
                MessageBox.Show("The Student Age Must Be Between 15 and 30 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                PictureboxStudentImage.Image.Save(Picture, PictureboxStudentImage.Image.RawFormat);
                if (std.insertStd(Id, FName, LName, BDate, Gender, Phone, Address, Picture))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh WHERE CONCAT(Id,FName,LName,Address,Phone) LIKE'%" + Textbox_Search.Text + "%'" );
            fillgrid(command);
            
        }
        public void fillgrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }
        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_LoginDataSet4.hocsinh' table. You can move, or remove it, as needed.
            this.hocsinhTableAdapter.Fill(this.dB_LoginDataSet4.hocsinh);
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh");
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void bt_reset_Click(object sender, EventArgs e)
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

        private void bt_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Student_" + Textbox_ID.Text);
            if ((PictureboxStudentImage.Image == null))
            {
                MessageBox.Show("No Image In PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                PictureboxStudentImage.Image.Save((svf.FileName + "." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.Textbox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            manageForm.Textbox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            manageForm.Textbox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            manageForm.dateTimePicker1.Value = date;

            string sex = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            if (sex == "Female")
            {
                manageForm.Radiobt_Female.Checked = true;
            }

            if (sex == "Male")
            {
                manageForm.Radiobt_Male.Checked = true;
            }

            manageForm.Textbox_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            manageForm.Textbox_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            manageForm.PictureboxStudentImage.Image = Image.FromStream(picture);
            manageForm.Show();
        }

        private void LabelTotalStud_MouseEnter(object sender, EventArgs e)
        {
            LabelTotalStud.Text = ("Total Student: " + dataGridView1.Rows.Count);
        }
    }
    
}
