
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class AvgScoreByCourse
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
            this.DGVAvgScoreByCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvgScoreByCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAvgScoreByCourse
            // 
            this.DGVAvgScoreByCourse.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DGVAvgScoreByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAvgScoreByCourse.Location = new System.Drawing.Point(13, 13);
            this.DGVAvgScoreByCourse.Name = "DGVAvgScoreByCourse";
            this.DGVAvgScoreByCourse.Size = new System.Drawing.Size(357, 287);
            this.DGVAvgScoreByCourse.TabIndex = 0;
            // 
            // AvgScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 312);
            this.Controls.Add(this.DGVAvgScoreByCourse);
            this.Name = "AvgScoreByCourse";
            this.Text = "AvgScoreByCourse";
            this.Load += new System.EventHandler(this.AvgScoreByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvgScoreByCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAvgScoreByCourse;
    }
}