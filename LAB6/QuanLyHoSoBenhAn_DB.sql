
IF DB_ID(N'QuanLyHoSoBenhAn_DB') IS NULL CREATE DATABASE QuanLyHoSoBenhAn_DB;
GO
USE QuanLyHoSoBenhAn_DB;
GO

IF OBJECT_ID('XetNghiem','U') IS NOT NULL DROP TABLE XetNghiem;
IF OBJECT_ID('ToaThuoc','U') IS NOT NULL DROP TABLE ToaThuoc;
IF OBJECT_ID('PhieuKhamBenh','U') IS NOT NULL DROP TABLE PhieuKhamBenh;
IF OBJECT_ID('LichHen','U') IS NOT NULL DROP TABLE LichHen;
IF OBJECT_ID('HoSoBenhAn','U') IS NOT NULL DROP TABLE HoSoBenhAn;
IF OBJECT_ID('PhieuDangKy','U') IS NOT NULL DROP TABLE PhieuDangKy;
IF OBJECT_ID('BenhNhan','U') IS NOT NULL DROP TABLE BenhNhan;
IF OBJECT_ID('BacSi','U') IS NOT NULL DROP TABLE BacSi;
IF OBJECT_ID('KhoaDieuTri','U') IS NOT NULL DROP TABLE KhoaDieuTri;
GO

CREATE TABLE KhoaDieuTri(
    MaKhoa VARCHAR(20) NOT NULL PRIMARY KEY,
    TenKhoa NVARCHAR(150) NOT NULL UNIQUE
);

CREATE TABLE BacSi(
    MaBS VARCHAR(20) NOT NULL PRIMARY KEY,
    TenBS NVARCHAR(120) NOT NULL,
    MaKhoa VARCHAR(20) NOT NULL,
    CONSTRAINT FK_BacSi_Khoa FOREIGN KEY(MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);

CREATE TABLE BenhNhan(
    MaBN VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(120) NOT NULL,
    DiaChi NVARCHAR(250) NULL,
    NgaySinh DATE NULL,
    DienThoai VARCHAR(20) NOT NULL UNIQUE, -- Không cho phép 2 bệnh nhân trùng số điện thoại
    Anh3x4 VARBINARY(MAX) NULL
);

CREATE TABLE PhieuDangKy(
    MaPhieuDK VARCHAR(20) NOT NULL PRIMARY KEY,
    MaBN VARCHAR(20) NOT NULL,
    NgayDangKy DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    TrangThaiLePhi BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_PDK_BN FOREIGN KEY(MaBN) REFERENCES BenhNhan(MaBN)
);

CREATE UNIQUE INDEX UX_PDK_BN ON PhieuDangKy(MaBN);

CREATE TABLE HoSoBenhAn(
    MaHoSo VARCHAR(20) NOT NULL PRIMARY KEY,
    MaBN VARCHAR(20) NOT NULL,
    NgayLap DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT FK_HS_BN FOREIGN KEY(MaBN) REFERENCES BenhNhan(MaBN)
);

CREATE UNIQUE INDEX UX_HS_BN ON HoSoBenhAn(MaBN);

CREATE TABLE LichHen(
    MaLichHen VARCHAR(20) NOT NULL PRIMARY KEY,
    MaBN VARCHAR(20) NOT NULL,
    NgayGioHen DATETIME2 NOT NULL,
    TrangThai NVARCHAR(40) DEFAULT N'Chưa khám',
    CONSTRAINT FK_LH_BN FOREIGN KEY(MaBN) REFERENCES BenhNhan(MaBN)
);

CREATE TABLE PhieuKhamBenh(
    MaPhieuKham VARCHAR(20) NOT NULL PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    MaBS VARCHAR(20) NOT NULL,
    MaKhoa VARCHAR(20) NOT NULL,
    NgayGioKham DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    TrieuChung NVARCHAR(1000) NULL,
    CONSTRAINT FK_PK_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_PK_BacSi FOREIGN KEY(MaBS) REFERENCES BacSi(MaBS),
    CONSTRAINT FK_PK_Khoa FOREIGN KEY(MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);

CREATE TABLE ToaThuoc(
    MaToa VARCHAR(20) NOT NULL PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL,
    ChiTietThuoc NVARCHAR(MAX) NOT NULL,
    CachDung NVARCHAR(500) NULL,
    CONSTRAINT FK_Toa_PK FOREIGN KEY(MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham)
);

CREATE UNIQUE INDEX UX_Toa_PhieuKham ON ToaThuoc(MaPhieuKham);

CREATE TABLE XetNghiem(
    MaXetNghiem VARCHAR(20) NOT NULL PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL,
    TenLoaiXetNghiem NVARCHAR(150) NOT NULL,
    KetQua NVARCHAR(MAX) NULL,
    CONSTRAINT FK_XN_PK FOREIGN KEY(MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham)
);
GO


CREATE PROCEDURE sp_DangKyBenhNhanMoi
    @MaBN VARCHAR(20),
    @HoTen NVARCHAR(120),
    @DiaChi NVARCHAR(250),
    @NgaySinh DATE,
    @DienThoai VARCHAR(20),
    @MaPhieuDK VARCHAR(20),
    @MaHoSo VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

            INSERT INTO BenhNhan(MaBN, HoTen, DiaChi, NgaySinh, DienThoai) 
            VALUES(@MaBN, @HoTen, @DiaChi, @NgaySinh, @DienThoai);


            INSERT INTO PhieuDangKy(MaPhieuDK, MaBN, TrangThaiLePhi) 
            VALUES(@MaPhieuDK, @MaBN, 1);

            INSERT INTO HoSoBenhAn(MaHoSo, MaBN) 
            VALUES(@MaHoSo, @MaBN);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END;
GO

CREATE PROCEDURE sp_LuuKhamBenhVaToaThuoc
    @MaPhieuKham VARCHAR(20),
    @MaHoSo VARCHAR(20),
    @MaBS VARCHAR(20),
    @MaKhoa VARCHAR(20),
    @TrieuChung NVARCHAR(1000),
    @MaToa VARCHAR(20) = NULL,
    @ChiTietThuoc NVARCHAR(MAX) = NULL,
    @CachDung NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
            INSERT INTO PhieuKhamBenh(MaPhieuKham, MaHoSo, MaBS, MaKhoa, TrieuChung)
            VALUES(@MaPhieuKham, @MaHoSo, @MaBS, @MaKhoa, @TrieuChung);

            IF (@MaToa IS NOT NULL AND @ChiTietThuoc IS NOT NULL)
            BEGIN
                INSERT INTO ToaThuoc(MaToa, MaPhieuKham, ChiTietThuoc, CachDung)
                VALUES(@MaToa, @MaPhieuKham, @ChiTietThuoc, @CachDung);
            END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END;
GO

INSERT INTO KhoaDieuTri(MaKhoa, TenKhoa) VALUES
('K01', N'Khoa Nội Tổng Hợp'),
('K02', N'Khoa Ngoại Thần Kinh'),
('K03', N'Khoa Tim Mạch'),
('K04', N'Khoa Nhi');

INSERT INTO BacSi(MaBS, TenBS, MaKhoa) VALUES
('BS01', N'BS.CKII Trần Văn An', 'K01'),
('BS02', N'BS. Nguyễn Thị Bình', 'K03'),
('BS03', N'BS. Lê Khắc Dũng', 'K02'),
('BS04', N'BS. Phạm Quỳnh Hoa', 'K04');

-- 5.2. Chạy Transaction để thêm Bệnh nhân 1
EXEC sp_DangKyBenhNhanMoi 
    @MaBN = 'BN001', @HoTen = N'Phạm Minh Tuấn', @DiaChi = N'Quận 1, TP.HCM', 
    @NgaySinh = '1985-06-15', @DienThoai = '0901234567', 
    @MaPhieuDK = 'PDK001', @MaHoSo = 'HS001';

-- 5.3. Chạy Transaction để thêm Bệnh nhân 2
EXEC sp_DangKyBenhNhanMoi 
    @MaBN = 'BN002', @HoTen = N'Hoàng Thu Thủy', @DiaChi = N'Quận 7, TP.HCM', 
    @NgaySinh = '1992-11-20', @DienThoai = '0987654321', 
    @MaPhieuDK = 'PDK002', @MaHoSo = 'HS002';

-- 5.4. Đặt Lịch Hẹn khám định kỳ
INSERT INTO LichHen(MaLichHen, MaBN, NgayGioHen, TrangThai) VALUES
('LH001', 'BN001', '2026-12-05 08:30:00', N'Đã xác nhận'),
('LH002', 'BN002', '2026-12-10 14:00:00', N'Chưa khám');

-- 5.5. Chạy Transaction Khám bệnh & Lập toa cho Bệnh nhân 1 (BN001 bị Tim mạch)
EXEC sp_LuuKhamBenhVaToaThuoc 
    @MaPhieuKham = 'PK001', @MaHoSo = 'HS001', @MaBS = 'BS02', @MaKhoa = 'K03',
    @TrieuChung = N'Bệnh nhân khai tức ngực trái, khó thở khi gắng sức, huyết áp 150/95 mmHg.',
    @MaToa = 'TOA001', 
    @ChiTietThuoc = N'- Amlodipine 5mg (30 viên)
- Aspirin 81mg (30 viên)', 
    @CachDung = N'Mỗi loại uống 1 viên vào buổi sáng sau khi ăn no.';

-- 5.6. Chạy Transaction Khám bệnh cho Bệnh nhân 2 (Chỉ khám Nội, Không kê toa)
EXEC sp_LuuKhamBenhVaToaThuoc 
    @MaPhieuKham = 'PK002', @MaHoSo = 'HS002', @MaBS = 'BS01', @MaKhoa = 'K01',
    @TrieuChung = N'Đau mỏi vai gáy, sốt nhẹ 37.8 độ, có dấu hiệu suy nhược.';

-- 5.7. Thêm kết quả Xét Nghiệm bổ sung cho Phiếu khám của Bệnh nhân 1
INSERT INTO XetNghiem(MaXetNghiem, MaPhieuKham, TenLoaiXetNghiem, KetQua) VALUES
('XN001', 'PK001', N'Đo Điện tâm đồ (ECG)', N'Nhịp xoang nhanh 105 l/p, thiếu máu cơ tim vùng thành trước.'),
('XN002', 'PK001', N'Siêu âm Tim', N'Hở van 2 lá 1/4, chức năng co bóp thất trái (EF) 65%.');
GO

PRINT N'Hoàn tất việc tạo CSDL, Stored Procedure và nạp dữ liệu mẫu!';