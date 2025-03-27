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
    public partial class QuanLyPhong : Form
    {
        KetNoi ketnoi = new KetNoi();
        public QuanLyPhong()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string query = "select * from Phong ";
            try
            {
                DataTable dt = ketnoi.Execute(query);
                dGVDanhSachPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {   
                string maPhong = txtMaPhong.Text;
                string loaiPhong = cBLoaiPhong.Text;
                string gia = txtGia.Text;
                string trangThai = cBTrangThai.Text;

                string query = "UPDATE Phong SET LoaiPhong = @LoaiPhong, GiaCoBan = @Gia, Trangthai = @TrangThai WHERE MaPhong = @maPhong";

                ketnoi.GetSuaPhong(query, maPhong, loaiPhong, gia, trangThai);

                loaddata(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dGVDanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVDanhSachPhong.CurrentRow.Index;
            txtMaPhong.Text = dGVDanhSachPhong.Rows[index].Cells[0].Value.ToString();
            cBLoaiPhong.Text = dGVDanhSachPhong.Rows[index].Cells[1].Value.ToString();
            txtGia.Text = dGVDanhSachPhong.Rows[index].Cells[2].Value.ToString();
            cBTrangThai.Text = dGVDanhSachPhong.Rows[index].Cells[3].Value.ToString();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxLoaiPhong();
        }
        private void LoadComboBoxLoaiPhong()
        {
            try
            {

                string query = "SELECT LoaiPhong FROM Phong GROUP BY LoaiPhong";

                DataTable dt = ketnoi.Execute(query);


                if (dt.Rows.Count > 0)
                {
                    cBLoaiPhong.DisplayMember = "LoaiPhong";
                    cBLoaiPhong.ValueMember = "LoaiPhong";
                    cBLoaiPhong.DataSource = dt;
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

        private void cBLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
