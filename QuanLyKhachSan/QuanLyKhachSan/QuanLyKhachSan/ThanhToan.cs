using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThanhToan : Form
    {
        KetNoi ketnoi = new KetNoi();
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            string qr = "select * from KhachHang JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang";
            dGVThanhToan.DataSource = ketnoi.Execute(qr);
        }
        
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhachHang.Text; 
            string maThuePhong = lblMaTP.Text;

            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string query = @"
            SELECT 
    kh.MaKhachHang,
    kh.HoTen,
    p.GiaCoBan,
    tp.SoNguoi,
    tp.NgayThue,
	p.MaPhong,
    tp.MaThuePhong,
    DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) AS SoNgay,
    (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) AS TienPhong,
    ISNULL(SUM(tt.ThanhTien), 0) AS TienDichVu,
    CASE 
        WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
        ELSE 0
    END AS PhuThu,
    CASE 
        WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
        ELSE 0
    END AS GiamGiaKhachHang,
    ((DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) 
        + ISNULL(SUM(tt.ThanhTien), 0) 
        + CASE 
            WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
            ELSE 0
          END
        - CASE 
            WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
            ELSE 0
          END) AS TongTien
    FROM 
        ThuePhong tp
    JOIN KhachHang kh ON tp.MaKhachHang = kh.MaKhachHang
    JOIN Phong p ON tp.MaPhong = p.MaPhong
    JOIN ThanhTienDichVu tt ON tp.MaPhong = tt.MaPhong
        WHERE tp.MaKhachHang =  '" + maKhachHang + "' AND tp.MaThuePhong = '" + maThuePhong + @"'
        GROUP BY
            kh.MaKhachHang, kh.HoTen, p.GiaCoBan, tp.SoNguoi, tp.NgayThue,tp.MaThuePhong,p.MaPhong, kh.MaKhachHang
    ";

            DataTable dtKetQua = ketnoi.Execute(query);

            if (dtKetQua.Rows.Count > 0)
            {
                
                dGVThanhToan.DataSource = dtKetQua;
                DataRow row = dtKetQua.Rows[0];

                // Hiển thị
                txtTongtien.Text = "" + row["TongTien"].ToString();
                lblKhach.Text = "" + row["HoTen"].ToString();
                lblMaKhach.Text = "" + row["MaKhachHang"].ToString();
                lblMaPhong.Text = "" + row["MaPhong"].ToString();
                lblSoNgayO.Text = "" + row["SoNgay"].ToString();
                lblMaTP.Text = "" + row["MaThuePhong"].ToString();
                lblNgayThanhT.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //cập nhật trạng thái phòng

                string map = lblMaPhong.Text;
                string query1 = "UPDATE Phong SET TrangThai= N'Trống' WHERE MaPhong = @MaPhong ";
                ketnoi.ResetTrangThai(query1, map);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiemTheoSDTKhachHang_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KhachHang JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang "
                         + "WHERE (KhachHang.SoDienThoai LIKE '%" + txtSDTKH.Text + "%') ";
            txtMaHoaDon.Clear();
            //AND(ThuePhong.MaThuePhong LIKE '%" + cBMaTP.Text + "%')
            DataTable dt = ketnoi.GetTimKiem(query);
            if (dt.Rows.Count > 0)
            {
                dGVThanhToan.DataSource = dt;
                int index = dGVThanhToan.CurrentRow.Index;
                txtMaKhachHang.Text = dGVThanhToan.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVThanhToan.Rows[index].Cells[1].Value.ToString();
                lblMaTP.Text = dGVThanhToan.Rows[index].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThanhToan.CurrentRow.Index;
            txtMaKhachHang.Text = dGVThanhToan.Rows[index].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dGVThanhToan.Rows[index].Cells[1].Value.ToString();
            lblMaTP.Text = dGVThanhToan.Rows[index].Cells[7].Value.ToString();
            txtSDTKH.Text = dGVThanhToan.Rows[index].Cells[5].Value.ToString();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXemDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon dsHoaDon= new DanhSachHoaDon();
            dsHoaDon.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

            string mahd = txtMaHoaDon.Text;
            string query = "SELECT *"
                           + " FROM HoaDon "
                            + "WHERE MaHoaDon = '"+mahd+"'";
            DataTable dt = ketnoi.Execute(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rpDSHoaDon baocao = new rpDSHoaDon();
            baocao.SetDataSource(dt);

            InHoaDon inhoadon = new InHoaDon();
            inhoadon.crystalReportViewer1.ReportSource = baocao;

            inhoadon.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {       
            try 
            {
                string makhachhang = txtSDTKH.Text;
                if (string.IsNullOrWhiteSpace(cBHinhThuc.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int nextId = GetNextCustomerId();
                string maHoaDon = $"HD{nextId:D3}";
                string makh = lblMaKhach.Text;
                DateTime ngaythanhtoan = DateTime.Parse(lblNgayThanhT.Text);
                string tenkhachhang = lblKhach.Text;
                string sdt = txtSDTKH.Text;
                string songayo = lblSoNgayO.Text;
                string phong = lblMaPhong.Text;
                decimal tongtien = decimal.Parse(txtTongtien.Text);
                string matp = lblMaTP.Text;
                string hinhthuc = cBHinhThuc.Text;
                string tennhanvienDN = Login.tenNhanVienDangNhap;
                string query = "INSERT INTO HoaDon(MaHoaDon,TenNhanVien,MaKhachHang,HoTen,SoDienThoai,MaThuePhong, Phong, SoNgayO, SoTien, NgayThanhToan, HinhThucThanhToan) " +
                                $"VALUES (@MaHoaDon,@TenNhanVien, @MaKhachHang,@HoTen,@SoDienThoai,@MaThuePhong, @Phong, @SoNgayO, @SoTien, @NgayThanhToan, @HinhThucThanhToan) ";

                DataTable dt = ketnoi.GetThemHoaDon(query, maHoaDon, tennhanvienDN, makh, tenkhachhang, sdt, ngaythanhtoan, matp, songayo, phong, hinhthuc, tongtien);
                txtMaHoaDon.Text = maHoaDon;

                string queryHoaDon = "SELECT * FROM HoaDon WHERE MaHoaDon = '" + maHoaDon + "'";
                DataTable dtHoaDon = ketnoi.Execute(queryHoaDon);
            }
            catch 
            {
                MessageBox.Show("Vui lòng tính tiền trước khi thêm hóa đơn");
            }
        }
        private int GetNextCustomerId()
        {
            int nextId = 1;

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon) - 2) AS INT)) FROM HoaDon";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã hoá đơn tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
