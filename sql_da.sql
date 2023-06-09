USE [Đồ_Án_1_Test_2]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 5/30/2023 10:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[MaDN] [char](10) NOT NULL,
	[TenDN] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](10) NOT NULL,
	[Quyen] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaSach] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[MaSach] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
	[GiaBan] [float] NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](20) NULL,
	[SDT] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](20) NULL,
	[GT] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](20) NULL,
	[SDT] [char](10) NULL,
	[Email] [nvarchar](30) NULL,
	[Anh] [varbinary](max) NULL,
 CONSTRAINT [PK__tblNhanV__2725D70AE2774C9C] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNXB]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNXB](
	[MaNXB] [char](10) NOT NULL,
	[TenNXB] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
 CONSTRAINT [PK__tblNXB__3A19482C56DD5FCF] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[MaTL] [char](20) NULL,
	[MaNXB] [char](10) NULL,
	[MaTG] [char](10) NULL,
	[SLTon] [int] NULL,
	[GiaBan] [float] NULL,
 CONSTRAINT [PK__tblSach__B235742DEAACF41E] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[MaTG] [char](10) NOT NULL,
	[TenTG] [nvarchar](20) NULL,
	[SDT] [varchar](50) NULL,
 CONSTRAINT [PK__tblTacGi__27250074589C2AD2] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[MaTL] [char](20) NOT NULL,
	[TenTL] [nvarchar](20) NULL,
 CONSTRAINT [PK__tblTheLo__27250071AE3C8E57] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__tblChiTie__MaSac__3F466844] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK__tblChiTie__MaSac__3F466844]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__tblChiTiet__MaHD__38996AB5] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHoaDon] ([MaHD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK__tblChiTiet__MaHD__38996AB5]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__tblChiTie__MaSac__37A5467C] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK__tblChiTie__MaSac__37A5467C]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__tblChiTiet__MaPN__3A81B327] FOREIGN KEY([MaPN])
REFERENCES [dbo].[tblPhieuNhap] ([MaPN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK__tblChiTiet__MaPN__3A81B327]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__tblHoaDon__MaNV__3B75D760] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK__tblHoaDon__MaNV__3B75D760]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK__tblSach__MaNXB__32E0915F] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[tblNXB] ([MaNXB])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK__tblSach__MaNXB__32E0915F]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK__tblSach__MaTG__33D4B598] FOREIGN KEY([MaTG])
REFERENCES [dbo].[tblTacGia] ([MaTG])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK__tblSach__MaTG__33D4B598]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK__tblSach__MaTL__31EC6D26] FOREIGN KEY([MaTL])
REFERENCES [dbo].[tblTheLoai] ([MaTL])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK__tblSach__MaTL__31EC6D26]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD CHECK  (([Quyen]=N'Nhân viên' OR [Quyen]=N'Quản lý'))
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [CK__tblNhanVi__Email__25869641] CHECK  (([Email] like '%@gmail.com'))
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [CK__tblNhanVi__Email__25869641]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [CK__tblNhanVien__GT__24927208] CHECK  (([GT]=N'Nữ' OR [GT]=N'Nam'))
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [CK__tblNhanVien__GT__24927208]
GO
Insert into DangNhap(MaDN,TenDN,MatKhau,Quyen)
values ('DN01',N'Ngô Văn Đức','123',N'Quản lý')
/****** Object:  StoredProcedure [dbo].[CheckMaNV]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckMaNV]
  @manv VARCHAR(10)
AS
BEGIN
DECLARE @Result int
    
    SELECT @Result = COUNT(*) FROM tblNhanVien WHERE MaNV = @manv
    
    IF @Result > 0
        SELECT 'Mã nhân viên bị trùng!' as Result
    
 END
GO
/****** Object:  StoredProcedure [dbo].[ChekTaiKhoan]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChekTaiKhoan]
 @madn char(10),
 @quyen nvarchar(10)
as 
begin
    Select MaDN, Quyen from DangNhap where MaDN =@madn and Quyen = @quyen
end
GO
/****** Object:  StoredProcedure [dbo].[LayDSKhachHang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy danh sách khách hàng
CREATE PROCEDURE [dbo].[LayDSKhachHang]
AS
BEGIN
    SELECT * FROM tblKhachHang
END

GO
/****** Object:  StoredProcedure [dbo].[LayDSNhanVienVer2]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayDSNhanVienVer2]
AS
BEGIN
    SELECT MaNV, TenNV,GT, DiaChi,SDT,Email,Anh ,FORMAT(NgaySinh, 'dd/MM/yyyy') AS FormattedBirthDate
    FROM tblNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[LayDsSach]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayDsSach]
AS
BEGIN
    SELECT s.MaSach, s.TenSach, tg.TenTG, tl.TenTL, nxb.TenNXB, s.SLTon, s.GiaBan
    FROM tblSach as s 
    inner join tblTacGia as tg ON s.MaTG = tg.MaTG
	inner join tblTheLoai as tl on s.MaTL = s.MaTL
	inner join tblNXB as nxb on nxb.MaNXB = nxb.MaNXB
END
GO
/****** Object:  StoredProcedure [dbo].[LayNXB]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayNXB]
AS
BEGIN
    SELECT * FROM tblNXB
END
GO
/****** Object:  StoredProcedure [dbo].[LayTacGia]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayTacGia]
AS
BEGIN
    SELECT * FROM tblNXB
END
GO
/****** Object:  StoredProcedure [dbo].[LayTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayTheLoai]
AS
BEGIN
    SELECT * FROM tblTheLoai
END
GO
/****** Object:  StoredProcedure [dbo].[PrintHoaDon]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintHoaDon]
    @mahd char(10)
AS
BEGIN
    SELECT
       h.MaHD, h.NgayLap, s.TenSach, ct.SoLuong, s.GiaBan,ct.ThanhTien, h.TongTien
    FROM
        tblHoaDon h
        INNER JOIN tblChiTietHoaDon ct ON h.MaHD = ct.MaHD
        INNER JOIN tblSach s ON ct.MaSach = s.MaSach
    WHERE
        h.MaHD = @mahd
END
GO
/****** Object:  StoredProcedure [dbo].[SearchNgayLap]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchNgayLap]
    @ngaylap DATE
AS
BEGIN
    SELECT *
    FROM tblHoaDon
    WHERE CAST(NgayLap AS DATE) = @ngaylap
END
GO
/****** Object:  StoredProcedure [dbo].[SuaDanhSachTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaDanhSachTheLoai]
    @matl char(10),
    @tentl NVARCHAR(20)
AS
BEGIN
    UPDATE tblTheLoai
    SET TenTL = @tentl
    WHERE MaTL = @matl
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaKhachHang]
    @makh char(10),
    @tenkh NVARCHAR(20),
	@sdt varchar(50)
AS
BEGIN
    UPDATE tblKhachHang
    SET TenKH = @tenkh ,
	SDT = @sdt
    WHERE MaKH = @makh
END

GO
/****** Object:  StoredProcedure [dbo].[SuaNVVer3]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaNVVer3]
    @manv char(10),
    @tennv NVARCHAR(20),
    @ngaysinh DATETIME,
	@gt nvarchar(3),
	@diachi nvarchar(30),
	@sdt char(10),
	@email nvarchar(50),
	@anh varbinary(max)
AS
BEGIN
    UPDATE tblNhanVien
    SET TenNV = @tennv,
	    GT = @gt,
        NgaySinh = @ngaysinh,
		DiaChi = @diachi,
		SDT = @sdt,
		Email = @email,
		Anh = @anh
    WHERE MaNV = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNXB]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaNXB]
    @manxb char(10),
    @tennxb nvarchar(20),
	@diachi nvarchar(50),
	@sdt varchar(50)
AS
BEGIN
    UPDATE tblNXB
    SET TenNXB = @tennxb ,
	DiaChi =@diachi,
	SDT = @sdt
    WHERE MaNXB = @manxb
END
GO
/****** Object:  StoredProcedure [dbo].[SuaSach]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaSach]
    @masach char(10),
    @tensach nvarchar(20),
	@matl char(10),
	@manxb char(10),
	@matg char(10),
	@slt int,
	@giaban float
AS
BEGIN
    UPDATE tblSach
    SET TenSach = @tensach ,
	MaTL = @matl,
	MaNXB = @manxb,
	MaTG = @matg,
	SLTon = @slt,
	GiaBan = @giaban
    WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[SuaTacGia]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaTacGia]
    @matg char(10),
    @tentg NVARCHAR(20),
	@sdt varchar(50)
AS
BEGIN
    UPDATE tblTacGia
    SET TenTG = @tentg ,
	SDT = @sdt
    WHERE MaTG = @matg
END
GO
/****** Object:  StoredProcedure [dbo].[ThemCTHoaDon]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ThemCTHoaDon]
    @mahd char(10),
    @masach char(10),
    @soluong INT,
	@thanhtien FLOAT
AS
BEGIN
    DECLARE @GiaSanPham FLOAT
	SELECT @GiaSanPham = GiaBan FROM tblSach WHERE MaSach = @masach
	


	IF EXISTS (
        SELECT 1 FROM tblChiTietHoaDon WHERE MaHD = @mahd AND MaSach = @masach)
		BEGIN

		UPDATE tblChiTietHoaDon set SoLuong=SoLuong + @soluong ,ThanhTien = ThanhTien+ @GiaSanPham * @soluong

		-- Cập nhật số lượng sách
		UPDATE tblSach SET SLTon = SLTon - @soluong WHERE MaSach = @masach
    
		-- Cập nhật tổng tiền trong bảng tblHoaDon
		UPDATE tblHoaDon SET TongTien = TongTien + (@GiaSanPham * @SoLuong) WHERE MaHD = @mahd
		

		END
    ELSE
		BEGIN
		-- Thêm dữ liệu vào bảng tblChiTietHoaDon
		INSERT INTO tblChiTietHoaDon(MaHD, MaSach, SoLuong,ThanhTien )
		VALUES(@mahd, @masach, @SoLuong, @GiaSanPham * @SoLuong)
    
		-- Cập nhật số lượng trong bảng sách
		UPDATE tblSach SET SLTon = SLTon - @SoLuong WHERE MaSach = @masach
    
		-- Cập nhật tổng tiền trong bảng tblHoaDon
		UPDATE tblHoaDon SET TongTien = TongTien + (@GiaSanPham * @SoLuong) WHERE MaHD = @mahd
		END


END
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm khách hàng
CREATE PROCEDURE [dbo].[ThemKhachHang]
    @makh char(10),
    @tenkh nvarchar(20),
	@sdt varchar(50)
AS
BEGIN
    INSERT INTO tblKhachHang(MaKH,TenKH,SDT)
    VALUES (@makh, @tenkh,@sdt)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemNV]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNV]
    @manv char(10),
    @tennv nvarchar(20),
	@gt nvarchar(3),
	@ngaysinh date,
	@diachi nvarchar(50),
	@sdt char(10),
	@email nvarchar(30),
	@anh varbinary(max)
AS
BEGIN
    INSERT INTO tblNhanVien (MaNV,TenNV,GT,NgaySinh,DiaChi,SDT,Email,Anh)
    VALUES (@manv,@tennv, @gt,@ngaysinh,@diachi, @sdt, @email, @anh)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemNXB]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNXB]
    @manxb char(10),
    @tennxb nvarchar(20),
	@diachi nvarchar(50),
	@sdt varchar(50)
AS
BEGIN
    INSERT INTO tblNXB(MaNXB,TenNXB,DiaChi,SDT)
    VALUES (@manxb, @tennxb,@diachi,@sdt)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuTTPhieuNhap]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemPhieuTTPhieuNhap]
    @mapn char(10),
    @masach char(10),
    @soluong INT,
    @gianhap FLOAT,
	@giaban FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SoLuongCu INT, @TongTienCu FLOAT, @TongTienMoi FLOAT;
    IF EXISTS (
        SELECT 1 FROM tblChiTietPhieuNhap WHERE MaPN = @mapn AND MaSach = @masach
    )
    BEGIN
        SELECT @SoLuongCu = SoLuong , @TongTienCu = SoLuong * GiaNhap
        FROM tblChiTietPhieuNhap
        WHERE MaPN = @mapn AND MaSach = @masach;

        UPDATE tblSach SET SLTon = SLTon + @soluong, GiaBan = @giaban
        WHERE MaSach = @masach;

        SELECT @TongTienMoi = @soluong * @gianhap;

        UPDATE tblChiTietPhieuNhap SET SoLuong = @soluong, GiaNhap = @gianhap, GiaBan = @giaban
        WHERE MaPN = @mapn AND MaSach = @masach;

        UPDATE tblPhieuNhap SET TongTien = TongTien - @TongTienCu + @TongTienMoi
        WHERE MaPN = @mapn;
    END
    ELSE
    BEGIN
        INSERT INTO tblChiTietPhieuNhap(MaPN, MaSach, SoLuong, GiaNhap,GiaBan)
        VALUES (@mapn, @masach, @soluong, @gianhap,@giaban);

        UPDATE tblSach SET SLTon = SLTon + @soluong, GiaBan = @giaban
        WHERE MaSach = @masach;

        SELECT @TongTienMoi = @soluong * @gianhap;

        UPDATE tblPhieuNhap SET TongTien = TongTien + @TongTienMoi
        WHERE MaPN = @mapn;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemSach]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemSach]
    @masach char(10),
    @tensach nvarchar(20),
	@matl char(10),
	@manxb char(10),
	@matg char(10),
	@slt int,
	@giaban float
AS
BEGIN
    INSERT INTO tblSach(MaSach, TenSach,MaTL,MaNXB,MaTG,SLTon,GiaBan)
    VALUES (@masach,@tensach,@matl,@manxb,@matg,@slt,@giaban)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemTacGia]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemTacGia]
    @matg char(10),
    @tentg nvarchar(20),
	@sdt varchar(50)
AS
BEGIN
    INSERT INTO tblTacGia(MaTG, TenTG,SDT)
    VALUES (@matg, @tentg,@sdt)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemTheLoai]
    @matl char(10),
    @tentl nvarchar(20)
AS
BEGIN
    INSERT INTO tblTheLoai(MaTL, TenTL)
    VALUES (@matl, @tentl)
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeHoaDonTheoThang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKeHoaDonTheoThang]
    @ngaystart DATETIME,
    @ngayend DATETIME
AS
BEGIN
    SELECT DATEPART(MONTH, H.NgayLap) AS Thang,SUM(CT.ThanhTien) AS TongTien
    FROM tblHoaDon AS H INNER JOIN tblChiTietHoaDon AS CT ON H.MaHD = CT.MaHD
    WHERE H.NgayLap BETWEEN @ngaystart AND @ngayend
    GROUP BY DATEPART(MONTH, H.NgayLap)
    ORDER BY DATEPART(MONTH, H.NgayLap)
        
   
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTheoTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ThongKeTheoTheLoai]
    @ngaystart DATETIME,
    @ngayend DATETIME
AS
BEGIN
   SELECT 
    DATEPART(MONTH, H.NgayLap) AS Thang, TL.TenTL as [Tên_thể_Loại], S.TenSach as [Tên_Sách], SUM(CT.SoLuong) AS TongSoLuong, SUM(ct.ThanhTien) AS TongDoanhThu
    FROM tblHoaDon AS H 
	INNER JOIN tblChiTietHoaDon AS CT ON H.MaHD = CT.MaHD 
	INNER JOIN tblSach AS S ON CT.MaSach = S.MaSach 
    INNER JOIN tblTheLoai AS TL ON TL.MaTL = S.MaTL
    WHERE H.NgayLap BETWEEN @ngaystart AND @ngayend
    GROUP BY DATEPART(MONTH, H.NgayLap), TL.TenTL,S.TenSach
    ORDER BY DATEPART(MONTH, H.NgayLap), TL.TenTL,S.TenSach
   
END
GO
/****** Object:  StoredProcedure [dbo].[XoaChiTietHoaDonNhap]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[XoaChiTietHoaDonNhap]
(
    @MaHoaDon char(10),
    @MaSanPham char(10)
)
AS
BEGIN
    -- Tìm số lượng sản phẩm trong chi tiết hóa đơn nhập cần xóa
    DECLARE @SoLuong INT
    SELECT @SoLuong = SoLuong
    FROM tblChiTietPhieuNhap
    WHERE MaPN = @MaHoaDon AND MaSach = @MaSanPham
    
    -- Cập nhật lại số lượng sản phẩm trong bảng xe
    UPDATE tblSach
    SET SLTon = SLTon - @SoLuong
    WHERE MaSach = @MaSanPham
    
    -- Tìm giá sản phẩm trong chi tiết hóa đơn nhập cần xóa
    DECLARE @GiaSanPham FLOAT
    SELECT @GiaSanPham = GiaNhap
    FROM tblChiTietPhieuNhap
    WHERE MaPN = @MaHoaDon AND MaSach = @MaSanPham
    
    -- Cập nhật lại tổng tiền của hóa đơn nhập
    UPDATE tblPhieuNhap
    SET TongTien = TongTien - @SoLuong * @GiaSanPham
    WHERE MaPN = @MaHoaDon
     
    -- Xóa chi tiết hóa đơn nhập
    DELETE FROM tblChiTietPhieuNhap WHERE MaPN = @MaHoaDon AND MaSach = @MaSanPham
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCTHoaDon]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaCTHoaDon]
(
    @MaHoaDon char(10),
    @MaSach char(10)
)
AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @SoLuong INT ,@GiaSanPham Float

	-- Thêm dữ liệu vào bảng tblChiTietHoaDon
		select @SoLuong=SoLuong ,@GiaSanPham=ThanhTien FROM tblChiTietHoaDon WHERE MaHD = @MaHoaDon AND MaSach = @MaSach
    
		-- Cập nhật số lượng trong bảng sách
		UPDATE tblSach SET SLTon = SLTon + @SoLuong WHERE MaSach = @MaSach
    
		-- Cập nhật tổng tiền trong bảng tblHoaDon
		UPDATE tblHoaDon SET TongTien = TongTien - @GiaSanPham WHERE MaHD = @MaHoaDon
		DELETE FROM tblChiTietHoaDon WHERE MaHD = @MaHoaDon AND MaSach = @MaSach
		
END

GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Xóa khách hàng
CREATE PROCEDURE [dbo].[XoaKhachHang]
    @makh char(10)
AS
BEGIN
    DELETE FROM tblKhachHang
    WHERE MaKH = @makh
END

GO
/****** Object:  StoredProcedure [dbo].[XoaNV]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaNV]
    @manv char(10)
AS
BEGIN
    DELETE FROM tblNhanVien
    WHERE MaNV =@manv
END

GO
/****** Object:  StoredProcedure [dbo].[XoaNXB]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaNXB]
    @manxb char(10)
AS
BEGIN
    DELETE FROM tblNXB
    WHERE MaNXB = @manxb
END
GO
/****** Object:  StoredProcedure [dbo].[XoaSach]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaSach]
    @masach char(10)
AS
BEGIN
    DELETE FROM tblSach
    WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTacGia]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaTacGia]
    @matg char(10)
AS
BEGIN
    DELETE FROM tblTacGia
    WHERE MaTG = @matg
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTheLoai]    Script Date: 5/30/2023 10:29:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaTheLoai]
    @matl char(10)
AS
BEGIN
    DELETE FROM tblTheLoai
    WHERE MaTL = @matl
END
GO
