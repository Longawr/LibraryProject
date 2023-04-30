
namespace LibraryProject
{
    partial class FormSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tBxSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBxTheLoai = new System.Windows.Forms.ComboBox();
            this.cBxNXB = new System.Windows.Forms.ComboBox();
            this.tBxTacGia = new System.Windows.Forms.TextBox();
            this.tBxTenSach = new System.Windows.Forms.TextBox();
            this.tBxMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.tBxSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBxTheLoai);
            this.groupBox1.Controls.Add(this.cBxNXB);
            this.groupBox1.Controls.Add(this.tBxTacGia);
            this.groupBox1.Controls.Add(this.tBxTenSach);
            this.groupBox1.Controls.Add(this.tBxMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(29, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(834, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(742, 150);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 32);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tBxSoLuong
            // 
            this.tBxSoLuong.Location = new System.Drawing.Point(454, 36);
            this.tBxSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBxSoLuong.Name = "tBxSoLuong";
            this.tBxSoLuong.Size = new System.Drawing.Size(56, 26);
            this.tBxSoLuong.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số lượng";
            // 
            // cBxTheLoai
            // 
            this.cBxTheLoai.FormattingEnabled = true;
            this.cBxTheLoai.Location = new System.Drawing.Point(454, 91);
            this.cBxTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxTheLoai.Name = "cBxTheLoai";
            this.cBxTheLoai.Size = new System.Drawing.Size(229, 28);
            this.cBxTheLoai.TabIndex = 24;
            // 
            // cBxNXB
            // 
            this.cBxNXB.FormattingEnabled = true;
            this.cBxNXB.Location = new System.Drawing.Point(454, 142);
            this.cBxNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxNXB.Name = "cBxNXB";
            this.cBxNXB.Size = new System.Drawing.Size(229, 28);
            this.cBxNXB.TabIndex = 23;
            // 
            // tBxTacGia
            // 
            this.tBxTacGia.Location = new System.Drawing.Point(130, 154);
            this.tBxTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBxTacGia.Name = "tBxTacGia";
            this.tBxTacGia.Size = new System.Drawing.Size(241, 26);
            this.tBxTacGia.TabIndex = 22;
            // 
            // tBxTenSach
            // 
            this.tBxTenSach.Location = new System.Drawing.Point(130, 106);
            this.tBxTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBxTenSach.Name = "tBxTenSach";
            this.tBxTenSach.Size = new System.Drawing.Size(241, 26);
            this.tBxTenSach.TabIndex = 21;
            // 
            // tBxMaSach
            // 
            this.tBxMaSach.Location = new System.Drawing.Point(130, 42);
            this.tBxMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBxMaSach.Name = "tBxMaSach";
            this.tBxMaSach.Size = new System.Drawing.Size(157, 26);
            this.tBxMaSach.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã sách";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(742, 114);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 32);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(742, 78);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(742, 42);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(742, 6);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 32);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(24, 352);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(839, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách trong kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(834, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSach";
            this.Text = "d";
            this.Load += new System.EventHandler(this.FormSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tBxSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBxTheLoai;
        private System.Windows.Forms.ComboBox cBxNXB;
        private System.Windows.Forms.TextBox tBxTacGia;
        private System.Windows.Forms.TextBox tBxTenSach;
        private System.Windows.Forms.TextBox tBxMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
    }
}