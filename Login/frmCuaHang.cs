using BEL;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login
{
    public partial class frmCuaHang : Form
    {
        public bool isThoat = true;
        private TaiKhoan taiKhoan;
        private IconButton currentButton;
        private Panel leftBorderButton;

        public event EventHandler QuayLai;
        public frmCuaHang()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 88, 155);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }
        //Methods

        private void ActiveButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.IconColor = color;
                iconCurrentChild.IconChar = currentButton.IconChar;
                lblTitle.Text = currentButton.Text;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
            }
        }
        private void PhanQuyen()
        {
            taiKhoan = Constant.taiKhoan;
        }
        private void addUserControl(UserControl control)
        {
            if (panelContainer != null)
            {
                panelContainer.Controls.Clear();
            }
            control.BorderStyle = BorderStyle.None;
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }
        //Events

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            controlSanPham menu = new controlSanPham();
            addUserControl(menu);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            controlGioHang uc = new controlGioHang();
            addUserControl(uc);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            controlSanPham uc = new controlSanPham();
            addUserControl(uc);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            controlCaiDat uc = new controlCaiDat();
            addUserControl(uc);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            QuayLai(this, new EventArgs());
            Constant.listSP = null;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
