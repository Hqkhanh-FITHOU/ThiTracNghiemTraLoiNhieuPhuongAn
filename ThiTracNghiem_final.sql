CREATE DATABASE db_ThiTracNghiem
GO

USE db_ThiTracNghiem
GO

CREATE TABLE tblTaiKhoan
(
	PK_sTaikhoanID NVARCHAR(10) PRIMARY KEY,
	sHoten NVARCHAR(35),
	dNgaysinh DATE,
	bGioitinh BIT,
	sTendangnhap NVARCHAR(100),
	sMatkhau NVARCHAR(30)
)
GO




ALTER TABLE tblTaiKhoan
ADD sQuyenID NVARCHAR(10)
ALTER TABLE tblTaiKhoan
ADD CONSTRAINT FK_tblTaiKhoan_sQuyenID FOREIGN KEY (sQuyenID) REFERENCES tblQuyenHan(PK_sQuyenID)


CREATE TABLE tblQuyenHan
(
	PK_sQuyenID NVARCHAR(10) PRIMARY KEY,
	sTenquyen NVARCHAR(256),
)
GO


CREATE TABLE tblPhongThi
(
	PK_sPhongthiID NVARCHAR(10) PRIMARY KEY,
	sTenphongthi NVARCHAR(256),
	dThoigiantao DATETIME,
	bTrangthai BIT
)
GO

CREATE TABLE tblMonHoc
(
	PK_iMonID INT PRIMARY KEY,
	sTenmonhoc NVARCHAR(50)
)
GO

AlTER TABLE tblPhongThi
ADD iMonID INT
ALTER TABLE tblPhongThi
ADD CONSTRAINT FK_iMonID_tblPhongThi FOREIGN KEY (iMonID) REFERENCES tblMonHoc(PK_iMonID)

CREATE TABLE tblLop
(
	PK_sLopID NVARCHAR(10) PRIMARY KEY,
	sTenlop NVARCHAR(20),
)
GO

CREATE TABLE tblThiSinh
(
	sPhongthiID NVARCHAR(10),
	sTaikhoanID NVARCHAR(10)

	CONSTRAINT PK_ThisinhID PRIMARY KEY (sPhongthiID, sTaiKhoanID),
	CONSTRAINT FK_ThisinhID_sPhongthiID FOREIGN KEY (sPhongThiID) REFERENCES tblPhongthi(PK_sPhongthiID),
	CONSTRAINT FK_ThisinhID_sTaikhoanID FOREIGN KEY (sTaikhoanID) REFERENCES tblTaiKhoan(PK_sTaikhoanID)
)
GO

CREATE TABLE tblThanhVienLop
(
	sLopID NVARCHAR(10),
	sTaikhoanID NVARCHAR(10),
	sChucvu NVARCHAR(30)

	CONSTRAINT PK_ThanhvienLopID PRIMARY KEY (sLopID, sTaikhoanID),
	CONSTRAINT FK_ThanhvienLopID_sLopID FOREIGN KEY (sLopID) REFERENCES tblLop(PK_sLopID),
	CONSTRAINT FK_ThanhvienLopID_sTaikhoanID FOREIGN KEY (sTaikhoanID) REFERENCES tblTaiKhoan(PK_sTaikhoanID)
)
GO


CREATE TABLE tblBaiThi
(
	PK_sBaithiID NVARCHAR(10) PRIMARY KEY,
	sTaikhoanID NVARCHAR(10),
	sPhongthiID NVARCHAR(10),
	fDiemso FLOAT,
	tThoigianhoanthanh DATETIME --Thời gian hoàn thành

	CONSTRAINT FK_BaiThi_sTaikhoanID FOREIGN KEY (sTaikhoanID) REFERENCES tblTaiKhoan(PK_sTaikhoanID),
	CONSTRAINT FK_BaiThi_sPhongthiID FOREIGN KEY (sPhongthiID) REFERENCES tblPhongThi(PK_sPhongthiID)
)
GO

CREATE TABLE tblCauHoi
(
	PK_sCauhoiID NVARCHAR(10) PRIMARY KEY,
	iMonID INT,
	sNoidung NVARCHAR(256),
	sPhuonganA NVARCHAR(256),
	sPhuonganB NVARCHAR(256),
	sPhuonganC NVARCHAR(256),
	sPhuonganD NVARCHAR(256),
	sDapan NVARCHAR(10)

	CONSTRAINT FK_CauHoi_sMonhocID FOREIGN KEY (iMonID) REFERENCES tblMonHoc(PK_iMonID)
)
GO


CREATE TABLE tblCauTraLoi
(
	sBaithiID NVARCHAR(10),
	sCauhoiID NVARCHAR(10),
	sPhuongantraloi NVARCHAR(10),
	iThutuCau INT

	CONSTRAINT PK_CauTraLoiID PRIMARY KEY (sBaithiID,sCauhoiID),
	CONSTRAINT FK_CauTraLoi_sBaithiID FOREIGN KEY (sBaithiID) REFERENCES tblBaiThi(PK_sBaithiID),
	CONSTRAINT FK_CauTraLoi_sCauhoiID FOREIGN KEY (sCauhoiID) REFERENCES tblCauHoi(PK_sCauhoiID)
)
GO


INSERT INTO tblQuyenHan
VALUES
('AD',N'Quản trị'),
('HV',N'Học viên'),
('GT',N'Giám Thị')

INSERT INTO tblTaiKhoan(PK_sTaikhoanID,sMatkhau,sHoten,dNgaysinh,bGioitinh,sQuyenID)
VALUES 
('admin','admin',N'Quản trị hệ thống','1999-01-07',1,'AD'),
('giamthi','123456',N'Giám thị','1999-01-08',1,'GT'),
('hocvien','123456',N'Học viên','1999-01-09',1,'HV')
GO



CREATE PROC PR_LayTaiKhoan
@PK_sTaikhoanID NVARCHAR(10),
@sMatkhau NVARCHAR(30)
AS
IF EXISTS (SELECT * FROM tblTaiKhoan WHERE PK_sTaikhoanID = @PK_sTaikhoanID AND sMatkhau = @sMatkhau)
SELECT 1 AS [CODE]
ELSE
SELECT 0 AS [CODE]



INSERT INTO tblTaiKhoan(PK_sTaikhoanID,sMatkhau,sHoten,dNgaysinh,bGioitinh)
VALUES
('12A1001','12A1001',N'Trương Văn Chuyên','2002-04-08',1),
('12A1002','12A1002',N'Trần Xuân Phước','2002-04-09',1),
('12A1003','12A1003',N'Hoàng Thị Diễm','2002-02-10',1),
('12A1004','12A1004',N'Trư Văn Chuyển','2002-04-08',0),
('12A1005','12A1005',N'Trần Trung Hiếu','2002-04-08',1),
('12A1006','12A1006',N'Đoàn Quang Huy','2002-04-08',0),
('12A1007','12A1007',N'Nguyễn Quang Huy','2002-04-08',1),
('12A1008','12A1008',N'Linh Thị Ngọc Mai','2002-03-11',1),
('12A1009','12A1009',N'Lương Minh Ngọc','2002-04-08',0),
('12A1010','12A1010',N'Phạm Hoàng Phi','2002-04-08',1),
('12A1011','12A1011',N'Vì Thị Thanh Hồng','2002-04-18',0),
('12A1012','12A1012',N'Trương Văn Chuyên','2002-04-08',0),
('12A1013','12A1013',N'Trần Quốc Vinh','2002-04-08',0),
('12A1014','12A1014',N'Trương Văn Chuyên','2003-04-08',1),
('12A1015','12A1015',N'Trương Văn Chuyên','2002-04-08',1),
('12A1016','12A1016',N'Trương Văn Chuyên','2001-06-22',1),
('12A1017','12A1017',N'Phạm Hoàng Phi','2002-04-08',1),
('12A1018','12A1018',N'Trương Văn Chuyên','2002-04-08',1),
('12A1019','12A1019',N'Trương Văn Chuyên','2002-04-08',0),
('12A1020','12A1020',N'Đỗ Văn Long','2002-12-08',0),
('12A1021','12A1021',N'Trần Xuân Phước','2002-07-08',1),
('12A1022','12A1022',N'Đỗ Anh Sơn','2002-04-08',1),
('12A1023','12A1023',N'Đinh Cẩm Thạch','2002-04-08',1),
('12A1024','12A1024',N'Trương Nam Trường','2002-04-08',0),
('12A1025','12A1025',N'Vừ A Vàng','2002-01-08',1),
('12A1026','12A1026',N'Lê Bá Hiếu','2002-09-08',1),
('12A1027','12A1027',N'Trần Quang Dững','2002-04-08',0),
('12A1028','12A1028',N'Bồ Thảo Nhi','2002-04-08',1),
('12A1029','12A1029',N'Đinh Văn quyết','2002-04-08',1),
('12A1030','12A1030',N'La tiến linh','2002-01-07',0),
('12A1031','12A1031',N'bùi hải long','2002-04-08',1),
('12A1032','12A1032',N'phạm thanh mai','2002-04-08',1),
('12A1033','12A1033',N'lê thị trúc','2002-04-08',1),
('12A1034','12A1034',N'ngô văn uyển','2002-04-08',0),
('12A1035','12A1035',N'Trương Phái Sơn','2002-04-08',1),
('12A1036','12A1036',N'Trương Văn Toàn','2002-05-08',1),
('12A1037','12A1037',N'Trương Quang Toàn','2002-06-08',1),
('12A1038','12A1038',N'Chuyên Ngọc Giao','2002-08-08',0),
('12A1039','12A1039',N'Ngô Thì Ngậm','2002-04-08',1),
('12A1040','12A1040',N'Đơn Văn Côi','2002-10-08',1),
('12A1041','12A1041',N'Si Thị Tình','2002-04-08',1),
('12A1042','12A1042',N'Ơ Quá Nhiều','2002-11-08',0)


select * from tblTaiKhoan where PK_sTaikhoanID LIKE '12A1%'

update tblTaiKhoan 
SET sQuyenID = 'HV'
where PK_sTaikhoanID LIKE '12A1%'

GO
CREATE PROC PR_getDanhSachTaiKhoan
AS
SELECT * FROM tblTaiKhoan


GO
CREATE PROC PR_insertTaiKhoan
@PK_sTaikhoanID nvarchar(10),
@sHoten nvarchar(35),
@dNgaysinh date,
@bGioitinh bit,
@sQuyenID nvarchar(10),
@sMatKhau nvarchar(30)
AS
BEGIN
INSERT INTO tblTaiKhoan(PK_sTaikhoanID,sHoten,dNgaysinh,bGioitinh,sQuyenID,sMatkhau)
VALUES 
(@PK_sTaikhoanID,@sHoten,@dNgaysinh,@bGioitinh,@sQuyenID,@sMatKhau)
END
GO



CREATE PROC PR_updateTaiKhoan
@PK_sTaikhoanID nvarchar(10),
@sHoten nvarchar(35),
@dNgaysinh date,
@bGioitinh bit,
@sQuyenID nvarchar(10),
@sMatkhau nvarchar(30)
AS
BEGIN
	UPDATE tblTaiKhoan
	SET sHoten = @sHoten,
		dNgaysinh = @dNgaysinh,
		bGioitinh = @bGioitinh,
		sQuyenID = @sQuyenID,
		sMatkhau = @sMatkhau
	WHERE PK_sTaikhoanID = @PK_sTaikhoanID
END
GO

INSERT INTO tblPhongThi(PK_sPhongthiID,sTenphongthi,dThoigiantao,bTrangthai)
VALUES
('IT001',N'Tin học 10','2023-04-12',0),
('IT002',N'Tin học 11','2023-04-12',0),
('IT003',N'Tin học 12','2023-04-12',0)
GO


CREATE PROC PR_getDSPhongThi
AS
BEGIN
SELECT * FROM tblPhongThi
END
GO



INSERT INTO tblThanhVienLop(sLopID,sTaikhoanID)
VALUES
('12A1','12A1001'),
('12A1','12A1002'),
('12A1','12A1003'),
('12A1','12A1004'),
('12A1','12A1005'),
('12A1','12A1006'),
('12A1','12A1007'),
('12A1','12A1008'),
('12A1','12A1009'),
('12A1','12A1010'),
('12A1','12A1011'),
('12A1','12A1012'),
('12A1','12A1013'),
('12A1','12A1014'),
('12A1','12A1015'),
('12A1','12A1016'),
('12A1','12A1017'),
('12A1','12A1018'),
('12A1','12A1019'),
('12A1','12A1020'),
('12A1','12A1021'),
('12A1','12A1022'),
('12A1','12A1023'),
('12A1','12A1024'),
('12A1','12A1025'),
('12A1','12A1026'),
('12A1','12A1027'),
('12A1','12A1028'),
('12A1','12A1029'),
('12A1','12A1030'),
('12A1','12A1031'),
('12A1','12A1032'),
('12A1','12A1033'),
('12A1','12A1034'),
('12A1','12A1035'),
('12A1','12A1036'),
('12A1','12A1037'),
('12A1','12A1038'),
('12A1','12A1039'),
('12A1','12A1040'),
('12A1','12A1041'),
('12A1','12A1042')
GO


UPDATE tblThanhVienLop
SET sChucvu = N'Thành viên bình thường'
WHERE 
sLopID = '12A1'
GO

INSERT INTO tblMonHoc(PK_iMonID,sTenmonhoc)
VALUES
(1,N'Toán'),
(2,N'Vật lý'),
(3,N'Hóa học'),
(4,N'Sinh học'),
(5,N'Địa lí'),
(6,N'Lịch sử'),
(7,N'Tiếng anh'),
(8,N'Tin học'),
(9,N'Giáo dục công dân')
GO

--INSERT INTO tblCauHoi(PK_sCauhoiID,iMonID,sNoidung,sPhuonganA,sPhuonganB,sPhuonganC,sPhuonganD,sDapan)
--VALUES


--Get amount of the record at random (under this comment)
--select top [a number]* from [dbo].[TableName]
--where [condition]
--order by NEWID()



INSERT INTO tblThiSinh(sPhongthiID,sTaikhoanID)
VALUES
('IT001','12A1001'),
('IT001','12A1002'),
('IT001','12A1003'),
('IT001','12A1004'),
('IT001','12A1005'),
('IT001','12A1006'),
('IT001','12A1007'),
('IT001','12A1008'),
('IT001','12A1009'),
('IT001','12A1010'),
('IT001','12A1011'),
('IT001','12A1012'),
('IT001','12A1013'),
('IT001','12A1014'),
('IT001','12A1015'),
('IT001','12A1016'),
('IT001','12A1017'),
('IT001','12A1018'),
('IT001','12A1019'),
('IT001','12A1020'),
('IT001','12A1021'),
('IT002','12A1022'),
('IT002','12A1023'),
('IT002','12A1024'),
('IT002','12A1025'),
('IT002','12A1026'),
('IT002','12A1027'),
('IT002','12A1028'),
('IT002','12A1029'),
('IT002','12A1030'),
('IT002','12A1031'),
('IT002','12A1032'),
('IT002','12A1033'),
('IT002','12A1034'),
('IT002','12A1035'),
('IT002','12A1036'),
('IT002','12A1037'),
('IT002','12A1038'),
('IT002','12A1039'),
('IT002','12A1040'),
('IT002','12A1041'),
('IT002','12A1042')



--lấy các thí sinh không thuộc phòng thi X và các thí sinh chưa ghi danh vào phòng thi nào
--select sTaikhoanID from tblThiSinh 
--right join tblTaiKhoan
--on tblThiSinh.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
--where sPhongthiID IS NULL or sPhongthiID not like 'IT001'


SELECT * FROM tblThiSinh JOIN tblTaiKhoan ON tblThiSinh.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
WHERE tblThiSinh.sPhongthiID not like 'IT001';

drop PROC PR_GetMonThi_PhongThi
GO
CREATE PROC PR_GetMonThi_PhongThi
@sPhongthiID NVARCHAR(10)
AS
BEGIN
SELECT sTenmonhoc FROM tblPhongThi JOIN tblMonHoc ON tblMonHoc.PK_iMonID = tblPhongThi.iMonID
WHERE PK_sPhongthiID = @sPhongthiID
END



INSERT INTO tblCauHoi(PK_sCauhoiID,iMonID,sNoidung,sPhuonganA,sPhuonganB,sPhuonganC,sPhuonganD,sDapan)
VALUES
('81',8,N'Chương trình nào dưới đây dùng để soạn thảo văn bản?',N'Microsoft Word',N'Microsoft Powerpoint',N'Microsoft Excel',N'Microsoft Publisher', 'A'),
('82',8,N'Thiết bị nào sau đây dùng để kết nối mạng?',N'Rom',N'Ram',N'Router ',N'CPU', 'C'),
('83',8,N'Hệ thống nhớ của máy tính bao gồm:',N'Bộ nhớ trong, Bộ nhớ ngoài',N'Cache, Bộ nhớ ngoài',N'Bộ nhớ ngoài, ROM',N'Đĩa quang, Bộ nhớ trong', 'A'),
('84',8,N'Trong mạng máy tính, thuật ngữ Share có ý nghĩa gì?',N'Chia sẻ tài nguyên',N'Nhãn hiệu của một thiết bị kết nối mạng',N'Thực hiện lệnh in trong mạng cục bộ',N'Một phần mềm hỗ trợ sử dụng mạng cục bộ', 'A'),
('85',8,N'Chọn đáp án đúng:',N'1GB = 1000MB',N'1GB = 1240MB',N'1GB = 1204MB',N'1GB = 1024MB = 210 MB', 'D'),
('86',8,N'Nhóm các thiết bị nào sau đây là thiết bị lưu trữ ngoại vi của máy tính?',N'RAM, USB, Thẻ nhớ',N'ROM, CD-ROM, USB',N'USB, Thẻ nhớ, DVD',N'Đĩa cứng, USB, Thẻ nhớ', 'C'),
('87',8,N'Trong hệ thống máy tính, mọi việc tính toán được thực hiện trên dạng số nào dưới đây?',N'Bát phân',N'Nhị phân',N'Thập phân',N'Thập lục phân', 'B'),
('88',8,N'Trong mạng máy tính, thuật ngữ WAN có nghĩa là gì?',N'Mạng cục bộ',N'Mạng toàn cầu',N'Mạng diện rộng',N'Mạng LAN', 'C'),
('89',8,N'Phần mềm hệ thống:',N'Là phần mềm để giải quyết những viêc̣ thường găp̣ .',N'Có chức năng giám sát và điều phối thực hiện các chương trình.',N'Còn được gọi là chương trình giám sát.',N'Còn có tên khác là phần mềm ứng dụng', 'B'),
('810',8,N'Các máy tính ở trong mạng máy tính:',N'Chỉ nhận và xử lý các thông tin được máy khác gửi tới',N'Chỉ nhận được các thông tin cho máy khác',N'Đều nhận và gửi được các thông tin cho nhau',N'A và B đúng', 'D'),
('811',8,N'Thiết bị nào được ví như là bộ não của máy tính?',N'ALU',N'CPU',N'Input',N'Output', 'B'),
('812',8,N'Đơn vị nào dưới đây dùng để đo lượng thông tin?',N'Nanobyte',N'Kilobyte',N'Bit',N'Megabyte', 'B C D'),
('813',8,N'Mạng máy tính là?',N'Tập hợp các máy tính được nối với nhau theo một phương thức nào đó.',N'Tập hợp các máy tính',N'Mạng LAN',N'Mạng có dây', 'A'),
('814',8,N'Siêu văn bản được định nghĩa thế nào',N'Gồm văn bản, hình ảnh, âm thanh',N'Chứa đường dẫn đi tới các trang tài liệu khác',N'Gồm hình ảnh, âm thanh',N'Gồm văn bản và các liên kết', 'A B'),
('815',8,N'Thiết bị nào đóng vai trò là đầu ra lẫn đầu vào ?',N'Bàn phím',N'Máy in',N'Màn hình cảm ứng',N'Microphone', 'C'),
('816',8,N'Trong Hệ điều hành Windows, nhóm lệnh làm việc nằm trên thanh nào?',N'Thanh công cụ (Toolbar)',N'Thanh menu (Menu bar)',N'Thanh địa chỉ (Address Bar)',N'Thanh trạng thái (Status bar)', 'B'),
('817',8,N'Trong soạn thảo Word, thao tác nào sau đây sẽ kích hoạt lệnh Paste (Chọn nhiều đáp án)',N'Tại thẻ Home, nhóm Clipboard, chọn Paste',N'Bấm tổ hợp phím Ctrl + V.',N'Chọn vào mục trong Office Clipboar',N'Tất cả đều đúng', 'A B'),
('818',8,N'Trong soạn thảo Word, để chọn một đoạn văn bản ta thực hiện:',N'Click 1 lần trên đoạn',N'Click 2 lần trên đoạn',N'Click 3 lần trên đoạn',N'Click 4 lần trên đoạn', 'B'),
('819',8,N'Trong soạn thảo Word, muốn đánh dấu lựa chọn một từ, ta thực hiện:',N'Nháy đúp chuột vào từ cần chọn',N'Bấm tổ hợp phím Ctrl – C',N'Nháy chuột vào từ cần chọn',N'Bấm phím Enter', 'A'),
('820',8,N'Trong soạn thảo Word, muốn tách một ô trong Table thành nhiều ô, ta thực hiện:',N'Table – Merge Cells',N'Table – Split Cells',N'Tools – Split Cells',N'Table – Cells', 'B'),
('821',8,N'Trong bảng tính Excel, giá trị trả về của công thức =LEN(“TRUNG TAM TIN HOC”) là:',N'15',N'16',N'17',N'18', 'C'),
('822',8,N'Công dụng của phím Print Screen là gì?',N'In màn hình hiện hành ra máy in',N'Không có công dụng gì khi sử dụng 1 mình nó.',N'In văn bản hiện hành ra máy in',N'Chụp màn hình hiện hành', 'D'),
('823',8,N'Khái niệm hệ điều hành là gì ?',N'Cung cấp và xử lý các phần cứng và phần mềm',N'Nghiên cứu phương pháp, kỹ thuật xử lý thông tin bằng máy tính điện tử',N'Nghiên cứu về công nghệ phần cứng và phần mềm',N'Là một phần mềm chạy trên máy tính, dùng để điều hành, quản lý các thiết bị phần cứng và các tài nguyên phần mềm trên máy tính', 'D'),
('824',8,N'Cho biết cách xóa một tập tin hay thư mục mà không di chuyển vào Recycle Bin:?',N'Chọn thư mục hay tâp tin cần xóa -> Delete',N'Chọn thư mục hay tâp tin cần xóa -> Ctrl + Delete',N'Chọn thư mục hay tâp tin cần xóa -> Alt + Delete',N'Chọn thư mục hay tâp tin cần xóa -> Shift + Delete', 'D'),
('825',8,N'Danh sách các mục chọn trong thực đơn gọi là :',N'Menu pad',N'Menu options',N'Menu bar',N'Tất cả đều sai', 'C')

GO
INSERT INTO tblCauHoi(PK_sCauhoiID,iMonID,sNoidung,sPhuonganA,sPhuonganB,sPhuonganC,sPhuonganD,sDapan)
VALUES
('826',8,N'Ý nghĩa của từ viết tắt HTTP (HyperText Transfer Protocol) là gì?',N'Là giao thức truyền tập tin siêu liên kết',N'Là giao thức truyền tập tin siêu văn bản',N'Là giao thức truyền tập tin văn bản',N'Là giao thức truyền tập tin tài liệu', 'B'),
('827',8,N'Nút lệnh Stop trong trình duyệt web có chức năng gì?',N'Ngừng tải trang web',N'Tải lại trang web',N'Khởi động lại trình duyệt web',N'Ngừng thực thi trình duyệt web', 'A'),
('828',8,N'Trong các chuỗi sau, đâu là 1 chuỗi thể hiện đúng cấu trúc của một địa chỉ Email?',N'tranvana@dthu.edu.vn',N'tranvana.gmail.com',N'tran van a@dthu.edu.vn',N'tranvana@gmail.com', 'A D'),
('829',8,N'Trong Window, để xóa thư mục, tập tin phải thực hiện theo những bước nào sau đây?',N'Chọn t hư mục, tập tin cần xóa và Include in library/ Delete',N'Chọn thư mục, tập tin cần xóa, nhấp phải chuột và chọn Send Compressed Folder.',N'Chọn thư mục, tập tin cần xóa, gõ tổ hợp phím Alt + Delete',N'Chọn thư mục, tập tin cần xóa, chọn menu Organize\Delete (hoặc gõ phím Delete)', 'D'),
('830',8,N'Trong Window, để di chuyển thư mục, tập tin phải thực hiện theo những bước nào sau đây?',N'Chọn thư mục, tập tin cần di chuyển, chọn menu Organize\Copy rồi chọn đích đến, chọn menu Organize\Paste',N'Chọn thư mục, tập tin cần di chuyển và giữ Ctrl kéo và thả vào vị trí đích',N'Chọn thư mục, tập tin cần di chuyển, gõ tổ hợp phím CTRL + X rồi chọn đích đến gõ CTRL + V',N'Chọn thư mục, tập tin cần di chuyển, gõ tổ hợp phím CTRL + C rồi chọn đích đến gõ CTRL + V', 'D'),
('831',8,N'Trong Excel 2010, để co tất cả nội dung để in gọn trong một trang in, chọn tính năng nào sau đây?',N'Fit All Rows on One Page',N'Custom Scaling Options',N'Fit All Columns on One Page',N'Fit Sheets on One Page', 'D'),
('832',8,N'Trong Excel 2010, hàm nào dùng để tìm kiếm trên bảng phụ dựa vào cột chỉ mục?',N'VLOOKUP',N'HLOOKUP',N'LEFT',N'LEN', 'B'),
('833',8,N'Trong Excel 2010, khi thiết lập độ rộng của cột B=0 thì cột B sẽ?',N'bị nhập vào với cột A',N'bị ẩn',N'bị nhập vào với cột C',N'bị xóa', 'B'),
('834',8,N'Trong PP 2010, để tạo tệp trình chiếu mới sử dụng tổ hợp phím nào sau đây?',N'Ctrl+A',N'Ctrl+N',N'Ctrl+M',N'Alt+M', 'B'),
('835',8,N'Trong PP 2010, âm thanh đưa vào bài trình chiếu',N'Thực hiện được cả khi tạo hiệu ứng đối tượng và hiệu ứng chuyển trang',N'Thực hiện được chỉ khi tạo hiệu ứng chuyển trang giữa các slide',N'Không thực hiện được cả khi tạo hiệu ứng đối tượng và hiệu ứng chuyển trang',N'Thực hiện được chỉ khi tạo hiệu ứng động cho đối tượng trong slide', 'A'),
('836',8,N'Trong PP 2010, sau khi hiệu ứng xuất hiện cho đối tượng trên slide, để đặt thuộc tính lặp lại cho đối tượng này lặp lại cho đến khi chuyển sang slide khác, tùy chọn lệnh gì?',N'Effect Options',N'Until End Of Slide',N'Until Next Click',N'Trigger', 'B'),
('837',8,N'Hãy cho biết, phần tên của tập tin có thể đặt tối đa bao nhiêu ký tự?',N'128 ký tự',N'250 ký tự',N'9 ký tự',N'218 ký tự', 'A'),
('838',8,N'Trình duyệt web là gì?',N'Là hệ điều hành có thể sử dụng được Internet',N'Là phần mềm ứng dụng cho phép người sử dụng xem và tương tác với các văn bản, hình ảnh, đoạn phim, nhạc, trò chơi và các thông tin khác ở trên một trang web của một địa chỉ web trên mạng toàn cầu hoặc mạng nội bộ',N'Là ứng dụng liệt kê các trang web trên mạng Internet',N'Là thiết bị kết nối Internet', 'B'),
('839',8,N'Trong các phần mềm sau, phần mềm nào là phần mềm ứng dụng?',N'Windows 10',N'Linux',N'Ubuntu 14.4.4',N'Unikey', 'D'),
('840',8,N'Trong các phần mềm sau, phần mềm nào là phần mềm hệ thống?',N'Firefox',N'Google Chrome',N'Ubuntu 14.4.4',N'Microsoft Word 2010', 'C'),
('841',8,N'Hãy chỉ ra thiết bị xuất, trong các thiết bị sau?',N'Bàn phím',N'Chuột',N'Màn hình',N'Máy scan', 'C'),
('842',8,N'Theo quy ước về đặt tên miền, tên miền có đuôi là .gov thuộc nhóm trang web nào?',N'Trang web thuộc lĩnh vực thương mại',N'Trang web của tổ chức thuộc chính phủ',N'Trang web tổ chức phi lợi nhuận',N'Trang web thuộc lĩnh vực giáo dục', 'B'),
('843',8,N'Chương trình nào của Windows để quản lí các tập tin và thư mục trong máy tính?',N'Windows Explorer',N'Microsoft Office',N'Control Panel',N'Accessories', 'A')
GO



CREATE PROC PR_LayCauHoi
AS
BEGIN
SELECT * FROM tblCauHoi
END
Go



CREATE PROC PR_ThemCauHoi
@PK_sCauhoiID NVARCHAR(10),
@iMonID INT,
@sNoidung NVARCHAR(256),
@sPhuonganA NVARCHAR(256),
@sPhuonganB NVARCHAR(256),
@sPhuonganC NVARCHAR(256),
@sPhuonganD NVARCHAR(256),
@sDapan NVARCHAR(10)
AS
BEGIN
INSERT INTO 
tblCauHoi(PK_sCauhoiID,iMonID,sNoidung,sPhuonganA,sPhuonganB,sPhuonganC,sPhuonganD,sDapan)
VALUES				
(@PK_sCauhoiID,@iMonID,@sNoidung,@sPhuonganA,@sPhuonganB,@sPhuonganC,@sPhuonganD,@sDapan)
END
GO


exec PR_ThemCauHoi 
@PK_sCauhoiID = '91',
@iMonID = 9,
@sNoidung = N'Đâu là để thử chức năng',
@sPhuonganA = '123',
@sPhuonganB = '123',
@sPhuonganC = '3234',
@sPhuonganD = 'sdf11',
@sDapan = 'A B D'
GO

CREATE PROC PR_SuaCauHoi
@PK_sCauhoiID NVARCHAR(10),
@iMonID INT,
@sNoidung NVARCHAR(256),
@sPhuonganA NVARCHAR(256),
@sPhuonganB NVARCHAR(256),
@sPhuonganC NVARCHAR(256),
@sPhuonganD NVARCHAR(256),
@sDapan NVARCHAR(10)
AS
BEGIN
UPDATE tblCauHoi
SET iMonID = @iMonID,
	sNoidung = @sNoidung,
	sPhuonganA = @sPhuonganA,
	sPhuonganB = @sPhuonganB,
	sPhuonganC = @sPhuonganC,
	sPhuonganD = @sPhuonganD,
	sDapan = @sDapan
WHERE
PK_sCauhoiID = @PK_sCauhoiID
END
GO

--exec PR_SuaCauHoi 
--@PK_sCauhoiID = '91',
--@iMonID = 9,
--@sNoidung = N'Đâu là để thử chức năng',
--@sPhuonganA = N'vừa sửa cái này',
--@sPhuonganB = '123',
--@sPhuonganC = '3234',
--@sPhuonganD = 'sdf11',
--@sDapan = 'A B D'
--GO

CREATE PROC PR_XoaCauHoi
@PK_sCauhoiID NVARCHAR(10)
AS
BEGIN
Delete tblCauHoi WHERE PK_sCauhoiID = @PK_sCauhoiID
END
GO


CREATE PROC PR_GetPhongThi_ThiSinh
@sTaikhoanID NVARCHAR(10)
AS
BEGIN
SELECT PK_sPhongthiID, sTenphongthi FROM tblPhongThi JOIN tblThiSinh 
ON tblPhongThi.PK_sPhongthiID = tblThiSinh.sPhongthiID
WHERE sTaikhoanID = @sTaikhoanID AND bTrangthai = 0
END
GO

CREATE PROC PR_GetPhongThi
@sPhongthiID NVARCHAR(10)
AS
BEGIN
SELECT * FROM tblPhongThi
WHERE PK_sPhongthiID = @sPhongthiID
END


--Get amount of the record at random (under this comment)
--select top [a number]* from [dbo].[TableName]
--where [condition]
--order by NEWID()




GO

CREATE PROC PR_luuRandomCauHoi
@sBaithiID NVARCHAR(10)
AS
BEGIN
INSERT INTO tblCauTraLoi(sBaithiID,sCauhoiID,iThutuCau)
SElECT
TOP 30 @sBaithiID as [sBaithiID], PK_sCauhoiID,  ROW_NUMBER() OVER(ORDER BY NEWID()) as [iThutuCau] FROM tblCauHoi
WHERE iMonID = 8
END
GO



--SELECT sBaithiID,sTaikhoanID,sPhongthiID, sCauhoiID, iThutuCau FROM tblCauTraLoi
--JOIN tblBaiThi on tblBaiThi.PK_sBaithiID = tblCauTraLoi.sBaithiID
--WHERE sBaithiID = 1
--order by iThutuCau

--SELECT MAX(PK_sBaithiID) as [PK_sBaithiID] from tblBaithi
--GO

create proc PR_taoBaiThi
@sBaithiID nvarchar(10),
@sPhongthiID nvarchar(10),
@sTaikhoanID nvarchar(10)
as
insert into tblBaiThi(PK_sBaithiID,sPhongthiID,sTaikhoanID)
values(@sBaithiID,@sPhongthiID,@sTaikhoanID)
go


create proc PR_LayCauHoi_CauTraLoi
@sBaithiID nvarchar(10),
@iThutuCau int
as
select * from tblCauHoi join tblCauTraLoi
on tblCauHoi.PK_sCauhoiID = tblCauTraLoi.sCauhoiID
where sBaithiID = @sBaithiID and iThutuCau = @iThutuCau
order by iThutuCau
go


create proc PR_GhinhanCauTraLoi
@sBaithiID nvarchar(10),
@iThutuCau int,
@sPhuongantraloi nvarchar(10)
as
update tblCauTraLoi set sPhuongantraloi = @sPhuongantraloi
where sBaithiID = @sBaithiID and iThutuCau = @iThutuCau
go


create proc PR_LayCauHoi_CauTraLoi_1
@sBaithiID nvarchar(10)
as
select * from tblCauHoi join tblCauTraLoi
on tblCauHoi.PK_sCauhoiID = tblCauTraLoi.sCauhoiID
where sBaithiID = @sBaithiID 
order by iThutuCau
go

create proc PR_LayCauHoi_CauTraLoi_2
@sBaithiID nvarchar(10)
as
select iThutuCau,sNoidung,sPhuonganA,sPhuonganB,sPhuonganC,sPhuonganD,sDapan,sPhuongantraloi from tblCauHoi join tblCauTraLoi
on tblCauHoi.PK_sCauhoiID = tblCauTraLoi.sCauhoiID
where sBaithiID = @sBaithiID 
order by iThutuCau
go


create proc PR_LayTatCaBaiThi
as
begin
select * from tblBaiThi 
end
go


create proc PR_LayBaithi_Taikhoan
@sBaithiID nvarchar(10)
as
begin
select * from tblBaiThi join tblTaiKhoan
on tblBaiThi.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
where PK_sBaithiID = @sBaithiID
end
go

create proc PR_LayTatCaBaiThiCuaTaiKhoan
@TaikhoanID nvarchar(10)
as
begin
select * from tblBaiThi where sTaikhoanID = @TaikhoanID
end
go

create proc PR_LayListLop
as
begin
select * from tblLop
end
go


create proc PR_ThemLop
@sLopID nvarchar(10),
@sTenlop nvarchar(20)
as
begin
insert into tblLop(PK_sLopID,sTenlop) values (@sLopID,@sTenlop)
end
go


create proc PR_XoaLop
@sLopID nvarchar(10)
as
begin
delete tblThanhVienLop where sLopID = @sLopID
delete tblLop where PK_sLopID = @sLopID
end
go


create proc PR_LayDSThanhVienLop
@sLopID nvarchar(10)
as
begin
select sTaikhoanID,sHoten,dNgaysinh,bGioitinh,sChucvu from tblThanhVienLop join tblTaiKhoan on tblThanhVienLop.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
where sLopID = @sLopID
end
go



create proc PR_LayDanhSachThanhVienChuaGhiDanh_Lop
@sLopID nvarchar(10)
as
begin
select PK_sTaikhoanID,sHoten from tblTaiKhoan left join tblThanhVienLop on tblTaiKhoan.PK_sTaikhoanID = tblThanhVienLop.sTaikhoanID
where sLopID not like @sLopID or sLopID is null
end
go

create proc PR_LayDanhSachThanhVienDaGhiDanh_Lop
@sLopID nvarchar(10)
as
begin
select PK_sTaikhoanID,sHoten from tblThanhVienLop join tblTaiKhoan on tblThanhVienLop.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
where sLopID = @sLopID
end
go


create proc PR_BaocaoDiemthi_Phongthi
as
begin
select sTaikhoanID,sHoten,dNgaysinh,bGioitinh,fDiemso,sPhongthiID from tblBaiThi join tblTaiKhoan on tblBaiThi.sTaikhoanID = tblTaiKhoan.PK_sTaikhoanID
end
go




--select sTaikhoanID,sHoten,dNgaysinh,bGioitinh from tblTaiKhoan join tblThiSinh on tblTaiKhoan.PK_sTaikhoanID = tblThiSinh.sTaikhoanID
--where sPhongthiID = 'IT001'


select * from tblTaiKhoan
where  DATEDIFF(YEAR,tblTaiKhoan.dNgaysinh,GETDATE()) = 21