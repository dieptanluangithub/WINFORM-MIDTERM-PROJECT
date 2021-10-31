
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class RemoveCourseForm
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
            this.bt_Remove = new System.Windows.Forms.Button();
            this.TextBox_CourseID = new System.Windows.Forms.TextBox();
            this.label_EnterCourseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_Remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Remove.Location = new System.Drawing.Point(445, 65);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(96, 39);
            this.bt_Remove.TabIndex = 5;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // TextBox_CourseID
            // 
            this.TextBox_CourseID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CourseID.Location = new System.Drawing.Point(225, 72);
            this.TextBox_CourseID.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_CourseID.Name = "TextBox_CourseID";
            this.TextBox_CourseID.Size = new System.Drawing.Size(199, 26);
            this.TextBox_CourseID.TabIndex = 4;
            // 
            // label_EnterCourseID
            // 
            this.label_EnterCourseID.AutoSize = true;
            this.label_EnterCourseID.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EnterCourseID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_EnterCourseID.Location = new System.Drawing.Point(11, 65);
            this.label_EnterCourseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EnterCourseID.Name = "label_EnterCourseID";
            this.label_EnterCourseID.Size = new System.Drawing.Size(210, 29);
            this.label_EnterCourseID.TabIndex = 3;
            this.label_EnterCourseID.Text = "Enter The Course ID:";
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(565, 173);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.TextBox_CourseID);
            this.Controls.Add(this.label_EnterCourseID);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.TextBox TextBox_CourseID;
        private System.Windows.Forms.Label label_EnterCourseID;
    }
}