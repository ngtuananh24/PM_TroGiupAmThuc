namespace PM_TroGiupAmThuc
{
    partial class Dangki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangki));
            this.tb_tentaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pass_dky = new System.Windows.Forms.TextBox();
            this.tb_xacnhanpass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_dangki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tentaikhoan
            // 
            this.tb_tentaikhoan.Location = new System.Drawing.Point(262, 298);
            this.tb_tentaikhoan.Name = "tb_tentaikhoan";
            this.tb_tentaikhoan.Size = new System.Drawing.Size(354, 22);
            this.tb_tentaikhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tb_pass_dky
            // 
            this.tb_pass_dky.Location = new System.Drawing.Point(262, 337);
            this.tb_pass_dky.Name = "tb_pass_dky";
            this.tb_pass_dky.Size = new System.Drawing.Size(354, 22);
            this.tb_pass_dky.TabIndex = 6;
            // 
            // tb_xacnhanpass
            // 
            this.tb_xacnhanpass.Location = new System.Drawing.Point(262, 382);
            this.tb_xacnhanpass.Name = "tb_xacnhanpass";
            this.tb_xacnhanpass.Size = new System.Drawing.Size(354, 22);
            this.tb_xacnhanpass.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(262, 417);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(354, 22);
            this.tb_email.TabIndex = 8;
            // 
            // tb_dangki
            // 
            this.tb_dangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dangki.Location = new System.Drawing.Point(381, 469);
            this.tb_dangki.Name = "tb_dangki";
            this.tb_dangki.Size = new System.Drawing.Size(125, 53);
            this.tb_dangki.TabIndex = 9;
            this.tb_dangki.Text = "Đăng Kí";
            this.tb_dangki.UseVisualStyleBackColor = false;
            this.tb_dangki.Click += new System.EventHandler(this.tb_dangki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(925, 669);
            this.Controls.Add(this.tb_dangki);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_xacnhanpass);
            this.Controls.Add(this.tb_pass_dky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangki";
            this.Text = "Đăng Kí Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_tentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pass_dky;
        private System.Windows.Forms.TextBox tb_xacnhanpass;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button tb_dangki;
    }
}