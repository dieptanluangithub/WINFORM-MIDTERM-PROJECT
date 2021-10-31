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
    public partial class SHOW_FULL_LIST : Form
    {
        CONTACT contact = new CONTACT();
        public SHOW_FULL_LIST()
        {
            InitializeComponent();
        }

        void reloadListBoxData()
        {
            GROUP group = new GROUP();
            listBox_group.DataSource = group.getGroups(GlobalUserId.UserID);
            listBox_group.DisplayMember = "name";
            listBox_group.ValueMember = "id";
            listBox_group.SelectedItem = null;
        }
        void reloadDGV()
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DGV_full.RowTemplate.Height = 120;
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroups.name as 'Group', phone, email," +
                "address, pic" + "FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id WHERE mycontact.userid = @userid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = GlobalUserId.UserID;
            DGV_full.DataSource = contact.SelectContactList(command);
            picCol = (DataGridViewImageColumn)DGV_full.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < DGV_full.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    DGV_full.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }

            //DGV_full.ClearSelection();
        }
        private void SHOW_FULL_LIST_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            listBox_group.DataSource = group.getGroups(GlobalUserId.UserID);
            listBox_group.DisplayMember = "name";
            listBox_group.ValueMember = "id";
            listBox_group.SelectedItem = null;
            reloadListBoxData();
            SqlCommand command = new SqlCommand("SELECT * FROM mycontact");
            DGV_full.DataSource = contact.getContact(command);
            fillgrid(command);

        }
        public void fillgrid(SqlCommand command)
        {
            DGV_full.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            DGV_full.RowTemplate.Height = 120;
            DGV_full.DataSource = contact.getContact(command);

            picCol = (DataGridViewImageColumn)DGV_full.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_full.AllowUserToAddRows = false;

        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void DGV_full_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for(int i= 0; i< DGV_full.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    DGV_full.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }    
            }    
        }

        private void listBox_group_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_address.Text = DGV_full.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception) { }
        }

        private void DGV_full_Click(object sender, EventArgs e)
        {
            try
            {
                CONTACT contact = new CONTACT();
                int groupid = (Int32)listBox_group.SelectedValue;
                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroups.name as 'Group', phone, email" +
                ",address, pic" + "FROM dbo.mycontact INNER JOIN mygroups on mycontact.group_id " +
                "= mygroups.id WHERE mycontact.userid = @userid AND mycontact.group_id = @groupid");
                command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
                command.Parameters.Add("@userid", SqlDbType.Int).Value = GlobalUserId.UserID;
                DGV_full.DataSource = contact.SelectContactList(command);
                for (int i = 0; i < DGV_full.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        DGV_full.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception) { }
            DGV_full.ClearSelection();
            
        }

    }
}
