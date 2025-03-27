using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Net.NetworkInformation;

namespace QuanLyKhachSan
{
    internal class KetNoi
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public KetNoi()
        {
            string str = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString;
            //string str = "Data Source=PHONGDANG-LAPTO\\PHONGDANG;Initial Catalog=QLDiemSV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
        }

        public void openConnection()
        {
            if (ConnectionState.Closed == conn.State)
            {
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                    }

                }

            }
        }
        public void closeConnection()
        {
            if (ConnectionState.Open == conn.State)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                }
            }
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            openConnection();

            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            openConnection();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }

        }
        public DataTable Getlogin(string query, string username, string password)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetThem(string query, string maKhachHang, string hoTen, string phai, string ngaySinh, string diaChi, string soDienThoai, string cmND)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cmND);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetSuaKhachHang(string query, string maKhachHang, string hoTen, string phai, string ngaySinh, string diaChi, string soDienThoai, string cmND)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cmND);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetTimKiem(string query)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm, vui lòng thử lại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetDatPhong(string query, string maDatPhong, string maKhachHang,string tenkhach,string sdt,
        string maPhong,
        string maNhanVien,
        string ngayDen,
        string ngayDi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDatPhong", maDatPhong);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@HoTen", tenkhach);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@NgayDen", ngayDen);
                    cmd.Parameters.AddWithValue("@NgayDi", ngayDi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai"+ ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetThemHoaDon(string query, string mahoadon,string tennhanvienDN, string makh,string tenkhachhang, string sdt, DateTime ngaythanhtoan,string matp, string songayo, string phong, string hinhthuc, decimal tongtien)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoaDon", mahoadon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                    cmd.Parameters.AddWithValue("@HoTen", tenkhachhang);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@Phong", phong);
                    cmd.Parameters.AddWithValue("@TenNhanVien", tennhanvienDN);
                    cmd.Parameters.AddWithValue("@MaThuePhong", matp);
                    cmd.Parameters.AddWithValue("@SoNgayO", songayo);
                    cmd.Parameters.AddWithValue("@SoTien", tongtien);
                    cmd.Parameters.AddWithValue("@NgayThanhToan", ngaythanhtoan);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhthuc);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn, vui lòng thử lại: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable ThemDichVu(string query, string madichvu, string tendichvu,Decimal chiphi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDichVu", madichvu);
                    cmd.Parameters.AddWithValue("@TenDichVu", tendichvu);
                    cmd.Parameters.AddWithValue("@ChiPhi", chiphi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable XoaDichVu(string query, string mathuephong, string tendichvu, Decimal chiphi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThuePhong", mathuephong);
                    cmd.Parameters.AddWithValue("@TenDichVu", tendichvu);
                    cmd.Parameters.AddWithValue("@ChiPhi", chiphi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetThuePhong(string query,string matp, string maKH , string tenkh, string sdt, string maphong, string manv, string ngaythue, string songuoi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThuePhong", matp);
                    cmd.Parameters.AddWithValue("@MaKhachHang",maKH );
                    cmd.Parameters.AddWithValue("@HoTen", tenkh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@MaNhanVien", manv);
                    cmd.Parameters.AddWithValue("@MaPhong", maphong);
                    cmd.Parameters.AddWithValue("@NgayThue", ngaythue);
                    cmd.Parameters.AddWithValue("@SoNguoi", songuoi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai"+ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetSuaThuePhong(string query, string maphong,string songuoi,string matp)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaPhong", maphong);
                    cmd.Parameters.AddWithValue("@SoNguoi", songuoi);
                    cmd.Parameters.AddWithValue("@MaThuePhong", matp);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetSuaDichVu(string query,string madv, string tendv, Decimal chiphi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDichVu", madv);
                    cmd.Parameters.AddWithValue("@TenDichVu", tendv);
                    cmd.Parameters.AddWithValue("@ChiPhi", chiphi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetSuaPhong(string query, string maPhong, string loaiPhong, string gia, string trangThai)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);
                    cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetTrangthai(string query,string maphong)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaPhong", maphong);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetSuaHoaDon(string query, string  mahoadon, string makh, string tenkh, string sdt, string matp, string phong, string songayo, decimal sotien, DateTime ngaythanhtoan, string hinhthuc)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                    cmd.Parameters.AddWithValue("@HoTen", tenkh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@MaThuePhong", matp);
                    cmd.Parameters.AddWithValue("@Phong", phong);
                    cmd.Parameters.AddWithValue("@SoNgayO", songayo);
                    cmd.Parameters.AddWithValue("@SoTien", sotien);
                    cmd.Parameters.AddWithValue("@NgayThanhToan", ngaythanhtoan);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhthuc);
                    cmd.Parameters.AddWithValue("@MaHoaDon", mahoadon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai"+ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetThemTaiKhoan(string query, string id, string pass, string vaitro, string quyenhan)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Pass", pass);
                    cmd.Parameters.AddWithValue("@VaiTro", vaitro);
                    cmd.Parameters.AddWithValue("@QuyenHan", quyenhan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetSuaQuyenHan(string query, string id, string vaitro, string quyenhan)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@VaiTro", vaitro);
                    cmd.Parameters.AddWithValue("@QuyenHan", quyenhan);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai" + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public void GetNhanVien(string query, string maNhanVien, string hoTen, string ngaySinh,
string gioiTinh, string diaChi, string chucVu, decimal luong, string sdt, string id)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@Luong", luong);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
        }

        public DataTable GetSuaNhanVien(string query, string maNhanVien, string hoTen,
            string ngaySinh, string gioiTinh, string diaChi, string chucVu, decimal luong, string sdt, string id)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@Luong", luong);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai" + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetTTDichVu(string query, string mathanhtien, string maphong, string tendichvu, string soluong,decimal dongia, decimal thanhtien)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThanhTien", mathanhtien);
                    cmd.Parameters.AddWithValue("@MaPhong", maphong);
                    cmd.Parameters.AddWithValue("@TenDichVu", tendichvu);
                    cmd.Parameters.AddWithValue("@SoLuong", soluong);
                    cmd.Parameters.AddWithValue("@DonGia", dongia);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhtien);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai"+ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public void ResetTrangThai(string query1, string map)
        {
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query1;
                    cmd.Parameters.AddWithValue("@MaPhong", map);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai"+ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
