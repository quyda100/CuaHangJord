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
namespace Login
{
    public partial class controlQuanLiHoaDon : UserControl
    {
        public controlQuanLiHoaDon()
        {
            InitializeComponent();
        }
        BAL_HoaDon xulihoadon = new BAL_HoaDon();
        //Method
        private void loadDSHoaDon()
        {
            dgvHoaDon.DataSource = xulihoadon.loadDSHoaDon();
        }
        private void TimKiem()
        {
            string text = txtSearch.Text;
            if(text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            DataTable dt = new DataTable();
            if(cboSearch.Text.Equals("Theo mã"))
            {
                dt = xulihoadon.TimKiemTheoMa(text);
            }
            else if(cboSearch.Text.Equals("Tên khách hàng"))
            {
                dt = xulihoadon.TimKiemTheoTenKH(text);
            }
            else if (cboSearch.Text.Equals("Tên nhân viên"))
            {
                dt = xulihoadon.TimKiemTheoTenNV(text);
            }
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            dgvHoaDon.DataSource = dt;
        }



        //Event
        private void controlQuanLiHoaDon_Load(object sender, EventArgs e)
        {
            loadDSHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtTongHD.Text = row.Cells[1].Value.ToString();
                dateNgayLap.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txtNhanVien.Text = row.Cells[3].Value.ToString();
                txtKhachHang.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiem();
            }
        }

        private void iconReload_Click(object sender, EventArgs e)
        {
            loadDSHoaDon();
        }

        private void iconChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frm = new frmChiTietHoaDon();
            frm.maHD = txtMaHD.Text;
            frm.ShowDialog();
        }
    }
}
