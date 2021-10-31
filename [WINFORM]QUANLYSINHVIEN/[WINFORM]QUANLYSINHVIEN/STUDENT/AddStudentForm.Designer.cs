
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class AddStudentForm
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.Textbox_Fname = new System.Windows.Forms.TextBox();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_Phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Radiobt_Male = new System.Windows.Forms.RadioButton();
            this.Radiobt_Female = new System.Windows.Forms.RadioButton();
            this.PictureboxStudentImage = new System.Windows.Forms.PictureBox();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.bt_uploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.Coral;
            this.bt_cancel.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(103, 407);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(105, 38);
            this.bt_cancel.TabIndex = 0;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_add.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(271, 407);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(105, 38);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(55, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(54, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "BirthDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(55, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(54, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(54, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(55, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Picture:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("FS Angry Birds Movie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(152, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "ADD NEW STUDENT";
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(180, 59);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 21);
            this.Textbox_ID.TabIndex = 11;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.Location = new System.Drawing.Point(180, 86);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Fname.TabIndex = 12;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.Location = new System.Drawing.Point(180, 114);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Lname.TabIndex = 13;
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Phone.Location = new System.Drawing.Point(180, 202);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Phone.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Radiobt_Male
            // 
            this.Radiobt_Male.AutoSize = true;
            this.Radiobt_Male.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Male.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Male.Location = new System.Drawing.Point(180, 171);
            this.Radiobt_Male.Name = "Radiobt_Male";
            this.Radiobt_Male.Size = new System.Drawing.Size(60, 21);
            this.Radiobt_Male.TabIndex = 16;
            this.Radiobt_Male.TabStop = true;
            this.Radiobt_Male.Text = "Male";
            this.Radiobt_Male.UseVisualStyleBackColor = false;
            this.Radiobt_Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Radiobt_Female
            // 
            this.Radiobt_Female.AutoSize = true;
            this.Radiobt_Female.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Female.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Female.Location = new System.Drawing.Point(271, 171);
            this.Radiobt_Female.Name = "Radiobt_Female";
            this.Radiobt_Female.Size = new System.Drawing.Size(74, 21);
            this.Radiobt_Female.TabIndex = 17;
            this.Radiobt_Female.TabStop = true;
            this.Radiobt_Female.Text = "Female";
            this.Radiobt_Female.UseVisualStyleBackColor = false;
            // 
            // PictureboxStudentImage
            // 
            this.PictureboxStudentImage.Location = new System.Drawing.Point(226, 266);
            this.PictureboxStudentImage.Name = "PictureboxStudentImage";
            this.PictureboxStudentImage.Size = new System.Drawing.Size(99, 116);
            this.PictureboxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureboxStudentImage.TabIndex = 18;
            this.PictureboxStudentImage.TabStop = false;
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Address.Location = new System.Drawing.Point(180, 231);
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Address.TabIndex = 19;
            // 
            // bt_uploadImage
            // 
            this.bt_uploadImage.Location = new System.Drawing.Point(331, 359);
            this.bt_uploadImage.Name = "bt_uploadImage";
            this.bt_uploadImage.Size = new System.Drawing.Size(86, 23);
            this.bt_uploadImage.TabIndex = 20;
            this.bt_uploadImage.Text = "Upload Image";
            this.bt_uploadImage.UseVisualStyleBackColor = true;
            this.bt_uploadImage.Click += new System.EventHandler(this.bt_uploadImage_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::_WINFORM_QUANLYSINHVIEN.Properties.Resources._13;
            this.ClientSize = new System.Drawing.Size(484, 468);
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_cancel);
            this.Name = "AddStudentForm";
            this.Text = "19110055-AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Textbox_Lname;
        private System.Windows.Forms.TextBox Textbox_Phone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Radiobt_Male;
        private System.Windows.Forms.RadioButton Radiobt_Female;
        private System.Windows.Forms.PictureBox PictureboxStudentImage;
        private System.Windows.Forms.TextBox Textbox_Address;
        private System.Windows.Forms.Button bt_uploadImage;
        public System.Windows.Forms.TextBox Textbox_ID;
        public System.Windows.Forms.TextBox Textbox_Fname;
    }
}