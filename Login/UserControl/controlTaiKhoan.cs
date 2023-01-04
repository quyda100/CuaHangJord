using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
namespace Login
{
    public partial class controlTaiKhoan : UserControl
    {
        public controlTaiKhoan()
        {
            InitializeComponent();
        }
        BAL_NhanVien xulinhanvien = new BAL_NhanVien();
        BAL_ChucVu xulichucvu = new BAL_ChucVu();
        //Method
        private void LoadThongTin()
        {
            DataRow row = xulinhanvien.GetNhanVien(Constant.taiKhoan.username);
            txtMa.Text = row["MaNV"].ToString();
            txtTen.Text = row["TenNV"].ToString();
            if (row["GioiTinh"].ToString().Equals("Nữ"))
                radNu.Checked = true;
            else radNam.Checked = true;
            
            dateNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
            txtDiaChi.Text = row["DiaChi"].ToString();
            txtDienThoai.Text = row["SDT"].ToString();
            txtChucVu.Text = row["TenChucVu"].ToString();
            dateNgayVaoLam.Value = DateTime.Parse(row["NgayVaoLam"].ToString());
            string hinhAnh = row["HinhAnh"].ToString();
            txtHinhAnh.Text = hinhAnh;
            if (hinhAnh.Equals(""))
                picHinhAnh.Image = Image.FromFile(@"Image\Nhanvien\Default.png");
            else
            {
                picHinhAnh.Image = Image.FromFile(@"Image\Nhanvien\" + txtHinhAnh.Text);
            }
        }

        
        //Event
        private void controlTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            string machucvu = xulichucvu.layMaChucVu(txtChucVu.Text);
            int sodienthoai = int.Parse(txtDienThoai.Text);
            string hinhAnh = null;
            if (txtHinhAnh.Text.Length > 0) hinhAnh = txtHinhAnh.Text;
            NhanVien nv = new NhanVien(txtMa.Text, ten, ngaysinh, gioiTinh, diachi, sodienthoai, hinhAnh, machucvu);
            if (xulinhanvien.capnhatNhanVien(nv))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadThongTin();
        }
    }
}
