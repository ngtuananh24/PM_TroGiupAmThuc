using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace PM_TroGiupAmThuc
{
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
        }
        public  bool checkAccount (string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmal(string em)
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void tb_dangki_Click(object sender, EventArgs e)
        {
            string tentk = tb_tentaikhoan.Text;
            string matkhau = tb_pass_dky.Text;
            string xacnhanmk = tb_xacnhanpass.Text;
            string email = tb_email.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự!");return;}
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu tài khoản dài 3-20 kí tự!");return;}
            if (xacnhanmk!=matkhau) { MessageBox.Show("Mật khẩu không trùng nhau");return;}
            if (!CheckEmal(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng gmail"); return; }
            if(modify.Taikhoans("Select * from login where email = '"+email+"'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí email khác"); return; }
            try
            {
                string query1 = "INSERT INTO login (tentk, matkhau, email) VALUES (@tentk, @matkhau, @Email)";
                modify.CommandWithParameters(query1,
                    new SqlParameter("@tentk", tentk),
                    new SqlParameter("@matkhau", matkhau),
                    new SqlParameter("@Email", email));
                modify.CommandWithParameters(query1);
                MessageBox.Show("Đăng kí thành công!");
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng thử lại!");
            }
        }
    }
}
