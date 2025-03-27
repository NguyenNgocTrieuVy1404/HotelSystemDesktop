using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyKhachSan
{
    public partial class Login : Form
    {
        public static string CurrentUserName = "";
        public static string tenNhanVienDangNhap = "";
        public static string MaNhanVienDN = "";
        public Login()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            String username, password;
            username = txtDangnhap.Text;
            password = txtMatkhau.Text;
            string query = "EXEC USP_Login @id, @pass";
            DataTable dt = ketnoi.Getlogin(query, username, password);
            errorProvider1.Clear();
            
            if (string.IsNullOrEmpty(txtDangnhap.Text))
            {
                errorProvider1.SetError(txtDangnhap, "Bạn chưa điền tên đăng nhập !");
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
                errorProvider1.SetError(txtMatkhau, "Bạn chưa điền mật khẩu !");
            if (dt.Rows.Count > 0)
            {
                string vaiTro = dt.Rows[0]["VaiTro"].ToString();
                MessageBox.Show("Đăng nhập thành công với vai trò " + vaiTro);
                CurrentUserName = txtDangnhap.Text;
                string query1 = "SELECT HoTen FROM DANGNHAP JOIN NhanVien ON DANGNHAP.Id = NhanVien.Id WHERE DANGNHAP.Id ='" + username + "'";
                DataTable dtb = ketnoi.Execute(query1);
                tenNhanVienDangNhap = dtb.Rows[0].Field<string>("HoTen");
                string query2 = "SELECT MaNhanVien FROM DANGNHAP JOIN NhanVien ON DANGNHAP.Id = NhanVien.Id WHERE DANGNHAP.Id ='" + username + "'";
                DataTable dtb2 = ketnoi.Execute(query2);
                MaNhanVienDN = dtb2.Rows[0].Field<string>("MaNhanVien");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false)
            {
                txtMatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
