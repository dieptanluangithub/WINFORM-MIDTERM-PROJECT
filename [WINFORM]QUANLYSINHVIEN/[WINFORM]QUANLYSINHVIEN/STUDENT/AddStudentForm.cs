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

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Radiobt_Male.Checked)
                MessageBox.Show("You are Male!");
            else
                MessageBox.Show("You are Female!");
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
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
                    MessageBox.Show("ID Student Already Exist", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }                
        }
        bool verif()
        {
            if ((Textbox_Fname.Text.Trim() == "")
                ||(Textbox_Lname.Text.Trim() == "")
                ||(Textbox_Phone.Text.Trim() == "")
                ||(PictureboxStudentImage.Image  == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png,*.gif)|*.jpg;*.png,*.gif";
            if ((opf.ShowDialog()== DialogResult.OK))
            {
                PictureboxStudentImage.Image = Image.FromFile(opf.FileName);
            }    
        }

    }
}
