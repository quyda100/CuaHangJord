using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }
        BAL_TaiKhoan xulitaikhoan = new BAL_TaiKhoan();
        //Methods
        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private bool KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            TaiKhoan tk = xulitaikhoan.KiemTraDangNhap(tendangnhap, Encrypt(matkhau));
            if (tk != null)
            {
                Constant.taiKhoan = tk;
                return true;
            }
            return false;
        }
        private void Main_DangXuat(object sender, EventArgs e)
        {
            (sender as frmMain).isThoat = false;
            (sender as frmMain).Close();
            this.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtUsername.Text, txtPassword.Text))
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Hide();
                Main.DangXuat += Main_DangXuat;
            }
            else
            MessageBox.Show("Đăng nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void switchPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
