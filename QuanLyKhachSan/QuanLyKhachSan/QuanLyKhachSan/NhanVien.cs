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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string qr = "select * from NhanVien";
            dGVNhanVien.DataSource = ketnoi.Execute(qr);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtHoTen.Text;
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string gioiTinh = cBGioiTinh.SelectedItem?.ToString();
                string diaChi = txtDiaChi.Text;
                string chucVu = cBChucVu.Text;
                decimal luong = decimal.Parse(txtLuong.Text);
                string sdt = txtSDT.Text;
                string id = txtID.Text;

                // Kiểm tra dữ liệu đầu vào, đảm bảo rằng tất cả các trường đều không trống
                if (string.IsNullOrWhiteSpace(hoTen) ||
                    string.IsNullOrEmpty(ngaySinh) ||
                    string.IsNullOrWhiteSpace(gioiTinh) ||
                    string.IsNullOrWhiteSpace(diaChi) ||
                    string.IsNullOrWhiteSpace(chucVu) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(luong.ToString()) ||
                    string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nextId = GetNextCustomerId();
                string maNhanVien = $"NV{nextId:D2}";

                string query = "INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, ChucVu, Luong, SoDienThoai, Id) " +
                       "VALUES (@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @ChucVu, @Luong, @SoDienThoai, @Id)";


                ketnoi.GetNhanVien(query, maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, chucVu, luong, sdt, id);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int GetNextCustomerId()
        {
            int nextId = 1;

            try
            {
                string queryMaxId = "SELECT MAX(CASE WHEN ISNUMERIC(SUBSTRING(MaNhanVien, 3, LEN(MaNhanVien) - 2)) = 1 " +
                    "             THEN CAST(SUBSTRING(MaNhanVien, 3, LEN(MaNhanVien) - 2) AS INT) " +
                    "                ELSE NULL " +
                    "     END) AS MaxMaNhanVien " +
                    "FROM NhanVien";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã nhân viên tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = '" + txtMaNhanVien.Text + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Dữ liệu đã được xóa thành công.");
            }
            else
            {
                MessageBox.Show("Dữ liệu không được xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = txtMaNhanVien.Text;
                string hoTen = txtHoTen.Text;
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string gioiTinh = cBGioiTinh.Text;
                string diaChi = txtDiaChi.Text;
                string chucVu = cBChucVu.Text;
                decimal luong = decimal.Parse(txtLuong.Text);
                string sdt = txtSDT.Text;
                string id = txtID.Text;

                string query = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                    "DiaChi = @DiaChi, ChucVu = @ChucVu, Luong = @Luong, SoDienThoai = @SoDienThoai, Id = @Id" +
                    " WHERE MaNhanVien = @MaNhanVien";

                ketnoi.GetSuaNhanVien(query, maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, chucVu, luong, sdt, id);

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dGVNhanVien.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dGVNhanVien.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dGVNhanVien.Rows[index].Cells[2].Value.ToString();
            cBGioiTinh.Text = dGVNhanVien.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dGVNhanVien.Rows[index].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dGVNhanVien.Rows[index].Cells[5].Value.ToString();
            cBChucVu.Text = dGVNhanVien.Rows[index].Cells[6].Value.ToString();
            txtLuong.Text = dGVNhanVien.Rows[index].Cells[7].Value.ToString();
            txtID.Text = dGVNhanVien.Rows[index].Cells[8].Value.ToString();
        }
    }
}
