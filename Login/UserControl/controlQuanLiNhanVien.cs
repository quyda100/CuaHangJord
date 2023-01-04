using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
namespace Login
{
    public partial class controlQuanLiNhanVien : UserControl
    {
        BAL_NhanVien xulinhanvien = new BAL_NhanVien();
        BAL_ChucVu xulichucvu = new BAL_ChucVu();
        public controlQuanLiNhanVien()
        {
            InitializeComponent();
        }
        //Method
        private void loadDSNhanVien()
        {
            dgvNhanVien.DataSource = xulinhanvien.loadDSNhanVien();
        }
        private void loadDSChucVu(ComboBox cbo)
        {
            cbo.DataSource = xulichucvu.loadDSChucVu();
            cbo.DisplayMember = "TenChucVu";
            cbo.ValueMember = "MaChucVu";
        }
        private string taoma(string chucvu)
        {
            int soLuong = xulinhanvien.Count()+1;
            if (soLuong < 10)
                return chucvu + "0" + soLuong;
            return chucvu + soLuong;
        }
        public void timkiemtheochucvu()
        {
            string machucvu = cboSearchChucVu.SelectedValue.ToString();
            DataTable dt = xulinhanvien.TimKiemTheoChucVu(machucvu);
            if (dt.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = dt;
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TimKiemSanPham()
        {
            string text = txtSearch.Text;
            if (text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            DataTable dt = xulinhanvien.TimKiemTheoTen(text);
            if (dt.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = dt;
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private String CopyvaTraVeTenAnh(string file)
        {
            string Ketqua;
            Ketqua = file.Substring(file.LastIndexOf("\\") + 1);
            string filepath = "Image\\Sanpham\\" + Ketqua;
            if (!File.Exists("Image\\Sanpham\\" + Ketqua))
                File.Copy(file, filepath);
            return Ketqua;

        }

        //Event
        private void controlQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            loadDSNhanVien();
            loadDSChucVu(cboChucVu);
            loadDSChucVu(cboSearchChucVu);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                dateNgaySinh.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                string gioiTinh = row.Cells[3].Value.ToString();
                if (gioiTinh.Equals("Nữ")) radNu.Checked = true;
                else radNam.Checked = true;
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                dateNgayVaoLam.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                cboChucVu.Text = row.Cells[7].Value.ToString();
                string hinhAnh = row.Cells[8].Value.ToString();
                if (hinhAnh.Equals(""))
                    picNhanVien.Image = Image.FromFile(@"Image\Nhanvien\Default.png");
                else
                {
                    picNhanVien.Image = Image.FromFile(@"Image\Nhanvien\" + txtHinhAnh.Text);
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenNV.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            string machucvu = cboChucVu.SelectedValue.ToString();
            int sodienthoai = int.Parse(txtSDT.Text);
            string hinhAnh = txtHinhAnh.Text;
            string ma = taoma(machucvu);
            NhanVien nv = new NhanVien(ma, ten, ngaysinh, gioiTinh, diachi, sodienthoai, hinhAnh, machucvu);
            if(xulinhanvien.themNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSNhanVien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTenNV.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            string machucvu = cboChucVu.SelectedValue.ToString();
            int sodienthoai = int.Parse(txtSDT.Text);
            string hinhAnh = null;
            if (txtHinhAnh.Text.Length > 0) hinhAnh = txtHinhAnh.Text;
            string ma = txtMaNV.Text;
            NhanVien nv = new NhanVien(ma, ten, ngaysinh, gioiTinh, diachi, sodienthoai, hinhAnh, machucvu);
            if (xulinhanvien.capnhatNhanVien(nv))
            {
                MessageBox.Show("Cập nhật nhân viên có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel) return;
            string ten = txtTenNV.Text;
            DateTime ngaysinh = dateNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            string diachi = txtDiaChi.Text;
            string machucvu = cboChucVu.SelectedValue.ToString();
            int sodienthoai = int.Parse(txtSDT.Text);
            string hinhAnh = txtHinhAnh.Text;
            string ma = txtMaNV.Text;
            NhanVien nv = new NhanVien(ma, ten, ngaysinh, gioiTinh, diachi, sodienthoai, hinhAnh, machucvu);
            if (xulinhanvien.xoaNhanVien(nv))
            {
                MessageBox.Show("Xóa nhân viên có mã: " + ma + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSNhanVien();
        }

        private void cboSearchChucVu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            timkiemtheochucvu();
        }

        private void iconReload_Click(object sender, EventArgs e)
        {
            loadDSNhanVien();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSanPham();
            }
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn hình ảnh của sản phẩm";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Filter = "JPG Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string filename = dialog.FileName;
                picNhanVien.Image = Image.FromFile(filename);
                txtHinhAnh.Text = CopyvaTraVeTenAnh(filename);
            }
        }
    }
}
