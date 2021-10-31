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

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class REGISTERFORM : Form
    {
        public REGISTERFORM()
        {
            InitializeComponent();
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png,*.gif)|*.jpg;*.png,*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureboxUserImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            int Id = Convert.ToInt32(Textbox_ID.Text);
            string FName = Textbox_Fname.Text;
            string LName = Textbox_Lname.Text;
            string Username = Textbox_Username.Text;
            string Password = Textbox_Password.Text;
            MemoryStream Picture = new MemoryStream();
            if (!user.usernameExist(Username, Id))
            {
                if (user.insertUser(Id,FName,LName,Username,Password,Picture))
                {
                    MessageBox.Show("Registration Complete Successfull", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration Not Successfull", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username đã tồn tại", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
