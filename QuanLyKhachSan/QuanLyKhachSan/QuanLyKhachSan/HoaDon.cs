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
    public partial class HoaDon : Form
    {
        KetNoi ketnoi = new KetNoi();
        public HoaDon()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string qr = "select * from HoaDon ";
            dGVHoaDon.DataSource = ketnoi.Execute(qr);
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHoaDon.Text;
            string query = "SELECT *"
                           + " FROM HoaDon "
                            + "WHERE MaHoaDon = '" + mahd + "'";
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon "
                         + "WHERE HoaDon.SoDienThoai LIKE '%" + txtSDT.Text + "%' ";
            
            DataTable dt = ketnoi.GetTimKiem(query);
            if (dt.Rows.Count > 0)
            {
                dGVHoaDon.DataSource = dt;
                int index = dGVHoaDon.CurrentRow.Index;
                txtMaHoaDon.Text = dGVHoaDon.Rows[index].Cells[0].Value.ToString();
                txtMaKH.Text = dGVHoaDon.Rows[index].Cells[2].Value.ToString();
                txtKhachHang.Text = dGVHoaDon.Rows[index].Cells[3].Value.ToString();
                txtSDT.Text = dGVHoaDon.Rows[index].Cells[4].Value.ToString();
                txtMaThuePhong.Text = dGVHoaDon.Rows[index].Cells[5].Value.ToString();
                txtPhong.Text = dGVHoaDon.Rows[index].Cells[6].Value.ToString();
                txtSoNgayO.Text = dGVHoaDon.Rows[index].Cells[7].Value.ToString();
                txtSoTien.Text = dGVHoaDon.Rows[index].Cells[8].Value.ToString();
                txtNgayThanhToan.Text = dGVHoaDon.Rows[index].Cells[9].Value.ToString();
                txtHinhThucTT.Text = dGVHoaDon.Rows[index].Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVHoaDon.CurrentRow.Index;
            txtMaHoaDon.Text = dGVHoaDon.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dGVHoaDon.Rows[index].Cells[2].Value.ToString();
            txtKhachHang.Text = dGVHoaDon.Rows[index].Cells[3].Value.ToString();
            txtSDT.Text = dGVHoaDon.Rows[index].Cells[4].Value.ToString();
            txtMaThuePhong.Text = dGVHoaDon.Rows[index].Cells[5].Value.ToString();
            txtPhong.Text = dGVHoaDon.Rows[index].Cells[6].Value.ToString();
            txtSoNgayO.Text = dGVHoaDon.Rows[index].Cells[7].Value.ToString();
            txtSoTien.Text = dGVHoaDon.Rows[index].Cells[8].Value.ToString();
            txtNgayThanhToan.Text = dGVHoaDon.Rows[index].Cells[9].Value.ToString();
            txtHinhThucTT.Text = dGVHoaDon.Rows[index].Cells[10].Value.ToString();
            txtTimKiemSDT.Text = dGVHoaDon.Rows[index].Cells[4].Value.ToString();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM HoaDon WHERE MaHoaDon = '" + txtMaHoaDon.Text + "'";
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
                string mahoadon = txtMaHoaDon.Text;
                string makh = txtMaKH.Text;
                string tenkh = txtKhachHang.Text;
                string sdt = txtSDT.Text;   
                string matp = txtMaThuePhong.Text;
                string phong = txtPhong.Text;
                string songayo = txtSoNgayO.Text;
                decimal sotien = Decimal.Parse(txtSoTien.Text);
                DateTime ngaythanhtoan = DateTime.Parse(txtNgayThanhToan.Text);
                string hinhthuc = txtHinhThucTT.Text;

                string query = "UPDATE HoaDon " +
                    "SET MaKhachHang = @MaKhachHang,HoTen = @HoTen,SoDienThoai = @SoDienThoai, MaThuePhong = @MaThuePhong,Phong = @Phong, SoNgayO = @SoNgayO, SoTien = @SoTien, NgayThanhToan = @NgayThanhToan, HinhThucThanhToan = @HinhThucThanhToan " +
                    "WHERE MaHoaDon = @MaHoaDon;";

                ketnoi.GetSuaHoaDon(query, mahoadon, makh, tenkh, sdt, matp, phong, songayo,sotien,ngaythanhtoan,hinhthuc);

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
