create database GymManagement_1
use GymManagement_1



--create table with this order
create table PT(
	ID int primary key identity(0,1) ,
	Ho nvarchar(100) not null,
	Ten nvarchar(100) not null,
	SDT varchar(10) not null,
	TrangThai bit not null,
	ThoiGianXoa datetime null,
	GioiTinh bit null,
	NgaySinh datetime null,
	AvartarUrl nvarchar(100) null,
);


create table Specialties(
	ID int identity(0,1) primary key,
	Specialties nvarchar(50) not null,
	notes nvarchar(1000) null,
);

create table PTSpecialties(
	ID int identity(0,1) primary key,
	PT_ID int not null,
	Specialties_ID int not null,
	foreign key (PT_ID) references PT(ID),
	foreign key (Specialties_ID) references Specialties(ID)
);

create table GoiTap(
	ID int identity(0,1) primary key,
	TenGoi nvarchar(50) not null,
	LoaiGoi int not null,
	ThoiHanNgay int null,
	ThoiHanBuoi int null,
	GiaTien decimal(12,3) not null,
	ThongTin nvarchar(1000) null,
	HoatDong bit not null,
	Discount decimal(12,3) not null,
	StartSellingDate datetime null,
	EndSellingDate datetime null,
);


create table GoiPT(
	ID int primary key identity(0,1),
	TenGoi nvarchar(50) not null,
	SoBuoi	int not null,
	TrangThai bit not null default(1),
	GiaTien decimal(12,3) not null,
	Discount decimal(12,3) null
);

create table HocVien(
	[id] [int] IDENTITY(1,1) primary key,
	[code] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[sdt] [varchar](10) NOT NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [bit] NULL,
	[avatarUrl] [nvarchar](50) NULL,
	[tag] [int] NULL,
	[ghiChu] [nvarchar](1000) NOT NULL,
	[thoiGianTao] [datetime] NOT NULL,
	[thoiGianSua] [datetime] NOT NULL,
	[ngayXoa] [datetime] NOT NULL,
);


CREATE TABLE HopDongPT (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_HocVien INT NOT NULL,
    id_pt INT NOT NULL,
    id_pt_package INT NOT NULL,
    tongBuoi INT NOT NULL,
    conBuoi INT NOT NULL,
    trangThai INT NOT NULL DEFAULT 1 CHECK (trangThai IN (1, 2, 3, 4)),
    ngayTao DATETIME NOT NULL DEFAULT GETDATE(),

    -- Giả sử các bảng liên quan đã tồn tại, thêm khóa ngoại
    CONSTRAINT FK_hopDongPT_HocVien FOREIGN KEY (id_HocVien) REFERENCES HocVien(id),
    CONSTRAINT FK_hopDongPT_PT FOREIGN KEY (id_pt) REFERENCES PT(id),
    CONSTRAINT FK_hopDongPT_PTPackage FOREIGN KEY (id_pt_package) REFERENCES GoiPT(id)
);

CREATE TABLE buoiTapPT (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_HopDong INT NOT NULL,
    tg_BatDau DATETIME NOT NULL,
    tg_KetThuc DATE NOT NULL,
    trangThai INT NOT NULL DEFAULT 1 CHECK (trangThai IN (1, 2, 3, 4, 5, 6)),
    tgTao DATE NOT NULL DEFAULT GETDATE(),
    tg_Huy DATE NULL,
    lyDoHuy NVARCHAR(1000) NULL,

    CONSTRAINT FK_buoiTapPT_HopDong FOREIGN KEY (id_HopDong) REFERENCES hopDongPT(id)
);


CREATE VIEW v_DashboardGym
AS
SELECT 
    (SELECT COUNT(*) FROM HocVien) AS TongHocVien,
    (SELECT COUNT(*) FROM PT) AS TongPT,
    (SELECT COUNT(*) FROM HopDongPT WHERE trangThai = 1) AS HopDongHoatDong,
    (SELECT COUNT(*) FROM buoiTapPT WHERE trangThai = 1) AS BuoiChuaTap,
    (SELECT COUNT(*) FROM buoiTapPT WHERE trangThai = 3) AS BuoiHoanThanh;






select * from v_DashboardGym