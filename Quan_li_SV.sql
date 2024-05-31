CREATE DATABASE Quan_li_SV 
GO
 
USE Quan_li_SV 
GO 
 
CREATE TABLE TaiKhoan ( 
    TenDangNhap NVARCHAR(50) PRIMARY KEY,  
    MatKhau NVARCHAR(50) not null,  
    VaiTro INT not null, -- Giả sử enum được ánh xạ thành các giá trị số nguyên ( 0 là sinh viên, 1 là giảng viên, 2 là nhân viên)
    TrangThai INT DEFAULT 1, --(1 là đang hoạt động, 0 là đang khóa)
); 
GO
  
CREATE TABLE Khoa ( 
    MaKhoa NVARCHAR(50) PRIMARY KEY, 
    TenKhoa NVARCHAR(50) not null
);
GO
       
CREATE TABLE QuanLy ( 
    MaNQL NVARCHAR(50) PRIMARY KEY, 
    TenDangNhap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap),
    Email NVARCHAR(50) UNIQUE, 
    SDT NVARCHAR(10) not null, 
    NgaySinh DATE CHECK (YEAR(GETDATE()) - YEAR(NgaySinh) >= 18) not null, 
    DiaChi NVARCHAR(100) not null, 
    HoTen NVARCHAR(50) not null, 
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN(N'Nam', N'Nữ')) not null
);
GO
 
CREATE TABLE GiangVien ( 
    MaGV NVARCHAR(50) PRIMARY KEY, 
    TenDangNhap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap), 
    MaKhoa NVARCHAR(50) REFERENCES Khoa(MaKhoa), 
    Email NVARCHAR(50) UNIQUE, 
    SDT NVARCHAR(10) not null, 
    NgaySinh DATE CHECK (YEAR(GETDATE()) - YEAR(NgaySinh) >= 18) not null, 
    DiaChi NVARCHAR(100) not null, 
    HoTen NVARCHAR(50) not null, 
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN(N'Nam', N'Nữ')) not null
);
GO
 
CREATE TABLE SinhVien (  
    MaSV NVARCHAR(50) PRIMARY KEY, 
    TenDangNhap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap),  
    Lop NVARCHAR(50) not null,  
    MaKhoa NVARCHAR(50) REFERENCES Khoa(MaKhoa), 
	Email NVARCHAR(50) UNIQUE,  
    SDT NVARCHAR(10) not null, 
    NgaySinh DATE CHECK (YEAR(GETDATE()) - YEAR(NgaySinh) >= 18) not null, 
    DiaChi NVARCHAR(100) not null, 
    HoTen NVARCHAR(50) not null, 
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN(N'Nam', N'Nữ')) not null
); 
 
CREATE TABLE MonHoc ( 
    MaMH NVARCHAR(50) PRIMARY KEY,  
    TenMH NVARCHAR(50) not null,  
    HocKy NVARCHAR(50) not null,			--Theo chương trình đào tạo sẽ mở cho sinh viên đăng ký vào học kỳ nào
	TinChi NVARCHAR(50) not null,
    MaKhoa NVARCHAR(50) REFERENCES Khoa(MaKhoa)  
); 
 
CREATE TABLE HocPhan ( 
	MaHocPhan NVARCHAR(50) PRIMARY KEY, 
    MaMonHoc NVARCHAR(50) REFERENCES MonHoc(MaMH), 
    TenHocPhan NVARCHAR(50) not null, 
    MaGV NVARCHAR(50) REFERENCES GiangVien(MaGV), 
    Nam NVARCHAR(50) not null, 
    NgayMoDau NVARCHAR(50) not null,
	NgayKetThuc NVARCHAR(50) not null,
	TinChi NVARCHAR(50) not null,
	ThongTin NVARCHAR(500) not null,  --Thứ, tiết, phòng, cơ sở
); 
 
CREATE TABLE Diem ( 
    MaSinhVien NVARCHAR(50) REFERENCES SinhVien(MaSV), 
    MaHocPhan NVARCHAR(50) REFERENCES HocPhan(MaHocPhan), 
    DiemQuaTrinh FLOAT NULL,
    DiemGiuaKy FLOAT NULL,
    DiemCuoiKy FLOAT NULL,
    CONSTRAINT CHK_DiemQuaTrinh CHECK (DiemQuaTrinh IS NULL OR (DiemQuaTrinh >= 0 AND DiemQuaTrinh <= 10)),
    CONSTRAINT CHK_DiemGiuaKy CHECK (DiemGiuaKy IS NULL OR (DiemGiuaKy >= 0 AND DiemGiuaKy <= 10)),
    CONSTRAINT CHK_DiemCuoiKy CHECK (DiemCuoiKy IS NULL OR (DiemCuoiKy >= 0 AND DiemCuoiKy <= 10)),
    PRIMARY KEY (MaSinhVien, MaHocPhan) 
);

CREATE TABLE ThoiKhoaBieu ( 
	MaTKB NVARCHAR(50) PRIMARY KEY, 
    MaSinhVien NVARCHAR(50) REFERENCES SinhVien(MaSV), 
    HocKy NVARCHAR(50) not null CHECK (HocKy IN ('1', '2')),
    NamHoc NVARCHAR(50) not null,	--dữ liệu kiểu 2021-2022; 2022-2023; 2023-2024; 2024-2025
	UNIQUE (MaSinhVien, HocKy, NamHoc)
);

CREATE TABLE DangKy ( 
	MaDangKy NVARCHAR(50) PRIMARY KEY, 
    MaTKB NVARCHAR(50) REFERENCES ThoiKhoaBieu(MaTKB), 
    MaHocPhan NVARCHAR(50) REFERENCES HocPhan(MaHocPhan),
	UNIQUE (MaTKB, MaHocPhan)
); 


CREATE TABLE ThongBao (
    MaThongBao NVARCHAR(50) PRIMARY KEY,
    TieuDe NVARCHAR(100) NOT NULL,
    NoiDung NVARCHAR(MAX) NOT NULL,
    NgayTao DATETIME DEFAULT GETDATE(),
    NguoiTao NVARCHAR(50) REFERENCES QuanLy(MaNQL)
);

CREATE TABLE HocPhi (
    MaHocPhi NVARCHAR(50) PRIMARY KEY,
    HocPhi INT NOT NULL,
    TrangThai INT DEFAULT 0 CHECK (TrangThai IN (0, 1)),
    NgayThanhToan DATETIME,
    MaTKB NVARCHAR(50) REFERENCES ThoiKhoaBieu(MaTKB)
);

CREATE TABLE GopYVaHoiDap (
  MaGopY NVARCHAR(50) PRIMARY KEY,
  MaSinhVien NVARCHAR(50) REFERENCES SinhVien(MaSV),
  HoTen NVARCHAR(50) NOT NULL,
  Email NVARCHAR(50),
  NoiDung NVARCHAR(500) NOT NULL,
  TrangThai INT NOT NULL DEFAULT 1
  
);

---------------------------------INSERT CÁC KIỂU--------------------------------------------
INSERT INTO Khoa VALUES
('CNTT', N'Công nghệ thông tin'),
('NV', N'Ngữ Văn'),
('GDCT', N'Giáo dục chính trị'),
('TT', N'Toán-Tin')
GO

INSERT INTO TaiKhoan(TenDangNhap, MatKhau, VaiTro, TrangThai) VALUES
('47.01.104.001', N'12345678',0, 1),
('47.01.104.002', N'12345678',0, 1),
('47.01.104.003', N'12345678',0, 1),
('47.01.104.004', N'12345678',0, 1),
('GV001', N'12345678',1, 1),
('GV002', N'12345678',1, 1),
('GV003', N'12345678',1, 1),
('GV004', N'12345678',1, 1),
('GV005', N'12345678',1, 1),
('GV006', N'12345678',1, 1),
('QL001', N'12345678',2, 1),
('QL002', N'12345678',2, 1)
GO

INSERT INTO SinhVien(MaSV, TenDangNhap, Lop, MaKhoa, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh) VALUES
('47.01.104.001', '47.01.104.001', '47.01.CNTT.A', 'CNTT', 'NSV1@gmail.com', '0999999999', '2003-01-01', '280 ADV', N'Nguyễn Sinh Viên 1', N'Nam'),
('47.01.104.002', '47.01.104.002', '47.01.CNTT.B', 'CNTT', 'NSV2@gmail.com', '0888888888', '2003-01-01',  '280 ADV', N'Nguyễn Sinh Viên 2', N'Nữ'),
('47.01.104.003', '47.01.104.003', '47.01.CNTT.C', 'CNTT', 'NSV3@gmail.com', '0999999998', '2003-01-01', '280 ADV', N'Nguyễn Sinh Viên 3', N'Nam'),
('47.01.104.004', '47.01.104.004', '47.01.CNTT.D', 'CNTT', 'NSV4@gmail.com', '0888888887', '2003-01-01',  '280 ADV', N'Nguyễn Sinh Viên 4', N'Nữ')
GO

INSERT INTO GiangVien(MaGV, TenDangNhap, MaKhoa, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh) VALUES
('GV001', 'GV001', 'CNTT', 'NGV1@gmail.com', '0777777777', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 1', N'Nam'),
('GV002', 'GV002', 'CNTT', 'NGV2@gmail.com', '0666666666', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 2', N'Nữ'),
('GV003', 'GV003', 'GDCT', 'NGV3@gmail.com', '0666666661', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 3', N'Nam'),
('GV004', 'GV004', 'GDCT', 'NGV4@gmail.com', '0666666662', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 4', N'Nữ'),
('GV005', 'GV005', 'TT', 'NGV5@gmail.com', '0666666663', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 5', N'Nam'),
('GV006', 'GV006', 'TT', 'NGV6@gmail.com', '0666666664', '1995-01-01', '280 ADV', N'Nguyễn Giảng Viên 6', N'Nữ')
GO

INSERT INTO QuanLy(MaNQL, TenDangNhap, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh) VALUES
('QL001', 'QL001', 'NQL1@gmail.com', '0555555555', '1995-01-01', '280 ADV', N'Nguyễn Quản Lý 1', N'Nam'),
('QL002', 'QL002', 'NQL2@gmail.com', '0444444444', '1995-01-01', '280 ADV', N'Nguyễn Quản Lý 2', N'Nữ')
GO

INSERT INTO MonHoc(MaMH, TenMH, HocKy, TinChi, MaKhoa) VALUES
('POLI2001', N'Triết học Mác - Lênin', '1', '3', 'GDCT'),
('POLI1903', N'Pháp luật đại cương', '1', '2', 'GDCT'),
('MATH1002', N'Giải tích 1', '1', '3', 'TT'),
('COMP1010', N'Lập trình cơ bản', '1', '3', 'CNTT'),
('MATH1108', N' Đại số tuyến tính', '1', '3', 'TT'),
('MATH1010', N'Toán rời rạc', '1', '2', 'CNTT'),
('POLI2002', N'Kinh tế chính trị học Mác-Lênin', '2', '2', 'GDCT'),
('POLI2003', N'Chủ nghĩa xã hội khoa học', '2', '2','GDCT'),
('COMP1013', N'Lập trình nâng cao', '2', '3', 'CNTT'),
('COMP1205', N'Phương pháp nghiên cứu khoa học', '2', '2', 'CNTT'),
('COMP1017', N'Lập trình hướng đối tượng', '2', '3', 'CNTT'),
('COMP1501', N'Xác suất thống kê và ứng dụng', '2', '3', 'CNTT'),
('COMP1502', N'Quy hoạch tuyến tính và ứng dụng', '2', '3', 'CNTT'),
('POLI2005', N'Tư tưởng Hồ Chí Minh', '3', '2', 'GDCT'),
('COMP1701', N'Lý thuyết đồ thị và ứng dụng', '3', '3', 'CNTT'),
('COMP1018', N'Cơ sở dữ liệu', '3', '3', 'CNTT'),
('COMP1011', N'Kiến trúc máy tính và hợp ngữ', '3', '3', 'CNTT'),
('COMP1016', N'Cấu trúc dữ liệu', '3', '3', 'CNTT'),
('COMP1019', N'Lập trình trên Windows', '3', '3', 'CNTT'),
('POLI2004', N'Lịch sử Đảng Cộng sản Việt Nam', '4', '2', 'GDCT'),
('COMP1015', N'Nhập môn mạng máy tính', '4', '3', 'CNTT'),
('COMP1332', N'Hệ điều hành', '4', '3', 'CNTT'),
('COMP1303', N'Phát triển ứng dụng Web', '4', '3', 'CNTT'),
('COMP1401', N'Phân tích và thiết kế giải thuật', '4', '3', 'CNTT'),
('COMP1304', N'Phát triển ứng dụng trên thiết bị di động', '4', '3', 'CNTT'),
('COMP1044', N'Nhập môn công nghệ phần mềm', '5', '3', 'CNTT'),
('COMP1024', N'Các hệ cơ sở dữ liệu', '5', '3', 'CNTT'),
('COMP1704', N'Nhập môn DevOps', '5', '3', 'CNTT'),
('COMP1060', N'Phân tích thiết kế hướng đối tượng', '5', '3', 'CNTT'),
('COMP1064', N'Công nghệ NET', '5', '3', 'CNTT'),
('COMP1042', N'Công nghệ JAVA', '5', '3', 'CNTT'),
('COMP1031', N'Công nghệ Web', '5', '3', 'CNTT')
GO

INSERT INTO HocPhan(MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin) VALUES
--------- NAM1------------
('MATH100201', 'MATH1002', N'Giải tích 1', 'GV005', '2021', '11/10/2021', '06/12/2021', '3', N'Thứ Hai, Tiết(7 - 11), 280 An Dương Vương, Q.5'),
('MATH101001', 'MATH1010', N'Toán rời rạc', 'GV001', '2021', '11/10/2021', '13/12/2021', '2', N'Thứ Hai, Tiết(1 - 3), 280 An Dương Vương, Q.5'),
('MATH110801', 'MATH1108', N'Đại số tuyến tính', 'GV005', '2021', '12/10/2021', '07/12/2021', '3', N'Thứ Ba, Tiết(2 - 6), 280 An Dương Vương, Q.5'),
('COMP101001', 'COMP1010', N'Lập trình cơ bản', 'GV001', '2021', '12/10/2021', '28/12/2021', '3', N'Thứ Ba, Tiết(7 - 11), 280 An Dương Vương, Q.5'),
('POLI190301', 'POLI1903', N'Pháp luật đại cương', 'GV003', '2021', '14/10/2021', '11/11/2021', '2', N'Thứ Năm, Tiết(7 - 12), Online, 280 An Dương Vương, Q.5'),
('POLI200101', 'POLI2001', N'Triết học Mác – Lênin', 'GV003', '2021', '18/11/2021', '16/12/2021', '3', N'Thứ Năm, Tiết(4 - 12), Online, 280 An Dương Vương, Q.5'),
--------------------------
('MATH100202', 'MATH1002', N'Giải tích 1', 'GV006', '2021', '11/10/2021', '06/12/2021', '3', N'Thứ Hai, Tiết(7 - 11), 280 An Dương Vương, Q.5'),
('MATH101002', 'MATH1010', N'Toán rời rạc', 'GV002', '2021', '11/10/2021', '13/12/2021', '2', N'Thứ Hai, Tiết(1 - 3), 280 An Dương Vương, Q.5'),
('MATH110802', 'MATH1108', N'Đại số tuyến tính', 'GV006', '2021', '12/10/2021', '07/12/2021', '3', N'Thứ Ba, Tiết(2 - 6), 280 An Dương Vương, Q.5'),
('COMP101002', 'COMP1010', N'Lập trình cơ bản', 'GV002', '2021', '12/10/2021', '28/12/2021', '3', N'Thứ Ba, Tiết(7 - 11), 280 An Dương Vương, Q.5'),
('POLI190302', 'POLI1903', N'Pháp luật đại cương', 'GV004', '2021', '14/10/2021', '11/11/2021', '2', N'Thứ Năm, Tiết(7 - 12), Online, 280 An Dương Vương, Q.5'),
('POLI200102', 'POLI2001', N'Triết học Mác – Lênin', 'GV004', '2021', '18/11/2021', '16/12/2021', '3', N'Thứ Năm, Tiết(4 - 12), Online, 280 An Dương Vương, Q.5'),
--------------------------
('COMP150101', 'COMP1501', N'Xác suất thống kê và ứng dụng', 'GV001', '2022', '14/02/2022', '23/05/2022', '3', N'Thứ Hai, Tiết(4 - 6), B.214, 280 An Dương Vương, Q.5'),
('COMP150201', 'COMP1502', N'Quy hoạch tuyến tính và ứng dụng', 'GV001', '2022', '14/02/2022', '23/05/2022', '3', N'Thứ Hai, Tiết(7 - 9), B.215, 280 An Dương Vương, Q.5'),
('COMP101701', 'COMP1017', N'Lập trình hướng đối tượng', 'GV001', '2022', '15/02/2022', '03/05/2022', '3', N'Thứ Ba, Tiết(7 - 11), I.102, 280 An Dương Vương, Q.5'),
('COMP120501', 'COMP1205', N'Phương pháp nghiên cứu khoa học', 'GV001', '2022', '16/02/2022', '23/03/2022', '2', N'Thứ Tư, Tiết(1 - 5), GD.D, 280 An Dương Vương, Q.5'),
('COMP101301', 'COMP1013', N'Lập trình nâng cao', 'GV001', '2022', '16/02/2022', '07/04/2022', '3', N'Thứ Tư, Tiết(7 - 9), I.203, 280 An Dương Vương, Q.5;Thứ Năm, Tiết(2 - 6), LVS.D.104, 222 Lê Văn Sỹ, Q.3'),
('POLI200201', 'POLI2002', N'Kinh tế chính trị học Mác - Lênin', 'GV003', '2022', '18/02/2022', '18/03/2022', '2', N'Thứ Sáu, Tiết(1 - 6), LVS.GD.18, 222 Lê Văn Sỹ, Q.3'),
('POLI200301', 'POLI2003', N'Chủ nghĩa xã hội khoa học', 'GV003', '2022', '22/03/2022', '19/04/2022', '2', N'Thứ Ba, Tiết(1 - 6), LLQ.D.202, 351 Lạc Long Quân, P.5, Q.11'),
---------------------------
('COMP150102', 'COMP1501', N'Xác suất thống kê và ứng dụng', 'GV001', '2022', '14/02/2022', '23/05/2022', '3', N'Thứ Hai, Tiết(4 - 6), B.214, 280 An Dương Vương, Q.5'),
('COMP150202', 'COMP1502', N'Quy hoạch tuyến tính và ứng dụng', 'GV001', '2022', '14/02/2022', '23/05/2022', '3', N'Thứ Hai, Tiết(7 - 9), B.215, 280 An Dương Vương, Q.5'),
('COMP101702', 'COMP1017', N'Lập trình hướng đối tượng', 'GV001', '2022', '15/02/2022', '03/05/2022', '3', N'Thứ Ba, Tiết(7 - 11), I.102, 280 An Dương Vương, Q.5'),
('COMP120502', 'COMP1205', N'Phương pháp nghiên cứu khoa học', 'GV001', '2022', '16/02/2022', '23/03/2022', '2', N'Thứ Tư, Tiết(1 - 5), GD.D, 280 An Dương Vương, Q.5'),
('COMP101302', 'COMP1013', N'Lập trình nâng cao', 'GV001', '2022', '16/02/2022', '07/04/2022', '3', N'Thứ Tư, Tiết(7 - 9), I.203, 280 An Dương Vương, Q.5;Thứ Năm, Tiết(2 - 6), LVS.D.104, 222 Lê Văn Sỹ, Q.3'),
('POLI200202', 'POLI2002', N'Kinh tế chính trị học Mác - Lênin', 'GV003', '2022', '18/02/2022', '18/03/2022', '2', N'Thứ Sáu, Tiết(1 - 6), LVS.GD.18, 222 Lê Văn Sỹ, Q.3'),
('POLI200302', 'POLI2003', N'Chủ nghĩa xã hội khoa học', 'GV003', '2022', '22/03/2022', '19/04/2022', '2', N'Thứ Ba, Tiết(1 - 6), LLQ.D.202, 351 Lạc Long Quân, P.5, Q.11'),
--------- NAM2------------
('COMP101901', 'COMP1019', N'Lập trình trên Windows', 'GV001', '2022', '05/09/2022', '21/11/2022', '3', N'Thứ Hai, Tiết(7 - 11), I.102, 280 An Dương Vương, Q.5'),
('COMP170101', 'COMP1701', N'Lý thuyết đồ thị và ứng dụng', 'GV001', '2022', '06/09/2022', '12/10/2022', '3', N'Thứ Ba, Tiết(4 - 6), I.203, 280 An Dương Vương, Q.5;Thứ Tư, Tiết(1 - 2), LVS.D.104, 222 Lê Văn Sỹ, Q.3'),
('COMP101601', 'COMP1016', N'Cấu trúc dữ liệu', 'GV001', '2022', '06/09/2022', '22/11/2022', '3', N'Thứ Ba, Tiết(7 - 11), I.203, 280 An Dương Vương, Q.5'),
('COMP101801', 'COMP1018', N'Cơ sở dữ liệu', 'GV001', '2022', '08/09/2022', '24/11/2022', '3', N'Thứ Năm, Tiết(2 - 6), I.201, 280 An Dương Vương, Q.5'),
('COMP101101', 'COMP1011', N'Kiến trúc máy tính và hợp ngữ', 'GV001', '2022', '08/09/2022', '03/11/2022', '3', N'Thứ Năm, Tiết(7 - 11), B.214, 280 An Dương Vương, Q.5'),
('POLI200511', 'POLI2005', N'Tư tưởng Hồ Chí Minh', 'GV003', '2022', '12/10/2022', '09/11/2022', '2', N'Thứ Tư, Tiết(7 - 12), A.313*, 280 An Dương Vương, Q.5'),
---------------------------
('COMP101902', 'COMP1019', N'Lập trình trên Windows', 'GV002', '2022', '05/09/2022', '21/11/2022', '3', N'Thứ Hai, Tiết(7 - 11), I.102, 280 An Dương Vương, Q.5'),
('COMP170102', 'COMP1701', N'Lý thuyết đồ thị và ứng dụng', 'GV002', '2022', '06/09/2022', '12/10/2022', '3', N'Thứ Ba, Tiết(4 - 6), I.203, 280 An Dương Vương, Q.5;Thứ Tư, Tiết(1 - 2), LVS.D.104, 222 Lê Văn Sỹ, Q.3'),
('COMP101602', 'COMP1016', N'Cấu trúc dữ liệu', 'GV002', '2022', '06/09/2022', '22/11/2022', '3', N'Thứ Ba, Tiết(7 - 11), I.203, 280 An Dương Vương, Q.5'),
('COMP101802', 'COMP1018', N'Cơ sở dữ liệu', 'GV002', '2022', '08/09/2022', '24/11/2022', '3', N'Thứ Năm, Tiết(2 - 6), I.201, 280 An Dương Vương, Q.5'),
('COMP101102', 'COMP1011', N'Kiến trúc máy tính và hợp ngữ', 'GV002', '2022', '08/09/2022', '03/11/2022', '3', N'Thứ Năm, Tiết(7 - 11), B.214, 280 An Dương Vương, Q.5'),
('POLI200512', 'POLI2005', N'Tư tưởng Hồ Chí Minh', 'GV004', '2022', '12/10/2022', '09/11/2022', '2', N'Thứ Tư, Tiết(7 - 12), A.313*, 280 An Dương Vương, Q.5'),
---------------------------
('COMP130401', 'COMP1304', N'Phát triển ứng dụng trên thiết bị di động', 'GV001', '2023', '13/02/2023', '22/05/2023', '3', N'Thứ Hai, Tiết(1 - 4), I.201, 280 An Dương Vương, Q.5'),
('POLI200431', 'POLI2004', N'Lịch sử Đảng cộng sản Việt Nam', 'GV003', '2023', '13/02/2023', '17/03/2023', '2', N'Thứ Hai, Tiết(7 - 9), LLQ.D.106, 351 Lạc Long Quân, P.5, Q.11;Thứ Sáu, Tiết(7 - 9), LLQ.D.106, 351 Lạc Long Quân, P.5, Q.11'),
('COMP133201', 'COMP1332', N'Hệ điều hành', 'GV001', '2023', '15/02/2023', '03/05/2023', '3', N'Thứ Tư, Tiết(7 - 11), B.215, 280 An Dương Vương, Q.5'),
('COMP101501', 'COMP1015', N'Nhập môn mạng máy tính', 'GV001', '2023', '15/02/2023', '12/04/2023', '3', N'Thứ Tư, Tiết(2 - 6), I.202, 280 An Dương Vương, Q.5'),
('COMP104401', 'COMP1044', N'Nhập môn công nghệ phần mềm', 'GV001', '2023', '16/02/2023', '27/04/2023', '3', N'Thứ Năm, Tiết(7 - 10), B.214, 280 An Dương Vương, Q.5'),
('COMP140101', 'COMP1401', N'Phân tích và thiết kế giải thuật', 'GV001', '2023', '16/02/2023', '13/04/2023', '3', N'Thứ Năm, Tiết(1 - 5), B.214, 280 An Dương Vương, Q.5'),
('COMP130301', 'COMP1303', N'Phát triển ứng dụng Web', 'GV001', '2023', '17/02/2023', '05/05/2023', '3', N'Thứ Sáu, Tiết(2 - 6), I.203, 280 An Dương Vương, Q.5'),
---------------------------
('COMP130402', 'COMP1304', N'Phát triển ứng dụng trên thiết bị di động', 'GV002', '2023', '13/02/2023', '22/05/2023', '3', N'Thứ Hai, Tiết(1 - 4), I.201, 280 An Dương Vương, Q.5'),
('POLI200432', 'POLI2004', N'Lịch sử Đảng cộng sản Việt Nam', 'GV004', '2023', '13/02/2023', '17/03/2023', '2', N'Thứ Hai, Tiết(7 - 9), LLQ.D.106, 351 Lạc Long Quân, P.5, Q.11;Thứ Sáu, Tiết(7 - 9), LLQ.D.106, 351 Lạc Long Quân, P.5, Q.11'),
('COMP133202', 'COMP1332', N'Hệ điều hành', 'GV002', '2023', '15/02/2023', '03/05/2023', '3', N'Thứ Tư, Tiết(7 - 11), B.215, 280 An Dương Vương, Q.5'),
('COMP101502', 'COMP1015', N'Nhập môn mạng máy tính', 'GV002', '2023', '15/02/2023', '12/04/2023', '3', N'Thứ Tư, Tiết(2 - 6), I.202, 280 An Dương Vương, Q.5'),
('COMP104402', 'COMP1044', N'Nhập môn công nghệ phần mềm', 'GV002', '2023', '16/02/2023', '27/04/2023', '3', N'Thứ Năm, Tiết(7 - 10), B.214, 280 An Dương Vương, Q.5'),
('COMP140102', 'COMP1401', N'Phân tích và thiết kế giải thuật', 'GV002', '2023', '16/02/2023', '13/04/2023', '3', N'Thứ Năm, Tiết(1 - 5), B.214, 280 An Dương Vương, Q.5'),
('COMP130302', 'COMP1303', N'Phát triển ứng dụng Web', 'GV002', '2023', '17/02/2023', '05/05/2023', '3', N'Thứ Sáu, Tiết(2 - 6), I.203, 280 An Dương Vương, Q.5'),
--------- NAM3------------
('COMP102401', 'COMP1024', N'Các hệ cơ sở dữ liệu', 'GV001', '2023', '05/09/2023', '14/11/2023', '3', N'Thứ Ba, Tiết(2 - 5), I.202, 280 An Dương Vương, Q.5'),
('COMP170401', 'COMP1704', N'Nhập môn DevOps', 'GV001', '2023', '06/09/2023', '01/11/2023', '3', N'Thứ Tư, Tiết(2 - 6), C.203, 280 An Dương Vương, Q.5'),
('COMP106001', 'COMP1060', N'Phân tích thiết kế hướng đối tượng', 'GV001', '2023', '08/09/2023', '24/11/2023', '3', N'Thứ Sáu, Tiết(4 - 6), B.214, 280 An Dương Vương, Q.5'),
('COMP106401', 'COMP1064', N'Công nghệ NET', 'GV001', '2023', '08/09/2023', '13/10/2023', '3', N'Thứ Sáu, Tiết(7 - 11), C.201, 280 An Dương Vương, Q.5'),
('COMP104201', 'COMP1042', N'Công nghệ JAVA', 'GV001', '2023', '09/09/2023', '14/10/2023', '3', N'Thứ Bảy, Tiết(2 - 6), I.201, 280 An Dương Vương, Q.5'),
('COMP103101', 'COMP1031', N'Công nghệ Web', 'GV001', '2023', '11/09/2023', '16/10/2023', '3', N'Thứ Hai, Tiết(2 - 6), I.203, 280 An Dương Vương, Q.5')
GO

INSERT INTO ThoiKhoaBieu(MaTKB, MaSinhVien, HocKy, NamHoc) VALUES
--------- NAM1------------
('TKB001', '47.01.104.001', '1', '2021-2022'),
('TKB002', '47.01.104.002', '1', '2021-2022'),
('TKB003', '47.01.104.001', '2', '2021-2022'),
('TKB004', '47.01.104.002', '2', '2021-2022'),
---
('TKB005', '47.01.104.003', '1', '2021-2022'),
('TKB006', '47.01.104.004', '1', '2021-2022'),
('TKB007', '47.01.104.003', '2', '2021-2022'),
('TKB008', '47.01.104.004', '2', '2021-2022'),
--------- NAM2------------
('TKB009', '47.01.104.001', '1', '2022-2023'),
('TKB010', '47.01.104.002', '1', '2022-2023'),
('TKB011', '47.01.104.001', '2', '2022-2023'),
('TKB012', '47.01.104.002', '2', '2022-2023'),
---
('TKB013', '47.01.104.003', '1', '2022-2023'),
('TKB014', '47.01.104.004', '1', '2022-2023'),
('TKB015', '47.01.104.003', '2', '2022-2023'),
('TKB016', '47.01.104.004', '2', '2022-2023'),
--------- NAM3------------
('TKB017', '47.01.104.001', '1', '2023-2024'),
('TKB018', '47.01.104.002', '1', '2023-2024')
GO

INSERT INTO DangKy(MaDangKy, MaTKB, MaHocPhan) VALUES
--------- NAM1-HK1 ------------
--SV1
('DK001', 'TKB001', 'MATH100201'),
('DK002', 'TKB001', 'MATH101001'),
('DK003', 'TKB001', 'MATH110801'),
('DK004', 'TKB001', 'COMP101001'),
('DK005', 'TKB001', 'POLI190301'),
('DK006', 'TKB001', 'POLI200101'),
--SV2
('DK007', 'TKB002', 'MATH100201'),
('DK008', 'TKB002', 'MATH101001'),
('DK009', 'TKB002', 'MATH110801'),
('DK010', 'TKB002', 'COMP101001'),
('DK011', 'TKB002', 'POLI190301'),
('DK012', 'TKB002', 'POLI200101'),
--SV3
('DK013', 'TKB005', 'MATH100202'),
('DK014', 'TKB005', 'MATH101002'),
('DK015', 'TKB005', 'MATH110802'),
('DK016', 'TKB005', 'COMP101002'),
('DK017', 'TKB005', 'POLI190302'),
('DK018', 'TKB005', 'POLI200102'),
--SV4
('DK019', 'TKB006', 'MATH100202'),
('DK020', 'TKB006', 'MATH101002'),
('DK021', 'TKB006', 'MATH110802'),
('DK022', 'TKB006', 'COMP101002'),
('DK023', 'TKB006', 'POLI190302'),
('DK024', 'TKB006', 'POLI200102'),
--------- NAM1-HK2------------
--SV1
('DK025', 'TKB003', 'COMP150101'),
('DK026', 'TKB003', 'COMP150201'),
('DK027', 'TKB003', 'COMP101701'),
('DK028', 'TKB003', 'COMP120501'),
('DK029', 'TKB003', 'COMP101301'),
('DK030', 'TKB003', 'POLI200201'),
('DK031', 'TKB003', 'POLI200301'),
--SV2
('DK032', 'TKB004', 'COMP150101'),
('DK033', 'TKB004', 'COMP150201'),
('DK034', 'TKB004', 'COMP101701'),
('DK035', 'TKB004', 'COMP120501'),
('DK036', 'TKB004', 'COMP101301'),
('DK037', 'TKB004', 'POLI200201'),
('DK038', 'TKB004', 'POLI200301'),
--SV3
('DK039', 'TKB007', 'COMP150102'),
('DK040', 'TKB007', 'COMP150202'),
('DK041', 'TKB007', 'COMP101702'),
('DK042', 'TKB007', 'COMP120502'),
('DK043', 'TKB007', 'COMP101302'),
('DK044', 'TKB007', 'POLI200202'),
('DK045', 'TKB007', 'POLI200302'),
--SV4
('DK046', 'TKB008', 'COMP150102'),
('DK047', 'TKB008', 'COMP150202'),
('DK048', 'TKB008', 'COMP101702'),
('DK049', 'TKB008', 'COMP120502'),
('DK050', 'TKB008', 'COMP101302'),
('DK051', 'TKB008', 'POLI200202'),
('DK052', 'TKB008', 'POLI200302'),
--------- NAM2-HK1------------
--SV1
('DK053', 'TKB009', 'COMP101901'),
('DK054', 'TKB009', 'COMP170101'),
('DK055', 'TKB009', 'COMP101601'),
('DK056', 'TKB009', 'COMP101801'),
('DK057', 'TKB009', 'COMP101101'),
('DK058', 'TKB009', 'POLI200511'),
--SV2
('DK059', 'TKB010', 'COMP101901'),
('DK060', 'TKB010', 'COMP170101'),
('DK061', 'TKB010', 'COMP101601'),
('DK062', 'TKB010', 'COMP101801'),
('DK063', 'TKB010', 'COMP101101'),
('DK064', 'TKB010', 'POLI200511'),
--SV3
('DK065', 'TKB013', 'COMP101902'),
('DK066', 'TKB013', 'COMP170102'),
('DK067', 'TKB013', 'COMP101602'),
('DK068', 'TKB013', 'COMP101802'),
('DK069', 'TKB013', 'COMP101102'),
('DK070', 'TKB013', 'POLI200512'),
--SV4
('DK071', 'TKB014', 'COMP101902'),
('DK072', 'TKB014', 'COMP170102'),
('DK073', 'TKB014', 'COMP101602'),
('DK074', 'TKB014', 'COMP101802'),
('DK075', 'TKB014', 'COMP101102'),
('DK076', 'TKB014', 'POLI200512'),
--------- NAM2-HK2------------
--SV1
('DK077', 'TKB011', 'COMP130401'),
('DK078', 'TKB011', 'POLI200431'),
('DK079', 'TKB011', 'COMP133201'),
('DK080', 'TKB011', 'COMP101501'),
('DK081', 'TKB011', 'COMP104401'),
('DK082', 'TKB011', 'COMP140101'),
('DK083', 'TKB011', 'COMP130301'),
--SV2
('DK084', 'TKB012', 'COMP130401'),
('DK085', 'TKB012', 'POLI200431'),
('DK086', 'TKB012', 'COMP133201'),
('DK087', 'TKB012', 'COMP101501'),
('DK088', 'TKB012', 'COMP104401'),
('DK089', 'TKB012', 'COMP140101'),
('DK090', 'TKB012', 'COMP130301'),
--SV3
('DK091', 'TKB015', 'COMP130402'),
('DK092', 'TKB015', 'POLI200432'),
('DK093', 'TKB015', 'COMP133202'),
('DK094', 'TKB015', 'COMP101502'),
('DK095', 'TKB015', 'COMP104402'),
('DK096', 'TKB015', 'COMP140102'),
('DK097', 'TKB015', 'COMP130302'),
--SV4
('DK098', 'TKB016', 'COMP130402'),
('DK099', 'TKB016', 'POLI200432'),
('DK100', 'TKB016', 'COMP133202'),
('DK101', 'TKB016', 'COMP101502'),
('DK102', 'TKB016', 'COMP104402'),
('DK103', 'TKB016', 'COMP140102'),
('DK104', 'TKB016', 'COMP130302')
GO

INSERT INTO Diem(MaSinhVien, MaHocPhan, DiemQuaTrinh, DiemGiuaKy, DiemCuoiKy) VALUES
--------- NAM1-HK1 ------------
--SV1
('47.01.104.001', 'MATH100201', 8, NULL, NULL),
('47.01.104.001', 'MATH101001', 8, NULL, NULL),
('47.01.104.001', 'MATH110801', 8, NULL, NULL),
('47.01.104.001', 'COMP101001', 8, NULL, NULL),
('47.01.104.001', 'POLI190301', 8, NULL, NULL),
('47.01.104.001', 'POLI200101', 8, NULL, NULL),
--SV3
('47.01.104.003', 'MATH100202', 8, NULL, NULL),
('47.01.104.003', 'MATH101002', 8, NULL, NULL),
('47.01.104.003', 'MATH110802', 8, NULL, NULL),
('47.01.104.003', 'COMP101002', 8, NULL, NULL),
('47.01.104.003', 'POLI190302', 8, NULL, NULL),
('47.01.104.003', 'POLI200102', 8, NULL, NULL),
--------- NAM1-HK2 ------------
--SV1
('47.01.104.001', 'COMP150101', 8, NULL, NULL),
('47.01.104.001', 'COMP150201', 8, NULL, NULL),
('47.01.104.001', 'COMP101701', 8, NULL, NULL),
('47.01.104.001', 'COMP120501', 8, NULL, NULL),
('47.01.104.001', 'COMP101301', 8, NULL, NULL),
('47.01.104.001', 'POLI200201', 8, NULL, NULL),
('47.01.104.001', 'POLI200301', 8, NULL, NULL),
--SV3
('47.01.104.003', 'COMP150102', 8, NULL, NULL),
('47.01.104.003', 'COMP150202', 8, NULL, NULL),
('47.01.104.003', 'COMP101702', 8, NULL, NULL),
('47.01.104.003', 'COMP120502', 8, NULL, NULL),
('47.01.104.003', 'COMP101302', 8, NULL, NULL),
('47.01.104.003', 'POLI200202', 8, NULL, NULL),
('47.01.104.003', 'POLI200302', 8, NULL, NULL),
--------- NAM2-HK1 ------------
--SV1
('47.01.104.001', 'COMP101901', 8, NULL, NULL),
('47.01.104.001', 'COMP170101', 8, NULL, NULL),
('47.01.104.001', 'COMP101601', 8, NULL, NULL),
('47.01.104.001', 'COMP101801', 8, NULL, NULL),
('47.01.104.001', 'COMP101101', 8, NULL, NULL),
('47.01.104.001', 'POLI200511', 8, NULL, NULL),
--SV3
('47.01.104.003', 'COMP101902', 8, NULL, NULL),
('47.01.104.003', 'COMP170102', 8, NULL, NULL),
('47.01.104.003', 'COMP101602', 8, NULL, NULL),
('47.01.104.003', 'COMP101802', 8, NULL, NULL),
('47.01.104.003', 'COMP101102', 8, NULL, NULL),
('47.01.104.003', 'POLI200512', 8, NULL, NULL),
--------- NAM2-HK2 ------------
--SV1
('47.01.104.001', 'COMP130401', 8, NULL, NULL),
('47.01.104.001', 'POLI200431', 8, NULL, NULL),
('47.01.104.001', 'COMP133201', 8, NULL, NULL),
('47.01.104.001', 'COMP101501', 8, NULL, NULL),
('47.01.104.001', 'COMP104401', 8, NULL, NULL),
('47.01.104.001', 'COMP140101', 8, NULL, NULL),
('47.01.104.001', 'COMP130301', 8, NULL, NULL),
--SV3
('47.01.104.003', 'COMP130402', 8, NULL, NULL),
('47.01.104.003', 'POLI200432', 8, NULL, NULL),
('47.01.104.003', 'COMP133202', 8, NULL, NULL),
('47.01.104.003', 'COMP101502', 8, NULL, NULL),
('47.01.104.003', 'COMP104402', 8, NULL, NULL),
('47.01.104.003', 'COMP140102', 8, NULL, NULL),
('47.01.104.003', 'COMP130302', 8, NULL, NULL)
GO

INSERT INTO HocPhi (MaHocPhi, HocPhi, TrangThai, NgayThanhToan, MaTKB)
VALUES ('MHP001', 500000, 1, '2024-05-10', 'TKB001'),
       ('MHP002', 0, 0, NULL, 'TKB002'),
       ('MHP003', 800000, 1, '2024-05-12', 'TKB003');
GO

INSERT INTO ThongBao (MaThongBao, TieuDe, NoiDung, NguoiTao)
VALUES 
	('MTB001', N'Thông báo về lịch thi', N'Lịch thi học kỳ 2 đã được cập nhật. Vui lòng kiểm tra thông tin chi tiết trên hệ thống.', 'QL001'),
    ('MTB002', N'Thông báo nghỉ học', N'Do tình hình dịch bệnh, tất cả các lớp học sẽ được nghỉ từ ngày mai.', 'QL002'),
	('MTB003', N'Thông báo học bù', N'Học sinh lớp 12A cần học bù tiết Toán vào ngày mai lúc 14h.', 'QL001'),
    ('MTB004', N'Thông báo về buổi họp phụ huynh', N'Buổi họp phụ huynh lớp 10A sẽ diễn ra vào ngày mai lúc 8:00 sáng.', 'QL001'),
    ('MTB005', N'Thông báo về kỳ thi tốt nghiệp', N'Kỳ thi tốt nghiệp THPT sẽ diễn ra vào tháng 6 năm nay. Chi tiết lịch thi sẽ được thông báo sau.', 'QL001'),
    ('MTB006', N'Thông báo về lịch nghỉ lễ 30/4 và 1/5', N'Nhà trường sẽ nghỉ lễ từ ngày 30/4 đến hết ngày 1/5. Tất cả học sinh và giáo viên vui lòng chú ý.', 'QL001'),
    ('MTB007', N'Thông báo về lịch học bù', N'Các lớp học buổi sáng sẽ học bù vào buổi chiều từ ngày mai.', 'QL001'),
    ('MTB008', N'Thông báo về cuộc thi hát', N'Cuộc thi hát cho học sinh sẽ diễn ra vào ngày 20/5 tại sân trường. Tất cả học sinh quan tâm đăng ký tham gia.', 'QL001'),
    ('MTB009', N'Thông báo về lịch nghỉ học bù', N'Lịch nghỉ học bù cho các lớp bị nghỉ do mưa sẽ được thông báo sau.', 'QL001'),
    ('MTB010', N'Thông báo về việc sửa chữa điện', N'Ngày mai sẽ tiến hành sửa chữa hệ thống điện trong nhà trường. Mong quý phụ huynh thông cảm.', 'QL001'),
    ('MTB011', N'Thông báo về buổi giới thiệu ngành', N'Buổi giới thiệu về ngành Công nghệ thông tin sẽ diễn ra vào 8:00 sáng thứ Bảy tuần sau.', 'QL001'),
    ('MTB012', N'Thông báo về kỳ thi Olympic Toán', N'Kỳ thi Olympic Toán sẽ diễn ra vào tháng 7. Học sinh quan tâm đăng ký tại phòng hành chính.', 'QL001'),
    ('MTB013', N'Thông báo về lịch thi học kỳ 2', N'Lịch thi học kỳ 2 đã được công bố. Học sinh vui lòng kiểm tra thông tin chi tiết trên hệ thống.', 'QL001'),
    ('MTB014', N'Thông báo về việc cấp sách giáo trình', N'Ngày mai sẽ tiến hành cấp sách giáo trình cho các lớp học. Vui lòng đến phòng hành chính để nhận sách.', 'QL001'),
    ('MTB015', N'Thông báo về cuộc thi viết', N'Cuộc thi viết cho học sinh sẽ diễn ra vào thứ Bảy tuần sau. Học sinh quan tâm đăng ký tại phòng văn phòng.', 'QL001'),
    ('MTB016', N'Thông báo về việc tổ chức buổi gặp mặt cựu học sinh', N'Buổi gặp mặt cựu học sinh sẽ diễn ra vào ngày 15/6 tại nhà trường. Xin mời quý cựu học sinh đến tham dự.', 'QL001'),
    ('MTB017', N'Thông báo về việc tổ chức buổi gặp mặt cựu giáo viên', N'Buổi gặp mặt cựu giáo viên sẽ diễn ra vào ngày 20/6 tại nhà trường. Quý cựu giáo viên vui lòng xác nhận tham dự.', 'QL001'),
    ('MTB018', N'Thông báo về việc triển khai chương trình học mùa hè', N'Chương trình học mùa hè sẽ được triển khai từ ngày 1/7 đến hết ngày 31/7. Học sinh quan tâm đăng ký tại phòng hành chính.', 'QL001'),
    ('MTB019', N'Thông báo về lịch học thêm Toán', N'Lịch học thêm môn Toán cho học sinh lớp 12 sẽ được thông báo sau.', 'QL001'),
    ('MTB020', N'Thông báo về việc tổ chức buổi gặp mặt học sinh xuất sắc', N'Buổi gặp mặt học sinh xuất sắc năm học sẽ diễn ra vào ngày 30/6 tại sân trường. Xin mời quý vị về dự.', 'QL001'),
    ('MTB021', N'Thông báo về việc tổ chức buổi gặp mặt phụ huynh', N'Buổi gặp mặt phụ huynh học sinh năm học sẽ diễn ra vào ngày 25/6 tại phòng hội trường. Mong quý phụ huynh tham dự đông đủ.', 'QL001'),
    ('MTB022', N'Thông báo về việc cập nhật hồ sơ học sinh', N'Hồ sơ học sinh sẽ được cập nhật vào ngày 15/6. Quý phụ huynh vui lòng đến trường để cập nhật thông tin.', 'QL001'),
    ('MTB023', N'Thông báo về việc nộp hồ sơ du học', N'Hạn chót nộp hồ sơ du học sẽ là ngày 30/5. Học sinh quan tâm vui lòng nộp hồ sơ tại phòng văn phòng.', 'QL001'),
    ('MTB024', N'Thông báo về việc tổ chức cuộc thi hát', N'Cuộc thi hát cho học sinh sẽ diễn ra vào ngày 25/6 tại sân trường. Xin mời các bạn đăng ký tham gia.', 'QL001'),
    ('MTB025', N'Thông báo về việc tổ chức buổi triển lãm nghệ thuật', N'Buổi triển lãm nghệ thuật sẽ diễn ra vào ngày 10/7 tại phòng triển lãm của nhà trường. Mong các bạn học sinh và giáo viên tham dự.', 'QL001'),
    ('MTB026', N'Thông báo về việc tổ chức buổi họp phụ huynh lớp 11', N'Buổi họp phụ huynh lớp 11 sẽ diễn ra vào ngày 20/6 tại phòng học của lớp. Xin mời quý phụ huynh tham dự đông đủ.', 'QL001'),
    ('MTB027', N'Thông báo về việc tổ chức lễ kỷ niệm 50 năm thành lập trường', N'Lễ kỷ niệm 50 năm thành lập trường sẽ diễn ra vào ngày 15/7 tại sân trường. Quý cựu học sinh và giáo viên vui lòng xác nhận tham dự.', 'QL001'),
    ('MTB028', N'Thông báo về việc tổ chức buổi gặp mặt lớp 12A', N'Buổi gặp mặt lớp 12A sẽ diễn ra vào ngày 15/6 tại phòng học của lớp. Xin mời quý thầy cô và các bạn học sinh về dự.', 'QL001'),
    ('MTB029', N'Thông báo về việc tổ chức buổi gặp mặt lớp 12B', N'Buổi gặp mặt lớp 12B sẽ diễn ra vào ngày 20/6 tại phòng học của lớp. Xin mời quý thầy cô và các bạn học sinh về dự.', 'QL001'),
    ('MTB030', N'Thông báo về việc tổ chức buổi gặp mặt lớp 12C', N'Buổi gặp mặt lớp 12C sẽ diễn ra vào ngày 25/6 tại phòng học của lớp. Xin mời quý thầy cô và các bạn học sinh về dự.', 'QL001');
GO

----------------------------------Store Procedure, trigger, function các kiểu-----------------------------------
CREATE PROC AccountLogin
	@userName nvarchar(100),
	@passWord nvarchar(100)
AS
BEGIN
	DECLARE @vaiTro INT
	SELECT * 
	FROM TaiKhoan
	WHERE TenDangNhap = @userName and MatKhau = @passWord
	SELECT @vaiTro = VaiTro FROM TaiKhoan WHERE TenDangNhap = @userName AND MatKhau = @passWord
	IF @vaiTro IS NOT NULL
    	BEGIN
       	 -- Trả về 1 nếu tài khoản tồn tại và đúng mật khẩu
        RETURN 1
    	END
    	ELSE
    	BEGIN
       	 -- Trả về 0 nếu tài khoản không tồn tại hoặc sai mật khẩu
       	 RETURN 0
    	END
END
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE PROCEDURE LayDanhSachSVCuaLopHocPhan
    @MaHocPhan NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ROW_NUMBER() OVER (ORDER BY SinhVien.MaSV) AS STT,
           SinhVien.MaSV,
           SinhVien.Lop,
           SinhVien.HoTen,
           SinhVien.NgaySinh,
           Diem.DiemQuaTrinh,
           Diem.DiemGiuaKy,
           Diem.DiemCuoiKy
    FROM SinhVien
    INNER JOIN ThoiKhoaBieu ON SinhVien.MaSV = ThoiKhoaBieu.MaSinhVien
    INNER JOIN DangKy ON DangKy.MaTKB = ThoiKhoaBieu.MaTKB
    INNER JOIN HocPhan ON DangKy.MaHocPhan = HocPhan.MaHocPhan
    LEFT JOIN Diem ON SinhVien.MaSV = Diem.MaSinhVien AND HocPhan.MaHocPhan = Diem.MaHocPhan
    WHERE HocPhan.MaHocPhan = @MaHocPhan;
END;
GO

CREATE PROCEDURE TimKiemSVTrongLopHocPhan
    @MaHocPhan NVARCHAR(50),
    @MaSV NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ROW_NUMBER() OVER (ORDER BY SinhVien.MaSV) AS STT,
           SinhVien.MaSV,
           SinhVien.Lop,
           SinhVien.HoTen,
           SinhVien.NgaySinh,
           Diem.DiemQuaTrinh,
           Diem.DiemGiuaKy,
           Diem.DiemCuoiKy
    FROM SinhVien
    INNER JOIN ThoiKhoaBieu ON SinhVien.MaSV = ThoiKhoaBieu.MaSinhVien
    INNER JOIN DangKy ON DangKy.MaTKB = ThoiKhoaBieu.MaTKB
    INNER JOIN HocPhan ON DangKy.MaHocPhan = HocPhan.MaHocPhan
    LEFT JOIN Diem ON SinhVien.MaSV = Diem.MaSinhVien AND HocPhan.MaHocPhan = Diem.MaHocPhan
    WHERE HocPhan.MaHocPhan = @MaHocPhan AND dbo.fuConvertToUnsign1(SinhVien.MaSV) LIKE N'%' + dbo.fuConvertToUnsign1(@MaSV) + '%'
END
GO

CREATE PROCEDURE LayDiemSinhVien
    @MaHocPhan NVARCHAR(50),
    @MaSV NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT HocPhan.MaHocPhan,
           SinhVien.HoTen,
           Diem.MaSinhVien AS MaSV,
           Diem.DiemQuaTrinh,
           Diem.DiemGiuaKy,
           Diem.DiemCuoiKy
    FROM Diem
    INNER JOIN HocPhan ON Diem.MaHocPhan = HocPhan.MaHocPhan
    INNER JOIN SinhVien ON Diem.MaSinhVien = SinhVien.MaSV
    WHERE Diem.MaHocPhan = @MaHocPhan AND Diem.MaSinhVien = @MaSV;
END;
GO

CREATE PROCEDURE UpdateDiemSinhVien
    @MaHocPhan NVARCHAR(50),
    @MaSV NVARCHAR(50),
    @DiemQuaTrinh FLOAT = NULL,
    @DiemGiuaKy FLOAT = NULL,
    @DiemCuoiKy FLOAT = NULL
AS
BEGIN
    UPDATE Diem
    SET DiemQuaTrinh = @DiemQuaTrinh,
        DiemGiuaKy = @DiemGiuaKy,
        DiemCuoiKy = @DiemCuoiKy
    WHERE MaSinhVien = @MaSV
        AND MaHocPhan = @MaHocPhan;
END
GO

CREATE PROCEDURE InsertDiemNull
    @MaSinhVien NVARCHAR(50),
    @MaHocPhan NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Diem(MaSinhVien, MaHocPhan, DiemQuaTrinh, DiemGiuaKy, DiemCuoiKy)
    VALUES (@MaSinhVien, @MaHocPhan, NULL, NULL, NULL);
END
GO

CREATE PROCEDURE GetDiemByMaSV
    @MaSV NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Tạo bảng tạm để lưu kết quả
    CREATE TABLE #TempDiem
    (
        STT INT IDENTITY(1,1),
        MaHocPhan NVARCHAR(50),
        TenHocPhan NVARCHAR(50),
        TinChi NVARCHAR(50), -- Thêm cột TinChi
        DiemQuaTrinh FLOAT,
        DiemGiuaKy FLOAT,
        DiemCuoiKy FLOAT,
        DiemTrungBinh FLOAT
    );

    -- Lấy điểm của sinh viên từ bảng Diem
    INSERT INTO #TempDiem (MaHocPhan, TenHocPhan, TinChi, DiemQuaTrinh, DiemGiuaKy, DiemCuoiKy)
    SELECT d.MaHocPhan,
           hp.TenHocPhan,
           mh.TinChi, -- Thêm TinChi vào cột select
           d.DiemQuaTrinh,
           d.DiemGiuaKy,
           d.DiemCuoiKy
    FROM Diem d
    INNER JOIN HocPhan hp ON d.MaHocPhan = hp.MaHocPhan
    INNER JOIN MonHoc mh ON hp.MaMonHoc = mh.MaMH
    WHERE d.MaSinhVien = @MaSV;

    -- Tính điểm trung bình
    UPDATE #TempDiem
    SET DiemTrungBinh = ROUND((DiemQuaTrinh * 0.2 + DiemGiuaKy * 0.3 + DiemCuoiKy * 0.5), 2);

    -- Trả về kết quả
    SELECT * FROM #TempDiem;

    -- Xóa bảng tạm
    DROP TABLE #TempDiem;
END;
GO


CREATE PROCEDURE LoadDiemByMaSVAndNamHoc
    @MaSV NVARCHAR(50),
    @NamHoc NVARCHAR(50)
AS
BEGIN
    SELECT 
        ROW_NUMBER() OVER (ORDER BY d.MaHocPhan) AS STT,
        d.MaHocPhan,
        hp.TenHocPhan,
        d.DiemQuaTrinh,
        d.DiemGiuaKy,
        d.DiemCuoiKy
    FROM 
        Diem d
    INNER JOIN 
        HocPhan hp ON d.MaHocPhan = hp.MaHocPhan
    WHERE 
        d.MaSinhVien = @MaSV
        AND hp.Nam = @NamHoc;
END;
GO

CREATE FUNCTION GenerateNewTKBCode()
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @NewCode NVARCHAR(50);
    DECLARE @Counter INT = 1;

    SET @NewCode = 'TKB001';

    WHILE EXISTS (SELECT 1 FROM ThoiKhoaBieu WHERE MaTKB = @NewCode)
    BEGIN
        SET @Counter = @Counter + 1;
        SET @NewCode = 'TKB' + RIGHT('000' + CAST(@Counter AS NVARCHAR(3)), 3);
    END

    RETURN @NewCode;
END;
GO

CREATE PROCEDURE InsertThoiKhoaBieu
    @MaSinhVien NVARCHAR(50),
    @HocKy NVARCHAR(50),
    @NamHoc NVARCHAR(50)
AS
BEGIN
    DECLARE @NewTKB NVARCHAR(50);
    SET @NewTKB = dbo.GenerateNewTKBCode();

    INSERT INTO ThoiKhoaBieu (MaTKB, MaSinhVien, HocKy, NamHoc)
    VALUES (@NewTKB, @MaSinhVien, @HocKy, @NamHoc);
END;
GO

CREATE FUNCTION GenerateNewDKCode()
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @NewCode NVARCHAR(50);
    DECLARE @Counter INT = 1;

    SET @NewCode = 'DK001';

    WHILE EXISTS (SELECT 1 FROM DangKy WHERE MaDangKy = @NewCode)
    BEGIN
        SET @Counter = @Counter + 1;
        SET @NewCode = 'DK' + RIGHT('00' + CAST(@Counter AS NVARCHAR(3)), 3);
    END

    RETURN @NewCode;
END;
GO

CREATE PROCEDURE InsertDangKy
    @MaTKB NVARCHAR(50),
    @MaHocPhan NVARCHAR(50)
AS
BEGIN
    DECLARE @MaDangKy NVARCHAR(50);
    SET @MaDangKy = dbo.GenerateNewDKCode();

    INSERT INTO DangKy (MaDangKy, MaTKB, MaHocPhan)
    VALUES (@MaDangKy, @MaTKB, @MaHocPhan);
END;
GO

CREATE PROCEDURE LayDanhSachHocPhanCoDK
    @MaSinhVien NVARCHAR(50),
    @Nam NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @StartYear NVARCHAR(4);
    DECLARE @EndYear NVARCHAR(4);

    -- Tách năm từ chuỗi 'yyyy-yyyy'
    SET @StartYear = LEFT(@Nam, 4);
    SET @EndYear = RIGHT(@Nam, 4);

    WITH AllCourses AS (
        -- Lấy toàn bộ danh sách học phần có trong năm được chỉ định
        SELECT *
        FROM HocPhan
        WHERE Nam IN (@StartYear, @EndYear)
    ), RegisteredCourses AS (
        -- Lấy toàn bộ danh sách học phần mà sinh viên đã đăng ký
        SELECT HocPhan.*
        FROM HocPhan
        JOIN DangKy ON HocPhan.MaHocPhan = DangKy.MaHocPhan
        JOIN ThoiKhoaBieu ON DangKy.MaTKB = ThoiKhoaBieu.MaTKB
        JOIN SinhVien ON ThoiKhoaBieu.MaSinhVien = SinhVien.MaSV
        WHERE SinhVien.MaSV = @MaSinhVien
    )
    -- Trả về danh sách học phần mà sinh viên chưa đăng ký
    SELECT ROW_NUMBER() OVER (ORDER BY A.MaHocPhan) AS STT,
           A.*
    FROM AllCourses A
    LEFT JOIN RegisteredCourses B ON A.MaHocPhan = B.MaHocPhan
    WHERE B.MaHocPhan IS NULL;

END;
GO

CREATE PROCEDURE TimKiemMaHocPhanCoDK
    @MaSinhVien NVARCHAR(50),
    @Nam NVARCHAR(50),
	@MaHocPhan NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @StartYear NVARCHAR(4);
    DECLARE @EndYear NVARCHAR(4);

    -- Tách năm từ chuỗi 'yyyy-yyyy'
    SET @StartYear = LEFT(@Nam, 4);
    SET @EndYear = RIGHT(@Nam, 4);

    WITH AllCourses AS (
        -- Lấy toàn bộ danh sách học phần có trong năm được chỉ định
        SELECT *
        FROM HocPhan
        WHERE Nam IN (@StartYear, @EndYear)
    ), RegisteredCourses AS (
        -- Lấy toàn bộ danh sách học phần mà sinh viên đã đăng ký
        SELECT HocPhan.*
        FROM HocPhan
        JOIN DangKy ON HocPhan.MaHocPhan = DangKy.MaHocPhan
        JOIN ThoiKhoaBieu ON DangKy.MaTKB = ThoiKhoaBieu.MaTKB
        JOIN SinhVien ON ThoiKhoaBieu.MaSinhVien = SinhVien.MaSV
        WHERE SinhVien.MaSV = @MaSinhVien
    )
    -- Trả về danh sách học phần mà sinh viên chưa đăng ký
    SELECT ROW_NUMBER() OVER (ORDER BY A.MaHocPhan) AS STT,
           A.*
    FROM AllCourses A
    LEFT JOIN RegisteredCourses B ON A.MaHocPhan = B.MaHocPhan
    WHERE B.MaHocPhan IS NULL AND dbo.fuConvertToUnsign1(A.MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(@MaHocPhan) + '%'

END;
GO

CREATE PROC CapNhatSV
	@MaSV NVARCHAR(50) , 
   -- @TenDangNhap NVARCHAR(50),
	@HoTen NVARCHAR(50),
	@NgaySinh DATE,
	@GioiTinh NVARCHAR(10),
	@DiaChi NVARCHAR (100),
	@SDT NVARCHAR(10),
	@Lop NVARCHAR(50),
	@MaKhoa NVARCHAR(50),
	@Email NVARCHAR(50)
AS BEGIN
	UPDATE SinhVien
	SET 
		MaSV=@MaSV , 
		--TenDangNhap=@TenDangNhap,
		HoTen=@HoTen ,
		NgaySinh =@NgaySinh ,
		GioiTinh=@GioiTinh ,
		DiaChi=@DiaChi ,
		SDT=@SDT ,
		Lop=@Lop ,
		MaKhoa=@MaKhoa ,
		Email=@Email 
	WHERE MaSV=@MaSV
	IF @@ROWCOUNT>0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END;
GO

CREATE PROCEDURE ChinhSuaThongTinSinhVien
    @MaSV NVARCHAR(50),
    @Lop NVARCHAR(50),
    @Email NVARCHAR(50),
    @SDT NVARCHAR(10),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(100),
    @HoTen NVARCHAR(50),
    @GioiTinh NVARCHAR(10)
AS
BEGIN
    UPDATE SinhVien
    SET 
        Lop = @Lop,
        Email = @Email,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        DiaChi = @DiaChi,
        HoTen = @HoTen,
        GioiTinh = @GioiTinh
    WHERE MaSV = @MaSV;
END
GO

CREATE PROCEDURE ChinhSuaThongTinGiangVien
    @MaGV NVARCHAR(50),
    @HoTen NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @Email NVARCHAR(50),
    @SDT NVARCHAR(15),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10)
AS
BEGIN
    UPDATE GiangVien
    SET
        HoTen = @HoTen,
        DiaChi = @DiaChi,
        Email = @Email,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh
    WHERE MaGV = @MaGV;
END
GO

CREATE PROCEDURE ChinhSuaThongTinQuanLy
    @MaQL NVARCHAR(50),
    @HoTen NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @Email NVARCHAR(50),
    @SDT NVARCHAR(10),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10)
AS
BEGIN
    UPDATE QuanLy
    SET
        HoTen = @HoTen,
        DiaChi = @DiaChi,
        Email = @Email,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh
    WHERE MaNQL = @MaQL;
END
GO

CREATE PROCEDURE LayThoiKhoaBieuSinhVien
 
    @MaSinhVien NVARCHAR(50),
 
    @HocKy INT,
 
    @NamHoc NVARCHAR(50)
 
AS
 
BEGIN
 
    SELECT ROW_NUMBER() OVER (ORDER BY hp.MaHocPhan) AS STT,  
 
           hp.MaHocPhan,
 
           hp.TenHocPhan,  
 
   hp.TinChi,
 
   hp.ThongTin,
 
           gv.HoTen,
 
           hp.NgayMoDau,
 
   hp.NgayKetThuc
 
    FROM DangKy dk
 
    JOIN ThoiKhoaBieu tkb ON dk.MaTKB = tkb.MaTKB
 
    JOIN HocPhan hp ON dk.MaHocPhan = hp.MaHocPhan
 
JOIN GiangVien gv ON hp.MaGV = gv.MaGV
 
    WHERE tkb.MaSinhVien = @MaSinhVien AND tkb.HocKy = @HocKy AND tkb.NamHoc = @NamHoc
 
END
GO

CREATE PROCEDURE XoaHocPhanTrongThoiKhoaBieuSinhVien
    @MaHocPhan NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
 
    BEGIN TRY
        DELETE FROM DangKy
        WHERE MaHocPhan = @MaHocPhan;
        DELETE FROM ThoiKhoaBieu
        WHERE MaTKB IN (SELECT MaTKB FROM DangKy WHERE MaHocPhan = @MaHocPhan); 
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH;
END
GO


CREATE PROCEDURE LayDSSV
	AS
	BEGIN
	SET NOCOUNT ON;
 
	SELECT
	ROW_NUMBER() OVER (ORDER BY SV.MaSV) AS STT,
	SV.MaSV,
	SV.HoTen,
	SV.GioiTinh,
	SV.NgaySinh,
	SV.DiaChi,
	SV.SDT,
	SV.Lop,
	K.TenKhoa,
	SV.Email
	FROM SinhVien AS SV, Khoa AS K
	WHERE 
	SV.MaKhoa = K.MaKhoa
	END
GO

Create PROCEDURE TimKiemSVTrongDSSV
    @MaSV NVARCHAR(50) = NULL,
    @MaKhoa NVARCHAR(50) = NULL,
    @Lop NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
 
    SELECT
        ROW_NUMBER() OVER (ORDER BY SV.MaSV) AS STT,
        SV.MaSV,
        SV.HoTen,
        SV.GioiTinh,
        SV.NgaySinh,
        SV.DiaChi,
        SV.SDT,
        SV.Lop,
        K.TenKhoa,
        SV.Email
    FROM SinhVien AS SV
    INNER JOIN Khoa AS K ON SV.MaKhoa = K.MaKhoa
    WHERE 
        (SV.MaSV = @MaSV OR @MaSV IS NULL OR @MaSV = '') AND
        (SV.MaKhoa = @MaKhoa OR @MaKhoa IS NULL OR @MaKhoa = '') AND
        (SV.Lop = @Lop OR @Lop IS NULL OR @Lop = '')
END
GO

CREATE PROC ThemSV
  @MaSV NVARCHAR(50),
  --@TenDangNhap NVARCHAR(50),
  @Lop NVARCHAR(50),
  @MaKhoa NVARCHAR(50),
  @Email NVARCHAR(50),
  @SDT NVARCHAR(10),
  @NgaySinh DATE,
  @DiaChi NVARCHAR(100),
  @HoTen NVARCHAR(50),
  @GioiTinh NVARCHAR(10)
 
AS
BEGIN
  INSERT INTO SinhVien (
    MaSV,
    Lop,
    MaKhoa,
    Email,
    SDT,
    NgaySinh,
    DiaChi,
    HoTen,
    GioiTinh
  )
  VALUES (
    @MaSV,
    @Lop,
    @MaKhoa,
    @Email,
    @SDT,
    @NgaySinh,
    @DiaChi,
    @HoTen,
    @GioiTinh
  );
	IF @@ROWCOUNT >0  BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END;
GO

CREATE PROCEDURE GetHocPhanTheoSinhVien
    @MaSinhVien NVARCHAR(50),
    @HocKy INT,
    @NamHoc NVARCHAR(50)
AS
BEGIN
    SELECT ROW_NUMBER() OVER (ORDER BY hp.MaHocPhan) AS STT, 
           hp.MaHocPhan, 
           hp.MaMonHoc, 
           hp.TenHocPhan, 
   hp.TinChi,
   hp.ThongTin,
           hp.MaGV, 
           hp.Nam, 
           hp.NgayMoDau,
   hp.NgayKetThuc
    FROM DangKy dk
    JOIN ThoiKhoaBieu tkb ON dk.MaTKB = tkb.MaTKB
    JOIN HocPhan hp ON dk.MaHocPhan = hp.MaHocPhan
    WHERE tkb.MaSinhVien = @MaSinhVien AND tkb.HocKy = @HocKy AND tkb.NamHoc = @NamHoc
END
GO

CREATE PROCEDURE ThemHocPhanChoSinhVien
    @MaSinhVien NVARCHAR(50),
    @HocKy INT,
    @NamHoc NVARCHAR(50),
@MaHocPhan NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem sinh viên đã đăng ký học phần này chưa
    IF NOT EXISTS (
        SELECT 1
        FROM DangKy dk
        JOIN ThoiKhoaBieu tkb ON dk.MaTKB = tkb.MaTKB
        WHERE tkb.MaSinhVien = @MaSinhVien AND tkb.HocKy = @HocKy AND tkb.NamHoc = @NamHoc AND dk.MaHocPhan = @MaHocPhan
    )
    BEGIN
        -- Nếu sinh viên chưa đăng ký học phần này, thêm học phần vào danh sách đăng ký
        INSERT INTO DangKy(MaDangKy, MaTKB, MaHocPhan)
        VALUES (NEWID(), (SELECT MaTKB FROM ThoiKhoaBieu WHERE MaSinhVien = @MaSinhVien AND HocKy = @HocKy AND NamHoc = @NamHoc), @MaHocPhan)
    END
    ELSE
    BEGIN
        -- Nếu sinh viên đã đăng ký học phần này, thông báo lỗi
        RAISERROR ('Sinh viên đã đăng ký học phần này.', 16, 1)
    END
END
GO

CREATE PROCEDURE XoaSV
    @MaSV NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Xóa sinh viên từ bảng SinhVien
    DELETE FROM SinhVien
    WHERE MaSV = @MaSV;

    -- Kiểm tra xem có bất kỳ hàng nào bị ảnh hưởng không
    IF @@ROWCOUNT > 0
    BEGIN
        PRINT 'Xóa sinh viên thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy sinh viên có mã ' + @MaSV + '.';
    END
END
GO

CREATE PROCEDURE ChonSV (@MaSV NVARCHAR(50))
AS
BEGIN
  SELECT *
  FROM SinhVien
  WHERE MaSV = @MaSV;
END;
GO

CREATE PROCEDURE LayThoiKhoaBieuSinhVien2
    @MaSV NVARCHAR(50),
    @HocKy NVARCHAR(50),
    @NamHoc NVARCHAR(50)
AS
BEGIN
    -- Tìm kiếm thông tin thời khóa biểu của sinh viên dựa trên mã sinh viên, học kỳ và năm học
    SELECT 
        ROW_NUMBER() OVER (ORDER BY TK.MaTKB) AS STT, 
        TK.MaSinhVien AS MaSV,
        HP.MaHocPhan, 
        HP.MaMonHoc, 
        HP.TenHocPhan, 
        HP.MaGV AS MaGiaoVien, 
        HP.Nam, 
        HP.NgayMoDau AS NgayBatDau, 
        HP.NgayKetThuc, 
        HP.TinChi, 
        HP.ThongTin
    FROM 
        ThoiKhoaBieu AS TK
    INNER JOIN 
        DangKy AS DK ON TK.MaTKB = DK.MaTKB
    INNER JOIN 
        HocPhan AS HP ON DK.MaHocPhan = HP.MaHocPhan
    WHERE 
        TK.MaSinhVien = @MaSV 
        AND TK.HocKy = @HocKy 
        AND TK.NamHoc = @NamHoc;
END
GO

CREATE PROCEDURE LayDiemSinhVienTheoThoiKhoaBieu
    @MaSinhVien NVARCHAR(50),
    @HocKy NVARCHAR(50),
    @NamHoc NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Tạo bảng tạm để lưu kết quả
    CREATE TABLE #TempDiem
    (
        STT INT IDENTITY(1,1),
        MaHocPhan NVARCHAR(50),
        TenHocPhan NVARCHAR(50),
        TinChi NVARCHAR(50), -- Thêm cột TinChi
        DiemQuaTrinh FLOAT,
        DiemGiuaKy FLOAT,
        DiemCuoiKy FLOAT,
        DiemTrungBinh FLOAT
    );

    -- Lấy các học phần từ thời khóa biểu của sinh viên
    INSERT INTO #TempDiem (MaHocPhan, TenHocPhan, TinChi)
    SELECT DISTINCT H.MaHocPhan, MH.TenMH, MH.TinChi -- Thêm TinChi vào cột select
    FROM ThoiKhoaBieu TKB
    INNER JOIN DangKy DK ON TKB.MaTKB = DK.MaTKB
    INNER JOIN HocPhan H ON DK.MaHocPhan = H.MaHocPhan
    INNER JOIN MonHoc MH ON H.MaMonHoc = MH.MaMH
    WHERE TKB.MaSinhVien = @MaSinhVien AND TKB.HocKy = @HocKy AND TKB.NamHoc = @NamHoc;

    -- Lấy điểm của sinh viên cho các học phần đã lấy được
    UPDATE #TempDiem
    SET DiemQuaTrinh = D.DiemQuaTrinh,
        DiemGiuaKy = D.DiemGiuaKy,
        DiemCuoiKy = D.DiemCuoiKy
    FROM #TempDiem TD
    LEFT JOIN Diem D ON TD.MaHocPhan = D.MaHocPhan AND D.MaSinhVien = @MaSinhVien;

    -- Tính điểm trung bình
    UPDATE #TempDiem
    SET DiemTrungBinh = ROUND((DiemQuaTrinh * 0.2 + DiemGiuaKy * 0.3 + DiemCuoiKy * 0.5), 2);

    -- Trả về kết quả
    SELECT * FROM #TempDiem;

    -- Xóa bảng tạm
    DROP TABLE #TempDiem;
END;
GO

CREATE PROCEDURE ThemGopYVaHoiDap
    @MaSinhVien NVARCHAR(50),
    @HoTen NVARCHAR(50),
    @Email NVARCHAR(50),
    @NoiDung NVARCHAR(500)
AS
BEGIN
    DECLARE @MaGopY NVARCHAR(50)
    
    -- Tạo MaGopY tự động tăng dần
    SELECT @MaGopY = CONCAT('GY', RIGHT('0000' + CAST(ISNULL(MAX(RIGHT(MaGopY, 4)), 0) + 1 AS NVARCHAR(4)), 4))
    FROM GopYVaHoiDap
    
    -- Thêm bản ghi vào bảng GopYVaHoiDap
    INSERT INTO GopYVaHoiDap (MaGopY, MaSinhVien, HoTen, Email, NoiDung, TrangThai)
    VALUES (@MaGopY, @MaSinhVien, @HoTen, @Email, @NoiDung, 1) -- Trạng thái mặc định là New
    
    SELECT @MaGopY AS MaGopY_Them
END
GO
--drop proc ThemGopYVaHoiDap

CREATE TRIGGER GenerateNewMaHocPhi
ON HocPhi
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaHocPhi NVARCHAR(50)
 
    SELECT @NewMaHocPhi = 'MHP' + RIGHT('000' + CAST(ISNULL(MAX(RIGHT(MaHocPhi, 3)), 0) + 1 AS NVARCHAR(3)), 3)
    FROM HocPhi
 
    INSERT INTO HocPhi (MaHocPhi, HocPhi, TrangThai, NgayThanhToan, MaTKB)
    SELECT 
        @NewMaHocPhi,
        HocPhi,
        TrangThai,
        NgayThanhToan,
        MaTKB
    FROM inserted
END;
 GO
-- Tạo trigger GenerateNewMaThongBao
CREATE TRIGGER GenerateNewMaThongBao
ON ThongBao
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaThongBao NVARCHAR(50)
 
    SELECT @NewMaThongBao = 'MTB' + RIGHT('000' + CAST(ISNULL(MAX(RIGHT(MaThongBao, 3)), 0) + 1 AS NVARCHAR(3)), 3)
    FROM ThongBao
 
    INSERT INTO ThongBao (MaThongBao, TieuDe, NoiDung, NgayTao, NguoiTao)
    SELECT 
        @NewMaThongBao,
        TieuDe,
        NoiDung,
        NgayTao,
        NguoiTao
    FROM inserted
END;
 GO
-- Tạo trigger UpdateHocPhiOnDangKy
CREATE TRIGGER UpdateHocPhiOnDangKy
ON DangKy
AFTER INSERT
AS
BEGIN
    -- Declare variables to hold values from the inserted row
    DECLARE @MaTKB NVARCHAR(50);
    DECLARE @MaHocPhan NVARCHAR(50);
    DECLARE @MaMonHoc NVARCHAR(50);
    DECLARE @TinChi INT;
    DECLARE @HocPhi INT;
    DECLARE @MaHocPhi NVARCHAR(50);

    -- Get values from the inserted row
    SELECT @MaTKB = i.MaTKB, @MaHocPhan = i.MaHocPhan
    FROM inserted i;

    -- Get the MaMonHoc and TinChi for the inserted MaHocPhan
    SELECT @MaMonHoc = MaMonHoc, @TinChi = CAST(TinChi AS INT)
    FROM HocPhan
    WHERE MaHocPhan = @MaHocPhan;

    -- Calculate the tuition fee
    SET @HocPhi = @TinChi * 365000;

    -- Get the MaHocPhi for the corresponding MaTKB
    SELECT @MaHocPhi = MaHocPhi
    FROM HocPhi
    WHERE MaTKB = @MaTKB;

    -- If there is no existing HocPhi entry, insert a new one
    IF @MaHocPhi IS NULL
    BEGIN
        SET @MaHocPhi = NEWID(); -- Generate a new unique identifier for MaHocPhi

        INSERT INTO HocPhi (MaHocPhi, HocPhi, MaTKB)
        VALUES (@MaHocPhi, @HocPhi, @MaTKB);
    END
    ELSE
    BEGIN
        -- Update the existing HocPhi entry
        UPDATE HocPhi
        SET HocPhi = HocPhi + @HocPhi
        WHERE MaHocPhi = @MaHocPhi;
    END
END;
GO

CREATE PROCEDURE ThemThongBao
    @TieuDe NVARCHAR(100),
    @NoiDung NVARCHAR(MAX),
    @NguoiTao NVARCHAR(50)
AS
BEGIN
    INSERT INTO ThongBao (TieuDe, NoiDung, NguoiTao)
    VALUES (@TieuDe, @NoiDung, @NguoiTao);
END;
GO

CREATE PROCEDURE LayLopTheoKhoa
    @MaKhoa NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
 
    SELECT DISTINCT Lop
    FROM SinhVien
    WHERE MaKhoa = @MaKhoa;
END
GO

CREATE PROCEDURE XoaSinhVien
    @MaSV NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
 
    -- Xóa các bản ghi trong bảng DangKy liên quan đến MaSinhVien
    DELETE FROM DangKy
    WHERE MaTKB IN (SELECT MaTKB FROM ThoiKhoaBieu WHERE MaSinhVien = @MaSV);
 
    -- Xóa các bản ghi trong bảng ThoiKhoaBieu liên quan đến MaSinhVien
    DELETE FROM ThoiKhoaBieu WHERE MaSinhVien = @MaSV;
 
    -- Xóa sinh viên
    DELETE FROM SinhVien WHERE MaSV = @MaSV;
 
    SET NOCOUNT OFF;
END

