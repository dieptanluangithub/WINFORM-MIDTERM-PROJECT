
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class EditCourseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDown_Period = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Select = new System.Windows.Forms.ComboBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.TextBox_Label = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Period)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Aguda", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(65, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Aguda", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Aguda", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(65, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Aguda", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Course:";
            // 
            // NumericUpDown_Period
            // 
            this.NumericUpDown_Period.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_Period.Location = new System.Drawing.Point(240, 173);
            this.NumericUpDown_Period.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDown_Period.Name = "NumericUpDown_Period";
            this.NumericUpDown_Period.Size = new System.Drawing.Size(90, 26);
            this.NumericUpDown_Period.TabIndex = 14;
            // 
            // comboBox_Select
            // 
            this.comboBox_Select.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Select.FormattingEnabled = true;
            this.comboBox_Select.Location = new System.Drawing.Point(240, 94);
            this.comboBox_Select.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Select.Name = "comboBox_Select";
            this.comboBox_Select.Size = new System.Drawing.Size(241, 26);
            this.comboBox_Select.TabIndex = 13;
            this.comboBox_Select.SelectedIndexChanged += new System.EventHandler(this.comboBox_Select_SelectedIndexChanged);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Teal;
            this.bt_Edit.Font = new System.Drawing.Font("SVN-Genica Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Edit.Location = new System.Drawing.Point(183, 344);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(147, 47);
            this.bt_Edit.TabIndex = 12;
            this.bt_Edit.Text = "EDIT";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Description.Location = new System.Drawing.Point(240, 214);
            this.TextBox_Description.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(241, 98);
            this.TextBox_Description.TabIndex = 11;
            // 
            // TextBox_Label
            // 
            this.TextBox_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Label.Location = new System.Drawing.Point(240, 134);
            this.TextBox_Label.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Label.Name = "TextBox_Label";
            this.TextBox_Label.Size = new System.Drawing.Size(241, 26);
            this.TextBox_Label.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Ivory;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(0, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(598, 49);
            this.label11.TabIndex = 51;
            this.label11.Text = "EDIT COURSE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(597, 445);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NumericUpDown_Period);
            this.Controls.Add(this.comboBox_Select);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.TextBox_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Period;
        private System.Windows.Forms.ComboBox comboBox_Select;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.TextBox TextBox_Label;
        private System.Windows.Forms.Label label11;
    }
}