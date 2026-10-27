CREATE DATABASE QuanLyNhanSuDB;
GO

USE QuanLyNhanSuDB;
GO

CREATE TABLE PhongBan (
    MaPB varchar(20) PRIMARY KEY,
    TenPhongBan nvarchar(100) NOT NULL
);
GO

CREATE TABLE PhieuPhuTroi (
    SoPhieuPT varchar(20) PRIMARY KEY,
    NgayPhuTroi date NOT NULL,
    HinhThuc nvarchar(50) NOT NULL
);
GO

CREATE TABLE NhanVien (
    MaNV varchar(20) PRIMARY KEY,
    MaPB varchar(20) NOT NULL,
    HoTen nvarchar(100) NOT NULL,
    DiaChi nvarchar(250) NULL,
    DienThoai varchar(20) NULL,
    NgayVaoLam date NOT NULL,
    CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB)
);
GO

CREATE TABLE QuyetDinhTuyenDung (
    SoQDTD varchar(20) PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    NgayBatDau date NOT NULL,
    NgayKetThuc date NOT NULL,
    LuongThuViec decimal(18,2) NOT NULL,
    CONSTRAINT FK_QDTD_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE HopDong (
    SoHD varchar(20) PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    LoaiHD nvarchar(50) NOT NULL,
    NgayKy date NOT NULL,
    TrangThai nvarchar(50) NOT NULL,
    ThoiHan int NULL,
    CONSTRAINT FK_HopDong_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE BangChamCong (
    MaBCC varchar(20) PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    Thang int NOT NULL,
    Nam int NOT NULL,
    TongGioLam decimal(5,2) NOT NULL,
    CONSTRAINT FK_BangChamCong_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE QDKhenThuongKyLuat (
    SoQDKTKL varchar(20) PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    LoaiQD nvarchar(20) NOT NULL,
    SoTien decimal(18,2) NOT NULL,
    NgayKy date NOT NULL,
    CONSTRAINT FK_QDKTKL_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE BangLuong (
    MaBL varchar(20) PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    Thang int NOT NULL,
    Nam int NOT NULL,
    TongThuNhap decimal(18,2) NOT NULL,
    TongKhauTru decimal(18,2) NOT NULL,
    ThucLanh decimal(18,2) NOT NULL,
    CONSTRAINT FK_BangLuong_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE HoSoBaoHiem (
    SoBH varchar(20) PRIMARY KEY,
    SoHD varchar(20) NOT NULL,
    LoaiBH nvarchar(50) NOT NULL,
    MucDong decimal(18,2) NOT NULL,
    CONSTRAINT FK_HoSoBaoHiem_HopDong FOREIGN KEY (SoHD) REFERENCES HopDong(SoHD)
);
GO

CREATE TABLE ChiTietPhuTroi (
    SoPhieuPT varchar(20) NOT NULL,
    MaNV varchar(20) NOT NULL,
    SoGio decimal(5,2) NOT NULL,
    PRIMARY KEY (SoPhieuPT, MaNV),
    CONSTRAINT FK_CTPT_PhieuPhuTroi FOREIGN KEY (SoPhieuPT) REFERENCES PhieuPhuTroi(SoPhieuPT),
    CONSTRAINT FK_CTPT_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE PhieuThuChi (
    SoPhieuTC varchar(20) PRIMARY KEY,
    SoQDKTKL varchar(20) NOT NULL,
    LoaiPhieu nvarchar(20) NOT NULL,
    SoTien decimal(18,2) NOT NULL,
    NgayLap date NOT NULL,
    CONSTRAINT FK_PhieuThuChi_QDKTKL FOREIGN KEY (SoQDKTKL) REFERENCES QDKhenThuongKyLuat(SoQDKTKL)
);
GO


INSERT INTO PhongBan (MaPB, TenPhongBan) VALUES 
('BGD', N'Ban Giám đốc'),
('P_NS', N'Phòng Hành chính - Nhân sự'),
('P_KT', N'Phòng Kế toán - Tài chính'),
('PX_SN', N'Phân xưởng Sơn nước');
GO

INSERT INTO PhieuPhuTroi (SoPhieuPT, NgayPhuTroi, HinhThuc) VALUES 
('PT_202609_01', '2026-09-02', N'Trực lễ Quốc Khánh'),
('PT_202609_02', '2026-09-15', N'Tăng ca tối');
GO

INSERT INTO NhanVien (MaNV, MaPB, HoTen, DiaChi, DienThoai, NgayVaoLam) VALUES 
('NV001', 'BGD', N'Nguyễn Hoàng Cường', N'Quận 7, TP.HCM', '0901234567', '2020-05-01'),
('NV002', 'P_NS', N'Trần Thị Bích Ngọc', N'Bình Thạnh, TP.HCM', '0912345678', '2022-08-15'),
('NV003', 'PX_SN', N'Lê Minh Tuấn', N'Quận 12, TP.HCM', '0987654321', '2025-02-10'),
('NV004', 'P_KT', N'Phạm Văn Hùng', N'Thành phố Thủ Đức', '0933445566', '2026-09-01');
GO

INSERT INTO QuyetDinhTuyenDung (SoQDTD, MaNV, NgayBatDau, NgayKetThuc, LuongThuViec) VALUES 
('QD_2609_01', 'NV004', '2026-09-01', '2026-10-31', 8500000.00);
GO

INSERT INTO HopDong (SoHD, MaNV, LoaiHD, NgayKy, TrangThai, ThoiHan) VALUES 
('HD_001', 'NV001', N'Dài hạn', '2020-07-01', N'Đang hiệu lực', NULL),
('HD_002', 'NV002', N'Dài hạn', '2022-10-15', N'Đang hiệu lực', NULL),
('HD_003', 'NV003', N'Ngắn hạn', '2025-02-10', N'Đang hiệu lực', 12);
GO

INSERT INTO HoSoBaoHiem (SoBH, SoHD, LoaiBH, MucDong) VALUES 
('BHXH_001', 'HD_001', N'BHXH, BHYT, BHTN', 2500000.00),
('BHXH_002', 'HD_002', N'BHXH, BHYT, BHTN', 1250000.00);
GO

INSERT INTO BangChamCong (MaBCC, MaNV, Thang, Nam, TongGioLam) VALUES 
('BCC_2609_01', 'NV001', 9, 2026, 208.00),
('BCC_2609_02', 'NV002', 9, 2026, 200.00),
('BCC_2609_03', 'NV003', 9, 2026, 208.00),
('BCC_2609_04', 'NV004', 9, 2026, 208.00);
GO

INSERT INTO ChiTietPhuTroi (SoPhieuPT, MaNV, SoGio) VALUES 
('PT_202609_01', 'NV002', 8.00),
('PT_202609_02', 'NV003', 12.00);
GO

INSERT INTO QDKhenThuongKyLuat (SoQDKTKL, MaNV, LoaiQD, SoTien, NgayKy) VALUES 
('KT_2609_01', 'NV002', N'Khen thưởng', 1000000.00, '2026-09-25'),
('KL_2609_01', 'NV003', N'Kỷ luật', 200000.00, '2026-09-28');
GO

INSERT INTO PhieuThuChi (SoPhieuTC, SoQDKTKL, LoaiPhieu, SoTien, NgayLap) VALUES 
('PC_2609_01', 'KT_2609_01', N'Chi', 1000000.00, '2026-09-30'),
('PT_2609_01', 'KL_2609_01', N'Thu', 200000.00, '2026-09-30');
GO

INSERT INTO BangLuong (MaBL, MaNV, Thang, Nam, TongThuNhap, TongKhauTru, ThucLanh) VALUES 
('BL_2609_01', 'NV001', 9, 2026, 45000000.00, 2500000.00, 42500000.00),
('BL_2609_02', 'NV002', 9, 2026, 16000000.00, 1250000.00, 14750000.00),
('BL_2609_03', 'NV003', 9, 2026, 14500000.00, 200000.00, 14300000.00),
('BL_2609_04', 'NV004', 9, 2026, 8500000.00, 0.00, 8500000.00);
GO