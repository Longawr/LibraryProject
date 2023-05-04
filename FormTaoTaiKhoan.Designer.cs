namespace LibraryProject
{
    partial class FormTaoTaiKhoan
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
            this.pnlTaoTaiKhoan = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.ckbNam = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.tbxTenThuThu = new System.Windows.Forms.TextBox();
            this.lblTenTT = new System.Windows.Forms.Label();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlTaoTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTaoTaiKhoan
            // 
            this.pnlTaoTaiKhoan.Controls.Add(this.btnThoat);
            this.pnlTaoTaiKhoan.Controls.Add(this.btnThem);
            this.pnlTaoTaiKhoan.Controls.Add(this.ckbNu);
            this.pnlTaoTaiKhoan.Controls.Add(this.ckbNam);
            this.pnlTaoTaiKhoan.Controls.Add(this.dtpNgaySinh);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxAddr);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxEmail);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxSDT);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblAddr);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblEmail);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblSDT);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblGioiTinh);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblNgaySinh);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxTenThuThu);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblTenTT);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxMatKhau);
            this.pnlTaoTaiKhoan.Controls.Add(this.tbxUsername);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblPassword);
            this.pnlTaoTaiKhoan.Controls.Add(this.lblUsername);
            this.pnlTaoTaiKhoan.Location = new System.Drawing.Point(12, 21);
            this.pnlTaoTaiKhoan.Name = "pnlTaoTaiKhoan";
            this.pnlTaoTaiKhoan.Size = new System.Drawing.Size(854, 599);
            this.pnlTaoTaiKhoan.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Location = new System.Drawing.Point(546, 463);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 40);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Location = new System.Drawing.Point(158, 463);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 40);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Tạo tài khoản";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Location = new System.Drawing.Point(698, 92);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(55, 24);
            this.ckbNu.TabIndex = 20;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.Location = new System.Drawing.Point(570, 92);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(68, 24);
            this.ckbNam.TabIndex = 19;
            this.ckbNam.Text = "Nam";
            this.ckbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(158, 96);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(241, 26);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // tbxAddr
            // 
            this.tbxAddr.Location = new System.Drawing.Point(158, 219);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(406, 26);
            this.tbxAddr.TabIndex = 17;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(570, 154);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(241, 26);
            this.tbxEmail.TabIndex = 16;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Location = new System.Drawing.Point(158, 160);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(241, 26);
            this.tbxSDT.TabIndex = 15;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(25, 219);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(61, 20);
            this.lblAddr.TabIndex = 12;
            this.lblAddr.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(466, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(25, 160);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(110, 20);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Số điện thoại: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(466, 96);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(75, 20);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 96);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh ";
            // 
            // tbxTenThuThu
            // 
            this.tbxTenThuThu.Location = new System.Drawing.Point(570, 43);
            this.tbxTenThuThu.Name = "tbxTenThuThu";
            this.tbxTenThuThu.Size = new System.Drawing.Size(241, 26);
            this.tbxTenThuThu.TabIndex = 7;
            // 
            // lblTenTT
            // 
            this.lblTenTT.AutoSize = true;
            this.lblTenTT.Location = new System.Drawing.Point(466, 46);
            this.lblTenTT.Name = "lblTenTT";
            this.lblTenTT.Size = new System.Drawing.Size(98, 20);
            this.lblTenTT.TabIndex = 6;
            this.lblTenTT.Text = "Tên thủ thư: ";
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Location = new System.Drawing.Point(158, 296);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(241, 26);
            this.tbxMatKhau.TabIndex = 4;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(158, 43);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(241, 26);
            this.tbxUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 302);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(878, 632);
            this.Controls.Add(this.pnlTaoTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            this.pnlTaoTaiKhoan.ResumeLayout(false);
            this.pnlTaoTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaoTaiKhoan;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxTenThuThu;
        private System.Windows.Forms.Label lblTenTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox ckbNu;
        private System.Windows.Forms.CheckBox ckbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tbxAddr;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnThoat;
    }
}