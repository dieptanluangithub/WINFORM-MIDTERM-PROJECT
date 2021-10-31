
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class PrintCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGVPrintCourse = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.dB_LoginDataSet6 = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet6();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet6TableAdapters.courseTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrintCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPrintCourse
            // 
            this.DGVPrintCourse.AutoGenerateColumns = false;
            this.DGVPrintCourse.BackgroundColor = System.Drawing.Color.Salmon;
            this.DGVPrintCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPrintCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DGVPrintCourse.DataSource = this.courseBindingSource;
            this.DGVPrintCourse.Location = new System.Drawing.Point(3, 66);
            this.DGVPrintCourse.Name = "DGVPrintCourse";
            this.DGVPrintCourse.Size = new System.Drawing.Size(630, 278);
            this.DGVPrintCourse.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(630, 44);
            this.label11.TabIndex = 50;
            this.label11.Text = "LIST COURSE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_save.Font = new System.Drawing.Font("SVN-Abril Fatface", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_save.Location = new System.Drawing.Point(71, 377);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(129, 50);
            this.bt_save.TabIndex = 52;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_print.Font = new System.Drawing.Font("SVN-Abril Fatface", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_print.Location = new System.Drawing.Point(384, 377);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(129, 50);
            this.bt_print.TabIndex = 51;
            this.bt_print.Text = "PRINT";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // dB_LoginDataSet6
            // 
            this.dB_LoginDataSet6.DataSetName = "DB_LoginDataSet6";
            this.dB_LoginDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.dB_LoginDataSet6;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "label";
            this.dataGridViewTextBoxColumn2.HeaderText = "label";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "period";
            this.dataGridViewTextBoxColumn3.HeaderText = "period";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGVPrintCourse);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrintCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPrintCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_print;
        private DB_LoginDataSet6 dB_LoginDataSet6;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DB_LoginDataSet6TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}