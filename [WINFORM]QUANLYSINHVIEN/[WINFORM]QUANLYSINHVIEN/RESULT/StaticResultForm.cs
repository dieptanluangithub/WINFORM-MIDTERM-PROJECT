using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();

        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            DGV_staticcourse.DataSource = score.getAvgScoreByCourse();
        }
    }
}
