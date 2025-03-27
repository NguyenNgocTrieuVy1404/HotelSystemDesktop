using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string qr = "select * from KhachHang";
            dGVThongTinKhachHang.DataSource = ketnoi.Execute(qr);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void dGVThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThongTinKhachHang.CurrentRow.Index;
            txtMaKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[1].Value.ToString();
            cBGioiTinh.Text = dGVThongTinKhachHang.Rows[index].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dGVThongTinKhachHang.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dGVThongTinKhachHang.Rows[index].Cells[4].Value.ToString();
            txtSoDienThoai.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
            txtCMND.Text = dGVThongTinKhachHang.Rows[index].Cells[6].Value.ToString();
            txtTimKiemSDT.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtTenKhachHang.Text;
                string phai = cBGioiTinh.SelectedItem?.ToString();
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string cmND = txtCMND.Text;

                if (string.IsNullOrWhiteSpace(hoTen) ||
                    string.IsNullOrWhiteSpace(phai) ||
                    string.IsNullOrWhiteSpace(diaChi) ||
                    string.IsNullOrWhiteSpace(soDienThoai) ||
                    string.IsNullOrWhiteSpace(cmND))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nextId = GetNextCustomerId();
                string maKhachHang = $"KH{nextId:D3}"; 

                string query = "INSERT INTO KhachHang (MaKhachHang, HoTen, Phai, NgaySinh, DiaChi, SoDienThoai, CMND_Passport) " +
                               "VALUES (@MaKhachHang, @HoTen, @Phai, @NgaySinh, @DiaChi, @SoDienThoai, @CMND_Passport)";

                ketnoi.GetThem(query, maKhachHang, hoTen, phai, ngaySinh, diaChi, soDienThoai, cmND);

                loaddata();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetNextCustomerId()
        {
            int nextId = 1; 

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaKhachHang, 3, LEN(MaKhachHang) - 2) AS INT)) FROM KhachHang";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã khách hàng tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {          
                string query = "DELETE FROM KhachHang WHERE MaKhachHang = '" + txtMaKhachHang.Text + "'";
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
                string maKhachHang = txtMaKhachHang.Text.Trim();
                string hoTen = txtTenKhachHang.Text.Trim();
                string phai = cBGioiTinh.SelectedItem?.ToString();
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string diaChi = txtDiaChi.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();
                string cmND = txtCMND.Text.Trim();

                // Kiểm tra các trường có hợp lệ không
                if (string.IsNullOrEmpty(maKhachHang) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(phai))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE KhachHang SET HoTen = @HoTen, Phai = @Phai, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, CMND_Passport = @CMND_Passport WHERE MaKhachHang = @MaKhachHang";

                ketnoi.GetSuaKhachHang(query, maKhachHang, hoTen, phai, ngaySinh, diaChi, soDienThoai, cmND);

                loaddata();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi SQL: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {  
            
            string query = "SELECT * FROM KhachHang WHERE (SoDienThoai LIKE '%" + txtTimKiemSDT.Text + "%')";
            DataTable dt = ketnoi.GetTimKiem(query);

            if (dt.Rows.Count > 0)
            {
                dGVThongTinKhachHang.DataSource = dt;
                int index = dGVThongTinKhachHang.CurrentRow.Index;
                txtMaKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[1].Value.ToString();
                cBGioiTinh.Text = dGVThongTinKhachHang.Rows[index].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dGVThongTinKhachHang.Rows[index].Cells[3].Value.ToString();
                txtDiaChi.Text = dGVThongTinKhachHang.Rows[index].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
                txtCMND.Text = dGVThongTinKhachHang.Rows[index].Cells[6].Value.ToString();
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

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            ThuePhong fmTT = new ThuePhong();
            fmTT.ShowDialog();
        }
    }
}
