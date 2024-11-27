namespace PM_TroGiupAmThuc
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pass_laylai = new System.Windows.Forms.Label();
            this.btn_laypass = new System.Windows.Forms.Button();
            this.tb_email_quen_mk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email đăng kí:";
            // 
            // lb_pass_laylai
            // 
            this.lb_pass_laylai.AutoSize = true;
            this.lb_pass_laylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass_laylai.Location = new System.Drawing.Point(72, 355);
            this.lb_pass_laylai.Name = "lb_pass_laylai";
            this.lb_pass_laylai.Size = new System.Drawing.Size(180, 25);
            this.lb_pass_laylai.TabIndex = 2;
            this.lb_pass_laylai.Text = "Mật khẩu cấp lại là:";
            // 
            // btn_laypass
            // 
            this.btn_laypass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_laypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laypass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_laypass.Location = new System.Drawing.Point(322, 455);
            this.btn_laypass.Name = "btn_laypass";
            this.btn_laypass.Size = new System.Drawing.Size(149, 62);
            this.btn_laypass.TabIndex = 3;
            this.btn_laypass.Text = "Lấy Lại Mật Khẩu";
            this.btn_laypass.UseVisualStyleBackColor = false;
            // 
            // tb_email_quen_mk
            // 
            this.tb_email_quen_mk.Location = new System.Drawing.Point(225, 284);
            this.tb_email_quen_mk.Name = "tb_email_quen_mk";
            this.tb_email_quen_mk.Size = new System.Drawing.Size(313, 22);
            this.tb_email_quen_mk.TabIndex = 4;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 671);
            this.Controls.Add(this.tb_email_quen_mk);
            this.Controls.Add(this.btn_laypass);
            this.Controls.Add(this.lb_pass_laylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMK";
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_pass_laylai;
        private System.Windows.Forms.Button btn_laypass;
        private System.Windows.Forms.TextBox tb_email_quen_mk;
    }
}