namespace QuanLyKhachSan
{
    partial class DatPhong
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
            this.dGVDatPhong = new System.Windows.Forms.DataGridView();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaDatPhong = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaDatPhong = new System.Windows.Forms.Label();
            this.gBThongTinDatPhong = new System.Windows.Forms.GroupBox();
            this.LBLTTDP = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cBMaPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatPhong)).BeginInit();
            this.gBThongTinDatPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVDatPhong
            // 
            this.dGVDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDatPhong.Location = new System.Drawing.Point(35, 501);
            this.dGVDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVDatPhong.Name = "dGVDatPhong";
            this.dGVDatPhong.RowHeadersWidth = 51;
            this.dGVDatPhong.RowTemplate.Height = 24;
            this.dGVDatPhong.Size = new System.Drawing.Size(849, 194);
            this.dGVDatPhong.TabIndex = 3;
            this.dGVDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDatPhong_CellClick);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(326, 363);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(158, 49);
            this.btnDatPhong.TabIndex = 15;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(613, 106);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(172, 24);
            this.dtpNgayDi.TabIndex = 12;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDi.Location = new System.Drawing.Point(524, 114);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(57, 16);
            this.lblNgayDi.TabIndex = 11;
            this.lblNgayDi.Text = "Ngày Đi:";
            this.lblNgayDi.Click += new System.EventHandler(this.lblNgayDi_Click);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(613, 48);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(172, 24);
            this.dtpNgayDen.TabIndex = 10;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDen.Location = new System.Drawing.Point(517, 52);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(64, 16);
            this.lblNgayDen.TabIndex = 9;
            this.lblNgayDen.Text = "Ngày đến:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Enabled = false;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(178, 102);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(217, 33);
            this.txtMaKhachHang.TabIndex = 5;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Enabled = false;
            this.txtMaDatPhong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDatPhong.Location = new System.Drawing.Point(178, 51);
            this.txtMaDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDatPhong.Multiline = true;
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.Size = new System.Drawing.Size(217, 32);
            this.txtMaDatPhong.TabIndex = 4;
            this.txtMaDatPhong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblMaNhanVien.Location = new System.Drawing.Point(491, 172);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(90, 16);
            this.lblMaNhanVien.TabIndex = 3;
            this.lblMaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhong.Location = new System.Drawing.Point(63, 227);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(72, 17);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhachHang.Location = new System.Drawing.Point(34, 112);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(101, 16);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblMaDatPhong
            // 
            this.lblMaDatPhong.AutoSize = true;
            this.lblMaDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDatPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaDatPhong.Location = new System.Drawing.Point(37, 51);
            this.lblMaDatPhong.Name = "lblMaDatPhong";
            this.lblMaDatPhong.Size = new System.Drawing.Size(98, 17);
            this.lblMaDatPhong.TabIndex = 0;
            this.lblMaDatPhong.Text = "Mã Đặt Phòng:";
            // 
            // gBThongTinDatPhong
            // 
            this.gBThongTinDatPhong.Controls.Add(this.LBLTTDP);
            this.gBThongTinDatPhong.Controls.Add(this.btnReset);
            this.gBThongTinDatPhong.Controls.Add(this.btnTimKiem);
            this.gBThongTinDatPhong.Controls.Add(this.txtTimKiemSDT);
            this.gBThongTinDatPhong.Controls.Add(this.label3);
            this.gBThongTinDatPhong.Controls.Add(this.txtTenKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.label1);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaNV);
            this.gBThongTinDatPhong.Controls.Add(this.cBMaPhong);
            this.gBThongTinDatPhong.Controls.Add(this.btnDatPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaDatPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.dtpNgayDi);
            this.gBThongTinDatPhong.Controls.Add(this.lblNgayDi);
            this.gBThongTinDatPhong.Controls.Add(this.dtpNgayDen);
            this.gBThongTinDatPhong.Controls.Add(this.lblNgayDen);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaNhanVien);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaPhong);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaDatPhong);
            this.gBThongTinDatPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTinDatPhong.ForeColor = System.Drawing.Color.Navy;
            this.gBThongTinDatPhong.Location = new System.Drawing.Point(35, 56);
            this.gBThongTinDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBThongTinDatPhong.Name = "gBThongTinDatPhong";
            this.gBThongTinDatPhong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBThongTinDatPhong.Size = new System.Drawing.Size(849, 436);
            this.gBThongTinDatPhong.TabIndex = 2;
            this.gBThongTinDatPhong.TabStop = false;
            this.gBThongTinDatPhong.Enter += new System.EventHandler(this.gBThongTinDatPhong_Enter);
            // 
            // LBLTTDP
            // 
            this.LBLTTDP.AutoSize = true;
            this.LBLTTDP.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTTDP.ForeColor = System.Drawing.Color.Navy;
            this.LBLTTDP.Location = new System.Drawing.Point(267, 0);
            this.LBLTTDP.Name = "LBLTTDP";
            this.LBLTTDP.Size = new System.Drawing.Size(279, 25);
            this.LBLTTDP.TabIndex = 41;
            this.LBLTTDP.Text = "THÔNG TIN ĐẶT PHÒNG";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(613, 346);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 44);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(613, 291);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 46);
            this.btnTimKiem.TabIndex = 38;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemSDT
            // 
            this.txtTimKiemSDT.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSDT.Location = new System.Drawing.Point(295, 305);
            this.txtTimKiemSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemSDT.Multiline = true;
            this.txtTimKiemSDT.Name = "txtTimKiemSDT";
            this.txtTimKiemSDT.Size = new System.Drawing.Size(223, 29);
            this.txtTimKiemSDT.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tìm Kiếm Theo SDT Khách Hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(178, 164);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(217, 31);
            this.txtTenKhachHang.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(613, 164);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(208, 31);
            this.txtMaNV.TabIndex = 17;
            // 
            // cBMaPhong
            // 
            this.cBMaPhong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaPhong.FormattingEnabled = true;
            this.cBMaPhong.Location = new System.Drawing.Point(178, 224);
            this.cBMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBMaPhong.Name = "cBMaPhong";
            this.cBMaPhong.Size = new System.Drawing.Size(217, 25);
            this.cBMaPhong.TabIndex = 16;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(908, 701);
            this.Controls.Add(this.dGVDatPhong);
            this.Controls.Add(this.gBThongTinDatPhong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatPhong";
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatPhong)).EndInit();
            this.gBThongTinDatPhong.ResumeLayout(false);
            this.gBThongTinDatPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDatPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaDatPhong;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaDatPhong;
        private System.Windows.Forms.GroupBox gBThongTinDatPhong;
        private System.Windows.Forms.ComboBox cBMaPhong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label LBLTTDP;
    }
}