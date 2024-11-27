namespace PM_TroGiupAmThuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tb_tendangnhap = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.link_quenmk = new System.Windows.Forms.LinkLabel();
            this.link_dangki = new System.Windows.Forms.LinkLabel();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PM_TroGiupAmThuc.Properties.Resources.png_transparent_password_manager_computer_icons_password_strength_password_safe_chang_miscellaneous_password_strength_password_safe_thumbnail;
            this.pictureBox4.Location = new System.Drawing.Point(140, 385);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // tb_tendangnhap
            // 
            this.tb_tendangnhap.Location = new System.Drawing.Point(209, 309);
            this.tb_tendangnhap.Name = "tb_tendangnhap";
            this.tb_tendangnhap.Size = new System.Drawing.Size(266, 22);
            this.tb_tendangnhap.TabIndex = 4;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(209, 395);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(266, 22);
            this.tb_pass.TabIndex = 5;
            // 
            // link_quenmk
            // 
            this.link_quenmk.AutoSize = true;
            this.link_quenmk.Location = new System.Drawing.Point(118, 477);
            this.link_quenmk.Name = "link_quenmk";
            this.link_quenmk.Size = new System.Drawing.Size(97, 16);
            this.link_quenmk.TabIndex = 6;
            this.link_quenmk.TabStop = true;
            this.link_quenmk.Text = "Quên Mật Khẩu";
            this.link_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_quenmk_LinkClicked);
            // 
            // link_dangki
            // 
            this.link_dangki.AutoSize = true;
            this.link_dangki.Location = new System.Drawing.Point(412, 477);
            this.link_dangki.Name = "link_dangki";
            this.link_dangki.Size = new System.Drawing.Size(109, 16);
            this.link_dangki.TabIndex = 7;
            this.link_dangki.TabStop = true;
            this.link_dangki.Text = "Đăng kí tài khoản";
            this.link_dangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_dangki_LinkClicked);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.AutoSize = true;
            this.btn_dangnhap.BackColor = System.Drawing.Color.Cyan;
            this.btn_dangnhap.Location = new System.Drawing.Point(281, 519);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(85, 43);
            this.btn_dangnhap.TabIndex = 8;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 625);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.link_dangki);
            this.Controls.Add(this.link_quenmk);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_tendangnhap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập - PM Trợ Giúp Ẩm Thực";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tb_tendangnhap;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.LinkLabel link_quenmk;
        private System.Windows.Forms.LinkLabel link_dangki;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}

