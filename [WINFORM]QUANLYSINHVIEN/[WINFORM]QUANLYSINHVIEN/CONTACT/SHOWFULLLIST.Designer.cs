
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class SHOW_FULL_LIST
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
            this.DGV_full = new System.Windows.Forms.DataGridView();
            this.listBox_group = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_full)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_full
            // 
            this.DGV_full.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_full.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_full.Location = new System.Drawing.Point(272, 52);
            this.DGV_full.Name = "DGV_full";
            this.DGV_full.Size = new System.Drawing.Size(968, 341);
            this.DGV_full.TabIndex = 0;
            this.DGV_full.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_full_ColumnHeaderMouseClick);
            // 
            // listBox_group
            // 
            this.listBox_group.Font = new System.Drawing.Font("SVN-Bariol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_group.FormattingEnabled = true;
            this.listBox_group.ItemHeight = 24;
            this.listBox_group.Location = new System.Drawing.Point(12, 52);
            this.listBox_group.Name = "listBox_group";
            this.listBox_group.Size = new System.Drawing.Size(241, 340);
            this.listBox_group.TabIndex = 26;
            this.listBox_group.Click += new System.EventHandler(this.listBox_group_Click);
            this.listBox_group.SelectedIndexChanged += new System.EventHandler(this.SHOW_FULL_LIST_Load);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.OrangeRed;
            this.label9.Font = new System.Drawing.Font("iCielBC Cubano Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 32);
            this.label9.TabIndex = 73;
            this.label9.Text = "GROUP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("iCielBC Cubano Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "LIST CONTACT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("iCielBC Cubano Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "ADDRESS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(431, 409);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(337, 65);
            this.textBox_address.TabIndex = 76;
            // 
            // SHOW_FULL_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1237, 496);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_group);
            this.Controls.Add(this.DGV_full);
            this.Name = "SHOW_FULL_LIST";
            this.Text = "SHOW_FULL_LIST";
            this.Load += new System.EventHandler(this.SHOW_FULL_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_full)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_full;
        private System.Windows.Forms.ListBox listBox_group;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
    }
}