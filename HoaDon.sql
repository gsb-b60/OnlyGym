Use GymManagement
go

CREATE DATABASE [GymManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GymManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GymManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GymManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GymManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GymManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GymManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GymManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GymManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GymManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GymManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GymManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [GymManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GymManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GymManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GymManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GymManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GymManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GymManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GymManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GymManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GymManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GymManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GymManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GymManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GymManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GymManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GymManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GymManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GymManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GymManagement] SET  MULTI_USER 
GO
ALTER DATABASE [GymManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GymManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GymManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GymManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GymManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GymManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GymManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [GymManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GymManagement]
GO



Select * from NhomHang
Select * from Hang
Select * from MuaHang
Select * from HoaDon
Select * from CTHD
Select * from DanhSachHoaDon

drop table NhomHang
drop table Hang
drop table MuaHang
drop table HoaDon
drop table CTHD
drop table DanhSachHoaDon

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaMuaHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[NgayBan] [nvarchar](10) NOT NULL,
	[NhanVien] [nvarchar](100) NOT NULL,
	[TongTien] [int] NOT NULL,
	[GiamGia] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[KhachDua] [int] NOT NULL,
	[HinhThuc] [nvarchar](100) NOT NULL,
	[ConLai] [int] NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE CTHD ADD ThanhTien AS (TongTien - (TongTien * GiamGia / 100)) PERSISTED;


drop table CTHD

/****** Object:  Table [dbo].[DanhSachHoaDon]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachHoaDon](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nvarchar](10) NOT NULL,
	[IDHocVien] [nvarchar](10) NOT NULL,
	[NgayTao] [nvarchar](10) NOT NULL,
	[KhachHang] [nvarchar](100) NOT NULL,
	[TongTien] [int] NOT NULL,
	[HinhThuc] [nvarchar](100) NOT NULL,
	[NhanVienLap] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DanhSachHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Hang]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[MaNhom] [nvarchar](10) NOT NULL,
	[TenHang] [nvarchar](100) NOT NULL,
	[DVT] [nvarchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
drop table Hang

/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[NgayBan] [nvarchar](10) NOT NULL,
	[NhanVienLap] [nvarchar](100) NOT NULL,
	[TongTien] [int] NOT NULL,
	[GiamGia] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[KhachDua] [int] NOT NULL,
	[HinhThuc] [nvarchar](100) NOT NULL,
	[ConLai] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuaHang]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuaHang](
	[MaMuaHang] [nvarchar](10) NOT NULL,
	[STT] [int] NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[NhomHang] [nvarchar](100) NOT NULL,
	[TenHang] [nvarchar](100) NOT NULL,
	[DVT] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaMuaHang] ASC,
    [STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNhom] [int] IDENTITY(0,1) NOT NULL,
	[TenNhom] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DanhSachHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[DanhSachHoaDon] CHECK CONSTRAINT [FK_DanhSachHoaDon_HoaDon]
GO


select * from NhomHang

insert into NhomHang (TenNhom) values(N'Tất cả'),
(N'Nước uống và đồ ăn'),
(N'Phụ kiện tập luyện'),
(N'Quần áo');

insert into Hang (MaHang, MaNhom, TenHang, DVT, DonGia) values
('NA0001',1, N'Nước suối 500ml', N'Chai', 10000),
('NA0002',1, N'Nước điện giải', N'Chai', 25000),
('NA0003',1, N'Thanh protein bar', N'Thanh', 45000),
('NA0004',1, N'Sữa tăng cơ (whey 1kg)', N'Hộp', 650000),
('NA0005',1, N'Nước tăng lực', N'Chai', 30000),
('NA0006',1, N'Sinh tố protein', N'Ly', 55000),
('NA0007',1, N'Vitamin tổng hợp', N'Lọ', 220000),
('NA0008',1, N'Bánh yến mạch', N'Gói', 35000),
('NA0009',1, N'Sữa hạnh nhân', N'Hộp', 40000),
('NA0010',1, N'Gel năng lượng', N'Gói', 28000),
 
('PK0001',2, N'Găng tay tập gym', N'Đôi', 90000),
('PK0002',2, N'Dây nhảy thể lực', N'Cái', 70000),
('PK0003',2, N'Thảm tập yoga', N'Cái', 250000),
('PK0004',2, N'Dây kháng lực', N'Bộ', 180000),
('PK0005',2, N'Bóng tập yoga', N'Cái', 150000),
('PK0006',2, N'Bình nước thể thao 1L', N'Cái', 120000),
('PK0007',2, N'Băng quấn cổ tay', N'Đôi', 75000),
('PK0008',2, N'Tạ tay cao su 5kg', N'Cặp', 350000),
('PK0009',2, N'Đai lưng tập tạ', N'Cái', 300000),
('PK0010',2, N'Khăn thể thao', N'Cái', 90000),
 
('QA0001', 3, N'Áo thun tập gym nam', N'Cái', 120000),
('QA0002', 3, N'Quần short gym nữ', N'Cái', 150000),
('QA0003', 3, N'Áo bra thể thao nữ', N'Cái', 180000),
('QA0004', 3, N'Quần legging nữ', N'Cái', 220000),
('QA0005', 3, N'Áo khoác gió tập gym', N'Cái', 350000),
('QA0006', 3, N'Quần jogger nam', N'Cái', 280000),
('QA0007', 3, N'Áo tank top nam', N'Cái', 140000),
('QA0008', 3, N'Bộ đồ thể thao nữ', N'Bộ', 480000),
('QA0009', 3, N'Áo hoodie thể thao nam', N'Cái', 420000),
('QA0010', 3, N'Áo polo tập gym', N'Cái', 260000);


INSERT INTO CTHD (MaHD, MaMuaHang, TenKhachHang, SDT, NgayBan, NhanVien, TongTien, GiamGia, ThanhTien, KhachDua, HinhThuc, ConLai) 
VALUES
('HD120125', 'MH002', N'Nguyễn Văn A', '0987654321', '2025-01-12', N'Lê Thị Mai', 1500000, 5, 1425000, 1425000, N'Tiền mặt', 0),
('HD060125', 'MH001', N'Trần Thị M', '0912345678', '2025-01-06', N'Phạm Hồng Anh', 1950000, 10, 1755000, 1755000, N'Tiền mặt', 0),
('HD050225', 'MH003', N'Trần Thị B', '0971234567', '2025-02-05', N'Nguyễn Văn Bình', 1200000, 0, 1200000, 1200000, N'Chuyển khoản', 0),
('HD170225', 'MH004', N'Lê Văn N', '0903344556', '2025-02-17', N'Vũ Thị Hoa', 2300000, 8, 2116000, 2116000, N'Chuyển khoản', 0),
('HD180325', 'MH005', N'Phạm Văn C', '0912987456', '2025-03-18', N'Phạm Hồng Anh', 1800000, 5, 1710000, 1800000, N'Tiền mặt', 90000),
('HD110325', 'MH006', N'Hoàng Oanh', '0934567890', '2025-03-11', N'Trần Hữu Quang', 1450000, 10, 1305000, 1500000, N'Tiền mặt', 195000),
('HD020425', 'MH007', N'Lê Minh D', '0909123456', '2025-04-02', N'Vũ Thị Hoa', 2000000, 7, 1860000, 1860000, N'Chuyển khoản', 0),
('HD040425', 'MH008', N'Nguyễn Văn P', '0908999333', '2025-04-04', N'Lê Thị Mai', 2500000, 10, 2250000, 2250000, N'Chuyển khoản', 0),
('HD100525', 'MH009', N'Trần Thị Q', '0977665544', '2025-05-10', N'Nguyễn Văn Bình', 1100000, 0, 1100000, 1100000, N'Tiền mặt', 0),
('HD160525', 'MH010', N'Hoàng Thu E', '0967788990', '2025-05-16', N'Trần Hữu Quang', 950000, 5, 902500, 1000000, N'Tiền mặt', 97500),
('HD070625', 'MH011', N'Nguyễn Văn F', '0988111222', '2025-06-07', N'Lê Thị Mai', 2200000, 8, 2024000, 2100000, N'Tiền mặt', 76000),
('HD190625', 'MH012', N'Phạm Văn R', '0911445566', '2025-06-19', N'Phạm Hồng Anh', 2000000, 5, 1900000, 1900000, N'Chuyển khoản', 0),
('HD080725', 'MH013', N'Lê Thị S', '0922334455', '2025-07-08', N'Vũ Thị Hoa', 1750000, 10, 1575000, 1600000, N'Tiền mặt', 250000),
('HD200725', 'MH014', N'Bùi Thị G', '0901239876', '2025-07-20', N'Nguyễn Văn Bình', 1350000, 0, 1350000, 1350000, N'Chuyển khoản', 0),
('HD030825', 'MH015', N'Trịnh Văn H', '0977432112', '2025-08-03', N'Phạm Hồng Anh', 1750000, 5, 1662500, 1662500, N'Tiền mặt', 0),
('HD140825', 'MH016', N'Nguyễn Văn T', '0944556677', '2025-08-14', N'Trần Hữu Quang', 2600000, 10, 2340000, 2340000, N'Chuyển khoản', 0),
('HD150925', 'MH017', N'Ngô Thị I', '0939221122', '2025-09-15', N'Vũ Thị Hoa', 1600000, 5, 1520000, 1520000, N'Chuyển khoản', 0),
('HD101025', 'MH018', N'Vũ Văn J', '0927668899', '2025-10-10', N'Trần Hữu Quang', 2100000, 0, 2100000, 2100000, N'Tiền mặt', 0),
('HD111125', 'MH019', N'Đặng Thị K', '0903459988', '2025-11-11', N'Lê Thị Mai', 1250000, 10, 1125000, 1200000, N'Tiền mặt', 75000),
('HD121225', 'MH020', N'Nguyễn Văn L', '0908877665', '2025-12-12', N'Nguyễn Văn Bình', 1850000, 8, 1702000, 1702000, N'Chuyển khoản', 0);

insert into HoaDon
(MaHD, TenKhachHang, SDT, NgayBan, NhanVienLap, TongTien, GiamGia, ThanhTien, KhachDua, HinhThuc, ConLai) values
('HD060125', N'Trần Thị M', '0911000001', '06/01/2025', N'Phạm Hồng Anh', 1950000, 0, 1950000, 1950000, N'Tiền mặt', 0),
('HD120125', N'Nguyễn Văn A', '0911000002', '12/01/2025', N'Lê Thị Mai', 1500000, 100000, 1400000, 1400000, N'Tiền mặt', 0),
('HD050225', N'Trần Thị B', '0911000003', '05/02/2025', N'Nguyễn Văn Bình', 1200000, 0, 1200000, 1000000, N'Chuyển khoản', 200000),
('HD170225', N'Lê Văn N', '0911000004', '17/02/2025', N'Vũ Thị Hoa', 2300000, 300000, 2000000, 2000000, N'Chuyển khoản', 0),
('HD110325', N'Hoàng Oanh', '0911000005', '11/03/2025', N'Trần Hữu Quang', 1450000, 0, 1450000, 1450000, N'Tiền mặt', 0),
('HD180325', N'Phạm Văn C', '0911000006', '18/03/2025', N'Phạm Hồng Anh', 1800000, 200000, 1600000, 1000000, N'Tiền mặt', 600000),
('HD020425', N'Lê Minh D', '0911000007', '02/04/2025', N'Vũ Thị Hoa', 2000000, 0, 2000000, 1500000, N'Chuyển khoản', 500000),
('HD040425', N'Nguyễn Văn P', '0911000008', '04/04/2025', N'Lê Thị Mai', 2500000, 250000, 2250000, 2250000, N'Chuyển khoản', 0),
('HD100525', N'Trần Thị Q', '0911000009', '10/05/2025', N'Nguyễn Văn Bình', 1100000, 0, 1100000, 1100000, N'Tiền mặt', 0),
('HD160525', N'Hoàng Thu E', '0911000010', '16/05/2025', N'Trần Hữu Quang', 950000, 0, 950000, 500000, N'Tiền mặt', 450000),
('HD070625', N'Nguyễn Văn F', '0911000011', '07/06/2025', N'Lê Thị Mai', 2200000, 200000, 2000000, 2000000, N'Tiền mặt', 0),
('HD190625', N'Phạm Văn R', '0911000012', '19/06/2025', N'Phạm Hồng Anh', 2000000, 0, 2000000, 1800000, N'Chuyển khoản', 200000),
('HD080725', N'Lê Thị S', '0911000013', '17/07/2025', N'Vũ Thị Hoa', 1750000, 75000, 1675000, 1675000, N'Tiền mặt', 0),
('HD200725', N'Bùi Thị G', '0911000014', '20/07/2025', N'Nguyễn Văn Bình', 1350000, 0, 1350000, 1000000, N'Chuyển khoản', 350000),
('HD030825', N'Trịnh Văn H', '0911000015', '03/08/2025', N'Phạm Hồng Anh', 1750000, 0, 1750000, 1750000, N'Tiền mặt', 0),
('HD140825', N'Nguyễn Văn T', '0911000016', '14/08/2025', N'Trần Hữu Quang', 2600000, 600000, 2000000, 2000000, N'Chuyển khoản', 0),
('HD150925', N'Ngô Thị I', '0911000017', '15/09/2025', N'Vũ Thị Hoa', 1600000, 0, 1600000, 1600000, N'Chuyển khoản', 0),
('HD101025', N'Vũ Văn J', '0911000018', '10/10/2025', N'Trần Hữu Quang', 2100000, 0, 2100000, 2000000, N'Tiền mặt', 100000),
('HD111125', N'Đặng Thị K', '0911000019', '11/11/2025', N'Lê Thị Mai', 1250000, 0, 1250000, 1250000, N'Tiền mặt', 0),
('HD121225', N'Nguyễn Văn L', '0911000020', '12/12/2025', N'Nguyễn Văn Bình', 1850000, 85000, 1765000, 1765000, N'Chuyển khoản', 0)


INSERT INTO MuaHang (MaMuaHang, STT, MaHang, NhomHang, TenHang, DVT, SoLuong, DonGia, ThanhTien) VALUES
-- MH001 = 1,950,000
('MH001', 1, 'QA0001', N'Quần áo', N'Áo thun tập gym nam', N'Cái', 3, 120000, 360000),
('MH001', 2, 'NA0003', N'Nước uống và đồ ăn', N'Thanh protein bar', N'Thanh', 5, 45000, 225000),
('MH001', 3, 'NA0002', N'Nước uống và đồ ăn', N'Nước điện giải', N'Chai', 10, 25000, 250000),
('MH001', 4, 'PK0001', N'Phụ kiện tập luyện', N'Găng tay tập gym', N'Đôi', 5, 223000, 1115000),

-- MH002 = 1,500,000
('MH002', 1, 'QA0002', N'Quần áo', N'Quần short gym nữ', N'Cái', 3, 150000, 450000),
('MH002', 2, 'PK0004', N'Phụ kiện tập luyện', N'Dây kháng lực', N'Bộ', 3, 180000, 540000),
('MH002', 3, 'NA0001', N'Nước uống và đồ ăn', N'Nước suối 500ml', N'Chai', 2, 25000, 50000),
('MH002', 4, 'QA0003', N'Quần áo', N'Áo bra thể thao nữ', N'Cái', 2, 230000, 460000),

-- MH003 = 1,200,000
('MH003', 1, 'NA0001', N'Nước uống và đồ ăn', N'Nước suối 500ml', N'Chai', 6, 10000, 60000),
('MH003', 2, 'QA0005', N'Quần áo', N'Áo khoác gió tập gym', N'Cái', 3, 250000, 750000),
('MH003', 3, 'PK0001', N'Phụ kiện tập luyện', N'Găng tay tập gym', N'Đôi', 2, 195000, 390000),

-- MH004 = 2,300,000
('MH004', 1, 'QA0004', N'Quần áo', N'Quần legging nữ', N'Cái', 3, 220000, 660000),
('MH004', 2, 'PK0002', N'Phụ kiện tập luyện', N'Dây nhảy thể lực', N'Cái', 2, 70000, 140000),
('MH004', 3, 'NA0005', N'Nước uống và đồ ăn', N'Nước tăng lực', N'Chai', 10, 30000, 300000),
('MH004', 4, 'QA0008', N'Quần áo', N'Bộ đồ thể thao nữ', N'Bộ', 2, 600000, 1200000),

-- MH005 = 1,800,000
('MH005', 1, 'PK0003', N'Phụ kiện tập luyện', N'Thảm tập yoga', N'Cái', 2, 250000, 500000),
('MH005', 2, 'QA0002', N'Quần áo', N'Quần short gym nữ', N'Cái', 4, 150000, 600000),
('MH005', 3, 'NA0003', N'Nước uống và đồ ăn', N'Thanh protein bar', N'Thanh', 6, 45000, 270000),
('MH005', 4, 'PK0007', N'Phụ kiện tập luyện', N'Băng quấn cổ tay', N'Đôi', 4, 107500, 430000),

-- MH006 = 1,450,000
('MH006', 1, 'QA0007', N'Quần áo', N'Áo tank top nam', N'Cái', 3, 140000, 420000),
('MH006', 2, 'PK0005', N'Phụ kiện tập luyện', N'Bóng tập yoga', N'Cái', 4, 150000, 600000),
('MH006', 3, 'NA0008', N'Nước uống và đồ ăn', N'Bánh yến mạch', N'Gói', 3, 143333, 430000),

-- MH007 = 2,000,000
('MH007', 1, 'QA0006', N'Quần áo', N'Quần jogger nam', N'Cái', 2, 280000, 560000),
('MH007', 2, 'PK0009', N'Phụ kiện tập luyện', N'Đai lưng tập tạ', N'Cái', 3, 300000, 900000),
('MH007', 3, 'NA0009', N'Nước uống và đồ ăn', N'Sữa hạnh nhân', N'Hộp', 4, 135000, 540000),

-- MH008 = 2,500,000
('MH008', 1, 'QA0001', N'Quần áo', N'Áo thun tập gym nam', N'Cái', 5, 120000, 600000),
('MH008', 2, 'PK0008', N'Phụ kiện tập luyện', N'Tạ tay cao su 5kg', N'Cặp', 2, 350000, 700000),
('MH008', 3, 'QA0009', N'Quần áo', N'Áo hoodie thể thao nam', N'Cái', 2, 420000, 840000),
('MH008', 4, 'NA0002', N'Nước uống và đồ ăn', N'Nước điện giải', N'Chai', 4, 90000, 360000),

-- MH009 = 1,100,000
('MH009', 1, 'PK0006', N'Phụ kiện tập luyện', N'Bình nước thể thao 1L', N'Cái', 3, 120000, 360000),
('MH009', 2, 'QA0004', N'Quần áo', N'Quần legging nữ', N'Cái', 2, 220000, 440000),
('MH009', 3, 'NA0006', N'Nước uống và đồ ăn', N'Sinh tố protein', N'Ly', 5, 60000, 300000),

-- MH010 = 950,000
('MH010', 1, 'QA0002', N'Quần áo', N'Quần short gym nữ', N'Cái', 2, 150000, 300000),
('MH010', 2, 'PK0002', N'Phụ kiện tập luyện', N'Dây nhảy thể lực', N'Cái', 3, 70000, 210000),
('MH010', 3, 'NA0010', N'Nước uống và đồ ăn', N'Gel năng lượng', N'Gói', 8, 55000, 440000),

-- MH011 = 2,200,000
('MH011', 1, 'PK0003', N'Phụ kiện tập luyện', N'Thảm tập yoga', N'Cái', 3, 250000, 750000),
('MH011', 2, 'QA0006', N'Quần áo', N'Quần jogger nam', N'Cái', 3, 280000, 840000),
('MH011', 3, 'NA0004', N'Nước uống và đồ ăn', N'Sữa tăng cơ (whey 1kg)', N'Hộp', 1, 610000, 610000),

-- MH012 = 1,850,000
('MH012', 1, 'QA0008', N'Quần áo', N'Bộ đồ thể thao nữ', N'Bộ', 2, 600000, 1200000),
('MH012', 2, 'NA0007', N'Nước uống và đồ ăn', N'Nước trái cây tươi', N'Chai', 5, 35000, 175000),
('MH012', 3, 'PK0004', N'Phụ kiện tập luyện', N'Dây kháng lực', N'Bộ', 3, 150000, 450000),
('MH012', 4, 'NA0010', N'Nước uống và đồ ăn', N'Gel năng lượng', N'Gói', 5, 50000, 250000),

-- MH013 = 1,950,000
('MH013', 1, 'QA0009', N'Quần áo', N'Áo hoodie thể thao nam', N'Cái', 3, 420000, 1260000),
('MH013', 2, 'PK0006', N'Phụ kiện tập luyện', N'Bình nước thể thao 1L', N'Cái', 3, 120000, 360000),
('MH013', 3, 'NA0002', N'Nước uống và đồ ăn', N'Nước điện giải', N'Chai', 6, 27500, 165000),

-- MH014 = 2,300,000
('MH014', 1, 'QA0006', N'Quần áo', N'Quần jogger nam', N'Cái', 3, 280000, 840000),
('MH014', 2, 'PK0007', N'Phụ kiện tập luyện', N'Băng quấn cổ tay', N'Đôi', 4, 107500, 430000),
('MH014', 3, 'NA0004', N'Nước uống và đồ ăn', N'Sữa tăng cơ (whey 1kg)', N'Hộp', 1, 610000, 610000),
('MH014', 4, 'QA0003', N'Quần áo', N'Áo bra thể thao nữ', N'Cái', 2, 210000, 420000),

-- MH015 = 1,450,000
('MH015', 1, 'PK0005', N'Phụ kiện tập luyện', N'Bóng tập yoga', N'Cái', 3, 150000, 450000),
('MH015', 2, 'QA0001', N'Quần áo', N'Áo thun tập gym nam', N'Cái', 4, 120000, 480000),
('MH015', 3, 'NA0006', N'Nước uống và đồ ăn', N'Sinh tố protein', N'Ly', 3, 70000, 210000),
('MH015', 4, 'PK0003', N'Phụ kiện tập luyện', N'Thảm tập yoga', N'Cái', 2, 155000, 310000),

-- MH016 = 2,500,000
('MH016', 1, 'QA0005', N'Quần áo', N'Áo khoác gió tập gym', N'Cái', 3, 250000, 750000),
('MH016', 2, 'PK0008', N'Phụ kiện tập luyện', N'Tạ tay cao su 5kg', N'Cặp', 2, 350000, 700000),
('MH016', 3, 'NA0009', N'Nước uống và đồ ăn', N'Sữa hạnh nhân', N'Hộp', 5, 130000, 650000),
('MH016', 4, 'PK0002', N'Phụ kiện tập luyện', N'Dây nhảy thể lực', N'Cái', 4, 100000, 400000),

-- MH017 = 1,100,000
('MH017', 1, 'QA0004', N'Quần áo', N'Quần legging nữ', N'Cái', 2, 220000, 440000),
('MH017', 2, 'NA0003', N'Nước uống và đồ ăn', N'Thanh protein bar', N'Thanh', 6, 45000, 270000),
('MH017', 3, 'PK0009', N'Phụ kiện tập luyện', N'Đai lưng tập tạ', N'Cái', 2, 195000, 390000),

-- MH018 = 2,000,000
('MH018', 1, 'QA0008', N'Quần áo', N'Bộ đồ thể thao nữ', N'Bộ', 2, 600000, 1200000),
('MH018', 2, 'PK0001', N'Phụ kiện tập luyện', N'Găng tay tập gym', N'Đôi', 2, 225000, 450000),
('MH018', 3, 'NA0005', N'Nước uống và đồ ăn', N'Nước tăng lực', N'Chai', 10, 35000, 350000),

-- MH019 = 1,750,000
('MH019', 1, 'QA0007', N'Quần áo', N'Áo tank top nam', N'Cái', 4, 140000, 560000),
('MH019', 2, 'PK0002', N'Phụ kiện tập luyện', N'Dây nhảy thể lực', N'Cái', 5, 70000, 350000),
('MH019', 3, 'NA0001', N'Nước uống và đồ ăn', N'Nước suối 500ml', N'Chai', 8, 30000, 240000),
('MH019', 4, 'PK0005', N'Phụ kiện tập luyện', N'Bóng tập yoga', N'Cái', 3, 200000, 600000),

-- MH020 = 2,600,000
('MH020', 1, 'QA0009', N'Quần áo', N'Áo hoodie thể thao nam', N'Cái', 3, 420000, 1260000),
('MH020', 2, 'PK0008', N'Phụ kiện tập luyện', N'Tạ tay cao su 5kg', N'Cặp', 3, 350000, 1050000),
('MH020', 3, 'NA0008', N'Nước uống và đồ ăn', N'Bánh yến mạch', N'Gói', 5, 58000, 290000);

delete from MuaHang where MaMuaHang = 'MH021'
delete from MuaHang where MaMuaHang = 'MH022'
delete from MuaHang where MaMuaHang = 'MH023'
delete from MuaHang where MaMuaHang = 'MH024'

delete from DanhSachHoaDon where MaHD = 'HD20102503'
delete from HoaDon where MaHD = 'HD20102503'
delete from CTHD where MaHD = 'HD20102503'

delete from DanhSachHoaDon where MaHD = 'HD20102504'
delete from HoaDon where MaHD = 'HD20102504'
delete from CTHD where MaHD = 'HD20102504'



delete from DanhSachHoaDon where MaHD = 'HD20102502'
delete from HoaDon where MaHD = 'HD20102502'
delete from CTHD where MaHD = 'HD20102502'

delete from DanhSachHoaDon where MaHD = 'HD201025'
delete from HoaDon where MaHD = 'HD201025'
delete from CTHD where MaHD = 'HD201025'

Select * from NhomHang
Select * from Hang
Select * from MuaHang
Select * from HoaDon
Select * from CTHD
Select * from DanhSachHoaDon

CREATE PROCEDURE ResetStt_Hang
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra nếu bảng tồn tại
    IF OBJECT_ID('Hang', 'U') IS NULL
    BEGIN
        PRINT 'Bảng Hang không tồn tại!';
        RETURN;
    END

    -- Bước 1: Tạo bảng tạm
    SELECT MaHang, MaNhom, TenHang, DVT, DonGia
    INTO #TempHang
    FROM Hang;

    -- Bước 2: Xóa dữ liệu cũ
    DELETE FROM Hang;

    -- Bước 3: Reset lại giá trị IDENTITY về 0
    DBCC CHECKIDENT ('Hang', RESEED, 0);

    -- Bước 4: Chèn lại dữ liệu
    INSERT INTO Hang (MaHang, MaNhom, TenHang, DVT, DonGia)
    SELECT MaHang, MaNhom, TenHang, DVT, DonGia
    FROM #TempHang;

    -- Bước 5: Xóa bảng tạm
    DROP TABLE #TempHang;

    PRINT 'Đã refresh lại STT của bảng Hang thành công.';
END
GO


CREATE PROCEDURE ResetStt_NhomHang
AS
BEGIN
    SET NOCOUNT ON;

    -- Bước 1: Sao lưu dữ liệu sang bảng tạm
    SELECT TenNhom
    INTO #TempNhomHang
    FROM NhomHang;

    -- Bước 2: Xóa toàn bộ dữ liệu cũ
    DELETE FROM NhomHang;

    -- Bước 3: Reset lại giá trị IDENTITY về 0
    DBCC CHECKIDENT ('NhomHang', RESEED, 0);

    -- Bước 4: Chèn lại dữ liệu từ bảng tạm
    INSERT INTO NhomHang (TenNhom)
    SELECT TenNhom FROM #TempNhomHang;

    -- Bước 5: Xóa bảng tạm
    DROP TABLE #TempNhomHang;

    PRINT 'Đã reset lại MaNhom (IDENTITY) trong bảng NhomHang thành công!';
END
GO


INSERT INTO DanhSachHoaDon
(MaHD, IDHocVien, NgayTao, KhachHang, TongTien, HinhThuc, NhanVienLap) VALUES
('HD060125', '013', '06/01/2025', N'Trần Thị M', 1950000, N'Tiền mặt', N'Phạm Hồng Anh'),
('HD120125', '001', '12/01/2025', N'Nguyễn Văn A', 1500000, N'Tiền mặt', N'Lê Thị Mai'),
('HD050225', '002', '05/02/2025', N'Trần Thị B', 1200000, N'Chuyển khoản', N'Nguyễn Văn Bình'),
('HD170225', '014', '17/02/2025', N'Lê Văn N', 2300000, N'Chuyển khoản', N'Vũ Thị Hoa'),
('HD110325', '015', '11/03/2025', N'Hoàng Oanh', 1450000, N'Tiền mặt', N'Trần Hữu Quang'),
('HD180325', '003', '18/03/2025', N'Phạm Văn C', 1800000, N'Tiền mặt', N'Phạm Hồng Anh'),
('HD020425', '004', '02/04/2025', N'Lê Minh D', 2000000, N'Chuyển khoản', N'Vũ Thị Hoa'),
('HD040425', '016', '04/04/2025', N'Nguyễn Văn P', 2500000, N'Chuyển khoản', N'Lê Thị Mai'),
('HD100525', '017', '10/05/2025', N'Trần Thị Q', 1100000, N'Tiền mặt', N'Nguyễn Văn Bình'),
('HD160525', '005', '16/05/2025', N'Hoàng Thu E', 950000, N'Tiền mặt', N'Trần Hữu Quang'),
('HD070625', '006', '07/06/2025', N'Nguyễn Văn F', 2200000, N'Tiền mặt', N'Lê Thị Mai'),
('HD190625', '018', '19/06/2025', N'Phạm Văn R', 2000000, N'Chuyển khoản', N'Phạm Hồng Anh'),
('HD080725', '019', '08/07/2025', N'Lê Thị S', 1750000, N'Tiền mặt', N'Vũ Thị Hoa'),
('HD200725', '007', '20/07/2025', N'Bùi Thị G', 1350000, N'Chuyển khoản', N'Nguyễn Văn Bình'),
('HD030825', '008', '03/08/2025', N'Trịnh Văn H', 1750000, N'Tiền mặt', N'Phạm Hồng Anh'),
('HD140825', '020', '14/08/2025', N'Nguyễn Văn T', 2600000, N'Chuyển khoản', N'Trần Hữu Quang'),
('HD150925', '009', '15/09/2025', N'Ngô Thị I', 1600000, N'Chuyển khoản', N'Vũ Thị Hoa'),
('HD101025', '010', '10/10/2025', N'Vũ Văn J', 2100000, N'Tiền mặt', N'Trần Hữu Quang'),
('HD111125', '011', '11/11/2025', N'Đặng Thị K', 1250000, N'Tiền mặt', N'Lê Thị Mai'),
('HD121225', '012', '12/12/2025', N'Nguyễn Văn L', 1850000, N'Chuyển khoản', N'Nguyễn Văn Bình');

CREATE FUNCTION TaoMaHangMoi(@TenNhom NVARCHAR(100))
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @Prefix NVARCHAR(2)
    DECLARE @LastCode NVARCHAR(10)
    DECLARE @NextNumber INT
    DECLARE @NewCode NVARCHAR(10)

    -- Lấy 2 ký tự đầu từ tên nhóm, loại bỏ dấu cách
    SET @Prefix = LEFT(REPLACE(@TenNhom, ' ', ''), 2)

    -- Lấy mã cuối cùng trong bảng Hàng theo prefix
    SELECT TOP 1 @LastCode = MaHang
    FROM Hang
    WHERE MaHang LIKE @Prefix + '%'
    ORDER BY MaHang DESC

    -- Nếu chưa có mã nào thì bắt đầu từ 1
    IF @LastCode IS NULL
        SET @NextNumber = 1
    ELSE
        SET @NextNumber = CAST(RIGHT(@LastCode, 4) AS INT) + 1

    -- Tạo mã mới theo định dạng XX0001
    SET @NewCode = @Prefix + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR(4)), 4)

    RETURN @NewCode
END
GO

INSERT INTO Hang (MaHang, TenHang, DVT, DonGia)
VALUES (dbo.TaoMaHangMoi(N'Phụ kiện tập luyện'), N'Găng tay tập gym', N'Đôi', 90000);

CREATE FUNCTION dbo.TaoMaHDMoi(@NgayBan DATE)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @BaseCode NVARCHAR(20)
    DECLARE @NewCode NVARCHAR(20)
    DECLARE @Count INT

    -- Bước 1: Tạo mã gốc HD + ddMMyy
    SET @BaseCode = 'HD' + FORMAT(@NgayBan, 'ddMMyy')

    -- Bước 2: Đếm xem trong ngày đó đã có bao nhiêu hóa đơn
    SELECT @Count = COUNT(*)
    FROM CTHD
    WHERE LEFT(MaHD, 8) = @BaseCode

    -- Bước 3: Nếu chưa có → dùng mã gốc, nếu có rồi → thêm hậu tố 01, 02, ...
    IF @Count = 0
        SET @NewCode = @BaseCode
    ELSE
        SET @NewCode = @BaseCode + RIGHT('00' + CAST(@Count + 1 AS NVARCHAR(2)), 2)

    RETURN @NewCode
END
GO

drop function dbo.TaoMaHDMoi

SELECT dbo.TaoMaHDMoi('2025-02-05')

CREATE FUNCTION dbo.TaoMaMuaHangMoi()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @NewCode NVARCHAR(10);
    DECLARE @LastCode NVARCHAR(10);
    DECLARE @NumPart INT;

    -- Lấy mã mới nhất hiện có trong bảng MuaHang
    SELECT TOP 1 @LastCode = MaMuaHang
    FROM MuaHang
    ORDER BY MaMuaHang DESC;

    -- Nếu chưa có mã nào thì bắt đầu từ MH001
    IF @LastCode IS NULL
        SET @NewCode = 'MH001';
    ELSE
    BEGIN
        -- Cắt phần số ở sau 'MH'
        SET @NumPart = CAST(SUBSTRING(@LastCode, 3, LEN(@LastCode)) AS INT) + 1;
        -- Tạo mã mới với padding 3 chữ số
        SET @NewCode = 'MH' + RIGHT('000' + CAST(@NumPart AS NVARCHAR(3)), 3);
    END;

    RETURN @NewCode;
END;
GO

SELECT dbo.TaoMaMuaHangMoi();


Select * from DanhSachHoaDon

create function LocDanhSach(@hinhThuc nvarchar(100)) returns table
as
return(
	Select *
	from DanhSachHoaDon 
	where HinhThuc Like N'%' + @hinhThuc + '%'
	)
go

drop function LocDanhSach

Select * from LocDanhSach(N'Chuyển khoản')
Select * from LocDanhSach(N'Tiền mặt')

create function TimKiemHoaDonTheoMa(@hoaDon nvarchar(100)) returns table
as
return(
    SELECT *
    FROM DanhSachHoaDon
    WHERE MaHD LIKE '%'+@hoaDon+'%'
)
go

Select * from TimKiemHoaDonTheoMa('HD020425')

create function TimKiemHoaDonTheoKH(@hoaDon nvarchar(100)) returns table
as
return(
    SELECT *
    FROM DanhSachHoaDon
    WHERE KhachHang LIKE N'%'+@hoaDon+'%'
)
go

drop function TimKiemHoaDonTheoKH
drop function TimKiemHoaDonTheoMa


Select * from TimKiemHoaDonTheoKH(N'Phạm Văn C')

create function TimTheoNgay(@ngayBD nvarchar(100), @ngayKT nvarchar(100)) returns table
as
return(
    Select *
    From DanhSachHoaDon
    WHERE 
           TRY_CONVERT(DATE, @ngayBD, 103) <= TRY_CONVERT(DATE, NgayTao, 103) and 
              TRY_CONVERT(DATE, NgayTao, 103)  <= TRY_CONVERT(DATE, @ngayKT, 103)
)
go

drop function TimTheoNgay

Select * from TimTheoNgay('02/04/2025', '1/07/2025')

Select * from DanhSachHoaDon

Select * 
from DanhSachHoaDon A, CTHD B
where A.MaHD = B.MaHD 


Select * from DanhSachHoaDon
Select * from CTHD

create function TimKiemHangTheoMa(@hang nvarchar(100)) returns table
as
return(
    SELECT *
    FROM Hang
    WHERE MaHang LIKE N'%'+@hang+'%'
)
go

drop function TimKiemHangTheoMa


create function TimKiemHangTheoTen(@hang nvarchar(100)) returns table
as
return(
    SELECT *
    FROM Hang
    WHERE TenHang LIKE N'%'+@hang+'%'
)
go

drop function TimKiemHangTheoTen

create function TimDanhMuc(@danhMuc nvarchar(100)) returns table
as
return(
    SELECT *
    FROM NhomHang
    WHERE TenNhom LIKE N'%'+@danhMuc+'%'
)
go





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachThietBi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTB] [nvarchar](1000) NOT NULL,
	[HangSanXuat] [nvarchar](1000) NOT NULL,
	[ViTri] [nvarchar](1000) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TinhTrang] [nvarchar](1000) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[LocThietBiTheoViTri]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LocThietBiTheoViTri] (@viTri nvarchar(1000)) returns table
as
return(
	Select *
	from DanhSachThietBi 
	where ViTri = @viTri
	)
GO
/****** Object:  UserDefinedFunction [dbo].[TimKiemThietBi]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimKiemThietBi](@tenTB nvarchar(100)) returns table
as
return(
    SELECT *
    FROM DanhSachThietBi
    WHERE TenTB LIKE '%'+@tenTB+'%'
)
GO
/****** Object:  Table [dbo].[DanhSachGhiChu]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachGhiChu](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[IDTB] [int] NOT NULL,
	[VanDe] [nvarchar](1000) NOT NULL,
	[NgayGhiChu] [nvarchar](1000) NOT NULL,
	[HuongDan] [nvarchar](1000) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[TimTheoNgay]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimTheoNgay](@ngayBD nvarchar(100), @ngayKT nvarchar(100)) returns table
as
return(
    Select *
    From DanhSachGhiChu
    Where @ngayBD <= NgayGhiChu and NgayGhiChu <= @ngayKT
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimKiemGhiChuTheoID]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimKiemGhiChuTheoID](@id nvarchar(100)) returns table
as
return(
    SELECT *
    FROM DanhSachGhiChu
    WHERE IDTB LIKE '%'+@id+'%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[LocThietBiTheoHang]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LocThietBiTheoHang] (@hang nvarchar(100)) returns table
as
return(
	Select *
	from DanhSachThietBi 
	where HangSanXuat = @hang
	)
GO
/****** Object:  UserDefinedFunction [dbo].[LocThietBiTheoTinhTrang]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LocThietBiTheoTinhTrang] (@tinhTrang nvarchar(1000)) returns table
as
return(
	Select *
	from DanhSachThietBi 
	where TinhTrang = @tinhTrang
	)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CapNhatThietBi] 
@ID int, @ten nvarchar(1000), @hang nvarchar(1000), @viTri nvarchar(1000), @soLuong int, @tinhTrang nvarchar(1000)
As
    Update DanhSachThietBi
    Set TenTB = @ten, HangSanXuat = @hang, ViTri = @viTri, SoLuong = @soLuong, TinhTrang = @tinhTrang
    Where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[XoaThietBi]    Script Date: 9/29/2025 8:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[XoaThietBi]
    @ID INT
AS
BEGIN
    SET NOCOUNT OFF;

    DELETE FROM DanhSachThietBi WHERE ID = @ID;

    IF @@ROWCOUNT = 0
        RETURN;

    SET NOCOUNT ON;

    SELECT TenTB, HangSanXuat, ViTri, SoLuong, TinhTrang
    INTO #TempThietBi
    FROM DanhSachThietBi
    ORDER BY ID;

    TRUNCATE TABLE DanhSachThietBi;

    INSERT INTO DanhSachThietBi (TenTB, HangSanXuat, ViTri, SoLuong, TinhTrang)
    SELECT TenTB, HangSanXuat, ViTri, SoLuong, TinhTrang
    FROM #TempThietBi;

    DROP TABLE #TempThietBi;
END
GO
