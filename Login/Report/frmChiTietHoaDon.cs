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
using Microsoft.Reporting.WinForms;

namespace Login
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public string maHD { get; set; }
        BAL_HoaDon xulihoadon = new BAL_HoaDon();

        private void frmChiTietHoaDon_Load_1(object sender, EventArgs e)
        {
            this.Text = maHD;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Login.Report.ChiTietHoaDon.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("ChiTietHoaDon", xulihoadon.layChiTietHoaDon(maHD));
            this.reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
