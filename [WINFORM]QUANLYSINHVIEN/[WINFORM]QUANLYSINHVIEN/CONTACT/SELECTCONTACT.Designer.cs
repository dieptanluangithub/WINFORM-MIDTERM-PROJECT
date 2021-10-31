
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class SELECTCONTACT
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
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_selectcontact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_selectcontact)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.OrangeRed;
            this.label9.Font = new System.Drawing.Font("iCielBC Cubano Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-5, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(966, 32);
            this.label9.TabIndex = 72;
            this.label9.Text = "SELECT CONTACT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV_selectcontact
            // 
            this.DGV_selectcontact.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_selectcontact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_selectcontact.Location = new System.Drawing.Point(-1, 60);
            this.DGV_selectcontact.Name = "DGV_selectcontact";
            this.DGV_selectcontact.Size = new System.Drawing.Size(962, 378);
            this.DGV_selectcontact.TabIndex = 73;
            // 
            // SELECTCONTACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.DGV_selectcontact);
            this.Controls.Add(this.label9);
            this.Name = "SELECTCONTACT";
            this.Text = "SELECTCONTACT";
            this.Load += new System.EventHandler(this.SELECTCONTACT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_selectcontact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_selectcontact;
    }
}