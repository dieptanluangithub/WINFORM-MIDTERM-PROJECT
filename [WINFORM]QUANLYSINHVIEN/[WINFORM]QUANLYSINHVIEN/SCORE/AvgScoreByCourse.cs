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
    public partial class AvgScoreByCourse : Form
    {
        public AvgScoreByCourse()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void AvgScoreByCourse_Load(object sender, EventArgs e)
        {
            DGVAvgScoreByCourse.DataSource = score.getAvgScoreByCourse();
        }
    }
}
