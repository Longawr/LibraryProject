
namespace LibraryProject
{
    partial class FormPhieuMuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCTPM = new System.Windows.Forms.Panel();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataMain = new System.Windows.Forms.DataGridView();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCTPM.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).BeginInit();
            this.panelFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.panelCTPM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 61);
            this.panel1.TabIndex = 0;
            // 
            // panelCTPM
            // 
            this.panelCTPM.Controls.Add(this.tbxSoLuong);
            this.panelCTPM.Controls.Add(this.btnTraSach);
            this.panelCTPM.Controls.Add(this.btnTroLai);
            this.panelCTPM.Location = new System.Drawing.Point(12, 7);
            this.panelCTPM.Name = "panelCTPM";
            this.panelCTPM.Size = new System.Drawing.Size(286, 34);
            this.panelCTPM.TabIndex = 9;
            this.panelCTPM.Visible = false;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuong.Location = new System.Drawing.Point(109, 3);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(77, 27);
            this.tbxSoLuong.TabIndex = 10;
            this.tbxSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSoLuong_KeyDown);
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.White;
            this.btnTraSach.Enabled = false;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Location = new System.Drawing.Point(202, 3);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(82, 28);
            this.btnTraSach.TabIndex = 9;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.White;
            this.btnTroLai.Enabled = false;
            this.btnTroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroLai.Location = new System.Drawing.Point(3, 3);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(82, 28);
            this.btnTroLai.TabIndex = 8;
            this.btnTroLai.Text = "Trờ lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(304, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN SÁCH";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 449);
            this.panelMain.TabIndex = 8;
            // 
            // dataMain
            // 
            this.dataMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMain.Location = new System.Drawing.Point(0, 0);
            this.dataMain.Name = "dataMain";
            this.dataMain.RowHeadersWidth = 51;
            this.dataMain.RowTemplate.Height = 24;
            this.dataMain.Size = new System.Drawing.Size(800, 449);
            this.dataMain.TabIndex = 0;
            // 
            // panelFoot
            // 
            this.panelFoot.BackColor = System.Drawing.Color.DimGray;
            this.panelFoot.Controls.Add(this.btnXemCT);
            this.panelFoot.Controls.Add(this.btnSua);
            this.panelFoot.Controls.Add(this.btnXoa);
            this.panelFoot.Controls.Add(this.btnThem);
            this.panelFoot.Controls.Add(this.tbxSearch);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 498);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(800, 52);
            this.panelFoot.TabIndex = 7;
            // 
            // btnXemCT
            // 
            this.btnXemCT.BackColor = System.Drawing.Color.White;
            this.btnXemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCT.Location = new System.Drawing.Point(403, 12);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(109, 28);
            this.btnXemCT.TabIndex = 7;
            this.btnXemCT.Text = "Xem Chi Tiết";
            this.btnXemCT.UseVisualStyleBackColor = false;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(710, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(620, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(530, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSearch.Location = new System.Drawing.Point(12, 11);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(357, 28);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.Text = " Tìm Kiếm";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(703, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 28);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFoot);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhieuMuon";
            this.Text = "FormPhieuMuon";
            this.Load += new System.EventHandler(this.FormPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCTPM.ResumeLayout(false);
            this.panelCTPM.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).EndInit();
            this.panelFoot.ResumeLayout(false);
            this.panelFoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataMain;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Panel panelCTPM;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Button btnRefresh;
    }
}