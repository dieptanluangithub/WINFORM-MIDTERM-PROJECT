
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class ManageForm
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
            this.bt_uploadImage = new System.Windows.Forms.Button();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.PictureboxStudentImage = new System.Windows.Forms.PictureBox();
            this.Radiobt_Female = new System.Windows.Forms.RadioButton();
            this.Radiobt_Male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_Phone = new System.Windows.Forms.TextBox();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_Fname = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_download = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_LoginDataSet4 = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet4();
            this.LabelTotalStud = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.hocsinhTableAdapter = new _WINFORM_QUANLYSINHVIEN.DB_LoginDataSet4TableAdapters.hocsinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_uploadImage
            // 
            this.bt_uploadImage.Location = new System.Drawing.Point(247, 326);
            this.bt_uploadImage.Name = "bt_uploadImage";
            this.bt_uploadImage.Size = new System.Drawing.Size(98, 23);
            this.bt_uploadImage.TabIndex = 38;
            this.bt_uploadImage.Text = "Upload Image";
            this.bt_uploadImage.UseVisualStyleBackColor = true;
            this.bt_uploadImage.Click += new System.EventHandler(this.bt_uploadImage_Click);
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Address.Location = new System.Drawing.Point(137, 235);
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Address.TabIndex = 37;
            // 
            // PictureboxStudentImage
            // 
            this.PictureboxStudentImage.Location = new System.Drawing.Point(137, 270);
            this.PictureboxStudentImage.Name = "PictureboxStudentImage";
            this.PictureboxStudentImage.Size = new System.Drawing.Size(99, 116);
            this.PictureboxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureboxStudentImage.TabIndex = 36;
            this.PictureboxStudentImage.TabStop = false;
            // 
            // Radiobt_Female
            // 
            this.Radiobt_Female.AutoSize = true;
            this.Radiobt_Female.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Female.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Female.Location = new System.Drawing.Point(228, 175);
            this.Radiobt_Female.Name = "Radiobt_Female";
            this.Radiobt_Female.Size = new System.Drawing.Size(74, 21);
            this.Radiobt_Female.TabIndex = 35;
            this.Radiobt_Female.TabStop = true;
            this.Radiobt_Female.Text = "Female";
            this.Radiobt_Female.UseVisualStyleBackColor = false;
            // 
            // Radiobt_Male
            // 
            this.Radiobt_Male.AutoSize = true;
            this.Radiobt_Male.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Male.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Male.Location = new System.Drawing.Point(137, 175);
            this.Radiobt_Male.Name = "Radiobt_Male";
            this.Radiobt_Male.Size = new System.Drawing.Size(60, 21);
            this.Radiobt_Male.TabIndex = 34;
            this.Radiobt_Male.TabStop = true;
            this.Radiobt_Male.Text = "Male";
            this.Radiobt_Male.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Phone.Location = new System.Drawing.Point(137, 206);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Phone.TabIndex = 32;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.Location = new System.Drawing.Point(137, 118);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Lname.TabIndex = 31;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.Location = new System.Drawing.Point(137, 90);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Fname.TabIndex = 30;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(137, 63);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 21);
            this.Textbox_ID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(11, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(11, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student ID:";
            // 
            // bt_download
            // 
            this.bt_download.Location = new System.Drawing.Point(247, 363);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(98, 23);
            this.bt_download.TabIndex = 39;
            this.bt_download.Text = "Download Image";
            this.bt_download.UseVisualStyleBackColor = true;
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.hocsinhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(359, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 322);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "BDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "BDate";
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // hocsinhBindingSource
            // 
            this.hocsinhBindingSource.DataMember = "hocsinh";
            this.hocsinhBindingSource.DataSource = this.dB_LoginDataSet4;
            // 
            // dB_LoginDataSet4
            // 
            this.dB_LoginDataSet4.DataSetName = "DB_LoginDataSet4";
            this.dB_LoginDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelTotalStud
            // 
            this.LabelTotalStud.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelTotalStud.Font = new System.Drawing.Font("FS Harabara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalStud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTotalStud.Location = new System.Drawing.Point(959, 404);
            this.LabelTotalStud.Name = "LabelTotalStud";
            this.LabelTotalStud.Size = new System.Drawing.Size(237, 44);
            this.LabelTotalStud.TabIndex = 41;
            this.LabelTotalStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotalStud.MouseEnter += new System.EventHandler(this.LabelTotalStud_MouseEnter);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_add.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(26, 410);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(105, 38);
            this.bt_add.TabIndex = 42;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_remove.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.Location = new System.Drawing.Point(248, 410);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(105, 38);
            this.bt_remove.TabIndex = 43;
            this.bt_remove.Text = "REMOVE";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_edit.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(137, 410);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(105, 38);
            this.bt_edit.TabIndex = 44;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_reset.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(359, 410);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(105, 38);
            this.bt_reset.TabIndex = 45;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Search.Location = new System.Drawing.Point(670, 23);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Search.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(487, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Enter A Value To Search:";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_search.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(872, 14);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(105, 38);
            this.bt_search.TabIndex = 48;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.OrangeRed;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(84, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 29);
            this.label11.TabIndex = 49;
            this.label11.Text = "STUDENT MANAGE";
            // 
            // hocsinhTableAdapter
            // 
            this.hocsinhTableAdapter.ClearBeforeFill = true;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 473);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.LabelTotalStud);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.bt_uploadImage);
            this.Controls.Add(this.Textbox_Address);
            this.Controls.Add(this.PictureboxStudentImage);
            this.Controls.Add(this.Radiobt_Female);
            this.Controls.Add(this.Radiobt_Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Textbox_Phone);
            this.Controls.Add(this.Textbox_Lname);
            this.Controls.Add(this.Textbox_Fname);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LoginDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_uploadImage;
        private System.Windows.Forms.TextBox Textbox_Address;
        private System.Windows.Forms.PictureBox PictureboxStudentImage;
        private System.Windows.Forms.RadioButton Radiobt_Female;
        private System.Windows.Forms.RadioButton Radiobt_Male;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Textbox_Phone;
        private System.Windows.Forms.TextBox Textbox_Lname;
        public System.Windows.Forms.TextBox Textbox_Fname;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_download;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelTotalStud;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_reset;
        public System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label11;
        private DB_LoginDataSet4 dB_LoginDataSet4;
        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private DB_LoginDataSet4TableAdapters.hocsinhTableAdapter hocsinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}