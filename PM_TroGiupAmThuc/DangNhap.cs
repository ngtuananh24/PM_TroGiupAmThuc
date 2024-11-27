using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_TroGiupAmThuc
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void link_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenmk = new QuenMK();
            quenmk.ShowDialog();
        }

        private void link_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangki dangki = new Dangki();
            dangki.ShowDialog();
        }
        Modify modify = new Modify();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tentaikhoan = tb_tendangnhap.Text;
            string matkhau = tb_pass.Text;
            if (tentaikhoan.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản");}
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }
            else
            {
                string query = "select * from login where tentaikhoan  = '" + tentaikhoan + "' and matkhau = '" + matkhau + "'";
                if (modify.Taikhoans(query).Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không chính xác!");
                }
            }

        }
    }
}
