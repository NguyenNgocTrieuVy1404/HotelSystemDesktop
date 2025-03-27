using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DatPhong : Form
    {
        KetNoi ketnoi = new KetNoi();
        public DatPhong()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string str = "select * from DatPhong";
            dGVDatPhong.DataSource = ketnoi.Execute(str);
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxMaPhong();
            txtMaNV.Text = Login.MaNhanVienDN;
        }
        private void LoadComboBoxMaPhong()
        {
            try
            {
                string query = "SELECT MaPhong FROM Phong " +
                                "WHERE TrangThai = N'Trống';";
                DataTable dt = ketnoi.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    cBMaPhong.DisplayMember = "MaPhong"; // Hiển thị mã phòng
                    cBMaPhong.ValueMember = "MaPhong"; // Lưu trữ mã phòng
                    cBMaPhong.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            
            try
            {

                string maKhachHang = txtMaKhachHang.Text;
                string maPhong = cBMaPhong.Text;
                string tenkhach = txtTenKhachHang.Text;
                string sdt = txtTimKiemSDT.Text;
                string maNhanVien = txtMaNV.Text;
                string ngayDen = dtpNgayDen.Text;
                string ngayDi = dtpNgayDi.Text;

                // Kiểm tra dữ liệu đầu vào, đảm bảo rằng tất cả các trường đều không trống
                if (
                    string.IsNullOrWhiteSpace(maPhong) ||
                    string.IsNullOrEmpty(maKhachHang) ||
                    string.IsNullOrWhiteSpace(maNhanVien)||
                    string.IsNullOrWhiteSpace(ngayDi) ||
                    string.IsNullOrWhiteSpace(ngayDen)|| string.IsNullOrWhiteSpace(tenkhach)|| string.IsNullOrWhiteSpace(sdt))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int nextId = GetNextCustomerId();
                string maDatPhong = $"DP{nextId:D3}";

                string query = "INSERT INTO DatPhong (MaDatPhong,MaKhachHang,HoTen,SoDienThoai, MaPhong,MaNhanVien, NgayDen, NgayDi) " +
                            "VALUES (@MaDatPhong, @MaKhachHang,@HoTen,@SoDienThoai, @MaPhong , @MaNhanVien, @NgayDen, @NgayDi)";
                ketnoi.GetDatPhong(query, maDatPhong, maKhachHang,tenkhach,sdt, maPhong, maNhanVien, ngayDen, ngayDi);
                loaddata();
                string map = cBMaPhong.Text;
                string query1 = "UPDATE Phong SET TrangThai= N'Đã Đặt' WHERE MaPhong = @MaPhong ";
                ketnoi.ResetTrangThai(query1, map);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int GetNextCustomerId()
        {
            int nextId = 1; // Mặc định bắt đầu từ 1 nếu không có bản ghi nào trong cơ sở dữ liệu

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaDatPhong, 3, LEN(MaDatPhong) - 2) AS INT)) FROM DatPhong";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã đặt phòng tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }

        private void gBThongTinDatPhong_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KhachHang "
                         + "WHERE KhachHang.SoDienThoai LIKE '%" + txtTimKiemSDT.Text + "%' ";

            DataTable dt = ketnoi.GetTimKiem(query);
            if (dt.Rows.Count > 0)
            {
                dGVDatPhong.DataSource = dt;
                int index = dGVDatPhong.CurrentRow.Index;

                txtMaKhachHang.Text = dGVDatPhong.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVDatPhong.Rows[index].Cells[1].Value.ToString();
                txtTimKiemSDT.Text = dGVDatPhong.Rows[index].Cells[5].Value.ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void lblNgayDi_Click(object sender, EventArgs e)
        {

        }
    }
}
