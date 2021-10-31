
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class ManageCoursesForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.bt_addScore = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.label_decription = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_selectcourse = new System.Windows.Forms.Label();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.bt_avgScore = new System.Windows.Forms.Button();
            this.bt_removeScore = new System.Windows.Forms.Button();
            this.bt_showscr = new System.Windows.Forms.Button();
            this.bt_showstd = new System.Windows.Forms.Button();
            this.DGV_StudentScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.OrangeRed;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-5, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1251, 49);
            this.label11.TabIndex = 53;
            this.label11.Text = "MANAGE SCORE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_addScore
            // 
            this.bt_addScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.bt_addScore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_addScore.Location = new System.Drawing.Point(72, 340);
            this.bt_addScore.Name = "bt_addScore";
            this.bt_addScore.Size = new System.Drawing.Size(144, 48);
            this.bt_addScore.TabIndex = 62;
            this.bt_addScore.Text = "ADD";
            this.bt_addScore.UseVisualStyleBackColor = false;
            this.bt_addScore.Click += new System.EventHandler(this.bt_addScore_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(192, 153);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(254, 27);
            this.comboBoxCourse.TabIndex = 61;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(192, 277);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(254, 31);
            this.textDescription.TabIndex = 60;
            // 
            // textScore
            // 
            this.textScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(192, 216);
            this.textScore.Multiline = true;
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(254, 31);
            this.textScore.TabIndex = 59;
            // 
            // textStudentID
            // 
            this.textStudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStudentID.Location = new System.Drawing.Point(192, 96);
            this.textStudentID.Multiline = true;
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(254, 31);
            this.textStudentID.TabIndex = 58;
            // 
            // label_decription
            // 
            this.label_decription.AutoSize = true;
            this.label_decription.Font = new System.Drawing.Font("SVN-Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decription.ForeColor = System.Drawing.Color.Snow;
            this.label_decription.Location = new System.Drawing.Point(38, 279);
            this.label_decription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_decription.Name = "label_decription";
            this.label_decription.Size = new System.Drawing.Size(146, 27);
            this.label_decription.TabIndex = 57;
            this.label_decription.Text = "Description:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("SVN-Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.Snow;
            this.label_score.Location = new System.Drawing.Point(98, 218);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(81, 27);
            this.label_score.TabIndex = 56;
            this.label_score.Text = "Score:";
            // 
            // label_selectcourse
            // 
            this.label_selectcourse.AutoSize = true;
            this.label_selectcourse.Font = new System.Drawing.Font("SVN-Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectcourse.ForeColor = System.Drawing.Color.Snow;
            this.label_selectcourse.Location = new System.Drawing.Point(18, 158);
            this.label_selectcourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_selectcourse.Name = "label_selectcourse";
            this.label_selectcourse.Size = new System.Drawing.Size(165, 27);
            this.label_selectcourse.TabIndex = 55;
            this.label_selectcourse.Text = "Select Course:";
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Font = new System.Drawing.Font("SVN-Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentID.ForeColor = System.Drawing.Color.Snow;
            this.label_StudentID.Location = new System.Drawing.Point(51, 100);
            this.label_StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(136, 27);
            this.label_StudentID.TabIndex = 54;
            this.label_StudentID.Text = "Student ID:";
            // 
            // bt_avgScore
            // 
            this.bt_avgScore.BackColor = System.Drawing.Color.Violet;
            this.bt_avgScore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_avgScore.Location = new System.Drawing.Point(72, 402);
            this.bt_avgScore.Name = "bt_avgScore";
            this.bt_avgScore.Size = new System.Drawing.Size(340, 48);
            this.bt_avgScore.TabIndex = 63;
            this.bt_avgScore.Text = "Average Score By Course";
            this.bt_avgScore.UseVisualStyleBackColor = false;
            this.bt_avgScore.Click += new System.EventHandler(this.bt_avgScore_Click);
            // 
            // bt_removeScore
            // 
            this.bt_removeScore.BackColor = System.Drawing.Color.Crimson;
            this.bt_removeScore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_removeScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_removeScore.Location = new System.Drawing.Point(268, 340);
            this.bt_removeScore.Name = "bt_removeScore";
            this.bt_removeScore.Size = new System.Drawing.Size(144, 48);
            this.bt_removeScore.TabIndex = 64;
            this.bt_removeScore.Text = "REMOVE";
            this.bt_removeScore.UseVisualStyleBackColor = false;
            this.bt_removeScore.Click += new System.EventHandler(this.bt_removeScore_Click);
            // 
            // bt_showscr
            // 
            this.bt_showscr.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_showscr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_showscr.Location = new System.Drawing.Point(835, 85);
            this.bt_showscr.Name = "bt_showscr";
            this.bt_showscr.Size = new System.Drawing.Size(163, 42);
            this.bt_showscr.TabIndex = 65;
            this.bt_showscr.Text = "Show Score";
            this.bt_showscr.UseVisualStyleBackColor = false;
            this.bt_showscr.Click += new System.EventHandler(this.bt_showscr_Click);
            // 
            // bt_showstd
            // 
            this.bt_showstd.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_showstd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_showstd.Location = new System.Drawing.Point(638, 85);
            this.bt_showstd.Name = "bt_showstd";
            this.bt_showstd.Size = new System.Drawing.Size(163, 42);
            this.bt_showstd.TabIndex = 66;
            this.bt_showstd.Text = "Show Student";
            this.bt_showstd.UseVisualStyleBackColor = false;
            this.bt_showstd.Click += new System.EventHandler(this.bt_showstd_Click);
            // 
            // DGV_StudentScore
            // 
            this.DGV_StudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_StudentScore.Location = new System.Drawing.Point(490, 133);
            this.DGV_StudentScore.Name = "DGV_StudentScore";
            this.DGV_StudentScore.Size = new System.Drawing.Size(628, 337);
            this.DGV_StudentScore.TabIndex = 67;
            this.DGV_StudentScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_StudentScore_CellClick);
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1137, 482);
            this.Controls.Add(this.DGV_StudentScore);
            this.Controls.Add(this.bt_showstd);
            this.Controls.Add(this.bt_showscr);
            this.Controls.Add(this.bt_removeScore);
            this.Controls.Add(this.bt_avgScore);
            this.Controls.Add(this.bt_addScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textStudentID);
            this.Controls.Add(this.label_decription);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_selectcourse);
            this.Controls.Add(this.label_StudentID);
            this.Controls.Add(this.label11);
            this.Name = "ManageCoursesForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_addScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.Label label_decription;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_selectcourse;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.Button bt_avgScore;
        private System.Windows.Forms.Button bt_removeScore;
        private System.Windows.Forms.Button bt_showscr;
        private System.Windows.Forms.Button bt_showstd;
        private System.Windows.Forms.DataGridView DGV_StudentScore;
    }
}