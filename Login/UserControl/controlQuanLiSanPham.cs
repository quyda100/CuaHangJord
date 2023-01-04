using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BAL;
using BEL;

namespace Login
{
    public partial class controlQuanLiSanPham : UserControl
    {
        public controlQuanLiSanPham()
        {
            InitializeComponent();
        }
        BAL_SanPham xulisanpham = new BAL_SanPham();
        //Method
        private void loadSanPham(DataGridView dgv)
        {
            dgv.DataSource = xulisanpham.loadAllSanPham();
        }
        private void loadSize(ComboBox cbo)
        {
            cbo.DataSource = xulisanpham.loadSize();
            cbo.DisplayMember = "Size";
            cbo.ValueMember = "MaSize";
        }
        private void loadNSX(ComboBox cbo)
        {
            cbo.DataSource = xulisanpham.loadNhaSanXuat();
            cbo.DisplayMember = "TenNSX";
            cbo.ValueMember = "MaNSX";
        }
        private String TaoMa(string maNSX)
        {
            int index = xulisanpham.Count() + 1;
            if (index < 10)
                return maNSX + "0" + index.ToString();
            else
                return maNSX + index.ToString();
        }
        private void TimKiemSanPhamTheoSize()
        {
            DataTable dt;
            string maSize = cboSearchSize.SelectedValue.ToString();
            dt = xulisanpham.loadSanPhamTheoSizedgv(maSize);
            if (dt.Rows.Count > 0)
            {
                dgvSanPham.DataSource = dt;
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TimKiemSanPhamTheoNSX()
        {
            DataTable dt;
            string maNSX = cboSearchNSX.SelectedValue.ToString();
            dt = xulisanpham.loadSanPhamTheoNSXdgv(maNSX);
            if (dt.Rows.Count > 0)
            {
                dgvSanPham.DataSource = dt;
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private String CopyvaTraVeTenAnh(string file)
        {
            string Ketqua;
            Ketqua = file.Substring(file.LastIndexOf("\\")+1);
            string filepath = "Image\\Sanpham\\" + Ketqua;
            if (!File.Exists("Image\\Sanpham\\" + Ketqua))
                File.Copy(file, filepath);
            return Ketqua;

        }
        //Event
        private void controlQuanLiSanPham_Load(object sender, EventArgs e)
        {
            loadSanPham(dgvSanPham);
            loadSize(cboSize);
            loadNSX(cboNSX);
            loadSize(cboSearchSize);
            loadNSX(cboSearchNSX);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                numSoLuong.Value = int.Parse(row.Cells[3].Value.ToString());
                txtHinhAnh.Text = row.Cells[4].Value.ToString();
                cboSize.Text = row.Cells[5].Value.ToString();
                cboNSX.Text = row.Cells[6].Value.ToString();
                if (!txtHinhAnh.Text.Equals(""))
                    picSanPham.Image = Image.FromFile(@"Image\Sanpham\" + txtHinhAnh.Text);
                else
                {
                    picSanPham.Image = Image.FromFile(@"Image\Sanpham\Default.png");
                }
            }
            catch
            {
                throw;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenSP.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(numSoLuong.Text);
            string hinhanh = txtHinhAnh.Text;
            string masize = cboSize.SelectedValue.ToString();
            string manhasanxuat = cboNSX.SelectedValue.ToString();
            string ma = TaoMa(manhasanxuat);

            SanPham sp = new SanPham(ma, ten, dongia, soluong, masize, manhasanxuat,hinhanh);
            if (xulisanpham.themSanPham(sp))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPham(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadSanPham(dgvSanPham);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTenSP.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(numSoLuong.Text);
            string hinhanh = txtHinhAnh.Text;
            string masize = cboSize.SelectedValue.ToString();
            string manhasanxuat = cboNSX.SelectedValue.ToString();
            string ma = txtMaSP.Text;

            SanPham sp = new SanPham(ma, ten, dongia, soluong, masize, manhasanxuat, hinhanh);
            if (xulisanpham.capnhatSanPham(sp))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPham(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadSanPham(dgvSanPham);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string ten = txtTenSP.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(numSoLuong.Text);
            string hinhanh = null;
            if (txtHinhAnh.Text.Length > 0) hinhanh = txtHinhAnh.Text;
            string masize = cboSize.SelectedValue.ToString();
            string manhasanxuat = cboNSX.SelectedValue.ToString();
            string ma = txtMaSP.Text;

            SanPham sp = new SanPham(ma, ten, dongia, soluong, masize, manhasanxuat, hinhanh);
            if (result == DialogResult.Cancel) return;
            if (xulisanpham.xoaSanPham(sp))
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSanPham(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadSanPham(dgvSanPham);
        }

        private void cboSearchSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimKiemSanPhamTheoSize();
        }

        private void cboSearchNSX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimKiemSanPhamTheoNSX();
        }

        private void iconReload_Click(object sender, EventArgs e)
        {
            loadSanPham(dgvSanPham);
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
                picSanPham.Image = Image.FromFile(filename);
                txtHinhAnh.Text = CopyvaTraVeTenAnh(filename);
            }
        }
    }
}
