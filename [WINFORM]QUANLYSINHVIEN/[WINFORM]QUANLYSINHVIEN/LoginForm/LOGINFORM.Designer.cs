
namespace _WINFORM_QUANLYSINHVIEN
{
    partial class LOGINFORM
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
            this.components = new System.ComponentModel.Container();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_register = new System.Windows.Forms.Button();
            this.radio_std = new System.Windows.Forms.RadioButton();
            this.radio_human = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bt_cancel.Location = new System.Drawing.Point(51, 250);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(113, 32);
            this.bt_cancel.TabIndex = 0;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bt_login.Location = new System.Drawing.Point(221, 250);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(113, 32);
            this.bt_login.TabIndex = 1;
            this.bt_login.Text = "LOGIN";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(43, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FS Angry Birds Movie", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN EDUCATION";
            // 
            // Textbox_Username
            // 
            this.errorProvider1.SetError(this.Textbox_Username, "Phải nhập username");
            this.Textbox_Username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Textbox_Username.Location = new System.Drawing.Point(147, 123);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(162, 29);
            this.Textbox_Username.TabIndex = 5;
            this.Textbox_Username.Text = "username";
            this.toolTip1.SetToolTip(this.Textbox_Username, "Nhập tên đăng nhập");
            this.Textbox_Username.TextChanged += new System.EventHandler(this.Textbox_Username_TextChanged);
            this.Textbox_Username.Enter += new System.EventHandler(this.Textbox_Username_Enter);
            this.Textbox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Username_KeyPress);
            this.Textbox_Username.Leave += new System.EventHandler(this.Textbox_Username_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(147, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 29);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "password";
            this.toolTip1.SetToolTip(this.txtPassword, "Nhập Password");
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_WINFORM_QUANLYSINHVIEN.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bt_register
            // 
            this.bt_register.Font = new System.Drawing.Font("SVN-Aguda Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_register.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bt_register.Location = new System.Drawing.Point(134, 297);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(113, 32);
            this.bt_register.TabIndex = 8;
            this.bt_register.Text = "REGISTER";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // radio_std
            // 
            this.radio_std.AutoSize = true;
            this.radio_std.BackColor = System.Drawing.Color.Transparent;
            this.radio_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_std.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_std.Location = new System.Drawing.Point(49, 206);
            this.radio_std.Name = "radio_std";
            this.radio_std.Size = new System.Drawing.Size(76, 22);
            this.radio_std.TabIndex = 9;
            this.radio_std.TabStop = true;
            this.radio_std.Text = "Student";
            this.radio_std.UseVisualStyleBackColor = false;
            // 
            // radio_human
            // 
            this.radio_human.AutoSize = true;
            this.radio_human.BackColor = System.Drawing.Color.Transparent;
            this.radio_human.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_human.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_human.Location = new System.Drawing.Point(196, 206);
            this.radio_human.Name = "radio_human";
            this.radio_human.Size = new System.Drawing.Size(143, 22);
            this.radio_human.TabIndex = 10;
            this.radio_human.TabStop = true;
            this.radio_human.Text = "Human Resourse";
            this.radio_human.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LOGINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_WINFORM_QUANLYSINHVIEN.Properties.Resources._12;
            this.ClientSize = new System.Drawing.Size(399, 360);
            this.Controls.Add(this.radio_human);
            this.Controls.Add(this.radio_std);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cancel);
            this.Name = "LOGINFORM";
            this.Text = "19110055 - Diệp Tấn Luân";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.RadioButton radio_std;
        private System.Windows.Forms.RadioButton radio_human;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

