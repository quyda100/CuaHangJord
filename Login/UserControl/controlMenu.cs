using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
namespace Login
{
    public partial class controlMenu : UserControl
    {
        public controlMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlMenu_Load(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            TaiKhoan taiKhoan = Constant.taiKhoan;
            if(taiKhoan.LoaiTaiKhoan.Equals("Nhân viên"))
            {
                iconQuanLi.Enabled = false;
                iconThongKe.Enabled = false;
            }
            if (taiKhoan.LoaiTaiKhoan.Equals("Quản lí"))
                iconThongKe.Enabled = false;
        }

        private void iconShop_Click(object sender, EventArgs e)
        {
            frmCuaHang CuaHang = new frmCuaHang();
            CuaHang.Show();
            ParentForm.Hide();
            CuaHang.QuayLai += icon_QuaylaiCuaHang;
        }

        private void icon_QuaylaiCuaHang(object sender, EventArgs e)
        {
            (sender as frmCuaHang).isThoat = false;
            (sender as frmCuaHang).Close();
            ParentForm.Show();
        }

        private void icon_Quaylai(object sender, EventArgs e)
        {
            (sender as frmMain).isThoat = false;
            (sender as frmMain).Close();
            ParentForm.Show();
        }

        private void iconQuanLi_Click(object sender, EventArgs e)
        {
            frmQuanLi QuanLi = new frmQuanLi();
            QuanLi.Show();
            ParentForm.Hide();
            QuanLi.QuayLai += icon_QuaylaiQuanLi;
        }

        private void icon_QuaylaiQuanLi(object sender, EventArgs e)
        {
            (sender as frmQuanLi).isThoat = false;
            (sender as frmQuanLi).Close();
            ParentForm.Show();
        }

        private void iconThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
