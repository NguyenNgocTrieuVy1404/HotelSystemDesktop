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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string query = "select * from DANGNHAP";
            try
            {
                DataTable dt = ketnoi.Execute(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtTendangnhap.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtMatKhau.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtVaitro.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtQuyenhan.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            {
                string id = txtTendangnhap.Text;
                string pass = txtMatKhau.Text;
                string vaitro = txtVaitro.Text;
                string quyenhan = txtQuyenhan.Text;
                string query = "INSERT INTO DANGNHAP (Id, Pass, VaiTro, QuyenHan) VALUES (@Id, @Pass, @VaiTro, @QuyenHan)";

                DataTable dt = ketnoi.GetThemTaiKhoan(query, id, pass, vaitro, quyenhan);
                loaddata();
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string id = txtTendangnhap.Text;
                string query = "EXEC DeleteDangNhap @Id = '" + id + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Dữ liệu đã được xóa thành công.");
            }
            else
            {
                MessageBox.Show("Dữ liệu không được xóa.");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtTendangnhap.Text;
                string vaitro = txtVaitro.Text;
                string quyenhan = txtQuyenhan.Text;


                string query = "UPDATE DANGNHAP SET VaiTro = @VaiTro, QuyenHan = @QuyenHan WHERE Id = @Id;";

                ketnoi.GetSuaQuyenHan(query,id,vaitro,quyenhan);

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            Doimatkhau doimk = new Doimatkhau();
            doimk.ShowDialog();
            loaddata();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void chBHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chBHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void lblQuanLyTK_Click(object sender, EventArgs e)
        {
            c
        }
    }
}
