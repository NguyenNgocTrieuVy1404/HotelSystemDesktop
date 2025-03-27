CREATE DATABASE QLTTDatPhongKS
GO
USE QLTTDatPhongKS
GO
CREATE TABLE KhachHang (
    MaKhachHang NVARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100),
	Phai NVARCHAR(6),
	NgaySinh NVARCHAR(15),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    CMND_Passport NVARCHAR(20)
)
GO
CREATE TABLE Phong (
    MaPhong NVARCHAR(50) PRIMARY KEY,
    LoaiPhong NVARCHAR(50),
    GiaCoBan DECIMAL(18),
    TrangThai NVARCHAR(50)
)
CREATE TABLE DANGNHAP
(
    Id VARCHAR(10) PRIMARY KEY,
    Pass VARCHAR(15),
    VaiTro NVARCHAR(50),
    QuyenHan NVARCHAR(50)
)

CREATE TABLE NhanVien
(
    MaNhanVien NVARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    GioiTinh NVARCHAR(10), 
    DiaChi NVARCHAR(255), 
    NgaySinh VARCHAR(50), 
    ChucVu NVARCHAR(50),
    Luong DECIMAL(18),
    Id VARCHAR(10) FOREIGN KEY REFERENCES DANGNHAP(Id)
);

GO
CREATE TABLE ThuePhong (
    MaThuePhong NVARCHAR(50) PRIMARY KEY ,
    MaKhachHang NVARCHAR(50),
	HoTen NVARCHAR(100),
	SoDienThoai NVARCHAR(15),
    MaPhong NVARCHAR(50),
    MaNhanVien NVARCHAR(50),
    NgayThue NVARCHAR(15),
	SoNguoi INT,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);
GO
CREATE TABLE DatPhong (
    MaDatPhong NVARCHAR(50) PRIMARY KEY,
    MaKhachHang NVARCHAR(50),
	HoTen NVARCHAR(100),
	SoDienThoai NVARCHAR(15),
    MaPhong NVARCHAR(50),
    MaNhanVien NVARCHAR(50),
    NgayDen NVARCHAR(15),
    NgayDi NVARCHAR(15),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);
GO
CREATE TABLE DichVu (
    MaDichVu NVARCHAR(50) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    ChiPhi DECIMAL(18) DEFAULT 0
)
GO
CREATE TABLE HoaDon (
    MaHoaDon NVARCHAR(50) PRIMARY KEY,
	TenNhanVien NVARCHAR(100),
    MaKhachHang NVARCHAR(50),
	HoTen NVARCHAR(100),
	SoDienThoai NVARCHAR(15),
	MaThuePhong NVARCHAR(50),
	Phong NVARCHAR(50),
	SoNgayO NVARCHAR(50),
    SoTien DECIMAL(18),
    NgayThanhToan DATE,
    HinhThucThanhToan NVARCHAR(50)
)
GO
CREATE TABLE ThanhTienDichVu (
    MaThanhTien NVARCHAR(50) PRIMARY KEY,
    MaPhong NVARCHAR(50),
    TenDichVu NVARCHAR(100),
    SoLuong INT,
    DonGia DECIMAL(18),
    ThanhTien DECIMAL(18),
);
GO

INSERT INTO KhachHang (MaKhachHang,HoTen, Phai, NgaySinh, DiaChi, SoDienThoai, CMND_Passport)
VALUES (N'KH001', N'Nguyễn Văn A', N'Nam', '15/05/1990', N'123 Đường ABC, Quận 1, TP. Hồ Chí Minh', N'0901234567', N'123456789'),
    (N'KH002', N'Nguyễn Văn B', N'Nam', '20/08/1992', N'456 Đường XYZ, Quận 2, TP. Hồ Chí Minh', N'0912345678', N'987654321'),
    (N'KH003', N'Trần Thị C', N'Nữ', '10/03/1985', N'789 Đường DEF, Quận 3, TP. Hồ Chí Minh', N'0923456789', N'543216789'),
    (N'KH004', N'Lê Văn D', N'Nam', '12/05/1992', N'101 Đường GHI, Quận 4, TP. Hồ Chí Minh', N'0934567890', N'987654123'),
    (N'KH005', N'Phạm Thị E', N'Nữ', '26/03/2000', N'111 Đường KLM, Quận 5, TP. Hồ Chí Minh', N'0945678901', N'123456987'),
    (N'KH006', N'Hoàng Văn F', N'Nam', '01/02/2001', N'222 Đường NOP, Quận 6, TP. Hồ Chí Minh', N'0956789012', N'789654321'),
    (N'KH007', N'Nguyễn Thị G', N'Nữ', '03/07/1995', N'333 Đường QRS, Quận 7, TP. Hồ Chí Minh', N'0967890123', N'456789012'),
    (N'KH008', N'Trần Văn H', N'Nam', '18/09/1988', N'444 Đường TUV, Quận 8, TP. Hồ Chí Minh', N'0978901234', N'890123456'),
    (N'KH009', N'Lê Thị I', N'Nữ', '25/12/1993', N'555 Đường WXY, Quận 9, TP. Hồ Chí Minh', N'0989012345', N'234567890'),
    (N'KH010', N'Phan Văn K', N'Nam', '07/04/1997', N'666 Đường ZAB, Quận 10, TP. Hồ Chí Minh', N'0990123456', N'678901234'),
    (N'KH011', N'Hồ Thị L', N'Nữ', '14/08/1994', N'777 Đường CDE, Quận 11, TP. Hồ Chí Minh', N'0911122334', N'345678901'),
    (N'KH012', N'Đặng Văn M', N'Nam', '22/06/1989', N'888 Đường FGH, Quận 12, TP. Hồ Chí Minh', N'0922233445', N'789012345'),
    (N'KH013', N'Vũ Thị N', N'Nữ', '30/11/1991', N'999 Đường IJK, Quận Bình Thạnh, TP. Hồ Chí Minh', N'0933344556', N'901234567'),
    (N'KH014', N'Nguyễn Văn P', N'Nam', '09/10/1996', N'1010 Đường LMN, Quận Tân Bình, TP. Hồ Chí Minh', N'0944455667', N'234567890'),
    (N'KH015', N'Trần Thị Q', N'Nữ', '28/02/1987', N'1111 Đường OPQ, Quận Tân Phú, TP. Hồ Chí Minh', N'0955566778', N'678901234'),
    (N'KH016', N'Lê Văn R', N'Nam', '05/09/1998', N'1212 Đường RST, Quận Gò Vấp, TP. Hồ Chí Minh', N'0966677889', N'123456789');


INSERT INTO Phong (MaPhong,LoaiPhong, GiaCoBan, TrangThai)
VALUES 
	(N'P001', N'Phòng Thường', 100000, N'Đã thuê'),
    (N'P002', N'Phòng VIP', 150000, N'Đã thuê'),
    (N'P003', N'Phòng Thường', 100000, N'Đã thuê'),
    (N'P004', N'Phòng VIP', 150000, N'Đã thuê'),
    (N'P005', N'Phòng Thường', 100000, N'Đã thuê'),
    (N'P006', N'Phòng VIP', 150000, N'Trống'),
    (N'P007', N'Phòng Thường', 100000, N'Trống'),
    (N'P008', N'Phòng VIP', 150000, N'Trống'),
    (N'P009', N'Phòng Thường', 100000, N'Trống'),
    (N'P010', N'Phòng VIP', 150000, N'Trống'),
    (N'P011', N'Phòng Thường', 100000, N'Trống'),
    (N'P012', N'Phòng VIP', 150000, N'Trống'),
    (N'P013', N'Phòng Thường', 100000, N'Trống'),
    (N'P014', N'Phòng VIP', 150000, N'Trống'),
    (N'P015', N'Phòng Thường', 100000, N'Trống'),
    (N'P016', N'Phòng VIP', 150000, N'Trống'),
    (N'P017', N'Phòng Thường', 100000, N'Trống'),
    (N'P018', N'Phòng VIP', 150000, N'Trống'),
    (N'P019', N'Phòng Thường', 100000, N'Trống'),
    (N'P020', N'Phòng VIP', 150000, N'Trống'),
    (N'P021', N'Phòng Thường', 100000, N'Trống'),
    (N'P022', N'Phòng VIP', 150000, N'Trống'),
    (N'P023', N'Phòng Thường', 100000, N'Trống'),
    (N'P024', N'Phòng VIP', 150000, N'Trống'),
    (N'P025', N'Phòng Thường', 100000, N'Trống'),
    (N'P026', N'Phòng VIP', 150000, N'Trống'),
    (N'P027', N'Phòng Thường', 100000, N'Trống'),
    (N'P028', N'Phòng VIP', 150000, N'Trống'),
    (N'P029', N'Phòng Thường', 100000, N'Trống'),
    (N'P030', N'Phòng VIP', 150000, N'Trống'),
    (N'P031', N'Phòng Thường', 100000, N'Trống'),
    (N'P032', N'Phòng VIP', 150000, N'Trống'),
    (N'P033', N'Phòng Thường', 100000, N'Trống'),
    (N'P034', N'Phòng VIP', 150000, N'Trống'),
    (N'P035', N'Phòng Thường', 100000, N'Trống'),
    (N'P036', N'Phòng VIP', 150000, N'Trống'),
    (N'P037', N'Phòng Thường', 100000, N'Trống'),
    (N'P038', N'Phòng VIP', 150000, N'Trống'),
    (N'P039', N'Phòng Thường', 100000, N'Trống'),
    (N'P040', N'Phòng VIP', 150000, N'Trống'),
    (N'P041', N'Phòng Thường', 100000, N'Trống'),
    (N'P042', N'Phòng VIP', 150000, N'Trống'),
    (N'P043', N'Phòng Thường', 100000, N'Trống'),
    (N'P044', N'Phòng VIP', 150000, N'Trống'),
    (N'P045', N'Phòng Thường', 100000, N'Trống'),
    (N'P046', N'Phòng VIP', 150000, N'Trống'),
    (N'P047', N'Phòng Thường', 100000, N'Trống'),
    (N'P048', N'Phòng VIP', 150000, N'Trống'),
    (N'P049', N'Phòng Thường', 100000, N'Trống'),
    (N'P050', N'Phòng VIP', 150000, N'Trống');



INSERT INTO ThuePhong (MaThuePhong, MaKhachHang, HoTen, SoDienThoai, MaPhong, MaNhanVien, NgayThue, SoNguoi)
VALUES 
(N'TP001', N'KH001', N'Nguyễn Văn A', N'0901234567', N'P001', N'NV01', '01/02/2024', 2),
(N'TP002', N'KH002', N'Nguyễn Văn B', N'0912345678', N'P002', N'NV01', '02/06/2024', 3),
(N'TP003', N'KH003', N'Trần Thị C', N'0923456789', N'P005', N'NV01', '12/06/2024', 1),
(N'TP004', N'KH004', N'Lê Văn D', N'0934567890', N'P003', N'NV01', '01/01/2024', 4),
(N'TP005', N'KH005', N'Hoàng Văn F', N'0945678901', N'P004', N'NV01', '10/05/2024', 2);

INSERT INTO DatPhong (MaDatPhong, MaKhachHang, HoTen, SoDienThoai, MaPhong, MaNhanVien, NgayDen, NgayDi)
VALUES
    (N'DP001', N'KH001', N'Nguyễn Văn A', N'0901234567', N'P001', N'NV02', '01/07/2024', '05/07/2024'),
    (N'DP002', N'KH002', N'Nguyễn Văn B', N'0912345678', N'P002', N'NV02', '02/07/2024', '06/07/2024'),
    (N'DP003', N'KH003', N'Trần Thị C', N'0923456789', N'P005', N'NV02', '03/07/2024', '07/07/2024'),
    (N'DP004', N'KH004', N'Lê Văn D', N'0934567890', N'P003', N'NV02', '04/07/2024', '08/07/2024'),
    (N'DP005', N'KH006', N'Hoàng Văn F', N'0956789012', N'P004', N'NV02', '05/07/2024', '09/07/2024');
INSERT INTO DichVu (MaDichVu, TenDichVu, ChiPhi)
VALUES
    (N'DV01', N'Dịch vụ phòng', 600000),
    (N'DV02', N'Dịch vụ giặt là', 80000),
    (N'DV03', N'Dịch vụ đặt vé tham quan', 150000),
    (N'DV04', N'Dịch vụ đưa đón sân bay', 300000),
    (N'DV05', N'Dịch vụ phòng máy', 500000),
	(N'DV06', N'Coca', 20000),
    (N'DV07', N'Pesi', 25000),
    (N'DV08', N'Lẩu hải sản', 120000),
    (N'DV09', N'Lẩu thập cẩm', 150000),
    (N'DV10', N'Lẩu bò Phong Long', 180000)

INSERT INTO ThanhTienDichVu (MaThanhTien, MaPhong, TenDichVu, SoLuong, DonGia, ThanhTien)
VALUES
    ('TT001', 'P001', N'Dịch vụ phòng', 1, 600000, 600000),
    ('TT002', 'P002', N'Dịch vụ giặt là', 1, 80000, 80000),
    ('TT003', 'P005', N'Dịch vụ đặt vé tham quan', 1, 150000, 150000),
    ('TT004', 'P003', N'Dịch vụ đưa đón sân bay', 1, 300000, 300000),
    ('TT005', 'P004', N'Dịch vụ phòng', 1, 600000, 600000),
    ('TT006', 'P001', N'Coca', 2, 20000, 40000),
    ('TT007', 'P002', N'Pesi', 1, 25000, 25000),
    ('TT008', 'P005', N'Lẩu hải sản', 1, 120000, 120000),
    ('TT009', 'P003', N'Lẩu thập cẩm', 1, 150000, 150000),
    ('TT010', 'P004', N'Lẩu bò Phong Long', 1, 180000, 180000);



/*INSERT INTO HoaDon (MaHoaDon,MaThuePhong, MaPhong, SoTien, NgayThanhToan, HinhThucThanhToan)
VALUES*/


INSERT INTO DANGNHAP (Id, Pass, VaiTro, QuyenHan)
VALUES  ('admin', '123', N'Chủ quản', N'Toàn hệ thống'),
        ('service', '123456', N'Lễ tân', N'Lễ tân'),
        ('service1', '12456', N'Lễ tân', N'Lễ tân'), 
        ('service2', '13456', N'Lễ tân', N'Lễ tân'),
        ('service3', '12456', N'Lễ tân', N'Lễ tân'),
        ('service4', '12356', N'Lễ tân', N'Lễ tân')

INSERT INTO NhanVien (MaNhanVien, HoTen, ChucVu, Luong, SoDienThoai, GioiTinh, DiaChi, NgaySinh, Id)
VALUES  
    (N'NV01', N'Trần Thị Bích', N'Lễ Tân', 150000, N'0987654321', N'Nữ', N'Đà Nẵng', '1990-01-15', 'service'),
    (N'NV02', N'Nguyễn Thị Cẩm Tú', N'Lễ Tân', 150000, N'0987654322', N'Nữ', N'Hồ Chí Minh', '1995-05-20', 'service1'),
    (N'NV03', N'Lê Văn Dũng', N'Lễ Tân', 150000, N'0987654323', N'Nam', N'Hà Nội', '1992-10-10', 'service2'),
    (N'NV04', N'Hồ Thị Hương', N'Lễ Tân', 150000, N'0987654324', N'Nữ', N'Hải Phòng', '1993-12-25', 'service3'),
    (N'NV05', N'Trần Minh Khánh', N'Lễ Tân', 150000, N'0987654325', N'Nam', N'Bình Dương', '1991-08-08', 'service4'),
    (N'CQTP', N'Triều Vỹ Ngọc', N'Chủ Quản', 500000, N'0987612346', N'Nữ', N'TP.HCM', '1985-03-18', 'admin');


GO
CREATE PROC USP_Login
@id varchar(10),
@password varchar(15)
AS
BEGIN
	SELECT * FROM DANGNHAP WHERE id = @id AND Pass = @password
END

-- thủ tục xóa tài khoản và xóa phần id tài khoản của nhân viên
GO
CREATE PROCEDURE DeleteDangNhap
    @Id VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DELETE FROM DANGNHAP
    WHERE Id = @Id;

    UPDATE NhanVien
    SET Id = NULL
    WHERE Id = @Id;

    COMMIT TRANSACTION;
END

select* from ThanhTienDichVu
select* from HoaDon
select* from KhachHang
select* from DANGNHAP
SELECT * FROM DichVu;
delete from Phong
select* from DatPhong
select* from Phong
select* from ThuePhong
SELECT * FROM NhanVien;
SELECT * 
FROM KhachHang 
JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang 
WHERE (KhachHang.MaKhachHang LIKE 'KH01') AND (MaThuePhong LIKE 'TP01')

Select count (*) From DANGNHAP Where ID= N'admin' and Pass= N'123'

Update DANGNHAP set Pass = N'123' Where Id= N'admin' and Pass = N''
SELECT MaKhachHang FROM KhachHang


SELECT YEAR(NgayThanhToan) AS Năm,
       MONTH(TRY_CONVERT(DATE, NgayThanhToan,103)) AS Tháng,
       SUM(SoTien) AS 'Tổng Doanh Thu'
FROM HoaDon
WHERE MONTH(TRY_CONVERT(DATE, NgayThanhToan,103)) = '7' AND YEAR(NgayThanhToan) = '2024'
GROUP BY YEAR(NgayThanhToan), MONTH(TRY_CONVERT(DATE, NgayThanhToan,103));


SELECT HoTen FROM DANGNHAP JOIN NhanVien ON DANGNHAP.Id = NhanVien.Id WHERE DANGNHAP.Id ='service';

SELECT MaKhachHang
FROM KhachHang
WHERE MaKhachHang NOT IN (SELECT MaKhachHang FROM ThuePhong);

SELECT MaPhong
FROM Phong
WHERE MaPhong NOT IN (SELECT MaPhong FROM ThuePhong);

Select * from hoadon where SoDienThoai = '0923456789'


--test thành tiền
SELECT 
    kh.MaKhachHang,
    kh.HoTen,
    p.GiaCoBan,
    tp.SoNguoi,
    tp.NgayThue,
	p.LoaiPhong,
    DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) AS SoNgay,
    (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) AS TienPhong,
    ISNULL(SUM(tt.ThanhTien), 0) AS TienDichVu,
    CASE 
        WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
        ELSE 0
    END AS PhuThu,
    CASE 
        WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
        ELSE 0
    END AS GiamGiaKhachHang,
    ((DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) 
        + ISNULL(SUM(tt.ThanhTien), 0) 
        + CASE 
            WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
            ELSE 0
          END
        - CASE 
            WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
            ELSE 0
          END) AS TongTien
FROM 
    ThuePhong tp
JOIN KhachHang kh ON tp.MaKhachHang = kh.MaKhachHang
JOIN Phong p ON tp.MaPhong = p.MaPhong
JOIN ThanhTienDichVu tt ON tp.MaPhong = tt.MaPhong
--WHERE tp.MaKhachHang = 
GROUP BY
    kh.MaKhachHang, kh.HoTen, p.GiaCoBan, tp.SoNguoi, tp.NgayThue,p.LoaiPhong, kh.MaKhachHang
	--'" + maKhachHang + @"'

SELECT MaPhong FROM Phong WHERE MaPhong NOT IN (SELECT MaPhong FROM ThuePhong) AND TrangThai = N'Trống';

INSERT INTO ThuePhong (MaThuePhong, MaKhachHang, HoTen, SoDienThoai, MaPhong, MaNhanVien, NgayThue, SoNguoi)
VALUES (N'TP006', N'KH005', N'Khách Hàng 5', N'0945678901', N'P007', N'NV01', '10/05/2024', 2);

SELECT ThuePhong.MaPhong FROM ThuePhong JOIN Phong ON ThuePhong.MaPhong= Phong.MaPhong 
WHERE TrangThai=N'Đã thuê'
GROUP BY ThuePhong.MaPhong