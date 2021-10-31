
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class ResultForm
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
            this.bt_search = new System.Windows.Forms.Button();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_Fname = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.DGVResult = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_savefiel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_search.Font = new System.Drawing.Font("SVN-Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_search.Location = new System.Drawing.Point(237, 325);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(105, 38);
            this.bt_search.TabIndex = 57;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Search.ForeColor = System.Drawing.Color.Black;
            this.Textbox_Search.Location = new System.Drawing.Point(146, 293);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(196, 26);
            this.Textbox_Search.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Search By ID, First Name:";
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.ForeColor = System.Drawing.Color.Black;
            this.Textbox_Lname.Location = new System.Drawing.Point(146, 220);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 26);
            this.Textbox_Lname.TabIndex = 54;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.ForeColor = System.Drawing.Color.Black;
            this.Textbox_Fname.Location = new System.Drawing.Point(146, 172);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 26);
            this.Textbox_Fname.TabIndex = 53;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.ForeColor = System.Drawing.Color.Black;
            this.Textbox_ID.Location = new System.Drawing.Point(146, 123);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 26);
            this.Textbox_ID.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Student ID:";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_save.Font = new System.Drawing.Font("SVN-Square", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_save.Location = new System.Drawing.Point(347, 396);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(113, 42);
            this.bt_save.TabIndex = 59;
            this.bt_save.Text = "CANCEL";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_print.Font = new System.Drawing.Font("SVN-Square", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_print.Location = new System.Drawing.Point(526, 396);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(113, 42);
            this.bt_print.TabIndex = 58;
            this.bt_print.Text = "PRINT";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // DGVResult
            // 
            this.DGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResult.Location = new System.Drawing.Point(389, 34);
            this.DGVResult.Name = "DGVResult";
            this.DGVResult.Size = new System.Drawing.Size(845, 337);
            this.DGVResult.TabIndex = 60;
            this.DGVResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVResult_CellClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.OrangeRed;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-3, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 49);
            this.label11.TabIndex = 61;
            this.label11.Text = "STUDENT RESULT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_savefiel
            // 
            this.bt_savefiel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_savefiel.Font = new System.Drawing.Font("SVN-Square", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_savefiel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_savefiel.Location = new System.Drawing.Point(705, 396);
            this.bt_savefiel.Name = "bt_savefiel";
            this.bt_savefiel.Size = new System.Drawing.Size(158, 42);
            this.bt_savefiel.TabIndex = 62;
            this.bt_savefiel.Text = "SAVE TO FILE";
            this.bt_savefiel.UseVisualStyleBackColor = false;
            this.bt_savefiel.Click += new System.EventHandler(this.bt_savefiel_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1246, 450);
            this.Controls.Add(this.bt_savefiel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGVResult);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Textbox_Lname);
            this.Controls.Add(this.Textbox_Fname);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_search;
        public System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Textbox_Lname;
        public System.Windows.Forms.TextBox Textbox_Fname;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.DataGridView DGVResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_savefiel;
    }
}