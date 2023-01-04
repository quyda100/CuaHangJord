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
    public partial class controlGioHang : UserControl
    {
        BAL_SanPham xulisanpham = new BAL_SanPham();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        BAL_HoaDon xulihoadon = new BAL_HoaDon();
        BAL_KhachHang xulikhachhang = new BAL_KhachHang();
        public controlGioHang()
        {
            InitializeComponent();
        }
        static AutoCompleteStringCollection source = new AutoCompleteStringCollection();

        private void addSource()
        {
            foreach (string s in xulikhachhang.layDSTenKhachHang()) source.Add(s);
        }
        private void controlGioHang_Load(object sender, EventArgs e)
        {
            
            loadListSP(listView1);
            txtMaHD.Text = RandomString(5);
            int Tong = tinhTien();
            lblMoney.Text = String.Format(cul, "{0:c}", Tong);

            addSource();
            txtMaKH.AutoCompleteCustomSource = source;
        }
        private void loadListSP(ListView view)
        {
            if (Constant.listSP != null)
            {
                foreach (SanPham it in Constant.listSP)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = it.ma;
                    item.SubItems.Add(it.Ten);//tensp
                    String donGia = String.Format(cul, "{0:c}", it.donGia);
                    item.SubItems.Add(donGia);//dongia
                    item.SubItems.Add(it.SoLuong.ToString());//Số lượng
                    item.SubItems.Add(xulisanpham.laySize(it.maSize));//size
                    item.SubItems.Add(xulisanpham.layTenNSX(it.maNSX));//NSX
                    view.Items.Add(item);
                }
                txtSoLuong.Text = Constant.listSP.Count.ToString();
            }
        }
        private int tinhTien()
        {
            int Tong = 0;
            if (Constant.listSP != null)
            {
                foreach (SanPham it in Constant.listSP)
                {
                    Tong += it.donGia * it.SoLuong;
                }
            }
            return Tong;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            Constant.listSP.RemoveAt(listView1.SelectedIndices[0]);
            listView1.Items.Remove(listView1.SelectedItems[0]);
            int Tong = tinhTien();
            lblMoney.Text = String.Format(cul, "{0:c}", Tong);
            txtSoLuong.Text = Constant.listSP.Count.ToString();
        }

        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Constant.listSP.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                string mahoadon = txtMaHD.Text;
                int tongtien = tinhTien();
                DateTime ngaylap = DateTime.Now;
                string manhanvien = Constant.taiKhoan.username;
                string makhachhang = null;
                if (txtMaKH.Text.Length > 0) makhachhang = xulikhachhang.layMaKhachHang(txtMaKH.Text);
                HoaDon HD = new HoaDon(mahoadon, tongtien, ngaylap, manhanvien, makhachhang);
                xulihoadon.luuHD(HD);
                foreach (SanPham it in Constant.listSP)
                {
                    xulihoadon.luuCTHD(mahoadon, it);
                    xulisanpham.updateSoLuongSP(it);
                }
                listView1.Items.Clear();
                lblMoney.Text = String.Format(cul, "{0:c}", 0);
                frmChiTietHoaDon frm = new frmChiTietHoaDon();
                frm.maHD = mahoadon;
                frm.ShowDialog();
            }
        }
    }
}
