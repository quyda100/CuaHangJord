
namespace Login
{
    partial class controlMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconCuaHang = new FontAwesome.Sharp.IconButton();
            this.iconQuanLi = new FontAwesome.Sharp.IconButton();
            this.iconThongKe = new FontAwesome.Sharp.IconButton();
            this.iconThoat = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconCuaHang
            // 
            this.iconCuaHang.BackColor = System.Drawing.Color.White;
            this.iconCuaHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCuaHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconCuaHang.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconCuaHang.IconColor = System.Drawing.Color.Black;
            this.iconCuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCuaHang.IconSize = 64;
            this.iconCuaHang.Location = new System.Drawing.Point(340, 164);
            this.iconCuaHang.Name = "iconCuaHang";
            this.iconCuaHang.Size = new System.Drawing.Size(130, 118);
            this.iconCuaHang.TabIndex = 4;
            this.iconCuaHang.Text = "Cửa hàng";
            this.iconCuaHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconCuaHang.UseVisualStyleBackColor = false;
            this.iconCuaHang.Click += new System.EventHandler(this.iconShop_Click);
            // 
            // iconQuanLi
            // 
            this.iconQuanLi.BackColor = System.Drawing.Color.White;
            this.iconQuanLi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconQuanLi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconQuanLi.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.iconQuanLi.IconColor = System.Drawing.Color.Black;
            this.iconQuanLi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconQuanLi.IconSize = 64;
            this.iconQuanLi.Location = new System.Drawing.Point(476, 164);
            this.iconQuanLi.Name = "iconQuanLi";
            this.iconQuanLi.Size = new System.Drawing.Size(130, 118);
            this.iconQuanLi.TabIndex = 5;
            this.iconQuanLi.Text = "Quản lí";
            this.iconQuanLi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconQuanLi.UseVisualStyleBackColor = false;
            this.iconQuanLi.Click += new System.EventHandler(this.iconQuanLi_Click);
            // 
            // iconThongKe
            // 
            this.iconThongKe.BackColor = System.Drawing.Color.White;
            this.iconThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconThongKe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconThongKe.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconThongKe.IconColor = System.Drawing.Color.Black;
            this.iconThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThongKe.IconSize = 64;
            this.iconThongKe.Location = new System.Drawing.Point(340, 288);
            this.iconThongKe.Name = "iconThongKe";
            this.iconThongKe.Size = new System.Drawing.Size(130, 118);
            this.iconThongKe.TabIndex = 6;
            this.iconThongKe.Text = "Thống kê";
            this.iconThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconThongKe.UseVisualStyleBackColor = false;
            this.iconThongKe.Click += new System.EventHandler(this.iconThongKe_Click);
            // 
            // iconThoat
            // 
            this.iconThoat.BackColor = System.Drawing.Color.White;
            this.iconThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconThoat.ForeColor = System.Drawing.Color.Red;
            this.iconThoat.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.iconThoat.IconColor = System.Drawing.Color.Black;
            this.iconThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThoat.IconSize = 64;
            this.iconThoat.Location = new System.Drawing.Point(476, 288);
            this.iconThoat.Name = "iconThoat";
            this.iconThoat.Size = new System.Drawing.Size(130, 118);
            this.iconThoat.TabIndex = 7;
            this.iconThoat.Text = "Thoát";
            this.iconThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconThoat.UseVisualStyleBackColor = false;
            this.iconThoat.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // controlMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.iconThoat);
            this.Controls.Add(this.iconThongKe);
            this.Controls.Add(this.iconQuanLi);
            this.Controls.Add(this.iconCuaHang);
            this.Name = "controlMenu";
            this.Size = new System.Drawing.Size(947, 570);
            this.Load += new System.EventHandler(this.controlMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconCuaHang;
        private FontAwesome.Sharp.IconButton iconQuanLi;
        private FontAwesome.Sharp.IconButton iconThongKe;
        private FontAwesome.Sharp.IconButton iconThoat;
    }
}
