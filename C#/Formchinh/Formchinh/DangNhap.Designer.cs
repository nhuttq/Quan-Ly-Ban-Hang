namespace Formchinh
{
    partial class DangNhap
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
            this.butDangNhap = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.DangNhapTaiKhoan = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // butDangNhap
            // 
            this.butDangNhap.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.butDangNhap.Location = new System.Drawing.Point(289, 315);
            this.butDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(225, 41);
            this.butDangNhap.TabIndex = 0;
            this.butDangNhap.Text = "ĐĂNG NHẬP";
            this.butDangNhap.UseVisualStyleBackColor = false;
            this.butDangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.SystemColors.Info;
            this.butThoat.Location = new System.Drawing.Point(731, 315);
            this.butThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(208, 41);
            this.butThoat.TabIndex = 1;
            this.butThoat.Text = "THOÁT";
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.SystemColors.Info;
            this.lblTaiKhoan.Location = new System.Drawing.Point(300, 158);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(168, 17);
            this.lblTaiKhoan.TabIndex = 3;
            this.lblTaiKhoan.Text = "TÀI KHOẢN ĐĂNG NHẬP";
            this.lblTaiKhoan.Click += new System.EventHandler(this.lbltendangnhap_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.BackColor = System.Drawing.SystemColors.Info;
            this.lbMatKhau.Location = new System.Drawing.Point(351, 213);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(79, 17);
            this.lbMatKhau.TabIndex = 4;
            this.lbMatKhau.Text = "MẬT KHẨU";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(500, 154);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(329, 22);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // DangNhapTaiKhoan
            // 
            this.DangNhapTaiKhoan.AutoSize = true;
            this.DangNhapTaiKhoan.BackColor = System.Drawing.SystemColors.Info;
            this.DangNhapTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapTaiKhoan.Location = new System.Drawing.Point(443, 57);
            this.DangNhapTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DangNhapTaiKhoan.Name = "DangNhapTaiKhoan";
            this.DangNhapTaiKhoan.Size = new System.Drawing.Size(298, 26);
            this.DangNhapTaiKhoan.TabIndex = 7;
            this.DangNhapTaiKhoan.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            this.DangNhapTaiKhoan.Click += new System.EventHandler(this.DangNhapTaiKhoan_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(500, 209);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(329, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(604, 268);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formchinh.Properties.Resources.pngtree_6_beautiful_background_photos_image_263872;
            this.ClientSize = new System.Drawing.Size(1175, 438);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.DangNhapTaiKhoan);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDangNhap;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label DangNhapTaiKhoan;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}