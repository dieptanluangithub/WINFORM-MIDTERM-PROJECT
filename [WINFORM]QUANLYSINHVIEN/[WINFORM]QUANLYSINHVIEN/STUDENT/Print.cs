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
using Word = Microsoft.Office.Interop.Word;

namespace _WINFORM_QUANLYSINHVIEN
{
    public partial class Print : Form
    {
        STUDENT student = new STUDENT();
        public Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_LoginDataSet1.hocsinh' table. You can move, or remove it, as needed.
            this.hocsinhTableAdapter.Fill(this.dB_LoginDataSet1.hocsinh);
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh");
            fillgrid(command);
            if (radioButtonNO.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }

        }
        public void fillgrid(SqlCommand command)
        {
            DGVStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            DGVStudent.RowTemplate.Height = 120;
            DGVStudent.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)DGVStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGVStudent.AllowUserToAddRows = false;

        }
        private void bt_print_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog(); //Khởi tạo đối tượng PrintDialog
            dlg.ShowDialog(); //Hiển thị hộp thoại PrintDialog
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if (radioButtonYES.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMALE.Checked)
                {
                    query = "SELECT * FROM hocsinh WHERE Gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else if (radioButtonFEMALE.Checked)
                {
                    query = "SELECT * FROM hocsinh WHERE Gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM hocsinh WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                command = new SqlCommand(query);
                fillgrid(command);
            }
            else
            {

                if (radioButtonMALE.Checked)
                {
                    query = "SELECT * FROM hocsinh WHERE Gender = 'Male'";
                }

                else if (radioButtonFEMALE.Checked)
                {
                    query = "SELECT * FROM hocsinh WHERE Gender = 'Female'";
                }

                else
                {
                    query = "SELECT * FROM hocsinh";
                }
                command = new SqlCommand(query);
                fillgrid(command);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Student_list.txt";
            //using (var writer = new StreamWriter(path))
            //{
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //    }
            //    DateTime bdate;
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
            //        {
            //            if (j == 3)
            //            {
            //                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
            //                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
            //            }
            //            else if (j == dataGridView1.Columns.Count - 2)
            //            {
            //                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
            //            }

            //            else
            //            {
            //                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //            }
            //        }
            //        writer.WriteLine("");
            //        writer.WriteLine("_______________________________________________________________________________________________________________________________________________________");

            //    }
            //    writer.Close();
            //    MessageBox.Show("ĐÃ LƯU FILE MỜI XEM KẾT QUẢ");
            //}
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Document (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DGVStudent, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }// end row loop
                }// end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "LIST STUDENT";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save image
                for (r = 0; r < RowCount; r++)
                {
                    byte[] imgbyte = (byte[])DGVStudent.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic, true);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }

                //save the file
                oDoc.SaveAs(filename);
            }
        }
        private void Print_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_LoginDataSet1.hocsinh' table. You can move, or remove it, as needed.
            this.hocsinhTableAdapter.Fill(this.dB_LoginDataSet1.hocsinh);
            SqlCommand command = new SqlCommand("SELECT * FROM hocsinh");
            fillgrid(command);
        }
    }
}
