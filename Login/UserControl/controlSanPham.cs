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
using BAL;
using System.Globalization;

namespace Login
{
    public partial class controlSanPham : UserControl
    {
        BAL_SanPham xulisanpham = new BAL_SanPham();
        public controlSanPham()
        {
            InitializeComponent();
        }
        //Method
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");


        private void loadSP(DataTable dt, ListView view)
        {
            ImageList list = new ImageList();
            list.ImageSize = new Size(90, 90);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dt.Rows[i][1].ToString();
                item.SubItems.Add(dt.Rows[i][0].ToString());//masp
                item.SubItems.Add(dt.Rows[i][1].ToString());//tensp
                item.SubItems.Add(dt.Rows[i][2].ToString());//dongia
                item.SubItems.Add(xulisanpham.laySize(dt.Rows[i][5].ToString()));//size
                item.SubItems.Add(xulisanpham.layTenNSX(dt.Rows[i][6].ToString()));//hang
                item.SubItems.Add(dt.Rows[i][3].ToString());//Ton kho

                list.Images.Add(Image.FromFile(@"Image\Sanpham\" + dt.Rows[i][4]));
                item.ImageIndex = i;
                view.Items.Add(item);
            }
            view.LargeImageList = list;
        }
        private void TimKiemSanPham()
        {
            string text = txtSearch.Text;
            DataTable dt;
            if (text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            dt = xulisanpham.loadSanPhamByName(text);
            if (dt.Rows.Count > 0)
            {
                listView1.Clear();
                loadSP(dt, listView1);
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TimKiemSanPhamTheoSize()
        {
            DataTable dt;
            string maSize = cboSize.SelectedValue.ToString();
            dt = xulisanpham.loadSanPhamBySize(maSize);
            if (dt.Rows.Count > 0)
            {
                listView1.Clear();
                loadSP(dt, listView1);
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TimKiemSanPhamTheoNSX()
        {
            DataTable dt;
            string maNSX = cboNhaSanXuat.SelectedValue.ToString();
            dt = xulisanpham.loadSanPhamByNSX(maNSX);
            if (dt.Rows.Count > 0)
            {
                listView1.Clear();
                loadSP(dt, listView1);
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void loadDSSize(ComboBox cbo)
        {
            cbo.DataSource = xulisanpham.loadSize();
            cbo.DisplayMember = "Size";
            cbo.ValueMember = "MaSize";
        }
        private void loadDSNhaSanXuat(ComboBox cbo)
        {
            cbo.DataSource = xulisanpham.loadNhaSanXuat();
            cbo.DisplayMember = "TenNSX";
            cbo.ValueMember = "MaNSX";
        }




        //Event
        private void controlMuaHang_Load(object sender, EventArgs e)
        {
            loadSP(BAL_SanPham.layDSSanPham(), listView1);
            loadDSSize(cboSize);
            loadDSNhaSanXuat(cboNhaSanXuat);
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem SelectedItem = listView1.SelectedItems[0];
            txtMaSP.Text = SelectedItem.SubItems[1].Text;
            txtTenSP.Text = SelectedItem.SubItems[2].Text;
            txtDonGia.Text = SelectedItem.SubItems[3].Text;
            txtSize.Text = SelectedItem.SubItems[4].Text;
            txtNhaSanXuat.Text = SelectedItem.SubItems[5].Text;
            txtSoLuong.Text = SelectedItem.SubItems[6].Text;
            numSoLuong.Maximum = int.Parse(SelectedItem.SubItems[6].Text);
            if (int.Parse(SelectedItem.SubItems[6].Text) == 0)
            {
                lblTinhTrang.ForeColor = Color.Red;
                lblTinhTrang.Text = "Hết hàng";
                btnAddCart.Enabled = false;
            }
            else
            {
                lblTinhTrang.ForeColor = Color.Lime;
                lblTinhTrang.Text = "Còn hàng";
                btnAddCart.Enabled = true;
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            String ten = txtTenSP.Text;
            String maSize = xulisanpham.layMaSize(txtSize.Text);
            String maNSX = xulisanpham.layMaNSX(txtNhaSanXuat.Text);
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = (int)numSoLuong.Value;
            if(ten.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (SanPham sp in Constant.listSP)
            {
                if(sp.ma == ma)
                {
                    sp.SoLuong += soLuong;
                    return;
                }
            }
            Constant.listSP.Add(new SanPham(ma, ten, donGia, soLuong, maSize, maNSX));
        }
        

        private void iconCancel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            loadSP(BAL_SanPham.layDSSanPham(), listView1);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSanPham();
            }
        }

        private void cboSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimKiemSanPhamTheoSize();
        }

        private void cboNhaSanXuat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimKiemSanPhamTheoNSX();
        }
    }
}
