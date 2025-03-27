namespace QuanLyKhachSan
{
    partial class Main
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
            this.dsDanhSachHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.dsThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dsThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dsDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dsQuanLyPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dsDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.dsThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.dsQuanLiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.dsThongTinKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.dsHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.dsThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.dsDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.dsHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mHeThong = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửDụngDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsDanhSachHoaDon
            // 
            this.dsDanhSachHoaDon.BackColor = System.Drawing.Color.Cornsilk;
            this.dsDanhSachHoaDon.Name = "dsDanhSachHoaDon";
            this.dsDanhSachHoaDon.Size = new System.Drawing.Size(294, 34);
            this.dsDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            this.dsDanhSachHoaDon.Click += new System.EventHandler(this.dsDanhSachHoaDon_Click);
            // 
            // dsThongKe
            // 
            this.dsThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsDanhSachHoaDon,
            this.doanhThuToolStripMenuItem});
            this.dsThongKe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsThongKe.Name = "dsThongKe";
            this.dsThongKe.Size = new System.Drawing.Size(120, 29);
            this.dsThongKe.Text = "Thống Kê ";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.dsDoanhThu_Click);
            // 
            // dsPhong
            // 
            this.dsPhong.Name = "dsPhong";
            this.dsPhong.Size = new System.Drawing.Size(271, 34);
            this.dsPhong.Text = "Phòng";
            this.dsPhong.Click += new System.EventHandler(this.dsPhong_Click);
            // 
            // dsThuePhong
            // 
            this.dsThuePhong.Name = "dsThuePhong";
            this.dsThuePhong.Size = new System.Drawing.Size(271, 34);
            this.dsThuePhong.Text = "Thuê Phòng";
            this.dsThuePhong.Click += new System.EventHandler(this.dsThuePhong_Click);
            // 
            // dsDatPhong
            // 
            this.dsDatPhong.Name = "dsDatPhong";
            this.dsDatPhong.Size = new System.Drawing.Size(271, 34);
            this.dsDatPhong.Text = "Đặt Phòng";
            this.dsDatPhong.Click += new System.EventHandler(this.dsDatPhong_Click);
            // 
            // dsQuanLyPhong
            // 
            this.dsQuanLyPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsDatPhong,
            this.dsThuePhong,
            this.dsPhong,
            this.dsDichVu,
            this.sửDụngDịchVụToolStripMenuItem});
            this.dsQuanLyPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsQuanLyPhong.Name = "dsQuanLyPhong";
            this.dsQuanLyPhong.Size = new System.Drawing.Size(163, 29);
            this.dsQuanLyPhong.Text = "Quản Lý Phòng";
            // 
            // dsDichVu
            // 
            this.dsDichVu.Name = "dsDichVu";
            this.dsDichVu.Size = new System.Drawing.Size(271, 34);
            this.dsDichVu.Text = "Dịch Vụ";
            this.dsDichVu.Click += new System.EventHandler(this.dsDichVu_Click);
            // 
            // dsThanhToan
            // 
            this.dsThanhToan.Name = "dsThanhToan";
            this.dsThanhToan.Size = new System.Drawing.Size(316, 34);
            this.dsThanhToan.Text = "Thanh Toán";
            this.dsThanhToan.Click += new System.EventHandler(this.dsThanhToan_Click);
            // 
            // dsQuanLiKhachHang
            // 
            this.dsQuanLiKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsThongTinKhachHang,
            this.dsThanhToan,
            this.dsHoaDon});
            this.dsQuanLiKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsQuanLiKhachHang.Name = "dsQuanLiKhachHang";
            this.dsQuanLiKhachHang.Size = new System.Drawing.Size(216, 29);
            this.dsQuanLiKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // dsThongTinKhachHang
            // 
            this.dsThongTinKhachHang.Name = "dsThongTinKhachHang";
            this.dsThongTinKhachHang.Size = new System.Drawing.Size(316, 34);
            this.dsThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            this.dsThongTinKhachHang.Click += new System.EventHandler(this.dsThongTinKhachHang_Click);
            // 
            // dsHoaDon
            // 
            this.dsHoaDon.Name = "dsHoaDon";
            this.dsHoaDon.Size = new System.Drawing.Size(316, 34);
            this.dsHoaDon.Text = "Hóa Đơn";
            this.dsHoaDon.Click += new System.EventHandler(this.dsHoaDon_Click);
            // 
            // dsThoat
            // 
            this.dsThoat.Name = "dsThoat";
            this.dsThoat.Size = new System.Drawing.Size(246, 34);
            this.dsThoat.Text = "Thoát";
            this.dsThoat.Click += new System.EventHandler(this.dsThoat_Click);
            // 
            // dsDangXuat
            // 
            this.dsDangXuat.Name = "dsDangXuat";
            this.dsDangXuat.Size = new System.Drawing.Size(246, 34);
            this.dsDangXuat.Text = "Đăng Xuất";
            this.dsDangXuat.Click += new System.EventHandler(this.dsDangXuat_Click);
            // 
            // dsDoiMatKhau
            // 
            this.dsDoiMatKhau.Name = "dsDoiMatKhau";
            this.dsDoiMatKhau.Size = new System.Drawing.Size(246, 34);
            this.dsDoiMatKhau.Text = "Đổi Mật Khẩu ";
            this.dsDoiMatKhau.Click += new System.EventHandler(this.dsDoiMatKhau_Click);
            // 
            // dsHeThong
            // 
            this.dsHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dsHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsDoiMatKhau,
            this.dsDangXuat,
            this.dsThoat});
            this.dsHeThong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsHeThong.Name = "dsHeThong";
            this.dsHeThong.Size = new System.Drawing.Size(114, 29);
            this.dsHeThong.Text = "Hệ Thống";
            // 
            // mHeThong
            // 
            this.mHeThong.BackColor = System.Drawing.Color.Azure;
            this.mHeThong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHeThong.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mHeThong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsHeThong,
            this.dsQuanLiKhachHang,
            this.dsQuanLyPhong,
            this.dsThongKe,
            this.quảnLýNhânSựToolStripMenuItem});
            this.mHeThong.Location = new System.Drawing.Point(0, 0);
            this.mHeThong.Name = "mHeThong";
            this.mHeThong.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mHeThong.Size = new System.Drawing.Size(970, 33);
            this.mHeThong.TabIndex = 3;
            this.mHeThong.Text = "menuStrip2";
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanVienToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.quảnLýNhânSựToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản Lý Nhân Sự";
            this.quảnLýNhânSựToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânSựToolStripMenuItem_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.NhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.dsNhanVien_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.dsQuanLyTaiKhoan_Click);
            // 
            // sửDụngDịchVụToolStripMenuItem
            // 
            this.sửDụngDịchVụToolStripMenuItem.Name = "sửDụngDịchVụToolStripMenuItem";
            this.sửDụngDịchVụToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.sửDụngDịchVụToolStripMenuItem.Text = "Sử Dụng Dịch Vụ";
            this.sửDụngDịchVụToolStripMenuItem.Click += new System.EventHandler(this.sửDụngDịchVụToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.z5614726130801_df85a66200cddd54009ab6f9062c283f;
            this.ClientSize = new System.Drawing.Size(970, 541);
            this.Controls.Add(this.mHeThong);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mHeThong.ResumeLayout(false);
            this.mHeThong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dsDanhSachHoaDon;
        private System.Windows.Forms.ToolStripMenuItem dsThongKe;
        private System.Windows.Forms.ToolStripMenuItem dsPhong;
        private System.Windows.Forms.ToolStripMenuItem dsThuePhong;
        private System.Windows.Forms.ToolStripMenuItem dsDatPhong;
        private System.Windows.Forms.ToolStripMenuItem dsQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem dsThanhToan;
        private System.Windows.Forms.ToolStripMenuItem dsQuanLiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem dsThongTinKhachHang;
        private System.Windows.Forms.ToolStripMenuItem dsThoat;
        private System.Windows.Forms.ToolStripMenuItem dsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem dsDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem dsHeThong;
        private System.Windows.Forms.MenuStrip mHeThong;
        private System.Windows.Forms.ToolStripMenuItem dsDichVu;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsHoaDon;
        private System.Windows.Forms.ToolStripMenuItem sửDụngDịchVụToolStripMenuItem;
    }
}

