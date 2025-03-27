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
    public partial class Main : Form
    {
        private string quyenHan;
        KetNoi ketNoi = new KetNoi();
        public Main()
        {
            InitializeComponent();
            this.quyenHan = quyenHan;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainEnabled();
        }

        private void dsDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong fmDP = new DatPhong();
            fmDP.ShowDialog();
        }

        private void dsThuePhong_Click(object sender, EventArgs e)
        {
            ThuePhong fmTP = new ThuePhong();
            fmTP.ShowDialog();
        }
        private void MainEnabled()
        {
            mHeThong.Enabled = true;
            dsHeThong.Enabled = true;
            dsQuanLiKhachHang.Enabled = true;
            dsQuanLyPhong.Enabled = true;
            dsThongKe.Enabled = true;
           
        }

        private void dsDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();
                Login login = new Login();
                login.ShowDialog();
                
            }
            
        }

        private void dsDoiMatKhau_Click(object sender, EventArgs e)
        {

            if (Login.CurrentUserName == "admin")
            {
                Doimatkhau fmDMK = new Doimatkhau();
                fmDMK.ShowDialog();
            }
            else if (Login.CurrentUserName == "service"|| Login.CurrentUserName == "service1"|| 
                Login.CurrentUserName == "service2" ||Login.CurrentUserName == "service3" || Login.CurrentUserName == "service4")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hợp lệ để thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dsThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dsThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang fmTTKH = new ThongTinKhachHang();
            fmTTKH.ShowDialog();
        }

        private void dsThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan fmTT = new ThanhToan();
            fmTT.ShowDialog();
        }

        private void dsPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong fmQLP = new QuanLyPhong();
            fmQLP.ShowDialog();
        }

        private void dsDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon();
            danhSachHoaDon.ShowDialog();
        }

        private void dsDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu doanhthu = new DoanhThu(); 
            doanhthu.ShowDialog();
        }

        private void dsNhanVien_Click(object sender, EventArgs e)
        {
            if (Login.CurrentUserName == "admin")
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.ShowDialog();
            }
            else if (Login.CurrentUserName == "service" || Login.CurrentUserName == "service1" ||
                Login.CurrentUserName == "service2" || Login.CurrentUserName == "service3" || Login.CurrentUserName == "service4")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hợp lệ để thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dsQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Login.CurrentUserName == "admin")
            {
                QuanLyTaiKhoan ql = new QuanLyTaiKhoan();
                ql.ShowDialog();
            }
            else if (Login.CurrentUserName == "service" || Login.CurrentUserName == "service1" ||
                Login.CurrentUserName == "service2" || Login.CurrentUserName == "service3" || Login.CurrentUserName == "service4")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hợp lệ để thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dsDichVu_Click(object sender, EventArgs e)
        {
            DichVu dichvu = new DichVu();
            dichvu.ShowDialog();
        }

        private void dsHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.ShowDialog();
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhTienDichVu dichvu = new ThanhTienDichVu();
            dichvu.ShowDialog();
        }
    }
}
