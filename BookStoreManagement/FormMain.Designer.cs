namespace BookStoreManagement
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGioiThieu,
            this.tsmDanhMuc,
            this.tsmQuanLy,
            this.tsmPhieuNhap,
            this.tsmHoaDon,
            this.tsmThongKe,
            this.tsmThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1326, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmGioiThieu
            // 
            this.tsmGioiThieu.Name = "tsmGioiThieu";
            this.tsmGioiThieu.Size = new System.Drawing.Size(108, 27);
            this.tsmGioiThieu.Text = "Giới thiệu";
            // 
            // tsmDanhMuc
            // 
            this.tsmDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNXB,
            this.tsmTacGia,
            this.tsmTheLoai});
            this.tsmDanhMuc.Name = "tsmDanhMuc";
            this.tsmDanhMuc.Size = new System.Drawing.Size(107, 27);
            this.tsmDanhMuc.Text = "Danh mục";
            // 
            // tsmNXB
            // 
            this.tsmNXB.Name = "tsmNXB";
            this.tsmNXB.Size = new System.Drawing.Size(224, 28);
            this.tsmNXB.Text = "Nhà xuất bản";
            this.tsmNXB.Click += new System.EventHandler(this.tsmNXB_Click);
            // 
            // tsmTacGia
            // 
            this.tsmTacGia.Name = "tsmTacGia";
            this.tsmTacGia.Size = new System.Drawing.Size(224, 28);
            this.tsmTacGia.Text = "Tác giả";
            this.tsmTacGia.Click += new System.EventHandler(this.tsmTacGia_Click);
            // 
            // tsmTheLoai
            // 
            this.tsmTheLoai.Name = "tsmTheLoai";
            this.tsmTheLoai.Size = new System.Drawing.Size(224, 28);
            this.tsmTheLoai.Text = "Thể loại";
            this.tsmTheLoai.Click += new System.EventHandler(this.tsmTheLoai_Click);
            // 
            // tsmQuanLy
            // 
            this.tsmQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNhanVien,
            this.tsmKhachHang,
            this.tsmSanPham});
            this.tsmQuanLy.Name = "tsmQuanLy";
            this.tsmQuanLy.Size = new System.Drawing.Size(90, 27);
            this.tsmQuanLy.Text = "Quản lý";
            // 
            // tsmNhanVien
            // 
            this.tsmNhanVien.Name = "tsmNhanVien";
            this.tsmNhanVien.Size = new System.Drawing.Size(197, 28);
            this.tsmNhanVien.Text = "Nhân viên";
            this.tsmNhanVien.Click += new System.EventHandler(this.tsmNhanVien_Click);
            // 
            // tsmKhachHang
            // 
            this.tsmKhachHang.Name = "tsmKhachHang";
            this.tsmKhachHang.Size = new System.Drawing.Size(197, 28);
            this.tsmKhachHang.Text = "Khách hàng ";
            this.tsmKhachHang.Click += new System.EventHandler(this.tsmKhachHang_Click);
            // 
            // tsmSanPham
            // 
            this.tsmSanPham.Name = "tsmSanPham";
            this.tsmSanPham.Size = new System.Drawing.Size(197, 28);
            this.tsmSanPham.Text = "Sản phẩm";
            this.tsmSanPham.Click += new System.EventHandler(this.tsmSanPham_Click);
            // 
            // tsmPhieuNhap
            // 
            this.tsmPhieuNhap.Name = "tsmPhieuNhap";
            this.tsmPhieuNhap.Size = new System.Drawing.Size(116, 27);
            this.tsmPhieuNhap.Text = "Phiếu nhập";
            this.tsmPhieuNhap.Click += new System.EventHandler(this.tsmPhieuNhap_Click);
            // 
            // tsmHoaDon
            // 
            this.tsmHoaDon.Name = "tsmHoaDon";
            this.tsmHoaDon.Size = new System.Drawing.Size(95, 27);
            this.tsmHoaDon.Text = "Hóa đơn";
            this.tsmHoaDon.Click += new System.EventHandler(this.tsmHoaDon_Click);
            // 
            // tsmThongKe
            // 
            this.tsmThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.KhachHangToolStripMenuItem});
            this.tsmThongKe.Name = "tsmThongKe";
            this.tsmThongKe.Size = new System.Drawing.Size(102, 27);
            this.tsmThongKe.Text = "Thống kê";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(317, 28);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu tháng";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(317, 28);
            this.KhachHangToolStripMenuItem.Text = "Số khách hàng trong tháng";
            // 
            // tsmThoat
            // 
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(74, 27);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsmThoat_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = global::BookStoreManagement.Properties.Resources.library_interior_interior_design_books_wallpaper_preview1;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 31);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1326, 578);
            this.panel_body.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStoreManagement.Properties.Resources.library_interior_interior_design_books_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 609);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem tsmDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmNXB;
        private System.Windows.Forms.ToolStripMenuItem tsmTacGia;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmTheLoai;
        private System.Windows.Forms.ToolStripMenuItem tsmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmHoaDon;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmThoat;
        private System.Windows.Forms.Panel panel_body;
    }
}