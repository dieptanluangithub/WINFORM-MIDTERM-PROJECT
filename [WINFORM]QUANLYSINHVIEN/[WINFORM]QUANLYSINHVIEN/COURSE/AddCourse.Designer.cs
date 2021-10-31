
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class AddCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Textbox_Description = new System.Windows.Forms.TextBox();
            this.Textbox_Period = new System.Windows.Forms.TextBox();
            this.Textbox_Label = new System.Windows.Forms.TextBox();
            this.Textbox_IDCourse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_addCourse = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // Textbox_Description
            // 
            this.Textbox_Description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Description.Location = new System.Drawing.Point(203, 198);
            this.Textbox_Description.Multiline = true;
            this.Textbox_Description.Name = "Textbox_Description";
            this.Textbox_Description.Size = new System.Drawing.Size(260, 153);
            this.Textbox_Description.TabIndex = 28;
            // 
            // Textbox_Period
            // 
            this.Textbox_Period.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Period.Location = new System.Drawing.Point(203, 156);
            this.Textbox_Period.Name = "Textbox_Period";
            this.Textbox_Period.Size = new System.Drawing.Size(260, 26);
            this.Textbox_Period.TabIndex = 27;
            // 
            // Textbox_Label
            // 
            this.Textbox_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Label.Location = new System.Drawing.Point(203, 118);
            this.Textbox_Label.Name = "Textbox_Label";
            this.Textbox_Label.Size = new System.Drawing.Size(260, 26);
            this.Textbox_Label.TabIndex = 26;
            // 
            // Textbox_IDCourse
            // 
            this.Textbox_IDCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_IDCourse.Location = new System.Drawing.Point(203, 81);
            this.Textbox_IDCourse.Name = "Textbox_IDCourse";
            this.Textbox_IDCourse.Size = new System.Drawing.Size(260, 26);
            this.Textbox_IDCourse.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Firebrick;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(598, 49);
            this.label11.TabIndex = 50;
            this.label11.Text = "COURSE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_addCourse
            // 
            this.bt_addCourse.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_addCourse.Font = new System.Drawing.Font("SVN-Genica Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_addCourse.Location = new System.Drawing.Point(308, 380);
            this.bt_addCourse.Name = "bt_addCourse";
            this.bt_addCourse.Size = new System.Drawing.Size(187, 54);
            this.bt_addCourse.TabIndex = 51;
            this.bt_addCourse.Text = "ADD";
            this.bt_addCourse.UseVisualStyleBackColor = false;
            this.bt_addCourse.Click += new System.EventHandler(this.bt_addCourse_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.Teal;
            this.bt_cancel.Font = new System.Drawing.Font("SVN-Genica Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cancel.Location = new System.Drawing.Point(46, 380);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(187, 54);
            this.bt_cancel.TabIndex = 52;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(587, 456);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_addCourse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Textbox_Description);
            this.Controls.Add(this.Textbox_Period);
            this.Controls.Add(this.Textbox_Label);
            this.Controls.Add(this.Textbox_IDCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Textbox_Description;
        public System.Windows.Forms.TextBox Textbox_Period;
        public System.Windows.Forms.TextBox Textbox_Label;
        public System.Windows.Forms.TextBox Textbox_IDCourse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_addCourse;
        private System.Windows.Forms.Button bt_cancel;
    }
}