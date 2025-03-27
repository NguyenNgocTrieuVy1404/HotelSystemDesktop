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
    public partial class ThuePhong : Form
    {
        KetNoi ketnoi = new KetNoi();   
        public ThuePhong()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            string str = "select* from ThuePhong";
            dGVThuePhong.DataSource = ketnoi.Execute(str);
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxMaKH();
            txtMaNV.Text = Login.MaNhanVienDN;
            LoadComboBoxMaPhong();
            
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            int nextId = GetNextThuePhongId();
            string matp = $"TP{nextId:D3}";
            string maKH= cBMaKH.Text;
            string tenkh = txtTenKhachHang.Text;
            string sdt = txtTimKiemSDT.Text;
            string manv = txtMaNV.Text;
            string maphong = cBMaPhongTrong.Text;
            string ngaythue = dtpNgayThue.Text;
            string songuoi = txtSoNguoi.Text;

            string query = "INSERT INTO ThuePhong (MaThuePhong, MaKhachHang, HoTen, SoDienThoai, MaPhong, MaNhanVien, NgayThue, SoNguoi) " +
               "VALUES (@MaThuePhong, @MaKhachHang, @HoTen, @SoDienThoai, @MaPhong, @MaNhanVien, @NgayThue, @SoNguoi)";
            DataTable dt = ketnoi.GetThuePhong(query, matp, maKH,tenkh,sdt, maphong, manv, ngaythue, songuoi);
            string query1 = "UPDATE Phong SET TrangThai= N'Đã Thuê' WHERE MaPhong = @MaPhong";
            ketnoi.GetTrangthai(query1, maphong);
            loaddata();
            LoadComboBoxMaPhong();
        }
        private int GetNextThuePhongId()
        {
            int nextId = 1;

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaThuePhong, 3, LEN(MaThuePhong) - 2) AS INT)) FROM ThuePhong";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã thuê phòng tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }
        private void gBThongTinDatPhong_Enter(object sender, EventArgs e)
        {

        }

        private void dGVThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThuePhong.CurrentRow.Index;
            txtMaThuePhong.Text = dGVThuePhong.Rows[index].Cells[0].Value.ToString();
            cBMaKH.Text = dGVThuePhong.Rows[index].Cells[1].Value.ToString();
            txtTenKhachHang.Text = dGVThuePhong.Rows[index].Cells[2].Value.ToString();
            txtTimKiemSDT.Text = dGVThuePhong.Rows[index].Cells[3].Value.ToString();
            cBMaPhongTrong.Text = dGVThuePhong.Rows[index].Cells[4].Value.ToString();
            txtMaNV.Text = dGVThuePhong.Rows[index].Cells[5].Value.ToString();
            dtpNgayThue.Text = dGVThuePhong.Rows[index].Cells[6].Value.ToString();
            txtSoNguoi.Text = dGVThuePhong.Rows[index].Cells[7].Value.ToString();


        }
        private void LoadComboBoxMaKH()
        {
            try
            {
                string query = "SELECT MaKhachHang FROM KhachHang "+
                                "WHERE MaKhachHang NOT IN (SELECT MaKhachHang FROM ThuePhong);";
                DataTable dt = ketnoi.Execute(query);
                
                
                if (dt.Rows.Count > 0)
                {
                    cBMaKH.DisplayMember = "MaKhachHang";
                    cBMaKH.ValueMember = "MaKhachHang";
                    cBMaKH.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    cBMaPhongTrong.DisplayMember = "MaPhong";
                    cBMaPhongTrong.ValueMember = "MaPhong";
                    cBMaPhongTrong.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void cBMaPhongTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhong = cBMaPhongTrong.Text;
            string query = "SELECT LoaiPhong FROM Phong " +
                                "WHERE MaPhong ='" + maPhong + "'";
            DataTable dt = ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtLoaiPhong.Text = dt.Rows[0].Field<string>("LoaiPhong");
            }
        }

        private void btnSuaTtin_Click(object sender, EventArgs e)
        {
            try
            {
                string matp = txtMaThuePhong.Text;
                string maphong = cBMaPhongTrong.Text;
                string songuoi = txtSoNguoi.Text;
                string query = "UPDATE ThuePhong SET MaPhong = @MaPhong,SoNguoi = @SoNguoi WHERE MaThuePhong = @MaThuePhong";

                ketnoi.GetSuaThuePhong(query, maphong,songuoi,matp);

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThanhTienDichVu ttdv = new ThanhTienDichVu();
            ttdv.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KhachHang "
                         + "WHERE KhachHang.SoDienThoai LIKE '%" + txtTimKiemSDT.Text + "%' ";

            DataTable dt = ketnoi.GetTimKiem(query);
            if (dt.Rows.Count > 0)
            {
                dGVThuePhong.DataSource = dt;
                int index = dGVThuePhong.CurrentRow.Index;
                
                cBMaKH.Text = dGVThuePhong.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVThuePhong.Rows[index].Cells[1].Value.ToString();
                txtTimKiemSDT.Text = dGVThuePhong.Rows[index].Cells[5].Value.ToString();
                
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
    }
}
