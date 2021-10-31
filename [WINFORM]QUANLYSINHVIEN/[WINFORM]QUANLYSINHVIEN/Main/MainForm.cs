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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm studentList = new StudentListForm();
            studentList.Show(this);

        }
        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm stf = new StaticsForm();
            stf.Show(this);
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print studentPrint = new Print();
            studentPrint.Show(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse addcourse = new AddCourse();
            addcourse.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm remove = new RemoveCourseForm();
            remove.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm edit = new EditCourseForm();
            edit.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upstd = new UpdateDeleteStudentForm();
            upstd.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageForm man = new ManageForm();
            man.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            printCourse.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manc = new ManageCourseForm();
            manc.Show(this);
        }

        private void addCorseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm add = new AddScoreForm();
            add.Show(this);
        }

        private void aVGCorseByCorseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avg = new AvgScoreByCourse();
            avg.Show(this);
        }

        private void manageCorseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm man = new ManageCoursesForm();
            man.Show(this);
        }

        private void removeCorseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm re = new RemoveScoreForm();
            re.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm print = new PrintScoreForm();
            print.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            result.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm sta = new StaticResultForm();
            sta.ShowDialog();
        }
    }
}
