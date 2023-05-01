
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.pbxSach = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataMain = new System.Windows.Forms.DataGridView();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSach)).BeginInit();
            this.panelFoot.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Gray;
            this.panelHead.Controls.Add(this.pbxSach);
            this.panelHead.Controls.Add(this.labelTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(800, 57);
            this.panelHead.TabIndex = 0;
            // 
            // pbxSach
            // 
            this.pbxSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSach.BackgroundImage")));
            this.pbxSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxSach.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxSach.InitialImage")));
            this.pbxSach.Location = new System.Drawing.Point(0, 0);
            this.pbxSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxSach.Name = "pbxSach";
            this.pbxSach.Size = new System.Drawing.Size(89, 57);
            this.pbxSach.TabIndex = 4;
            this.pbxSach.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Location = new System.Drawing.Point(94, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(103, 40);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "SÁCH";
            // 
            // panelFoot
            // 
            this.panelFoot.BackColor = System.Drawing.Color.DimGray;
            this.panelFoot.Controls.Add(this.btnSua);
            this.panelFoot.Controls.Add(this.btnXoa);
            this.panelFoot.Controls.Add(this.btnTim);
            this.panelFoot.Controls.Add(this.btnThem);
            this.panelFoot.Controls.Add(this.tbxSearch);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 500);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(800, 50);
            this.panelFoot.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(710, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 25);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(620, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 25);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(440, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 25);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(530, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 25);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSearch.Location = new System.Drawing.Point(12, 11);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(411, 28);
            this.tbxSearch.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 57);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 443);
            this.panelMain.TabIndex = 4;
            // 
            // dataMain
            // 
            this.dataMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMain.Location = new System.Drawing.Point(0, 0);
            this.dataMain.Name = "dataMain";
            this.dataMain.RowHeadersWidth = 51;
            this.dataMain.RowTemplate.Height = 24;
            this.dataMain.Size = new System.Drawing.Size(800, 443);
            this.dataMain.TabIndex = 0;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFoot);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSach";
            this.Text = "d";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSach)).EndInit();
            this.panelFoot.ResumeLayout(false);
            this.panelFoot.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox pbxSach;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataMain;
    }
}