namespace QuanLyKhachSan
{
    partial class QuanLyPhong
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
            this.lblDanhSachPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cBLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.dGVDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.cBTrangThai = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhSachPhong
            // 
            this.lblDanhSachPhong.AutoSize = true;
            this.lblDanhSachPhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachPhong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDanhSachPhong.Location = new System.Drawing.Point(314, 9);
            this.lblDanhSachPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachPhong.Name = "lblDanhSachPhong";
            this.lblDanhSachPhong.Size = new System.Drawing.Size(283, 31);
            this.lblDanhSachPhong.TabIndex = 0;
            this.lblDanhSachPhong.Text = "DANH SÁCH PHÒNG";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(25, 76);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(72, 17);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(25, 133);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(78, 17);
            this.lblLoaiPhong.TabIndex = 2;
            this.lblLoaiPhong.Text = "Loại Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(147, 73);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(205, 24);
            this.txtMaPhong.TabIndex = 3;
            // 
            // cBLoaiPhong
            // 
            this.cBLoaiPhong.FormattingEnabled = true;
            this.cBLoaiPhong.Location = new System.Drawing.Point(147, 130);
            this.cBLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cBLoaiPhong.Name = "cBLoaiPhong";
            this.cBLoaiPhong.Size = new System.Drawing.Size(205, 24);
            this.cBLoaiPhong.TabIndex = 4;
            this.cBLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cBLoaiPhong_SelectedIndexChanged);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(26, 191);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(31, 17);
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Giá:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(26, 236);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(72, 17);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSua.Location = new System.Drawing.Point(93, 344);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 46);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dGVDanhSachPhong
            // 
            this.dGVDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhong.Location = new System.Drawing.Point(360, 73);
            this.dGVDanhSachPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dGVDanhSachPhong.Name = "dGVDanhSachPhong";
            this.dGVDanhSachPhong.RowHeadersWidth = 51;
            this.dGVDanhSachPhong.RowTemplate.Height = 24;
            this.dGVDanhSachPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSachPhong.Size = new System.Drawing.Size(472, 432);
            this.dGVDanhSachPhong.TabIndex = 12;
            this.dGVDanhSachPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachPhong_CellContentClick);
            // 
            // cBTrangThai
            // 
            this.cBTrangThai.FormattingEnabled = true;
            this.cBTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã Thuê",
            "Đang Sửa"});
            this.cBTrangThai.Location = new System.Drawing.Point(147, 233);
            this.cBTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cBTrangThai.Name = "cBTrangThai";
            this.cBTrangThai.Size = new System.Drawing.Size(205, 24);
            this.cBTrangThai.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(147, 188);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(205, 24);
            this.txtGia.TabIndex = 14;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 531);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cBTrangThai);
            this.Controls.Add(this.dGVDanhSachPhong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.cBLoaiPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblDanhSachPhong);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyPhong";
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.QuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cBLoaiPhong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dGVDanhSachPhong;
        private System.Windows.Forms.ComboBox cBTrangThai;
        private System.Windows.Forms.TextBox txtGia;
    }
}