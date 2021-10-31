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
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.ACCOUNT WHERE uname = @User AND pwd = @Pass", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = Textbox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0) && (radio_std.Checked))
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // this.DialogResult = DialogResult.OK;
                MainForm main = new MainForm();
                main.ShowDialog();
            }
            else if ((table.Rows.Count > 0) && (radio_human.Checked))
            {
                HUMANFORM hu = new HUMANFORM();
                hu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Textbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                bt_login_Click(sender, e);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                txtPassword.Focus();
            }
        }

        private void Textbox_Username_Enter(object sender, EventArgs e)
        {
            if(Textbox_Username.Text == "username")
            {
                Textbox_Username.Text = "";
                Textbox_Username.ForeColor = Color.Black;
            }    
        }

        private void Textbox_Username_Leave(object sender, EventArgs e)
        {
            if (Textbox_Username.Text == "")
            {
                Textbox_Username.Text = "username";
                Textbox_Username.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            REGISTERFORM re = new REGISTERFORM();
            re.ShowDialog();
        }

        private void Textbox_Username_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_Username.Text != "")
            {
                errorProvider1.Clear();
            }
        }

    }
}
