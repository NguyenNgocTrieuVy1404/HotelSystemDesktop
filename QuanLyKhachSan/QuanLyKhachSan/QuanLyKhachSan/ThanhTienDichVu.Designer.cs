namespace QuanLyKhachSan
{
    partial class ThanhTienDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBTenDichVu = new System.Windows.Forms.ComboBox();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dGVThanhTienDV = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.cBMaPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThanhTienDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thành Tiền:";
            // 
            // txtMaThanhTien
            // 
            this.txtMaThanhTien.Enabled = false;
            this.txtMaThanhTien.Location = new System.Drawing.Point(181, 150);
            this.txtMaThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThanhTien.Name = "txtMaThanhTien";
            this.txtMaThanhTien.Size = new System.Drawing.Size(288, 29);
            this.txtMaThanhTien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Dịch Vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thành Tiền:";
            // 
            // cBTenDichVu
            // 
            this.cBTenDichVu.FormattingEnabled = true;
            this.cBTenDichVu.Location = new System.Drawing.Point(181, 271);
            this.cBTenDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.cBTenDichVu.Name = "cBTenDichVu";
            this.cBTenDichVu.Size = new System.Drawing.Size(288, 28);
            this.cBTenDichVu.TabIndex = 8;
            this.cBTenDichVu.SelectedIndexChanged += new System.EventHandler(this.cBTenDichVu_SelectedIndexChanged);
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(181, 332);
            this.numericSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(160, 29);
            this.numericSoLuong.TabIndex = 9;
            this.numericSoLuong.ValueChanged += new System.EventHandler(this.numericSoLuong_ValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(181, 388);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(288, 29);
            this.txtDonGia.TabIndex = 10;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(181, 443);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(288, 29);
            this.txtThanhTien.TabIndex = 11;
            // 
            // dGVThanhTienDV
            // 
            this.dGVThanhTienDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThanhTienDV.Location = new System.Drawing.Point(516, 154);
            this.dGVThanhTienDV.Margin = new System.Windows.Forms.Padding(4);
            this.dGVThanhTienDV.Name = "dGVThanhTienDV";
            this.dGVThanhTienDV.RowHeadersWidth = 62;
            this.dGVThanhTienDV.RowTemplate.Height = 28;
            this.dGVThanhTienDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVThanhTienDV.Size = new System.Drawing.Size(664, 322);
            this.dGVThanhTienDV.TabIndex = 12;
            this.dGVThanhTienDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVThanhTienDV_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(300, 509);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(169, 47);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán DV";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Danh Sách Thành Tiền Dịch Vụ";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThanhToan.Location = new System.Drawing.Point(426, 36);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(375, 37);
            this.lblThanhToan.TabIndex = 15;
            this.lblThanhToan.Text = "THÀNH TIỀN DỊCH VỤ";
            // 
            // cBMaPhong
            // 
            this.cBMaPhong.FormattingEnabled = true;
            this.cBMaPhong.Location = new System.Drawing.Point(181, 209);
            this.cBMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cBMaPhong.Name = "cBMaPhong";
            this.cBMaPhong.Size = new System.Drawing.Size(288, 28);
            this.cBMaPhong.TabIndex = 16;
            // 
            // ThanhTienDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 582);
            this.Controls.Add(this.cBMaPhong);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dGVThanhTienDV);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.numericSoLuong);
            this.Controls.Add(this.cBTenDichVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaThanhTien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThanhTienDichVu";
            this.Text = "ThanhTienDichVu";
            this.Load += new System.EventHandler(this.ThanhTienDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThanhTienDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBTenDichVu;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridView dGVThanhTienDV;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.ComboBox cBMaPhong;
    }
}