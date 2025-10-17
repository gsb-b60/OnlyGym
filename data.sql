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

INSERT INTO PTSpecialties (PT_ID, Specialties_ID) VALUES
-- Female trainers 50–69
(50, 0), (50, 3), (50, 4),
(51, 0), (51, 1), (51, 5),
(52, 3), (52, 4), (52, 7),
(53, 0), (53, 6), (53, 10),
(54, 3), (54, 7), (54, 8),
(55, 0), (55, 4), (55, 9),
(56, 1), (56, 5), (56, 7),
(57, 3), (57, 8), (57, 11),
(58, 0), (58, 1), (58, 9),
(59, 3), (59, 4), (59, 6),
(60, 0), (60, 2), (60, 8),
(61, 4), (61, 7), (61, 10),
(62, 0), (62, 3), (62, 5),
(63, 1), (63, 4), (63, 11),
(64, 2), (64, 7), (64, 8),
(65, 0), (65, 4), (65, 10),
(66, 3), (66, 5), (66, 6),
(67, 1), (67, 7), (67, 9),
(68, 0), (68, 2), (68, 4),
(69, 3), (69, 6), (69, 8),

-- Male trainers 70–99
(70, 1), (70, 7), (70, 8),
(71, 2), (71, 6), (71, 9),
(72, 3), (72, 5), (72, 10),
(73, 0), (73, 1), (73, 8),
(74, 4), (74, 7), (74, 9),
(75, 5), (75, 10), (75, 11),
(76, 1), (76, 3), (76, 6),
(77, 0), (77, 4), (77, 8),
(78, 2), (78, 7), (78, 9),
(79, 3), (79, 5), (79, 10),
(80, 1), (80, 6), (80, 8),
(81, 0), (81, 4), (81, 9),
(82, 2), (82, 5), (82, 7),
(83, 3), (83, 10), (83, 11),
(84, 1), (84, 4), (84, 8),
(85, 0), (85, 6), (85, 7),
(86, 3), (86, 9), (86, 10),
(87, 1), (87, 4), (87, 11),
(88, 0), (88, 2), (88, 8),
(89, 3), (89, 5), (89, 7),
(90, 1), (90, 6), (90, 9),
(91, 2), (91, 8), (91, 10),
(92, 0), (92, 4), (92, 11),
(93, 3), (93, 5), (93, 7),
(94, 1), (94, 6), (94, 8),
(95, 0), (95, 9), (95, 10),
(96, 3), (96, 4), (96, 7),
(97, 1), (97, 5), (97, 11),
(98, 0), (98, 2), (98, 8),
(99, 3), (99, 6), (99, 9);

select * from

INSERT INTO Specialties (Specialties, Notes) VALUES
(N'Hồi Phục Chức Năng',
N'Phù hợp cho những người vừa bị chấn thương, phẫu thuật hoặc gặp vấn đề về khớp, lưng, vai. Huấn luyện viên sẽ xây dựng chương trình tập an toàn, nhẹ nhàng và theo dõi sát sao từng tiến triển. Mục tiêu là giúp cơ thể lấy lại sức mạnh, độ linh hoạt, giảm đau và cải thiện khả năng vận động hằng ngày. Các bài tập chủ yếu dùng dây kháng lực, bóng yoga, hoặc trọng lượng cơ thể, kết hợp thở và giãn cơ để phục hồi toàn diện.'),

(N'Thi Đấu Thể Hình',
N'Dành cho học viên muốn chạm đến đỉnh cao hình thể: cơ bắp rõ nét, tỷ lệ mỡ thấp, dáng cân đối. Huấn luyện viên sẽ hướng dẫn kỹ thuật tập tạ chuyên sâu, lịch tập theo chu kỳ bulking và cutting, dinh dưỡng theo mục tiêu, và cách kiểm soát hình thể trước thi đấu. Ngoài ra, bạn sẽ được hướng dẫn tư thế biểu diễn, kiểm soát ánh sáng, và cách duy trì thể trạng sau khi lên sân khấu.'),

(N'Giảm Cân Người Lớn Tuổi',
N'Chương trình này được thiết kế đặc biệt cho người từ 40 tuổi trở lên, muốn giảm cân nhưng vẫn giữ an toàn cho khớp và tim mạch. Các bài tập được điều chỉnh nhẹ nhàng, tập trung vào cải thiện thăng bằng, sức bền và khả năng hô hấp. Huấn luyện viên sẽ kết hợp đi bộ, bài tập kháng lực nhẹ, và hướng dẫn chế độ ăn đơn giản giúp duy trì cân nặng bền vững mà không gây mệt mỏi.'),

(N'Giảm Cân Nữ',
N'Phù hợp cho phụ nữ muốn lấy lại vóc dáng săn chắc và tự tin. Chương trình kết hợp giữa cardio đốt mỡ, tập tạ nhẹ tăng săn cơ, và hướng dẫn ăn uống linh hoạt giúp duy trì vóc dáng lâu dài. Huấn luyện viên sẽ tập trung vào các vùng dễ tích mỡ như bụng, hông và đùi, đồng thời giúp bạn hiểu rõ cách cơ thể phản ứng với thực phẩm và vận động để đạt kết quả tốt nhất.'),

(N'Giảm Cân Nam',
N'Thiết kế cho nam giới muốn giảm mỡ, tăng sức mạnh và duy trì thân hình gọn gàng. Huấn luyện viên sẽ hướng dẫn tập HIIT, compound exercises như squat, deadlift, push-up, giúp tăng tiêu hao năng lượng hiệu quả. Ngoài ra, bạn sẽ được tư vấn chế độ ăn giàu protein, dễ thực hiện và duy trì được lâu dài mà không gây mất cơ.'),

(N'Huấn Luyện Thể Lực',
N'Chương trình tập trung vào sức bền, tốc độ, phản xạ và sự linh hoạt. Phù hợp cho vận động viên, người chơi thể thao, hoặc người muốn khỏe toàn diện. Huấn luyện viên sẽ hướng dẫn bài tập kết hợp giữa tạ, dây kháng lực, bodyweight và bài tập tốc độ. Kết quả là bạn có thể lực dẻo dai, tăng sức mạnh, và phản ứng nhanh hơn trong mọi hoạt động.'),

(N'Thi Đấu Cử Tạ',
N'Phù hợp cho người đam mê sức mạnh và muốn phát triển kỹ thuật nâng tạ chuyên nghiệp. Huấn luyện viên hướng dẫn 3 động tác cơ bản: squat, bench press và deadlift, cùng kỹ thuật hỗ trợ an toàn. Chương trình bao gồm chu kỳ tăng tải, phân bố thời gian nghỉ, dinh dưỡng tối ưu và cách phục hồi cơ sau tập nặng. Mục tiêu là đạt sức mạnh tối đa mà vẫn đảm bảo an toàn khớp và lưng.'),

(N'Tăng Cường Sức Mạnh',
N'Dành cho người muốn khỏe hơn, mạnh hơn và cải thiện thể lực tổng thể. Bài tập sử dụng tạ tự do, tạ đơn, và bài tập compound giúp phát triển đồng đều cơ bắp. Huấn luyện viên điều chỉnh mức tạ, nhịp tập và nghỉ để đạt hiệu suất cao nhất. Sau vài tuần, bạn sẽ cảm nhận rõ sự khác biệt trong sức mạnh cơ thể, tư thế và năng lượng hằng ngày.'),

(N'Boxing Fitness',
N'Kết hợp boxing và tập thể lực để đốt mỡ nhanh, tăng sức bền và giảm stress hiệu quả. Bạn sẽ được tập kỹ thuật đấm, di chuyển, phản xạ và phối hợp tay chân cùng các bài tập tim mạch. Không cần kinh nghiệm — chỉ cần năng lượng và tinh thần chiến đấu. Sau 1 tháng, bạn sẽ thấy cơ thể nhẹ hơn, nhanh hơn và tự tin hơn trong từng chuyển động.'),

(N'Functional Training',
N'Bài tập mô phỏng các chuyển động tự nhiên của cơ thể như kéo, đẩy, nâng, bước, xoay. Giúp bạn khỏe hơn trong sinh hoạt hàng ngày và tránh chấn thương khi vận động. Chương trình phù hợp cho mọi độ tuổi, tập trung vào sức mạnh lõi (core strength), thăng bằng và kiểm soát cơ thể. Huấn luyện viên sẽ sử dụng nhiều công cụ như dây TRX, kettlebell, hoặc bóng y học để tạo thử thách thú vị.'),

(N'Yoga Giãn Cơ',
N'Chương trình kết hợp giữa yoga truyền thống và các bài giãn cơ giúp giảm đau nhức, tăng độ linh hoạt và cải thiện tinh thần. Phù hợp cho người làm việc văn phòng, người mới tập gym hoặc cần thư giãn sau buổi tập nặng. Giúp cải thiện tư thế, điều hòa hơi thở và giảm stress hiệu quả.'),

(N'Huấn Luyện Dinh Dưỡng',
N'Huấn luyện viên sẽ giúp bạn hiểu rõ cơ thể mình cần gì để đạt mục tiêu: giảm cân, tăng cơ hoặc duy trì sức khỏe. Bao gồm hướng dẫn chọn thực phẩm, phân chia bữa ăn hợp lý và xây dựng thói quen ăn uống bền vững. Không áp đặt thực đơn cứng nhắc mà hướng đến sự linh hoạt, giúp bạn ăn ngon và vẫn đạt kết quả lâu dài.');


select * from Specialties

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

INSERT INTO PT (Ho, Ten, SDT, TrangThai, ThoiGianXoa, GioiTinh, NgaySinh, AvartarUrl)
VALUES
-- --- FEMALE (0) ---
(N'Nguyễn Thị', N'Lan', '0912345678', 1, NULL, 0, '1999-04-12', N'pt2_f.jpg'),
(N'Trần Thị', N'Hoa', '0987654321', 1, NULL, 0, '1997-11-03', N'pt3_f.jpg'),
(N'Lê Thị', N'Linh', '0902345678', 0, '2024-07-12', 0, '1995-09-21', N'pt5_f.jpg'),
(N'Phạm Ngọc', N'Vy', '0376543210', 1, NULL, 0, '2000-02-01', N'pt2_f.jpg'),
(N'Hoàng Thị', N'Thảo', '0856789123', 1, NULL, 0, '1998-06-15', N'pt3_f.jpg'),
(N'Vũ Thị', N'Hương', '0967890123', 1, NULL, 0, '1994-10-10', N'pt5_f.jpg'),
(N'Phan Bảo', N'Ngọc', '0934567890', 0, '2023-09-25', 0, '1996-12-20', N'pt2_f.jpg'),
(N'Đặng Mai', N'Phương', '0701234567', 1, NULL, 0, '1999-05-17', N'pt3_f.jpg'),
(N'Nguyễn Thanh', N'Nhung', '0798765432', 1, NULL, 0, '2001-01-12', N'pt5_f.jpg'),
(N'Trần Hồng', N'Yến', '0812345679', 1, NULL, 0, '1993-07-09', N'pt2_f.jpg'),

-- --- MALE (1) ---
(N'Nguyễn Văn', N'Nam', '0905123456', 1, NULL, 1, '1990-03-25', N'pt1_m.jpg'),
(N'Trần Hữu', N'Huy', '0987456321', 1, NULL, 1, '1992-11-15', N'pt4_m.jpg'),
(N'Lê Đức', N'Long', '0912345987', 0, '2024-01-19', 1, '1995-09-03', N'pt1_m.jpg'),
(N'Phạm Minh', N'Tuấn', '0934567801', 1, NULL, 1, '1998-06-08', N'pt4_m.jpg'),
(N'Hoàng Hữu', N'Đạt', '0379123456', 1, NULL, 1, '2002-04-14', N'pt1_m.jpg'),
(N'Vũ Văn', N'Thắng', '0856347890', 1, NULL, 1, '1999-08-23', N'pt4_m.jpg'),
(N'Phan Đức', N'Phúc', '0976543210', 0, '2023-03-05', 1, '1994-10-05', N'pt1_m.jpg'),
(N'Đặng Minh', N'Tâm', '0887654321', 1, NULL, 1, '1996-02-11', N'pt4_m.jpg'),
(N'Nguyễn Văn', N'Khoa', '0795678901', 1, NULL, 1, '2001-07-01', N'pt1_m.jpg'),
(N'Trần Hữu', N'Phát', '0834567890', 1, NULL, 1, '1997-05-09', N'pt4_m.jpg'),
(N'Lê Minh', N'Hậu', '0911112233', 1, NULL, 1, '1989-04-12', N'pt1_m.jpg'),
(N'Phạm Đức', N'Anh', '0902223344', 0, '2022-08-07', 1, '1991-10-23', N'pt4_m.jpg'),
(N'Hoàng Văn', N'Tiến', '0933334455', 1, NULL, 1, '1995-12-11', N'pt1_m.jpg'),
(N'Vũ Hữu', N'Quân', '0944445566', 1, NULL, 1, '1993-01-18', N'pt4_m.jpg'),
(N'Phan Minh', N'Hải', '0955556677', 1, NULL, 1, '1999-09-09', N'pt1_m.jpg'),
(N'Đặng Văn', N'Dũng', '0966667788', 0, '2024-04-20', 1, '1998-03-02', N'pt4_m.jpg'),
(N'Nguyễn Hữu', N'Thịnh', '0977778899', 1, NULL, 1, '1994-08-27', N'pt1_m.jpg'),
(N'Trần Đức', N'Trung', '0988889900', 1, NULL, 1, '1990-02-22', N'pt4_m.jpg'),
(N'Lê Minh', N'Hoàng', '0999990011', 1, NULL, 1, '1996-06-16', N'pt1_m.jpg'),
(N'Phạm Hữu', N'Vinh', '0833332222', 1, NULL, 1, '1992-03-28', N'pt4_m.jpg'),
(N'Hoàng Văn', N'Hưng', '0844443333', 0, '2024-07-01', 1, '1993-11-30', N'pt1_m.jpg'),
(N'Vũ Hữu', N'Bình', '0855554444', 1, NULL, 1, '1998-10-04', N'pt4_m.jpg'),
(N'Phan Đức', N'Thọ', '0866665555', 1, NULL, 1, '2000-01-09', N'pt1_m.jpg'),
(N'Đặng Minh', N'Tuấn', '0877776666', 1, NULL, 1, '1995-02-19', N'pt4_m.jpg'),
(N'Nguyễn Văn', N'Đức', '0888887777', 1, NULL, 1, '1994-07-05', N'pt1_m.jpg'),
(N'Trần Hữu', N'Nhật', '0899998888', 0, '2023-12-01', 1, '2001-09-14', N'pt4_m.jpg'),
(N'Lê Đức', N'Kiên', '0901010101', 1, NULL, 1, '1997-03-17', N'pt1_m.jpg'),
(N'Phạm Minh', N'Thành', '0912121212', 1, NULL, 1, '1995-05-05', N'pt4_m.jpg'),
(N'Hoàng Hữu', N'Lộc', '0923232323', 1, NULL, 1, '1993-06-06', N'pt1_m.jpg'),
(N'Vũ Văn', N'Triết', '0934343434', 1, NULL, 1, '1988-04-25', N'pt4_m.jpg'),
(N'Phan Đức', N'Khôi', '0945454545', 1, NULL, 1, '1999-02-15', N'pt1_m.jpg'),
(N'Đặng Minh', N'Phong', '0956565656', 1, NULL, 1, '2000-07-20', N'pt4_m.jpg'),
(N'Nguyễn Văn', N'Quý', '0967676767', 1, NULL, 1, '1992-12-12', N'pt1_m.jpg'),
(N'Trần Hữu', N'Thái', '0978787878', 0, '2023-05-15', 1, '1997-09-08', N'pt4_m.jpg'),
(N'Lê Đức', N'Thịnh', '0989898989', 1, NULL, 1, '1995-11-25', N'pt1_m.jpg'),
(N'Phạm Minh', N'Vũ', '0990909090', 1, NULL, 1, '1999-03-30', N'pt4_m.jpg'),
(N'Hoàng Hữu', N'Hiếu', '0818181818', 1, NULL, 1, '1998-10-19', N'pt1_m.jpg'),
(N'Vũ Văn', N'Khánh', '0828282828', 1, NULL, 1, '1993-01-22', N'pt4_m.jpg'),
(N'Phan Đức', N'Vương', '0838383838', 1, NULL, 1, '1990-07-03', N'pt1_m.jpg'),
(N'Đặng Minh', N'Phúc', '0848484848', 1, NULL, 1, '2001-06-29', N'pt4_m.jpg');


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