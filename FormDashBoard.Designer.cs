﻿
namespace LibraryProject
{
    partial class FormDashBoard
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxDashboard = new System.Windows.Forms.PictureBox();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTKInfo = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnPhieuMuon = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnThuThu = new System.Windows.Forms.Button();
            this.btnPhieuTra = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashboard)).BeginInit();
            this.panelTaiKhoan.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHead.Controls.Add(this.btnClose);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1125, 38);
            this.panelHead.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1091, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSidebar.Controls.Add(this.pbxDashboard);
            this.panelSidebar.Controls.Add(this.panelTaiKhoan);
            this.panelSidebar.Controls.Add(this.panelControl);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 38);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(225, 687);
            this.panelSidebar.TabIndex = 12;
            // 
            // pbxDashboard
            // 
            this.pbxDashboard.Image = global::LibraryProject.Properties.Resources.notebook;
            this.pbxDashboard.Location = new System.Drawing.Point(3, 4);
            this.pbxDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxDashboard.Name = "pbxDashboard";
            this.pbxDashboard.Size = new System.Drawing.Size(222, 144);
            this.pbxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDashboard.TabIndex = 7;
            this.pbxDashboard.TabStop = false;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.btnDangXuat);
            this.panelTaiKhoan.Controls.Add(this.btnTKInfo);
            this.panelTaiKhoan.Controls.Add(this.btnTaiKhoan);
            this.panelTaiKhoan.Location = new System.Drawing.Point(3, 156);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTaiKhoan.MaximumSize = new System.Drawing.Size(225, 112);
            this.panelTaiKhoan.MinimumSize = new System.Drawing.Size(225, 38);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(225, 38);
            this.panelTaiKhoan.TabIndex = 9;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Gray;
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(1, 74);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(218, 38);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTKInfo
            // 
            this.btnTKInfo.BackColor = System.Drawing.Color.Gray;
            this.btnTKInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTKInfo.FlatAppearance.BorderSize = 0;
            this.btnTKInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKInfo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKInfo.ForeColor = System.Drawing.Color.White;
            this.btnTKInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKInfo.Location = new System.Drawing.Point(1, 38);
            this.btnTKInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKInfo.Name = "btnTKInfo";
            this.btnTKInfo.Size = new System.Drawing.Size(218, 38);
            this.btnTKInfo.TabIndex = 9;
            this.btnTKInfo.Text = "Thông Tin Tài Khoản";
            this.btnTKInfo.UseVisualStyleBackColor = false;
            this.btnTKInfo.Click += new System.EventHandler(this.btnTKInfo_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.DimGray;
            this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(-15, -15);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(250, 69);
            this.btnTaiKhoan.TabIndex = 8;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnSach);
            this.panelControl.Controls.Add(this.btnCaiDat);
            this.panelControl.Controls.Add(this.btnPhieuMuon);
            this.panelControl.Controls.Add(this.btnDocGia);
            this.panelControl.Controls.Add(this.btnThuThu);
            this.panelControl.Controls.Add(this.btnPhieuTra);
            this.panelControl.Controls.Add(this.btnThongKe);
            this.panelControl.Location = new System.Drawing.Point(3, 202);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(225, 308);
            this.panelControl.TabIndex = 10;
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.DimGray;
            this.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Location = new System.Drawing.Point(-1, -1);
            this.btnSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(225, 38);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCaiDat.Image = global::LibraryProject.Properties.Resources.settings;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(-1, 269);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(225, 38);
            this.btnCaiDat.TabIndex = 6;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPhieuMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btnPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuMuon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPhieuMuon.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuMuon.Location = new System.Drawing.Point(-1, 44);
            this.btnPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(225, 38);
            this.btnPhieuMuon.TabIndex = 1;
            this.btnPhieuMuon.Text = "Phiếu Mượn";
            this.btnPhieuMuon.UseVisualStyleBackColor = false;
            this.btnPhieuMuon.Click += new System.EventHandler(this.btnPhieuMuon_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDocGia.Image = global::LibraryProject.Properties.Resources.user;
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.Location = new System.Drawing.Point(-1, 134);
            this.btnDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(225, 38);
            this.btnDocGia.TabIndex = 3;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnThuThu
            // 
            this.btnThuThu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThuThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThuThu.FlatAppearance.BorderSize = 0;
            this.btnThuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuThu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThuThu.Image = global::LibraryProject.Properties.Resources.librarian;
            this.btnThuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuThu.Location = new System.Drawing.Point(-1, 179);
            this.btnThuThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThuThu.Name = "btnThuThu";
            this.btnThuThu.Size = new System.Drawing.Size(225, 38);
            this.btnThuThu.TabIndex = 4;
            this.btnThuThu.Text = "Thủ Thư";
            this.btnThuThu.UseVisualStyleBackColor = false;
            this.btnThuThu.Click += new System.EventHandler(this.btnThuThu_Click);
            // 
            // btnPhieuTra
            // 
            this.btnPhieuTra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPhieuTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhieuTra.FlatAppearance.BorderSize = 0;
            this.btnPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuTra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPhieuTra.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnPhieuTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuTra.Location = new System.Drawing.Point(-1, 89);
            this.btnPhieuTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhieuTra.Name = "btnPhieuTra";
            this.btnPhieuTra.Size = new System.Drawing.Size(225, 38);
            this.btnPhieuTra.TabIndex = 2;
            this.btnPhieuTra.Text = "Phiếu Trả";
            this.btnPhieuTra.UseVisualStyleBackColor = false;
            this.btnPhieuTra.Click += new System.EventHandler(this.btnPhieuTra_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKe.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-1, 224);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(225, 38);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(225, 38);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 687);
            this.panelMain.TabIndex = 13;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 725);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashBoard_Load);
            this.panelHead.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashboard)).EndInit();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel panelSidebar;
        private System.Windows.Forms.PictureBox pbxDashboard;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTKInfo;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnPhieuMuon;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnThuThu;
        private System.Windows.Forms.Button btnPhieuTra;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panelMain;
    }
}

