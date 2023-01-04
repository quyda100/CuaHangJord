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
    public partial class controlQuanLiKhachHang : UserControl
    {
        public controlQuanLiKhachHang()
        {
            InitializeComponent();
        }
        BAL_KhachHang xulikhachhang = new BAL_KhachHang();


        //Method
        private void loadDSKhachHang(DataGridView dgv)
        {
            dgv.DataSource = xulikhachhang.loadDSKhachHang();
        }
        private void loadDSLoaiKhachHang(ComboBox cbo)
        {
            cbo.DataSource = xulikhachhang.loadDSLoaiKhachHang();
            cbo.DisplayMember = "TenLoai";
        }
        private string taoma(string loai)
        {
            int soLuong = xulikhachhang.Count() + 1;
            if (soLuong < 10)
                return loai + "0" + soLuong;
            return loai + soLuong;
        }
        //Event

        private void controlQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            loadDSKhachHang(dgvKhachHang);
            loadDSLoaiKhachHang(cboKhachHang);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            int sodienthoai = int.Parse(txtSDT.Text);
            string loaikh = xulikhachhang.layMaKhachHang(cboKhachHang.Text);
            string ma = taoma(loaikh);
            KhachHang kh = new KhachHang(ma, ten, gioiTinh, diachi, sodienthoai, loaikh);
            if(xulikhachhang.themKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSKhachHang(dgvKhachHang);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            int sodienthoai = int.Parse(txtSDT.Text);
            string loaikh = xulikhachhang.layMaKhachHang(cboKhachHang.Text);
            string ma = taoma(loaikh);
            KhachHang kh = new KhachHang(ma, ten, gioiTinh, diachi, sodienthoai, loaikh);
            if (xulikhachhang.capnhatKhachHang(kh))
            {
                MessageBox.Show("Cập nhật khách hàng có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSKhachHang(dgvKhachHang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            int sodienthoai = int.Parse(txtSDT.Text);
            string loaikh = xulikhachhang.layMaKhachHang(cboKhachHang.Text);
            string ma = taoma(loaikh);
            KhachHang kh = new KhachHang(ma, ten, gioiTinh, diachi, sodienthoai, loaikh);
            if (xulikhachhang.xoaKhachHang(kh))
            {
                MessageBox.Show("Xóa khách hàng có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSKhachHang(dgvKhachHang);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                string gioiTinh = row.Cells[2].Value.ToString();
                if (gioiTinh.Equals("Nữ")) radNu.Checked = true;
                else radNam.Checked = true;
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                cboKhachHang.Text = row.Cells[5].Value.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
