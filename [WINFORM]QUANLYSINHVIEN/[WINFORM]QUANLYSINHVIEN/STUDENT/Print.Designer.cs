
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class Print
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
            this.radioButtonALL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFEMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bt_check = new System.Windows.Forms.Button();
            this.DGVStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_LoginDataSet1 = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet1();
            this.bt_print = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_DateBetween = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hocsinhTableAdapter = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet1TableAdapters.hocsinhTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonALL
            // 
            this.radioButtonALL.AutoSize = true;
            this.radioButtonALL.Location = new System.Drawing.Point(6, 12);
            this.radioButtonALL.Name = "radioButtonALL";
            this.radioButtonALL.Size = new System.Drawing.Size(44, 17);
            this.radioButtonALL.TabIndex = 0;
            this.radioButtonALL.TabStop = true;
            this.radioButtonALL.Text = "ALL";
            this.radioButtonALL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFEMALE);
            this.groupBox1.Controls.Add(this.radioButtonMALE);
            this.groupBox1.Controls.Add(this.radioButtonALL);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 35);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFEMALE
            // 
            this.radioButtonFEMALE.AutoSize = true;
            this.radioButtonFEMALE.Location = new System.Drawing.Point(188, 12);
            this.radioButtonFEMALE.Name = "radioButtonFEMALE";
            this.radioButtonFEMALE.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFEMALE.TabIndex = 2;
            this.radioButtonFEMALE.TabStop = true;
            this.radioButtonFEMALE.Text = "Female";
            this.radioButtonFEMALE.UseVisualStyleBackColor = true;
            // 
            // radioButtonMALE
            // 
            this.radioButtonMALE.AutoSize = true;
            this.radioButtonMALE.Location = new System.Drawing.Point(97, 12);
            this.radioButtonMALE.Name = "radioButtonMALE";
            this.radioButtonMALE.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMALE.TabIndex = 1;
            this.radioButtonMALE.TabStop = true;
            this.radioButtonMALE.Text = "Male";
            this.radioButtonMALE.UseVisualStyleBackColor = true;
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Location = new System.Drawing.Point(448, 46);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(46, 17);
            this.radioButtonYES.TabIndex = 3;
            this.radioButtonYES.TabStop = true;
            this.radioButtonYES.Text = "YES";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            this.radioButtonYES.Click += new System.EventHandler(this.radioButtonYES_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(539, 46);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 4;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.Click += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 21);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(557, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(90, 21);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // bt_check
            // 
            this.bt_check.BackColor = System.Drawing.Color.Crimson;
            this.bt_check.Font = new System.Drawing.Font("SVN-Genica Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_check.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_check.Location = new System.Drawing.Point(695, 37);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(142, 59);
            this.bt_check.TabIndex = 28;
            this.bt_check.Text = "CHECK";
            this.bt_check.UseVisualStyleBackColor = false;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // DGVStudent
            // 
            this.DGVStudent.AutoGenerateColumns = false;
            this.DGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.DGVStudent.DataSource = this.hocsinhBindingSource;
            this.DGVStudent.Location = new System.Drawing.Point(-1, 123);
            this.DGVStudent.Name = "DGVStudent";
            this.DGVStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVStudent.Size = new System.Drawing.Size(851, 251);
            this.DGVStudent.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "BDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // hocsinhBindingSource
            // 
            this.hocsinhBindingSource.DataMember = "hocsinh";
            this.hocsinhBindingSource.DataSource = this.dB_LoginDataSet1;
            // 
            // dB_LoginDataSet1
            // 
            this.dB_LoginDataSet1.DataSetName = "DB_LoginDataSet1";
            this.dB_LoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_print.Font = new System.Drawing.Font("SVN-Sunday", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.Location = new System.Drawing.Point(538, 396);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(113, 42);
            this.bt_print.TabIndex = 29;
            this.bt_print.Text = "PRINT";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_save.Font = new System.Drawing.Font("SVN-Sunday", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Location = new System.Drawing.Point(183, 396);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(113, 42);
            this.bt_save.TabIndex = 30;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "and";
            // 
            // label_DateBetween
            // 
            this.label_DateBetween.AutoSize = true;
            this.label_DateBetween.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateBetween.Location = new System.Drawing.Point(294, 80);
            this.label_DateBetween.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DateBetween.Name = "label_DateBetween";
            this.label_DateBetween.Size = new System.Drawing.Size(114, 21);
            this.label_DateBetween.TabIndex = 32;
            this.label_DateBetween.Text = "Date between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Use date range:";
            // 
            // hocsinhTableAdapter
            // 
            this.hocsinhTableAdapter.ClearBeforeFill = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_DateBetween);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVStudent);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonNO);
            this.Controls.Add(this.radioButtonYES);
            this.Controls.Add(this.groupBox1);
            this.Name = "Print";
            this.Text = "Print";
            this.Click += new System.EventHandler(this.Print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonALL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFEMALE;
        private System.Windows.Forms.RadioButton radioButtonMALE;
        private System.Windows.Forms.RadioButton radioButtonYES;
        private System.Windows.Forms.RadioButton radioButtonNO;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.DataGridView DGVStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_DateBetween;
        private System.Windows.Forms.Label label1;
        private DB_LoginDataSet1 dB_LoginDataSet1;
        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private DB_LoginDataSet1TableAdapters.hocsinhTableAdapter hocsinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}