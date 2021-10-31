using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class HUMANFORM : Form
    {
        MY_DB mydb = new MY_DB();
        GROUP group = new GROUP();
        public HUMANFORM()
        {
            InitializeComponent();
        }
        public void getImageAndUsername()
        {
            MY_DB mydb = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [mycontact] WHERE id=@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GlobalUserId.UserID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox2.Image = Image.FromStream(picture);
                lab_welcome.Text = "Welcome Back ( " + table.Rows[0]["uname"].ToString() + " )";
            }
        }

        private void HumanResource_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
        }
        private void bt_showfull_Click(object sender, EventArgs e)
        {
            SHOW_FULL_LIST show = new SHOW_FULL_LIST();
            show.ShowDialog();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            ADDNEWCONTACT add = new ADDNEWCONTACT();
            add.ShowDialog();
        }

        private void bt_gadd_Click(object sender, EventArgs e)
        {
            string gname = textBox_groupname.Text;
            try
            {
                if (!group.GroupExit(gname))
                {
                    
                    if (group.insertGroup(gname))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EDITCONTACT edit = new EDITCONTACT();
            edit.ShowDialog();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            SELECTCONTACT se = new SELECTCONTACT();
            se.ShowDialog();
        }
    }
}
