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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;

            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double maleStudentPercentage = (totalMale * (100 / total));
            double femaleStudentPercentage = (totalFemale * (100 / total));
            TotalLabel.Text = ("Total Students: " + total.ToString());
            MaleLabel.Text = ("Male: " + (maleStudentPercentage.ToString("0.00") + "%"));
            FemaleLabel.Text = ("Female:" + (femaleStudentPercentage.ToString("0.00") + "%"));

        }
        private void PanelTotal_MouseEnter(object sender, EventArgs e)
        {
            TotalLabel.ForeColor = panTotalColor;
            PanelTotal.BackColor = Color.White;
        }

        private void PanelTotal_MouseLeave(object sender, EventArgs e)
        {
            TotalLabel.ForeColor = Color.White;
            PanelTotal.BackColor = panTotalColor;
        }

        private void PanelMale_MouseEnter(object sender, EventArgs e)
        {
            MaleLabel.ForeColor = panMaleColor;
            PanelMale.BackColor = Color.White;
        }

        private void PanelMale_MouseLeave(object sender, EventArgs e)
        {
            MaleLabel.ForeColor = Color.White;
            PanelMale.BackColor = panMaleColor;
        }

        private void PanelFemale_MouseEnter(object sender, EventArgs e)
        {
            FemaleLabel.ForeColor = panFemaleColor;
            PanelFemale.BackColor = Color.White;
        }

        private void PanelFemale_MouseLeave(object sender, EventArgs e)
        {
            FemaleLabel.ForeColor = Color.White;
            PanelFemale.BackColor = panFemaleColor;
        }
    }
}
