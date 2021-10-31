
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class ManageCourseForm
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
            this.numericUpDown_HoursNum = new System.Windows.Forms.NumericUpDown();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.TextBox_Label = new System.Windows.Forms.TextBox();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_HoursNum = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.listBox_TotalCourse = new System.Windows.Forms.ListBox();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.label_TotalCourse = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_first = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_last = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HoursNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_HoursNum
            // 
            this.numericUpDown_HoursNum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_HoursNum.Location = new System.Drawing.Point(178, 175);
            this.numericUpDown_HoursNum.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_HoursNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_HoursNum.Name = "numericUpDown_HoursNum";
            this.numericUpDown_HoursNum.Size = new System.Drawing.Size(90, 23);
            this.numericUpDown_HoursNum.TabIndex = 24;
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Description.Location = new System.Drawing.Point(178, 221);
            this.TextBox_Description.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(214, 103);
            this.TextBox_Description.TabIndex = 23;
            // 
            // TextBox_Label
            // 
            this.TextBox_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Label.Location = new System.Drawing.Point(180, 132);
            this.TextBox_Label.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Label.Name = "TextBox_Label";
            this.TextBox_Label.Size = new System.Drawing.Size(214, 23);
            this.TextBox_Label.TabIndex = 22;
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ID.Location = new System.Drawing.Point(180, 91);
            this.TextBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(214, 23);
            this.TextBox_ID.TabIndex = 21;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("SVN-Franko", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.Orange;
            this.label_Description.Location = new System.Drawing.Point(64, 221);
            this.label_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(110, 26);
            this.label_Description.TabIndex = 20;
            this.label_Description.Text = "Description:";
            // 
            // label_HoursNum
            // 
            this.label_HoursNum.AutoSize = true;
            this.label_HoursNum.Font = new System.Drawing.Font("SVN-Franko", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoursNum.ForeColor = System.Drawing.Color.Orange;
            this.label_HoursNum.Location = new System.Drawing.Point(64, 175);
            this.label_HoursNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_HoursNum.Name = "label_HoursNum";
            this.label_HoursNum.Size = new System.Drawing.Size(70, 26);
            this.label_HoursNum.TabIndex = 19;
            this.label_HoursNum.Text = "Period:";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Font = new System.Drawing.Font("SVN-Franko", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Label.ForeColor = System.Drawing.Color.Orange;
            this.label_Label.Location = new System.Drawing.Point(64, 132);
            this.label_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(60, 26);
            this.label_Label.TabIndex = 18;
            this.label_Label.Text = "Label:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("SVN-Franko", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.Orange;
            this.label_ID.Location = new System.Drawing.Point(64, 91);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(34, 26);
            this.label_ID.TabIndex = 17;
            this.label_ID.Text = "ID:";
            // 
            // listBox_TotalCourse
            // 
            this.listBox_TotalCourse.Font = new System.Drawing.Font("SVN-Bariol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_TotalCourse.FormattingEnabled = true;
            this.listBox_TotalCourse.ItemHeight = 24;
            this.listBox_TotalCourse.Location = new System.Drawing.Point(535, 91);
            this.listBox_TotalCourse.Name = "listBox_TotalCourse";
            this.listBox_TotalCourse.Size = new System.Drawing.Size(241, 292);
            this.listBox_TotalCourse.TabIndex = 25;

            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_edit.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(192, 414);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(105, 38);
            this.bt_edit.TabIndex = 48;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_remove.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.Location = new System.Drawing.Point(320, 415);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(105, 38);
            this.bt_remove.TabIndex = 47;
            this.bt_remove.Text = "REMOVE";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_add.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(66, 414);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(105, 38);
            this.bt_add.TabIndex = 46;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label_TotalCourse
            // 
            this.label_TotalCourse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_TotalCourse.Font = new System.Drawing.Font("iCielBC Cubano Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalCourse.ForeColor = System.Drawing.Color.Maroon;
            this.label_TotalCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_TotalCourse.Location = new System.Drawing.Point(536, 408);
            this.label_TotalCourse.Name = "label_TotalCourse";
            this.label_TotalCourse.Size = new System.Drawing.Size(237, 44);
            this.label_TotalCourse.TabIndex = 45;
            this.label_TotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.OrangeRed;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(2, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(837, 49);
            this.label11.TabIndex = 50;
            this.label11.Text = "COURSE MANAGE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_first
            // 
            this.bt_first.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_first.Font = new System.Drawing.Font("SVN-Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_first.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_first.Location = new System.Drawing.Point(36, 344);
            this.bt_first.Name = "bt_first";
            this.bt_first.Size = new System.Drawing.Size(105, 38);
            this.bt_first.TabIndex = 51;
            this.bt_first.Text = "FIRST";
            this.bt_first.UseVisualStyleBackColor = false;
            this.bt_first.Click += new System.EventHandler(this.bt_first_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_previous.Font = new System.Drawing.Font("SVN-Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_previous.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_previous.Location = new System.Drawing.Point(289, 344);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(105, 38);
            this.bt_previous.TabIndex = 52;
            this.bt_previous.Text = "PREVIOUS";
            this.bt_previous.UseVisualStyleBackColor = false;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_next
            // 
            this.bt_next.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_next.Font = new System.Drawing.Font("SVN-Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_next.Location = new System.Drawing.Point(163, 344);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(105, 38);
            this.bt_next.TabIndex = 53;
            this.bt_next.Text = "NEXT";
            this.bt_next.UseVisualStyleBackColor = false;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_last
            // 
            this.bt_last.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_last.Font = new System.Drawing.Font("SVN-Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_last.Location = new System.Drawing.Point(413, 344);
            this.bt_last.Name = "bt_last";
            this.bt_last.Size = new System.Drawing.Size(105, 38);
            this.bt_last.TabIndex = 54;
            this.bt_last.Text = "LAST";
            this.bt_last.UseVisualStyleBackColor = false;
            this.bt_last.Click += new System.EventHandler(this.bt_last_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 497);
            this.Controls.Add(this.bt_last);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_previous);
            this.Controls.Add(this.bt_first);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label_TotalCourse);
            this.Controls.Add(this.listBox_TotalCourse);
            this.Controls.Add(this.numericUpDown_HoursNum);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.TextBox_Label);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_HoursNum);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.label_ID);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HoursNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_HoursNum;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.TextBox TextBox_Label;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_HoursNum;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ListBox listBox_TotalCourse;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label_TotalCourse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_first;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_last;
    }
}