
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class StaticsForm
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
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.MaleLabel = new System.Windows.Forms.Label();
            this.FemaleLabel = new System.Windows.Forms.Label();
            this.PanelTotal.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.IndianRed;
            this.PanelTotal.Controls.Add(this.TotalLabel);
            this.PanelTotal.Location = new System.Drawing.Point(0, 0);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(500, 180);
            this.PanelTotal.TabIndex = 0;
            this.PanelTotal.MouseEnter += new System.EventHandler(this.PanelTotal_MouseEnter);
            this.PanelTotal.MouseLeave += new System.EventHandler(this.PanelTotal_MouseLeave);
            // 
            // PanelMale
            // 
            this.PanelMale.Controls.Add(this.MaleLabel);
            this.PanelMale.Location = new System.Drawing.Point(0, 180);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(254, 176);
            this.PanelMale.TabIndex = 1;
            this.PanelMale.MouseEnter += new System.EventHandler(this.PanelMale_MouseEnter);
            this.PanelMale.MouseLeave += new System.EventHandler(this.PanelMale_MouseLeave);
            // 
            // PanelFemale
            // 
            this.PanelFemale.Controls.Add(this.FemaleLabel);
            this.PanelFemale.Location = new System.Drawing.Point(254, 180);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(246, 175);
            this.PanelFemale.TabIndex = 2;
            this.PanelFemale.MouseEnter += new System.EventHandler(this.PanelFemale_MouseEnter);
            this.PanelFemale.MouseLeave += new System.EventHandler(this.PanelFemale_MouseLeave);
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.Color.LightGray;
            this.TotalLabel.Font = new System.Drawing.Font("SVN-Abril Fatface", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(12, 21);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(484, 146);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "TOTAL STUDENT: 100%";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaleLabel
            // 
            this.MaleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaleLabel.Font = new System.Drawing.Font("SVN-Abril Fatface", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleLabel.Location = new System.Drawing.Point(11, 12);
            this.MaleLabel.Name = "MaleLabel";
            this.MaleLabel.Size = new System.Drawing.Size(237, 153);
            this.MaleLabel.TabIndex = 0;
            this.MaleLabel.Text = "MALE: 50%";
            this.MaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FemaleLabel
            // 
            this.FemaleLabel.BackColor = System.Drawing.Color.LightCoral;
            this.FemaleLabel.Font = new System.Drawing.Font("SVN-Abril Fatface", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleLabel.Location = new System.Drawing.Point(5, 12);
            this.FemaleLabel.Name = "FemaleLabel";
            this.FemaleLabel.Size = new System.Drawing.Size(237, 153);
            this.FemaleLabel.TabIndex = 1;
            this.FemaleLabel.Text = "FEMALE: 50%";
            this.FemaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 369);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelMale.ResumeLayout(false);
            this.PanelFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label MaleLabel;
        private System.Windows.Forms.Label FemaleLabel;
    }
}