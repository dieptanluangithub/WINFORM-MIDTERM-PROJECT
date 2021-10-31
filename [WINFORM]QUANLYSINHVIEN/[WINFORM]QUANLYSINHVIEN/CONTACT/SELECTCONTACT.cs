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

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class SELECTCONTACT : Form
    {
        CONTACT contact = new CONTACT();
        public SELECTCONTACT()
        {
            InitializeComponent();
        }

        private void SELECTCONTACT_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM mycontact");
            DGV_selectcontact.DataSource = contact.getContact(command);
            fillgrid(command);

        }
        public void fillgrid(SqlCommand command)
        {
            DGV_selectcontact.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            DGV_selectcontact.RowTemplate.Height = 120;
            DGV_selectcontact.DataSource = contact.getContact(command);

            picCol = (DataGridViewImageColumn)DGV_selectcontact.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_selectcontact.AllowUserToAddRows = false;

        }
    }
}
