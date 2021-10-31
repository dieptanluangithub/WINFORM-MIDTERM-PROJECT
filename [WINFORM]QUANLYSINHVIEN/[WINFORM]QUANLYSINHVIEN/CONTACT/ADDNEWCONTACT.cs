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
    public partial class ADDNEWCONTACT : Form
    {
        MY_DB mydb = new MY_DB();
        GROUP group = new GROUP();
        CONTACT contact = new CONTACT();
        public ADDNEWCONTACT()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            //CONTACT con = new CONTACT();


            //string FName = Textbox_Fname.Text;
            //string LName = Textbox_Lname.Text;
            //int Group_id = Convert.ToInt32(comboBox_group.SelectedValue);
            //string Phone = Textbox_phone.Text;
            //string Email = Textbox_email.Text;
            //string Address = textBox_address.Text;
            //MemoryStream Picture = new MemoryStream();
            ////int Id = Convert.ToInt32(Textbox_ID.Text);

            //if (con.insertContact(FName, LName,Group_id, Phone, Email, Address,Picture, Id))
            //{
            //    MessageBox.Show("Registration Complete Successfull", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Registration Not Successfull", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //int id = Convert.ToInt32(Textbox_ID.Text);



            int cID = Convert.ToInt32(Textbox_ID.Text);
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            string phone = Textbox_phone.Text;
            string address = textBox_address.Text;
            string email = Textbox_email.Text;
            int userid = GlobalUserId.UserID;


           
            try
            {
                int groupid = Convert.ToInt32(comboBox_group.SelectedValue);
                MemoryStream pic = new MemoryStream();
                PictureboxUserImage.Image.Save(pic, PictureboxUserImage.Image.RawFormat);

                if (!contact.ContactExist(Convert.ToInt32(Textbox_ID.Text)))
                {
                    if (contact.insertContact(cID,fname, lname, groupid, phone, email, address, pic, userid))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("One Or More Fields Are Empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ADDNEWCONTACT_Load(object sender, EventArgs e)
        {

            comboBox_group.DataSource = group.getGroups2();
            comboBox_group.DisplayMember = "name";
            comboBox_group.ValueMember = "id";
            comboBox_group.SelectedItem = null;
        }
    }
}
