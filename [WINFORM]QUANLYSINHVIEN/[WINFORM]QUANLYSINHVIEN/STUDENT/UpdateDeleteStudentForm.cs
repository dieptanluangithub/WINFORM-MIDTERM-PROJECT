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
using System.IO;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class UpdateDeleteStudentForm : Form
    {
        STUDENT student = new STUDENT();
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        
        private void bt_find_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Textbox_ID.Text);
            SqlCommand command = new SqlCommand("SELECT Id, FName, LName, BDate, Gender, Phone, Address, Picture FROM hocsinh WHERE Id = " + Id);
            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                Textbox_Fname.Text = table.Rows[0]["FName"].ToString();
                Textbox_Lname.Text = table.Rows[0]["LName"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["BDate"];

                if (table.Rows[0]["Gender"].ToString() == "Female")
                {
                    Radiobt_Female.Checked = true;
                }
                else
                {
                    Radiobt_Male.Checked = true;
                }
                Textbox_Phone.Text = table.Rows[0]["Phone"].ToString();
                Textbox_Address.Text = table.Rows[0]["Address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureboxStudentImage.Image = Image.FromStream(picture);
                
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog()== DialogResult.OK))
            {
                PictureboxStudentImage.Image = Image.FromFile(opf.FileName);
            }    
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(Textbox_ID.Text);
                if((MessageBox.Show("Are You Sure You Want To Delete This Student","Delete Student", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
                {
                    if(student.deteleStudent(studentID))
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
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone,adrs,pic))
                    {
                        MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
