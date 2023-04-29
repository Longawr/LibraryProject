
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnPhieuMuon = new System.Windows.Forms.Button();
            this.btnThuThu = new System.Windows.Forms.Button();
            this.btnPhieuTra = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.DimGray;
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Controls.Add(this.btnCaiDat);
            this.panelSide.Controls.Add(this.btnSach);
            this.panelSide.Controls.Add(this.btnThongKe);
            this.panelSide.Controls.Add(this.btnPhieuMuon);
            this.panelSide.Controls.Add(this.btnThuThu);
            this.panelSide.Controls.Add(this.btnPhieuTra);
            this.panelSide.Controls.Add(this.btnDocGia);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 30);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 570);
            this.panelSide.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(51, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.DimGray;
            this.btnCaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::LibraryProject.Properties.Resources.settings;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 369);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(200, 30);
            this.btnCaiDat.TabIndex = 6;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
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
            this.btnSach.Location = new System.Drawing.Point(0, 153);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(200, 30);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DimGray;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 333);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 30);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.BackColor = System.Drawing.Color.DimGray;
            this.btnPhieuMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btnPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuMuon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnPhieuMuon.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuMuon.Location = new System.Drawing.Point(0, 189);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(200, 30);
            this.btnPhieuMuon.TabIndex = 1;
            this.btnPhieuMuon.Text = "Phiếu Mượn";
            this.btnPhieuMuon.UseVisualStyleBackColor = false;
            this.btnPhieuMuon.Click += new System.EventHandler(this.btnPhieuMuon_Click);
            // 
            // btnThuThu
            // 
            this.btnThuThu.BackColor = System.Drawing.Color.DimGray;
            this.btnThuThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThuThu.FlatAppearance.BorderSize = 0;
            this.btnThuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuThu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuThu.ForeColor = System.Drawing.Color.White;
            this.btnThuThu.Image = global::LibraryProject.Properties.Resources.librarian;
            this.btnThuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuThu.Location = new System.Drawing.Point(0, 297);
            this.btnThuThu.Name = "btnThuThu";
            this.btnThuThu.Size = new System.Drawing.Size(200, 30);
            this.btnThuThu.TabIndex = 4;
            this.btnThuThu.Text = "Thủ Thư";
            this.btnThuThu.UseVisualStyleBackColor = false;
            this.btnThuThu.Click += new System.EventHandler(this.btnThuThu_Click);
            // 
            // btnPhieuTra
            // 
            this.btnPhieuTra.BackColor = System.Drawing.Color.DimGray;
            this.btnPhieuTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhieuTra.FlatAppearance.BorderSize = 0;
            this.btnPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuTra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnPhieuTra.Image = global::LibraryProject.Properties.Resources.open_book__1_;
            this.btnPhieuTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuTra.Location = new System.Drawing.Point(0, 225);
            this.btnPhieuTra.Name = "btnPhieuTra";
            this.btnPhieuTra.Size = new System.Drawing.Size(200, 30);
            this.btnPhieuTra.TabIndex = 2;
            this.btnPhieuTra.Text = "Phiếu Trả";
            this.btnPhieuTra.UseVisualStyleBackColor = false;
            this.btnPhieuTra.Click += new System.EventHandler(this.btnPhieuTra_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.DimGray;
            this.btnDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.Image = global::LibraryProject.Properties.Resources.user;
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.Location = new System.Drawing.Point(0, 261);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(200, 30);
            this.btnDocGia.TabIndex = 3;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Gray;
            this.panelHead.Controls.Add(this.btnClose);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1300, 30);
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
            this.btnClose.Location = new System.Drawing.Point(1270, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1100, 570);
            this.panelMain.TabIndex = 2;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashBoard";
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnThuThu;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnPhieuTra;
        private System.Windows.Forms.Button btnPhieuMuon;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}

