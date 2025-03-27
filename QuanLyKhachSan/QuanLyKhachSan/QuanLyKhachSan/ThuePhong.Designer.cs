namespace QuanLyKhachSan
{
    partial class ThuePhong
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
            this.dGVThuePhong = new System.Windows.Forms.DataGridView();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.txtMaThuePhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaThuePhong = new System.Windows.Forms.Label();
            this.gBThongTinDatPhong = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBMaPhongTrong = new System.Windows.Forms.ComboBox();
            this.cBMaKH = new System.Windows.Forms.ComboBox();
            this.btnSuaTtin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThuePhong)).BeginInit();
            this.gBThongTinDatPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVThuePhong
            // 
            this.dGVThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThuePhong.Location = new System.Drawing.Point(9, 345);
            this.dGVThuePhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVThuePhong.Name = "dGVThuePhong";
            this.dGVThuePhong.RowHeadersWidth = 51;
            this.dGVThuePhong.RowTemplate.Height = 24;
            this.dGVThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVThuePhong.Size = new System.Drawing.Size(711, 137);
            this.dGVThuePhong.TabIndex = 4;
            this.dGVThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVThuePhong_CellContentClick);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiPhong.Location = new System.Drawing.Point(356, 140);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(78, 17);
            this.lblLoaiPhong.TabIndex = 24;
            this.lblLoaiPhong.Text = "Loại Phòng:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblMaNhanVien.Location = new System.Drawing.Point(35, 144);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(98, 17);
            this.lblMaNhanVien.TabIndex = 16;
            this.lblMaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThuePhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuePhong.ForeColor = System.Drawing.Color.Black;
            this.btnThuePhong.Location = new System.Drawing.Point(230, 235);
            this.btnThuePhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(89, 24);
            this.btnThuePhong.TabIndex = 15;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(438, 44);
            this.dtpNgayThue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(116, 24);
            this.dtpNgayThue.TabIndex = 10;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDen.Location = new System.Drawing.Point(357, 47);
            this.lblNgayDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(77, 17);
            this.lblNgayDen.TabIndex = 9;
            this.lblNgayDen.Text = "Ngày Thuê:";
            // 
            // txtMaThuePhong
            // 
            this.txtMaThuePhong.Enabled = false;
            this.txtMaThuePhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuePhong.Location = new System.Drawing.Point(136, 49);
            this.txtMaThuePhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaThuePhong.Multiline = true;
            this.txtMaThuePhong.Name = "txtMaThuePhong";
            this.txtMaThuePhong.Size = new System.Drawing.Size(146, 19);
            this.txtMaThuePhong.TabIndex = 4;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhong.Location = new System.Drawing.Point(363, 113);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(72, 17);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhachHang.Location = new System.Drawing.Point(24, 83);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(110, 17);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblMaThuePhong
            // 
            this.lblMaThuePhong.AutoSize = true;
            this.lblMaThuePhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuePhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaThuePhong.Location = new System.Drawing.Point(26, 49);
            this.lblMaThuePhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaThuePhong.Name = "lblMaThuePhong";
            this.lblMaThuePhong.Size = new System.Drawing.Size(106, 17);
            this.lblMaThuePhong.TabIndex = 0;
            this.lblMaThuePhong.Text = "Mã Thuê Phòng:";
            // 
            // gBThongTinDatPhong
            // 
            this.gBThongTinDatPhong.Controls.Add(this.label5);
            this.gBThongTinDatPhong.Controls.Add(this.btnReset);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaNV);
            this.gBThongTinDatPhong.Controls.Add(this.txtTenKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.label4);
            this.gBThongTinDatPhong.Controls.Add(this.btnTimKiem);
            this.gBThongTinDatPhong.Controls.Add(this.txtTimKiemSDT);
            this.gBThongTinDatPhong.Controls.Add(this.label3);
            this.gBThongTinDatPhong.Controls.Add(this.button1);
            this.gBThongTinDatPhong.Controls.Add(this.txtLoaiPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtSoNguoi);
            this.gBThongTinDatPhong.Controls.Add(this.label2);
            this.gBThongTinDatPhong.Controls.Add(this.cBMaPhongTrong);
            this.gBThongTinDatPhong.Controls.Add(this.cBMaKH);
            this.gBThongTinDatPhong.Controls.Add(this.btnSuaTtin);
            this.gBThongTinDatPhong.Controls.Add(this.lblLoaiPhong);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaNhanVien);
            this.gBThongTinDatPhong.Controls.Add(this.btnThuePhong);
            this.gBThongTinDatPhong.Controls.Add(this.dtpNgayThue);
            this.gBThongTinDatPhong.Controls.Add(this.lblNgayDen);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaThuePhong);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaPhong);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaThuePhong);
            this.gBThongTinDatPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTinDatPhong.ForeColor = System.Drawing.Color.Navy;
            this.gBThongTinDatPhong.Location = new System.Drawing.Point(44, 39);
            this.gBThongTinDatPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBThongTinDatPhong.Name = "gBThongTinDatPhong";
            this.gBThongTinDatPhong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBThongTinDatPhong.Size = new System.Drawing.Size(636, 275);
            this.gBThongTinDatPhong.TabIndex = 3;
            this.gBThongTinDatPhong.TabStop = false;
            this.gBThongTinDatPhong.Enter += new System.EventHandler(this.gBThongTinDatPhong_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(182, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "THÔNG TIN THUÊ PHÒNG";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(504, 233);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 28);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(136, 144);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(146, 18);
            this.txtMaNV.TabIndex = 38;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(136, 114);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(146, 19);
            this.txtTenKhachHang.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(438, 180);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 36);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemSDT
            // 
            this.txtTimKiemSDT.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSDT.Location = new System.Drawing.Point(278, 184);
            this.txtTimKiemSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiemSDT.Multiline = true;
            this.txtTimKiemSDT.Name = "txtTimKiemSDT";
            this.txtTimKiemSDT.Size = new System.Drawing.Size(116, 26);
            this.txtTimKiemSDT.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(62, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tìm Kiếm Theo SDT Khách Hàng:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(59, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "Sử Dụng Dịch Vụ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(438, 140);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoaiPhong.Multiline = true;
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(146, 24);
            this.txtLoaiPhong.TabIndex = 31;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.Location = new System.Drawing.Point(438, 81);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNguoi.Multiline = true;
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(146, 18);
            this.txtSoNguoi.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(367, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số Người:";
            // 
            // cBMaPhongTrong
            // 
            this.cBMaPhongTrong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaPhongTrong.FormattingEnabled = true;
            this.cBMaPhongTrong.Location = new System.Drawing.Point(438, 109);
            this.cBMaPhongTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBMaPhongTrong.Name = "cBMaPhongTrong";
            this.cBMaPhongTrong.Size = new System.Drawing.Size(146, 24);
            this.cBMaPhongTrong.TabIndex = 28;
            this.cBMaPhongTrong.SelectedIndexChanged += new System.EventHandler(this.cBMaPhongTrong_SelectedIndexChanged);
            // 
            // cBMaKH
            // 
            this.cBMaKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaKH.FormattingEnabled = true;
            this.cBMaKH.Location = new System.Drawing.Point(136, 78);
            this.cBMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBMaKH.Name = "cBMaKH";
            this.cBMaKH.Size = new System.Drawing.Size(146, 24);
            this.cBMaKH.TabIndex = 27;
            // 
            // btnSuaTtin
            // 
            this.btnSuaTtin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaTtin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTtin.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTtin.Location = new System.Drawing.Point(362, 235);
            this.btnSuaTtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaTtin.Name = "btnSuaTtin";
            this.btnSuaTtin.Size = new System.Drawing.Size(94, 24);
            this.btnSuaTtin.TabIndex = 25;
            this.btnSuaTtin.Text = "Sửa thông tin";
            this.btnSuaTtin.UseVisualStyleBackColor = true;
            this.btnSuaTtin.Click += new System.EventHandler(this.btnSuaTtin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thông Tin Khách Thuê Phòng:";
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(727, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVThuePhong);
            this.Controls.Add(this.gBThongTinDatPhong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThuePhong";
            this.Text = "ThuePhong";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVThuePhong)).EndInit();
            this.gBThongTinDatPhong.ResumeLayout(false);
            this.gBThongTinDatPhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVThuePhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.TextBox txtMaThuePhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaThuePhong;
        private System.Windows.Forms.GroupBox gBThongTinDatPhong;
        private System.Windows.Forms.ComboBox cBMaKH;
        private System.Windows.Forms.Button btnSuaTtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBMaPhongTrong;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
    }
}