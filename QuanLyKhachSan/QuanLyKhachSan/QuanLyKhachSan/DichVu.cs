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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string query = " select* from DichVu";
            dGVDichVu.DataSource = ketnoi.Execute(query);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int nextId = GetNextIdDivhVu();
                string madichvu = $"DV{nextId:D2}";
                string tendichvu = txtTenDichVu.Text;
                Decimal chiphi = Decimal.Parse(txtChiPhi.Text);

                string query = "INSERT INTO DichVu (MaDichVu, TenDichVu, ChiPhi) "
                                + "VALUES (@MaDichVu, @TenDichVu, @ChiPhi)";
                ketnoi.ThemDichVu(query, madichvu, tendichvu, chiphi);
                loaddata();
            }
            catch 
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dGVDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVDichVu.CurrentRow.Index;
            txtMaDichVu.Text = dGVDichVu.Rows[index].Cells[0].Value.ToString();
            txtTenDichVu.Text = dGVDichVu.Rows[index].Cells[1].Value.ToString();
            txtChiPhi.Text = dGVDichVu.Rows[index].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madichvu = txtMaDichVu.Text;
                string tendichvu = txtTenDichVu.Text;
                Decimal chiphi = Decimal.Parse(txtChiPhi.Text);

                string query = "DELETE FROM DichVu WHERE MaDichVu = '" + madichvu + "'";
                ketnoi.XoaDichVu(query, madichvu, tendichvu, chiphi);
                loaddata();
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txtMaDichVu.Text;
                string tendv = txtTenDichVu.Text;
                Decimal chiphi = Decimal.Parse(txtChiPhi.Text);
                string query = "UPDATE DichVu SET TenDichVu = @TenDichVu, ChiPhi = @ChiPhi WHERE MaDichVu = @MaDichVu";
                DataTable dt = ketnoi.GetSuaDichVu(query, madv, tendv, chiphi);
                loaddata();
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }
        private int GetNextIdDivhVu()
        {
            int nextId = 1;

            try
            {
                string queryMaxId = "SELECT MAX(CAST(SUBSTRING(MaDichVu, 3, LEN(MaDichVu) - 2) AS INT)) FROM DichVu";
                DataTable dtMaxId = ketnoi.Execute(queryMaxId);

                if (dtMaxId.Rows.Count > 0 && dtMaxId.Rows[0][0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dtMaxId.Rows[0][0]);
                    nextId = maxId + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblDichVu_Click(object sender, EventArgs e)
        {

        }
    }
}
