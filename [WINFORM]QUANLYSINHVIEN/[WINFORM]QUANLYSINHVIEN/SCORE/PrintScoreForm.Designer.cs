
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class PrintScoreForm
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
            this.DGV_printScore = new System.Windows.Forms.DataGridView();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dlg = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_printScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_printScore
            // 
            this.DGV_printScore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_printScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_printScore.Location = new System.Drawing.Point(-1, 87);
            this.DGV_printScore.Name = "DGV_printScore";
            this.DGV_printScore.Size = new System.Drawing.Size(639, 342);
            this.DGV_printScore.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_save.Font = new System.Drawing.Font("SVN-Square", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_save.Location = new System.Drawing.Point(117, 444);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(113, 42);
            this.bt_save.TabIndex = 32;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_print.Font = new System.Drawing.Font("SVN-Square", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_print.Location = new System.Drawing.Point(402, 444);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(113, 42);
            this.bt_print.TabIndex = 31;
            this.bt_print.Text = "PRINT";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Firebrick;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(645, 49);
            this.label11.TabIndex = 52;
            this.label11.Text = "PRINT SCORE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dlg
            // 
            this.dlg.UseEXDialog = true;
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(635, 498);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.DGV_printScore);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_printScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_printScore;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Label label11;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog dlg;
    }
}