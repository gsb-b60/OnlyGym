create database GymManagement_1
use GymManagement_1

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

INSERT INTO PT (Ho, Ten, SDT, TrangThai, ThoiGianXoa, GioiTinh, NgaySinh, AvartarUrl) VALUES
(N'Nguyễn Thị', N'Lan', '0912345678', 1, NULL, 0, '1999-04-12', N'https://example.com/avatar/0.jpg'),
(N'Trần Thị', N'Hoa', '0987654321', 1, NULL, 0, '1997-11-03', N'https://example.com/avatar/1.jpg'),
(N'Lê Thị', N'Linh', '0902345678', 0, '2024-07-12', 0, '1995-09-21', N'https://example.com/avatar/2.jpg'),
(N'Phạm Ngọc', N'Vy', '0376543210', 1, NULL, 0, '2000-02-01', N'https://example.com/avatar/3.jpg'),
(N'Hoàng Thị', N'Thảo', '0856789123', 1, NULL, 0, '1998-06-15', N'https://example.com/avatar/4.jpg'),
(N'Vũ Thị', N'Hương', '0967890123', 1, NULL, 0, '1994-10-10', N'https://example.com/avatar/5.jpg'),
(N'Phan Bảo', N'Ngọc', '0934567890', 0, '2023-09-25', 0, '1996-12-20', N'https://example.com/avatar/6.jpg'),
(N'Đặng Mai', N'Phương', '0701234567', 1, NULL, 0, '1999-05-17', N'https://example.com/avatar/7.jpg'),
(N'Nguyễn Thanh', N'Nhung', '0798765432', 1, NULL, 0, '2001-01-12', N'https://example.com/avatar/8.jpg'),
(N'Trần Hồng', N'Yến', '0812345679', 1, NULL, 0, '1993-07-09', N'https://example.com/avatar/9.jpg'),

-- 20 nữ đến đây; bắt đầu nam
(N'Nguyễn Văn', N'Nam', '0905123456', 1, NULL, 1, '1990-03-25', N'https://example.com/avatar/10.jpg'),
(N'Trần Hữu', N'Huy', '0987456321', 1, NULL, 1, '1992-11-15', N'https://example.com/avatar/11.jpg'),
(N'Lê Đức', N'Long', '0912345987', 0, '2024-01-19', 1, '1995-09-03', N'https://example.com/avatar/12.jpg'),
(N'Phạm Minh', N'Tuấn', '0934567801', 1, NULL, 1, '1998-06-08', N'https://example.com/avatar/13.jpg'),
(N'Hoàng Hữu', N'Đạt', '0379123456', 1, NULL, 1, '2002-04-14', N'https://example.com/avatar/14.jpg'),
(N'Vũ Văn', N'Thắng', '0856347890', 1, NULL, 1, '1999-08-23', N'https://example.com/avatar/15.jpg'),
(N'Phan Đức', N'Phúc', '0976543210', 0, '2023-03-05', 1, '1994-10-05', N'https://example.com/avatar/16.jpg'),
(N'Đặng Minh', N'Tâm', '0887654321', 1, NULL, 1, '1996-02-11', N'https://example.com/avatar/17.jpg'),
(N'Nguyễn Văn', N'Khoa', '0795678901', 1, NULL, 1, '2001-07-01', N'https://example.com/avatar/18.jpg'),
(N'Trần Hữu', N'Phát', '0834567890', 1, NULL, 1, '1997-05-09', N'https://example.com/avatar/19.jpg'),
(N'Lê Minh', N'Hậu', '0911112233', 1, NULL, 1, '1989-04-12', N'https://example.com/avatar/20.jpg'),
(N'Phạm Đức', N'Anh', '0902223344', 0, '2022-08-07', 1, '1991-10-23', N'https://example.com/avatar/21.jpg'),
(N'Hoàng Văn', N'Tiến', '0933334455', 1, NULL, 1, '1995-12-11', N'https://example.com/avatar/22.jpg'),
(N'Vũ Hữu', N'Quân', '0944445566', 1, NULL, 1, '1993-01-18', N'https://example.com/avatar/23.jpg'),
(N'Phan Minh', N'Hải', '0955556677', 1, NULL, 1, '1999-09-09', N'https://example.com/avatar/24.jpg'),
(N'Đặng Văn', N'Dũng', '0966667788', 0, '2024-04-20', 1, '1998-03-02', N'https://example.com/avatar/25.jpg'),
(N'Nguyễn Hữu', N'Thịnh', '0977778899', 1, NULL, 1, '1994-08-27', N'https://example.com/avatar/26.jpg'),
(N'Trần Đức', N'Trung', '0988889900', 1, NULL, 1, '1990-02-22', N'https://example.com/avatar/27.jpg'),
(N'Lê Minh', N'Hoàng', '0999990011', 1, NULL, 1, '1996-06-16', N'https://example.com/avatar/28.jpg'),
(N'Phạm Hữu', N'Vinh', '0833332222', 1, NULL, 1, '1992-03-28', N'https://example.com/avatar/29.jpg'),
(N'Hoàng Văn', N'Hưng', '0844443333', 0, '2024-07-01', 1, '1993-11-30', N'https://example.com/avatar/30.jpg'),
(N'Vũ Hữu', N'Bình', '0855554444', 1, NULL, 1, '1998-10-04', N'https://example.com/avatar/31.jpg'),
(N'Phan Đức', N'Thọ', '0866665555', 1, NULL, 1, '2000-01-09', N'https://example.com/avatar/32.jpg'),
(N'Đặng Minh', N'Tuấn', '0877776666', 1, NULL, 1, '1995-02-19', N'https://example.com/avatar/33.jpg'),
(N'Nguyễn Văn', N'Đức', '0888887777', 1, NULL, 1, '1994-07-05', N'https://example.com/avatar/34.jpg'),
(N'Trần Hữu', N'Nhật', '0899998888', 0, '2023-12-01', 1, '2001-09-14', N'https://example.com/avatar/35.jpg'),
(N'Lê Đức', N'Kiên', '0901010101', 1, NULL, 1, '1997-03-17', N'https://example.com/avatar/36.jpg'),
(N'Phạm Minh', N'Thành', '0912121212', 1, NULL, 1, '1995-05-05', N'https://example.com/avatar/37.jpg'),
(N'Hoàng Hữu', N'Lộc', '0923232323', 1, NULL, 1, '1993-06-06', N'https://example.com/avatar/38.jpg'),
(N'Vũ Văn', N'Triết', '0934343434', 1, NULL, 1, '1988-04-25', N'https://example.com/avatar/39.jpg'),
(N'Phan Đức', N'Khôi', '0945454545', 1, NULL, 1, '1999-02-15', N'https://example.com/avatar/40.jpg'),
(N'Đặng Minh', N'Phong', '0956565656', 1, NULL, 1, '2000-07-20', N'https://example.com/avatar/41.jpg'),
(N'Nguyễn Văn', N'Quý', '0967676767', 1, NULL, 1, '1992-12-12', N'https://example.com/avatar/42.jpg'),
(N'Trần Hữu', N'Thái', '0978787878', 0, '2023-05-15', 1, '1997-09-08', N'https://example.com/avatar/43.jpg'),
(N'Lê Đức', N'Thịnh', '0989898989', 1, NULL, 1, '1995-11-25', N'https://example.com/avatar/44.jpg'),
(N'Phạm Minh', N'Vũ', '0990909090', 1, NULL, 1, '1999-03-30', N'https://example.com/avatar/45.jpg'),
(N'Hoàng Hữu', N'Hiếu', '0818181818', 1, NULL, 1, '1998-10-19', N'https://example.com/avatar/46.jpg'),
(N'Vũ Văn', N'Khánh', '0828282828', 1, NULL, 1, '1993-01-22', N'https://example.com/avatar/47.jpg'),
(N'Phan Đức', N'Vương', '0838383838', 1, NULL, 1, '1990-07-03', N'https://example.com/avatar/48.jpg'),
(N'Đặng Minh', N'Phúc', '0848484848', 1, NULL, 1, '2001-06-29', N'https://example.com/avatar/49.jpg');


select * from PT

-- 🎯 DAY-BASED PACKAGES (LoaiGoi = 1)
INSERT INTO GoiTap (TenGoi, LoaiGoi, ThoiHanNgay, ThoiHanBuoi, GiaTien, ThongTin, HoatDong, Discount, StartSellingDate, EndSellingDate)
VALUES
(N'M1', 1, 30, NULL, 300000, N'Gói cơ bản 1 tháng, phù hợp cho người mới bắt đầu.', 1, 20000, '2025-01-01', NULL),
(N'M3', 1, 90, NULL, 850000, N'Gói 3 tháng tiết kiệm hơn, phù hợp người luyện đều.', 1, 50000, '2025-01-01', NULL),
(N'M6', 1, 180, NULL, 1500000, N'Gói 6 tháng, giảm giá nhẹ cho khách hàng trung thành.', 1, 90000, '2025-01-01', NULL),
(N'M12', 1, 360, NULL, 2700000, N'Gói 12 tháng – lựa chọn phổ biến nhất của phòng gym.', 1, 150000, '2025-01-01', NULL),
(N'1 Year Pro', 1, 365, NULL, 3000000, N'Gói Pro 1 năm dành cho học viên nghiêm túc.', 1, 200000, '2025-01-01', NULL),
(N'2 Year Commitment', 1, 730, NULL, 5400000, N'Gói dài hạn 2 năm – nhận nhiều ưu đãi đặc biệt.', 1, 300000, '2025-01-01', NULL),

-- 🎁 MARKETING PACKAGES (Seasonal)
(N'Tết 2023 Special', 1, 60, NULL, 450000, N'Ưu đãi đặc biệt mừng Tết 2023, chỉ bán trong tháng 1-2.', 0, 120000, '2023-01-01', '2023-02-15'),
(N'Noel Fit Deal', 1, 45, NULL, 420000, N'Giảm giá mạnh mùa Noel, giới hạn số lượng.', 0, 150000, '2024-12-01', '2024-12-31'),
(N'Summer Fit 2025', 1, 90, NULL, 700000, N'Khuyến mãi chào hè 2025, tặng kèm nước uống protein.', 1, 80000, '2025-05-01', '2025-07-31'),

-- 💪 SESSION-BASED PACKAGES (LoaiGoi = 2)
(N'S30', 2, NULL, 30, 350000, N'30 buổi tập – phù hợp học viên mới.', 1, 25000, '2025-01-01', NULL),
(N'S50', 2, NULL, 50, 550000, N'50 buổi – tiết kiệm 10%.', 1, 40000, '2025-01-01', NULL),
(N'S70', 2, NULL, 70, 700000, N'70 buổi – dành cho người luyện đều đặn.', 1, 50000, '2025-01-01', NULL),
(N'S100', 2, NULL, 100, 950000, N'100 buổi – gói tập lâu dài, tiết kiệm lớn.', 1, 70000, '2025-01-01', NULL),

-- 🎉 MARKETING SESSION PACKAGES
(N'Holiday 2024 Combo', 2, NULL, 60, 480000, N'Ưu đãi lễ cuối năm, tặng thêm 5 buổi miễn phí.', 0, 100000, '2024-12-10', '2025-01-10'),
(N'Back to School 2025', 2, NULL, 40, 420000, N'Khuyến mãi chào năm học mới cho sinh viên.', 1, 50000, '2025-08-01', '2025-09-30');

select * from GoiTap