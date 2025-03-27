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
    public partial class ThanhTienDichVu : Form
    {

        public ThanhTienDichVu()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string qr = "select * from ThanhTienDichVu";
            dGVThanhTienDV.DataSource = ketnoi.Execute(qr);
        }
        private void ThanhTienDichVu_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxDichVu();
            LoadComboBoxMaPhong();
        }

        private void dGVThanhTienDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThanhTienDV.CurrentRow.Index;
            txtMaThanhTien.Text = dGVThanhTienDV.Rows[index].Cells[0].Value.ToString();
            cBMaPhong.Text = dGVThanhTienDV.Rows[index].Cells[1].Value.ToString();
            cBTenDichVu.Text = dGVThanhTienDV.Rows[index].Cells[2].Value.ToString();
            numericSoLuong.Text = dGVThanhTienDV.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dGVThanhTienDV.Rows[index].Cells[4].Value.ToString();
            txtThanhTien.Text = dGVThanhTienDV.Rows[index].Cells[5].Value.ToString();

        }
        private void LoadComboBoxDichVu()
        {
            try
            {

                string query = "SELECT TenDichVu FROM DichVu ";
                DataTable dt = ketnoi.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    cBTenDichVu.DisplayMember = "TenDichVu";
                    cBTenDichVu.ValueMember = "TenDichVu";
                    cBTenDichVu.DataSource = dt;
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
        private void cBTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tendichvu = cBTenDichVu.Text;
            string query = "SELECT ChiPhi FROM DichVu " +
                                "WHERE TenDichVu =N'" + tendichvu + "'";
            DataTable dt = ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtDonGia.Text = dt.Rows[0]["ChiPhi"].ToString();
            }
        }
        private void LoadComboBoxMaPhong()
        {
            try
            {

                string query = "SELECT ThuePhong.MaPhong FROM ThuePhong JOIN Phong ON ThuePhong.MaPhong= Phong.MaPhong " +
                               " WHERE TrangThai=N'Đã thuê' " +
                                "GROUP BY ThuePhong.MaPhong";
                DataTable dt = ketnoi.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    cBMaPhong.DisplayMember = "MaPhong";
                    cBMaPhong.ValueMember = "MaPhong";
                    cBMaPhong.DataSource = dt;
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

        private int GetNextCustomerId1()
        {
            int nextId = 1; // Mặc định bắt đầu từ 1 nếu không có bản ghi nào trong cơ sở dữ liệu

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaThanhTien, 3, LEN(MaThanhTien) - 2) AS INT)) FROM ThanhTienDichVu";
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int nextId = GetNextCustomerId1();
                string mathanhtien = $"TT{nextId:D3}";
                string maphong = cBMaPhong.Text;
                string tendichvu = cBTenDichVu.Text;
                string soluong = numericSoLuong.Text;
                decimal dongia = decimal.Parse(txtDonGia.Text);
                decimal thanhtien = decimal.Parse(txtThanhTien.Text);
                string query = "INSERT INTO ThanhTienDichVu " +
                   "(MaThanhTien, MaPhong, TenDichVu, SoLuong, DonGia, ThanhTien) " +
                   "VALUES (@MaThanhTien, @MaPhong, @TenDichVu, @SoLuong, @DonGia, @ThanhTien)";
                DataTable dt = ketnoi.GetTTDichVu(query, mathanhtien, maphong, tendichvu, soluong, dongia, thanhtien);
                loaddata();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void numericSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal donGia = decimal.Parse(txtDonGia.Text);
            decimal soLuong = numericSoLuong.Value;
            decimal thanhTien = donGia * soLuong;
            txtThanhTien.Text = thanhTien.ToString();
        }
    }
}
