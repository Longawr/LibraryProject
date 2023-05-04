
namespace LibraryProject
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelSide = new System.Windows.Forms.Panel();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.btbLogin = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.panelSide.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSide.Controls.Add(this.lblProducer);
            this.panelSide.Controls.Add(this.lblTitle);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 30);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(328, 770);
            this.panelSide.TabIndex = 0;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.ForeColor = System.Drawing.Color.White;
            this.lblProducer.Location = new System.Drawing.Point(270, 742);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(58, 19);
            this.lblProducer.TabIndex = 1;
            this.lblProducer.Text = "Nhóm X";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(57, 340);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phần Mềm\r\nQuản Lý Thư Viện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelHead.Controls.Add(this.btnClose);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1000, 30);
            this.panelHead.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(970, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.lblLogin);
            this.panelMain.Controls.Add(this.btnQuenMK);
            this.panelMain.Controls.Add(this.btbLogin);
            this.panelMain.Controls.Add(this.panelPassword);
            this.panelMain.Controls.Add(this.panelUser);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 800);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(476, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 63);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLogin.Location = new System.Drawing.Point(569, 263);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 37);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuenMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuenMK.FlatAppearance.BorderSize = 0;
            this.btnQuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMK.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.Gray;
            this.btnQuenMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuenMK.Location = new System.Drawing.Point(628, 448);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(126, 30);
            this.btnQuenMK.TabIndex = 4;
            this.btnQuenMK.Text = "Quên mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = false;
            // 
            // btbLogin
            // 
            this.btbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbLogin.FlatAppearance.BorderSize = 0;
            this.btbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbLogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btbLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbLogin.Location = new System.Drawing.Point(522, 448);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(100, 30);
            this.btbLogin.TabIndex = 3;
            this.btbLogin.Text = "Login";
            this.btbLogin.UseVisualStyleBackColor = false;
            this.btbLogin.Click += new System.EventHandler(this.btbLogin_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.Control;
            this.panelPassword.Controls.Add(this.tbxPassword);
            this.panelPassword.Controls.Add(this.pbxPassword);
            this.panelPassword.Location = new System.Drawing.Point(522, 394);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(350, 40);
            this.panelPassword.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPassword.Location = new System.Drawing.Point(54, 9);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(281, 21);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Text = " Password";
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // pbxPassword
            // 
            this.pbxPassword.Image = global::LibraryProject.Properties.Resources.padlock;
            this.pbxPassword.Location = new System.Drawing.Point(6, 5);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(30, 30);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPassword.TabIndex = 1;
            this.pbxPassword.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
            this.panelUser.Controls.Add(this.tbxUser);
            this.panelUser.Controls.Add(this.pbxUser);
            this.panelUser.Location = new System.Drawing.Point(522, 341);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(350, 40);
            this.panelUser.TabIndex = 0;
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.SystemColors.Control;
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUser.Location = new System.Drawing.Point(54, 9);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(281, 21);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = " Username";
            this.tbxUser.Enter += new System.EventHandler(this.tbxUser_Enter);
            this.tbxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUser_KeyDown);
            this.tbxUser.Leave += new System.EventHandler(this.tbxUser_Leave);
            // 
            // pbxUser
            // 
            this.pbxUser.Image = global::LibraryProject.Properties.Resources.librarian;
            this.pbxUser.Location = new System.Drawing.Point(7, 5);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(30, 30);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Button btbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}