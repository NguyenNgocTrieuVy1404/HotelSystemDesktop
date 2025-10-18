# Hệ Thống Quản Lý Khách Sạn

## Mô tả
Ứng dụng Windows Forms C# quản lý khách sạn toàn diện với đầy đủ chức năng từ đặt phòng, thuê phòng, thanh toán đến báo cáo. Dự án học tập sử dụng kiến trúc 3-layer và Crystal Reports.

## Chức năng chính
- ✅ **Quản lý khách hàng**: Thêm, sửa, xóa, tìm kiếm thông tin khách hàng
- ✅ **Quản lý phòng**: Quản lý loại phòng, giá cả, trạng thái phòng
- ✅ **Đặt phòng**: Đặt phòng trước cho khách hàng
- ✅ **Thuê phòng**: Check-in khách hàng vào phòng
- ✅ **Quản lý dịch vụ**: Thêm/sửa/xóa các dịch vụ khách sạn
- ✅ **Thanh toán**: Tạo hóa đơn và thanh toán
- ✅ **Báo cáo**: Báo cáo doanh thu, danh sách hóa đơn
- ✅ **Quản lý nhân viên**: Quản lý tài khoản và phân quyền
- ✅ **In hóa đơn**: Xuất hóa đơn bằng Crystal Reports

## Cấu trúc dự án

### Windows Forms Application
```
QuanLyKhachSan/
├── Program.cs                    # Entry point
├── Intro.cs                      # Màn hình giới thiệu
├── Login.cs                      # Đăng nhập hệ thống
├── Main.cs                       # Menu chính
├── KetNoi.cs                     # Kết nối database
├── ThongTinKhachHang.cs          # Quản lý khách hàng
├── QuanLyPhong.cs                # Quản lý phòng
├── DatPhong.cs                   # Đặt phòng
├── ThuePhong.cs                  # Thuê phòng
├── DichVu.cs                     # Quản lý dịch vụ
├── ThanhTienDichVu.cs            # Thanh toán dịch vụ
├── HoaDon.cs                     # Quản lý hóa đơn
├── ThanhToan.cs                  # Thanh toán
├── InHoaDon.cs                   # In hóa đơn
├── DanhSachHoaDon.cs             # Danh sách hóa đơn
├── DoanhThu.cs                   # Báo cáo doanh thu
├── NhanVien.cs                   # Quản lý nhân viên
├── QuanLyTaiKhoan.cs             # Quản lý tài khoản
├── Doimatkhau.cs                 # Đổi mật khẩu
└── rpDSHoaDon.rpt                # Crystal Report template
```

## Công nghệ
- **C# Windows Forms** - Giao diện desktop
- **SQL Server** - Cơ sở dữ liệu
- **ADO.NET** - Truy cập dữ liệu
- **Crystal Reports** - Báo cáo và in ấn
- **Entity Framework** - ORM (tùy chọn)

## Cài đặt

### 1. Yêu cầu
- Visual Studio 2019/2022
- SQL Server 2016+
- .NET Framework 4.7.2+
- Crystal Reports Runtime

### 2. Setup database
```sql
-- Chạy file SQL_QLKhachSan.sql trong SQL Server Management Studio
-- Hoặc import file SQL vào SQL Server
```

### 3. Cấu hình kết nối
Sửa file `App.config`:
```xml
<connectionStrings>
    <add name="ketnoi" 
         connectionString="Data Source=YOUR_SERVER;Initial Catalog=QLTTDatPhongKS;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 4. Chạy ứng dụng
```bash
# Mở solution trong Visual Studio
# Build solution (Ctrl+Shift+B)
# Chạy ứng dụng (F5)
```

## Cấu trúc database

### Các bảng chính
- **KhachHang**: Thông tin khách hàng
- **Phong**: Thông tin phòng khách sạn
- **ThuePhong**: Phiếu thuê phòng
- **DatPhong**: Phiếu đặt phòng
- **DichVu**: Danh mục dịch vụ
- **HoaDon**: Hóa đơn thanh toán
- **ThanhTienDichVu**: Chi tiết dịch vụ
- **NhanVien**: Thông tin nhân viên
- **DANGNHAP**: Tài khoản đăng nhập

## Cách sử dụng

### 1. Đăng nhập
- Mở ứng dụng → Nhập tài khoản/mật khẩu
- Phân quyền: Admin, Manager, Staff

### 2. Quản lý khách hàng
- Menu "Quản lý" → "Khách hàng"
- Thêm/sửa/xóa thông tin khách hàng
- Tìm kiếm theo tên, SĐT, CMND

### 3. Quản lý phòng
- Menu "Quản lý" → "Phòng"
- Thêm/sửa loại phòng, giá cả
- Cập nhật trạng thái phòng (Trống/Đã thuê/Đang sửa)

### 4. Đặt phòng
- Menu "Dịch vụ" → "Đặt phòng"
- Chọn khách hàng và phòng
- Nhập ngày đến/ngày đi

### 5. Thuê phòng
- Menu "Dịch vụ" → "Thuê phòng"
- Check-in khách hàng vào phòng
- Cập nhật trạng thái phòng

### 6. Thanh toán
- Menu "Dịch vụ" → "Thanh toán"
- Tạo hóa đơn cho khách hàng
- Tính toán tiền phòng + dịch vụ

### 7. Báo cáo
- Menu "Báo cáo" → "Doanh thu"
- Xem báo cáo theo tháng/năm
- In danh sách hóa đơn

## Tính năng nổi bật

### 1. Phân quyền người dùng
- **Admin**: Toàn quyền hệ thống
- **Manager**: Quản lý và báo cáo
- **Staff**: Thao tác cơ bản

### 2. Quản lý trạng thái phòng
- Tự động cập nhật trạng thái phòng
- Kiểm tra phòng trống khi đặt/thuê
- Reset trạng thái khi khách trả phòng

### 3. Tính toán tự động
- Tính tiền phòng theo số ngày ở
- Tính tiền dịch vụ theo số lượng
- Tổng tiền = Tiền phòng + Tiền dịch vụ

### 4. Báo cáo Crystal Reports
- In hóa đơn chuyên nghiệp
- Báo cáo doanh thu chi tiết
- Export PDF/Excel

## Lưu ý
- Đây là dự án học tập Windows Forms
- Cần cài đặt Crystal Reports Runtime
- Kiểm tra kết nối SQL Server trước khi chạy
- Backup database trước khi test
