/* =====================================================================
   HỆ THỐNG QUẢN LÝ CHO THUÊ VĂN PHÒNG CAO ỐC
   Script tạo CSDL QuanLyChoThueVanPhong (SQL Server)
   - Thời hạn hợp đồng tối thiểu >= 6 tháng (BR01)
   - Trạng thái phòng: Trống, Đã thuê (QD02)
   - Thanh toán tiền phòng và dịch vụ tách riêng (BR04, BR05)
   ===================================================================== */
IF DB_ID(N'QuanLyChoThueVanPhong') IS NULL CREATE DATABASE QuanLyChoThueVanPhong;
GO
USE QuanLyChoThueVanPhong;
GO

-- 1. XÓA BẢNG NẾU ĐÃ TỒN TẠI (Theo thứ tự khóa ngoại)
IF OBJECT_ID('KiemTraDinhKy','U') IS NOT NULL DROP TABLE KiemTraDinhKy;
IF OBJECT_ID('TheGiuXe','U') IS NOT NULL DROP TABLE TheGiuXe;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('SuDungDichVu','U') IS NOT NULL DROP TABLE SuDungDichVu;
IF OBJECT_ID('DichVu','U') IS NOT NULL DROP TABLE DichVu;
IF OBJECT_ID('HoaDonPhong','U') IS NOT NULL DROP TABLE HoaDonPhong;
IF OBJECT_ID('PhieuGiaHan','U') IS NOT NULL DROP TABLE PhieuGiaHan;
IF OBJECT_ID('ChiTietHopDong','U') IS NOT NULL DROP TABLE ChiTietHopDong;
IF OBJECT_ID('HopDongThue','U') IS NOT NULL DROP TABLE HopDongThue;
IF OBJECT_ID('KhachHang','U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('Phong','U') IS NOT NULL DROP TABLE Phong;
IF OBJECT_ID('Tang','U') IS NOT NULL DROP TABLE Tang;
GO

-- 2. TẠO BẢNG VÀ RÀNG BUỘC
CREATE TABLE Tang(
    MaTang varchar(20) NOT NULL PRIMARY KEY,
    TenTang nvarchar(100) NOT NULL
);

CREATE TABLE Phong(
    MaPhong varchar(20) NOT NULL PRIMARY KEY,
    MaTang varchar(20) NOT NULL,
    DienTich decimal(18,2) NOT NULL CHECK(DienTich > 0),
    Huong nvarchar(50) NULL,
    GiaCoSo decimal(18,2) NOT NULL CHECK(GiaCoSo >= 0),
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Trống',
    CONSTRAINT FK_Phong_Tang FOREIGN KEY(MaTang) REFERENCES Tang(MaTang),
    CONSTRAINT CK_Phong_TrangThai CHECK(TrangThai IN (N'Trống', N'Đã thuê'))
);

CREATE TABLE KhachHang(
    MaKH varchar(20) NOT NULL PRIMARY KEY,
    TenKhachHang nvarchar(150) NOT NULL,
    DiaChi nvarchar(250) NULL,
    DienThoai varchar(20) NULL
);

CREATE TABLE HopDongThue(
    SoHopDong varchar(20) NOT NULL PRIMARY KEY,
    MaKH varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    ThoiHanThue int NOT NULL CHECK(ThoiHanThue >= 6), -- BR01: Tối thiểu 6 tháng
    TienDatCoc decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienDatCoc >= 0),
    NgayKetThuc date NOT NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Đang hiệu lực',
    CONSTRAINT FK_HD_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT CK_HD_Ngay CHECK(NgayKetThuc >= NgayLap)
);

CREATE TABLE ChiTietHopDong(
    SoHopDong varchar(20) NOT NULL,
    MaPhong varchar(20) NOT NULL,
    DonGiaThue decimal(18,2) NOT NULL CHECK(DonGiaThue >= 0),
    PRIMARY KEY(SoHopDong, MaPhong),
    CONSTRAINT FK_CTHD_HD FOREIGN KEY(SoHopDong) REFERENCES HopDongThue(SoHopDong),
    CONSTRAINT FK_CTHD_Phong FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong)
);

CREATE TABLE PhieuGiaHan(
    MaGiaHan varchar(20) NOT NULL PRIMARY KEY,
    SoHopDong varchar(20) NOT NULL,
    ThoiGianGiaHan int NOT NULL CHECK(ThoiGianGiaHan > 0),
    NgayLap date NOT NULL,
    CONSTRAINT FK_PGH_HD FOREIGN KEY(SoHopDong) REFERENCES HopDongThue(SoHopDong)
);

CREATE TABLE HoaDonPhong(
    MaHDP varchar(20) NOT NULL PRIMARY KEY,
    SoHopDong varchar(20) NOT NULL,
    ThangNam varchar(10) NOT NULL, -- Format: MM/yyyy
    SoTien decimal(18,2) NOT NULL CHECK(SoTien >= 0),
    DaThanhToan bit NOT NULL DEFAULT 0,
    NgayThu date NULL,
    CONSTRAINT FK_HDP_HD FOREIGN KEY(SoHopDong) REFERENCES HopDongThue(SoHopDong)
);

CREATE TABLE DichVu(
    MaDV varchar(20) NOT NULL PRIMARY KEY,
    TenDV nvarchar(100) NOT NULL,
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0)
);

CREATE TABLE SuDungDichVu(
    MaDV varchar(20) NOT NULL,
    MaPhong varchar(20) NOT NULL,
    ThangNam varchar(10) NOT NULL, -- Format: MM/yyyy
    ChiSoDau int NOT NULL CHECK(ChiSoDau >= 0),
    ChiSoCuoi int NOT NULL CHECK(ChiSoCuoi >= 0),
    TieuThu int NOT NULL CHECK(TieuThu >= 0),
    ThanhTien decimal(18,2) NOT NULL CHECK(ThanhTien >= 0),
    DaThanhToan bit NOT NULL DEFAULT 0,
    PRIMARY KEY(MaDV, MaPhong, ThangNam),
    CONSTRAINT FK_SDDV_DV FOREIGN KEY(MaDV) REFERENCES DichVu(MaDV),
    CONSTRAINT FK_SDDV_Phong FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong),
    CONSTRAINT CK_SDDV_ChiSo CHECK(ChiSoCuoi >= ChiSoDau)
);

CREATE TABLE NhanVien(
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    MaPhong varchar(20) NOT NULL,
    HoTen nvarchar(150) NOT NULL,
    ChucVu nvarchar(100) NULL,
    CongTy nvarchar(150) NULL,
    HinhAnh varchar(255) NULL, -- Lưu đường dẫn ảnh
    CONSTRAINT FK_NV_Phong FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong)
);

CREATE TABLE TheGiuXe(
    MaThe varchar(20) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL UNIQUE, -- BR09: Một nhân viên sở hữu 1 thẻ định danh
    BienSoXe varchar(20) NOT NULL,
    LoaiXe nvarchar(50) NOT NULL,
    CONSTRAINT FK_The_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE KiemTraDinhKy(
    MaKT varchar(20) NOT NULL PRIMARY KEY,
    MaPhong varchar(20) NOT NULL,
    NgayKiemTra date NOT NULL,
    BienBanViPham nvarchar(500) NULL,
    TienPhat decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienPhat >= 0), -- BR11
    CONSTRAINT FK_KT_Phong FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong)
);
GO

-- 3. CHÈN DỮ LIỆU MẪU (TEST DATA)
INSERT INTO Tang(MaTang, TenTang) VALUES 
('T1', N'Tầng 1 (Trệt)'), ('T2', N'Tầng 2'), ('T3', N'Tầng 3');

INSERT INTO Phong(MaPhong, MaTang, DienTich, Huong, GiaCoSo, TrangThai) VALUES
('P101', 'T1', 120.5, N'Đông Nam', 25000000, N'Đã thuê'),
('P201', 'T2', 85.0, N'Tây Bắc', 18000000, N'Đã thuê'),
('P202', 'T2', 90.0, N'Đông Nam', 20000000, N'Trống'),
('P301', 'T3', 150.0, N'Nam', 35000000, N'Trống');

INSERT INTO KhachHang(MaKH, TenKhachHang, DiaChi, DienThoai) VALUES
('KH01', N'Công ty CP Phần mềm Sài Gòn', N'Quận 1, TP.HCM', '0901234567'),
('KH02', N'Công ty TNHH Thương mại Vạn Phát', N'Quận 3, TP.HCM', '0912345678');

-- Khách hàng KH01 thuê phòng P101 12 tháng (Hợp lệ BR01 >= 6)
INSERT INTO HopDongThue(SoHopDong, MaKH, NgayLap, ThoiHanThue, TienDatCoc, NgayKetThuc, TrangThai) VALUES
('HD2026-001', 'KH01', '2026-01-15', 12, 50000000, '2027-01-15', N'Đang hiệu lực'),
('HD2026-002', 'KH02', '2026-05-01', 6, 20000000, '2026-11-01', N'Đang hiệu lực');

INSERT INTO ChiTietHopDong(SoHopDong, MaPhong, DonGiaThue) VALUES
('HD2026-001', 'P101', 25000000),
('HD2026-002', 'P201', 18000000);

-- Tiền phòng đóng hàng tháng từ tháng thứ 7 (BR04)
INSERT INTO HoaDonPhong(MaHDP, SoHopDong, ThangNam, SoTien, DaThanhToan, NgayThu) VALUES
('HDP-08-2026', 'HD2026-001', '08/2026', 25000000, 1, '2026-08-02'),
('HDP-09-2026', 'HD2026-001', '09/2026', 25000000, 0, NULL); -- Đang nợ tháng 9

INSERT INTO DichVu(MaDV, TenDV, DonGia) VALUES
('DV01', N'Điện năng tiêu thụ', 3500),
('DV02', N'Nước sinh hoạt', 15000);

INSERT INTO SuDungDichVu(MaDV, MaPhong, ThangNam, ChiSoDau, ChiSoCuoi, TieuThu, ThanhTien, DaThanhToan) VALUES
('DV01', 'P101', '08/2026', 1000, 1500, 500, 1750000, 1),
('DV02', 'P101', '08/2026', 50, 70, 20, 300000, 1);

INSERT INTO NhanVien(MaNV, MaPhong, HoTen, ChucVu, CongTy) VALUES
('NV001', 'P101', N'Nguyễn Văn A', N'Trưởng phòng', N'Công ty CP Phần mềm Sài Gòn'),
('NV002', 'P101', N'Trần Thị B', N'Nhân viên', N'Công ty CP Phần mềm Sài Gòn');

INSERT INTO TheGiuXe(MaThe, MaNV, BienSoXe, LoaiXe) VALUES
('TX-1001', 'NV001', '59P1-123.45', N'Xe máy Honda AirBlade'),
('TX-1002', 'NV002', '59X2-987.65', N'Xe máy Yamaha Vision');

INSERT INTO KiemTraDinhKy(MaKT, MaPhong, NgayKiemTra, BienBanViPham, TienPhat) VALUES
('KT-2026-01', 'P101', '2026-10-15', N'Tự ý thay đổi kết cấu vách ngăn', 5000000);
GO

PRINT N'==== KHỞI TẠO CSDL QUẢN LÝ CAO ỐC VĂN PHÒNG THÀNH CÔNG ====';