
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class AddScoreForm
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
            this.label_StudentID = new System.Windows.Forms.Label();
            this.label_selectcourse = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_decription = new System.Windows.Forms.Label();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.DGVAddScore = new System.Windows.Forms.DataGridView();
            this.bt_addScore = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_StudentID.Location = new System.Drawing.Point(46, 81);
            this.label_StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(121, 29);
            this.label_StudentID.TabIndex = 4;
            this.label_StudentID.Text = "Student ID:";
            // 
            // label_selectcourse
            // 
            this.label_selectcourse.AutoSize = true;
            this.label_selectcourse.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectcourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_selectcourse.Location = new System.Drawing.Point(13, 139);
            this.label_selectcourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_selectcourse.Name = "label_selectcourse";
            this.label_selectcourse.Size = new System.Drawing.Size(154, 29);
            this.label_selectcourse.TabIndex = 5;
            this.label_selectcourse.Text = "Select Course:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_score.Location = new System.Drawing.Point(93, 199);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(74, 29);
            this.label_score.TabIndex = 6;
            this.label_score.Text = "Score:";
            // 
            // label_decription
            // 
            this.label_decription.AutoSize = true;
            this.label_decription.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_decription.Location = new System.Drawing.Point(33, 260);
            this.label_decription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_decription.Name = "label_decription";
            this.label_decription.Size = new System.Drawing.Size(134, 29);
            this.label_decription.TabIndex = 7;
            this.label_decription.Text = "Description:";
            // 
            // textStudentID
            // 
            this.textStudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStudentID.Location = new System.Drawing.Point(212, 90);
            this.textStudentID.Multiline = true;
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(254, 31);
            this.textStudentID.TabIndex = 8;
            // 
            // textScore
            // 
            this.textScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(212, 210);
            this.textScore.Multiline = true;
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(254, 31);
            this.textScore.TabIndex = 9;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(212, 271);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(254, 31);
            this.textDescription.TabIndex = 10;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(212, 147);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(254, 27);
            this.comboBoxCourse.TabIndex = 11;
            // 
            // DGVAddScore
            // 
            this.DGVAddScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAddScore.Location = new System.Drawing.Point(509, 72);
            this.DGVAddScore.Name = "DGVAddScore";
            this.DGVAddScore.Size = new System.Drawing.Size(339, 386);
            this.DGVAddScore.TabIndex = 12;
            this.DGVAddScore.Click += new System.EventHandler(this.DGVAddScore_Click);
            // 
            // bt_addScore
            // 
            this.bt_addScore.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addScore.Location = new System.Drawing.Point(162, 354);
            this.bt_addScore.Name = "bt_addScore";
            this.bt_addScore.Size = new System.Drawing.Size(163, 56);
            this.bt_addScore.TabIndex = 13;
            this.bt_addScore.Text = "ADD SCORE";
            this.bt_addScore.UseVisualStyleBackColor = true;
            this.bt_addScore.Click += new System.EventHandler(this.bt_addScore_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Firebrick;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(858, 49);
            this.label11.TabIndex = 51;
            this.label11.Text = "ADD SCORE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_addScore);
            this.Controls.Add(this.DGVAddScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textStudentID);
            this.Controls.Add(this.label_decription);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_selectcourse);
            this.Controls.Add(this.label_StudentID);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.Label label_selectcourse;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_decription;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.DataGridView DGVAddScore;
        private System.Windows.Forms.Button bt_addScore;
        private System.Windows.Forms.Label label11;
    }
}