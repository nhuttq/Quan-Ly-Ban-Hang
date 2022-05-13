create database BANHANG
use BANHANG

-------------------------------TẠO BẢNG-----------------------------------------

 --Bảng HANG
create table HANG
(MaSP varchar(10),
TenSP nvarchar (50),
DonViTinh nvarchar(10),
DonGia int,
SoLuong int,
primary key (MaSP)
) 

--Bảng NHACUNGCAP
create table NHACUNGCAP
(MaNCC varchar (10),
TenNCC nvarchar (50),
DienThoai varchar (10),
DiaChi nvarchar (150)
primary key (MaNCC)
) 

--Bảng NHAP
Create table NHAP
( MaHDN varchar(10) primary key ,
MaNCC varchar(10),
ThoiGian date ,
Thue int ,
ChietKhau int,
TongTien int,
foreign key (MaNCC) references NHACUNGCAP
)


--Bảng CHITIETNHAP
create table CHITIETNHAP
( MaHDN varchar(10) ,
MaSP varchar(10),
SoLuongNhap int ,
DonGiaNhap int ,
ThanhTien int ,
foreign key (MaHDN) references NHAP on delete cascade,
foreign key (MaSP) references HANG on delete cascade,
primary key(MaHDN,MaSP)
	
)


--Bảng KHACHHANG
create table KHACHHANG
(
	MaKH varchar (10) not null primary key,
	TenKH varchar(50) not null,
	DiaChi varchar(50) not null,
	DienThoai char (10) not null
)

--Bảng Bán
create table BAN (MaHDB varchar(10) primary key not null,
			  	  MaKH varchar(10) not null,
				  ThoiGian date not null,
				  KhuyenMai int,
				  TongTien int,
foreign key (MaKH) references KHACHHANG)



--Bảng Ban_Chi_Tiet
create table BANCHITIET(MaHDB varchar(10) not null,
						   MaSP varchar(10) not null,
						   SoLuongBan int,
						   ThanhTien float,
			foreign key (MaSP) references HANG on delete cascade,
			foreign key (MaHDB) references BAN on delete cascade,
			primary key(MaHDB, MaSP)
)
--Bảng tài khoản
Create table TAIKHOAN
(
TenTK varchar (50),
MatKhau varchar (10),
primary key (TenTK)
)

-----------------------------------------------TRIGGER----------------------------------


---Khi cập nhật CHITIETNHAP thì Update HANG set SoLuong 
create trigger tUpdateNhapCT
on CHITIETNHAP
for update
as
begin
	update HANG set SoLuong = HANG.SoLuong  - deleted.SoLuongNhap + inserted.SoLuongNhap
	from HANG join deleted on HANG.MaSP = deleted.MaSP
			  join inserted on HANG.MaSP = inserted.MaSP	
	
end
---Khi cập nhật BANCHITIET thì Update HANG set SoLuong
create trigger tUpdateBanCT
on BANCHITIET
for update
as
begin
	update HANG set SoLuong = HANG.SoLuong + deleted.SoLuongBan - inserted.SoLuongBan
	from HANG join deleted on HANG.MaSP = deleted.MaSP
			  join inserted on HANG.MaSP = inserted.MaSP	

end
----Khi xóa BANCHITIET thì Update HANG set SoLuong
go

	create trigger tDeleteBanCT
	on BANCHITIET after delete 
	as
	begin 
		UPDATE HANG set SoLuong = HANG.Soluong + deleted.SoLuongBan
		from HANG join deleted on deleted.MaSP = HANG.MaSP
		
	end 
	go
-----Trigger xóa CHITIETNHAP thì Update HANG set SoLuong
go
	create trigger tDeleteNhapCT
	on CHITIETNHAP after Delete 
	as
	begin 
		UPDATE HANG set SoLuong = HANG.SoLuong - deleted.SoluongNhap
		from HANG join deleted on deleted.MaSP = HANG.MaSP
		
	end


--. Khi thêm mới BANCHITIET thì update HANG set SoLuong
create trigger tInsertBanCT
On BANCHITIET AFTER INSERT 
AS 
BEGIN 
	UPDATE HANG SET SoLuong = HANG.SoLuong - inserted.SoLuongBan
	FROM HANG join inserted ON inserted.MaSP = HANG.MaSP 
	
END 
GO 

select * from BAN
--1. Khi thêm mới CHITIETNHAP thì Update HANG set SoLuong
create trigger tInsertNhapCT
ON CHITIETNHAP FOR INSERT 
AS
BEGIN 
	UPDATE HANG SET SoLuong = HANG.SoLuong + inserted.SoLuongNhap 
	FROM HANG JOIN inserted ON inserted.MaSP = HANG.MaSP
	
END
GO

--------Khi thêm, sửa, xóa BANCHITIET thì update TongTien ở bảng BAN
create trigger tTinhTien_Them
on BANCHITIET
after insert
as
begin
	update BAN set TongTien = TongTien  + inserted.ThanhTien 
	from BAN join inserted on BAN.MaHDB = inserted.MaHDB
end

create trigger tTinhTien_Sua
on BANCHITIET
after update
as
begin
	update BAN set TongTien = TongTien - deleted.ThanhTien + inserted.ThanhTien 
	from BAN join inserted on BAN.MaHDB = inserted.MaHDB
			join deleted on deleted.MaHDB = inserted.MaHDB
end

create trigger tTinhTien_Xoa
on BANCHITIET
after delete
as
begin
	update BAN set TongTien = TongTien  - deleted.ThanhTien 
	from BAN join deleted on BAN.MaHDB = deleted.MaHDB
end


--------Khi thêm, sửa, xóa NHAPCHITIET thì update TongTien ở bảng NHAP
create trigger tTinhTienNhap_Them
on CHITIETNHAP
after insert
as
begin
	update NHAP set TongTien = TongTien  + inserted.ThanhTien 
	from NHAP join inserted on NHAP.MaHDN = inserted.MaHDN
end

create trigger tTinhTienNhap_Sua
on CHITIETNHAP
after update
as
begin
	update NHAP set TongTien = TongTien - deleted.MaHDN + inserted.ThanhTien 
	from NHAP join inserted on NHAP.MaHDN = inserted.MaHDN
			join deleted on deleted.MaHDN = inserted.MaHDN
end

create trigger tTinhTienNhap_Xoa
on CHITIETNHAP
after delete
as
begin
	update NHAP set TongTien = TongTien - deleted.MaHDN 
	from NHAP join deleted on NHAP.MaHDN = deleted.MaHDN
end

--------------------------------------------DỮ LIỆU--------------------------------------

insert into NHACUNGCAP values ('NCC001',N'Đại lý vở Hồng Hà ', '0835679821',N'03 Lý Thái Tổ'),
							    ('NCC002',N'Công Ty cổ phần Kim Đồng', '012196886',N'27 Trần Thị Lý'),
								('NCC003',N'Sách vở Thiên Thần Nhỏ', '0935270776',N'07 Trưng Trắc'),
								('NCC004',N'Đại lý dụng cụ học tập', '0168908463',N'30 An Dương Vương'),
							    ('NCC005',N'Đại lý bút Phúc Long', '012691621',N'29 Ngô Quyền')
select * from NHACUNGCAP 

Insert into KHACHHANG (MaKH, TenKH, DiaChi, DienThoai)
Values ('KH0001', 'Truong Quang Minh', 'Ha Tinh', '0358364759'),
	('KH0002', 'Nguyen Thi Quyen Nhi', 'Can Loc', '0782687412'),
	('KH0003', 'Tran Thanh Chung', 'Ky Tan', '0964851232'),
	('KH0004', 'Ha Cong Chuc', 'Thach Ha', '0987452165'),
	('KH0005', 'Pham Van Gia Bao', 'Cam Xuyen', '0989488522')
select * from KHACHHANG


insert into HANG(MaSP,TenSP,DonViTinh,DonGia,SoLuong
) values ('SP001',N'Sách giáo khoa', N'VND','400000',12),
		('SP002',N'Vở kẻ hàng', N'VND','670000',12),
		('SP003',N'Giấy kiểm tra', N'VND','780000',12),
		('SP004',N'Vở ô ly', N'VND','900000',12),
		('SP005',N'Bút bi Thiên Long', N'VND','435000',12)
delete from HANG

insert into NHAP (MaHDN, ThoiGian, MaNCC) 
values ('HDN0000001','2021/02/03','NCC001'),
		('HDN0000002','2021/03/23','NCC002'),
		('HDN0000003','2021/04/23','NCC003'),
		('HDN0000004','2021/05/24','NCC004'),
		('HDN0000005','2021/04/21','NCC005')
select *  from NHAP

insert into CHITIETNHAP (MaHDN,MaSP,SoLuongNhap,DonGiaNhap)
values ('HDN0000001','SP001',100, '15000'),
		('HDN0000002','SP002',200, '12000'),
		('HDN0000003','SP003',130, '9000'),
		('HDN0000004','SP004',145, '12000'),
		('HDN0000005','SP005',156, '25000')
select * from CHITIETNHAP 



insert into BAN(MaHDB, MaKH, ThoiGian)
values  ('HDB0000001', 'KH0001', '2021/1/12'),
		('HDB0000002', 'KH0002', '2021/3/20'),
		('HDB0000003', 'KH0003', '2021/6/16'),
		('HDB0000004', 'KH0004', '2021/1/26'),
		('HDB0000005', 'KH0005', '2021/5/5')


insert into BANCHITIET (MaHDB, MaSP, SoLuongBan)
values  ('HDB0000001', 'SP001', 3),
		('HDB0000002', 'SP002', 5),
		('HDB0000003', 'SP003', 6),
		('HDB0000004', 'SP004', 4),
		('HDB0000005', 'SP005', 6)
select * from BANCHITIET 



insert into TAIKHOAN 
values ('Ly','12345678')

select * from TAIKHOAN
----------------------------------------------CODE THỦ TỤC/HÀM-----------------------------------
----------------------------------------------TAIKHOAN
--Select ALLTaiKhoan
Create proc pSelectALLTK
as
begin 
	select * from TAIKHOAN 
end 
go 
--Xoa TaiKhoan

Create proc pXoaTK (@TenTK varchar (50))
as
begin 
	Delete from TAIKHOAN where TenTK = @TenTK
end 
go 
--Ham trương hợp trùng tên tài khoản 
create function fGetTenTK (@TenTK varchar (50))
returns bit 
as 
begin 
	declare @count int 
	select @count = COUNT (TenTK) from TAIKHOAN where TenTK= @TenTK
	if @count >0 
		return 1
	return 0
end
go 
--SP them TK
create proc pThemTK
(@TenTK varchar (50), @MatKhau varchar (10) )
as
begin 
	if (dbo.fGetTenTK(@TenTK)=1)
	begin
		return 
	end 
	else 
	begin 
		insert into TAIKHOAN 
		(TenTK, MatKhau)
		values 
		(@TenTK, @MatKhau)
	end 
end 
go 
--Cap nhat MatKhau 
create proc pSuaTK
(@TenTK varchar (50), @MatKhau varchar (10))
as
begin 
	Update TAIKHOAN set MatKhau=@MatKhau where TenTK=@TenTK
end 
go 

---Đăng nhập
create proc pDangNhap (@TenTK varchar(50), @MatKhau varchar(10))
as
begin 
	select * from TaiKhoan where TenTK = @TenTK and MatKhau = @MatKhau
end
----------------------------------------------NHACUNGCAP
--SP lay ra toan bo NCC
go
Create proc pSelectALLNCC
as
begin 
	select * from NHACUNGCAP
end 
go



--SP xoa NCC
go
Create proc pXoaNCC ( @MaNCC varchar (10))
as
begin 
	Delete from NHACUNGCAP where MaNCC = @MaNCC
end 
go 
----Ham truong hop trung ten trung SDT
Create function fGetNCC (@TenNCC nvarchar (50), @DienThoai varchar (15))
returns bit
as
begin 
	declare @count int 
	select @count = COUNT (MaNCC) from NHACUNGCAP where TenNCC = @TenNCC and DienThoai = @DienThoai
	if @count >0 
		return 1 
	return 0
end 
go 
-------Tu tang Ma NCC

create function fGetNewMaNCC ()
returns varchar (10)
as
begin 
	declare @iCount int,  @MaNCC_new varchar (10)
	select @iCount = COUNT(MaNCC) from NHACUNGCAP
	if (@iCount <= 0)
	begin 
		set @MaNCC_new = 'NCC' + '001'
	end 
	else 
	begin 
		select @MaNCC_new = MAX(RIGHT(MaNCC, 3)) + 1 from NHACUNGCAP
		set @MaNCC_new = 'NCC' + RIGHT(REPLICATE ('0',2) + @MaNCC_new, 3)
	end 
	return @MaNCC_new 
end 
go 
---SP Them NCC 
Create proc pThemNCC
(@TenNCC nvarchar (100), @DiaChi nvarchar (100), @DienThoai varchar (13))
as
begin 
	if (dbo.fGetNCC(@TenNCC,@DienThoai)=1)
	begin 
		return 
	end 
	else 
	begin 
		Insert into NHACUNGCAP
		(MaNCC, TenNCC, DiaChi, DienThoai)
	Values 
		(dbo.fGetNewMaNCC(), @TenNCC, @DiaChi, @DienThoai)
	end 
end 
go
--------Sua NCC
Create proc pSuaNCC (@MaNCC varchar (10), @TenNCC nvarchar (100), @DiaChi nvarchar (100), @DienThoai varchar (13))
as
begin
	update NHACUNGCAP set TenNCC=@TenNCC, DienThoai=@DienThoai, DiaChi=@DiaChi
	where MaNCC = @MaNCC
end 
go 
-----SP tim kiem NCC
create proc pTimKiemNCC ( @Text nvarchar (100))
as
begin 
		select * from NHACUNGCAP where TenNCC like CONCAT('%',@Text,'%') or MaNCC Like CONCAT ('%',@Text,'%')
end




---------------------------------------------------------KHACHHANG
--SP lay ra toan bo khach hang 
go
Create proc pSelectALLKH
as
begin 
	select * from KHACHHANG
end 
go

exec pSelectALLKH

--SP xoa khach hang
go
Create proc pXoaKH ( @MaKH varchar (10))
as
begin 
	Delete from KHACHHANG where MaKH = @MaKH
end 
go 
----Ham truong hop trung ten trung SDT
Create function fGetKH (@TenKH nvarchar (50),@DienThoai varchar (15))
returns bit
as
begin 
	declare @count int 
	select @count = COUNT (MaKH) from KHACHHANG where TenKH = @TenKH and DienThoai = @DienThoai
	if @count >0 
		return 1 
	return 0
end 
go 
-------Tu tang Ma Khach Hang 

create function fGetNewMaKH ()
returns varchar (10)
as
begin 
	declare @iCount int,  @MaKH_new varchar (10)
	select @iCount = COUNT(MaKH) from KHACHHANG
	if (@iCount <= 0)
	begin 
		set @MaKH_new = 'KH' + '00000001'
	end 
	else 
	begin 
		select @MaKH_new = MAX(RIGHT(MaKH, 8)) + 1 from KHACHHANG 
		set @MaKH_new = 'KH' + RIGHT(REPLICATE ('0',7) + @MaKH_new, 8)
	end 
	return @MaKH_new 
end 
go 
---SP Them Khach Hang 
Create proc pThemKH
(@TenKH nvarchar (100), @DiaChi nvarchar (100), @DienThoai varchar (13))
as
begin 
	if (dbo.fGetKH(@TenKH,@DienThoai)=1)
	begin 
		return 
	end 
	else 
	begin 
		Insert into KHACHHANG 
		(MaKH, TenKH, DiaChi, DienThoai)
	Values 
		(dbo.fGetNewMaKH(), @TenKH, @DiaChi, @DienThoai)
	end 
end 
go
--------Sua Khach Hang
Create proc pSuaKH (@MaKh varchar (10), @TenKH nvarchar (100), @DiaChi nvarchar (100), @DienThoai varchar (13))
as
begin
	update KHACHHANG set TenKH=@TenKH, DienThoai=@DienThoai, DiaChi=@DiaChi
	where MaKh=@MaKH
end 
go 
-----SP tim kiem khach hang
create proc pTimKiemKH ( @Text nvarchar (100))
as
begin 
		select * from KHACHHANG where TenKH like CONCAT('%',@Text,'%') or MaKH Like CONCAT ('%',@Text,'%')
end

-----------------------------------------------NHAP------------------------------------------------
-- Select All Nhập
go

create proc pSelectAllNhap
as
begin
	select  NHAP.MaHDN, NHACUNGCAP.MaNCC, NHACUNGCAP.TenNCC, sum(ChiTietNhap.ThanhTien) as TongTien, ThoiGian, Thue,ChietKhau,
				(SUM(ChiTietNhap.ThanhTien) - NHAP.ChietKhau + NHAP.Thue) as ThanhToan
	from NHAP full outer join CHITIETNHAP on NHAP.MaHDN = CHITIETNHAP.MaHDN
				join NHACUNGCAP on NHACUNGCAP.MaNCC = NHAP.MaNCC
	group by NHAP.MaHDN, NHACUNGCAP.MaNCC, NHACUNGCAP.TenNCC, ThoiGian, NHAP.ChietKhau, NHAP.Thue, CHITIETNHAP.ThanhTien, NHAP.TongTien
end
go

exec pSelectAllNhap

--SP xóa Nhap
create proc pXoaHDN (@MaHDN varchar(10))
as
begin
	Delete From NHAP where MaHDN = @MaHDN
end
go

--Tự động tăng Mã HDN
create function fGetNewMaHDN ()
returns varchar (10)
as
begin 
	declare @iCount int, @MaHDN varchar (10), @MaHDN_new varchar (10)
	select @iCount = COUNT(MaHDN) from NHAP
	if (@iCount <= 0)
	begin 
		set @MaHDN_new = 'HDN' + '0000001'
	end 
	else 
	begin
		select @MaHDN_new = MAX(RIGHT(MaHDN, 7)) + 1 from NHAP
		set @MaHDN_new = 'HDN' + RIGHT(REPLICATE ('0',6) + @MaHDN_new, 7)
	end 
	return @MaHDN_new 
end 
go

go

--Thêm Hóa đơn

create proc pThemHDN
( @MaNCC varchar(10), @ThoiGian datetime)
as
begin
	declare @Count int

	set  @Count = (select COUNT(MaNCC) from NHACUNGCAP where MaNCC = @MaNCC )
	if (@Count < 1) 
		begin
			return
		end
	Insert Into NHAP 
	(MaHDN, MaNCC,ThoiGian)
	Values
		(dbo.fGetNewMaHDN(), @MaNCC, @ThoiGian)
end
go

--Sửa hóa đơn
create proc pSuaHDN
(@MaHDN varchar(10),@MaNCC varchar(10), @ThoiGian datetime, @Thue int, @Chietkhau int, @ThanhToan int )
As
Begin
	declare @Count int
	set @Count = (select COUNT(MaNCC) from NHACUNGCAP where MaNCC = @MaNCC )
	if (@Count < 1) 
		begin
			return
		end
	Update NHAP set MaNCC = @MaNCC, ThoiGian = @ThoiGian, Thue = @Thue, ChietKhau = @Chietkhau, TongTien = @ThanhToan
	where MaHDN = @MaHDN
End
Go

-- SP tìm kiếm Nhập
create proc pTimKiemHDN ( @Text nvarchar(100))
as
begin
	
	select NHAP.MaHDN, NHACUNGCAP.MaNCC, NHACUNGCAP.TenNCC, sum(ChiTietNhap.ThanhTien) as TongTien, ThoiGian, Thue,ChietKhau,
				(SUM(ChiTietNhap.ThanhTien) - NHAP.ChietKhau + NHAP.Thue) as PhaiTra
	from NHAP full outer join CHITIETNHAP on NHAP.MaHDN = CHITIETNHAP.MaHDN
				join NHACUNGCAP on NHACUNGCAP.MaNCC = NHAP.MaNCC
	where NHAP.MaHDN like CONCAT('%', @Text ,'%') or NHACUNGCAP.TenNCC like CONCAT('%', @Text ,'%')
	group by NHAP.MaHDN, NHACUNGCAP.MaNCC, NHACUNGCAP.TenNCC , ThoiGian, NHAP.ChietKhau, NHAP.Thue, CHITIETNHAP.SoLuongNhap, NHAP.TongTien,CHITIETNHAP.ThanhTien

end
go

------------------------------------------------------------CHITIETNHAP
--Xóa CTN
create proc pXoaCTN (@MaHDN varchar(10), @MaSP varchar(10))
as
begin
	Delete From CHITIETNHAP where MaHDN = @MaHDN and MaSP = @MaSP
end
go

-- Select All ChiTietHoaDon
create proc pSelectAllCTN
as
begin
	select ctn.MaHDN, ctn.MaSP, h.TenSP, ctn.SoLuongNhap, ctn.DonGiaNhap, ctn.ThanhTien
		from CHITIETNHAP as ctn join HANG as h on h.MaSP = ctn.MaSP
								join NHAP as n on n.MaHDN = ctn.MaHDN			
end
go

-- Hàm Trường hợp trùng MaHD và MaSP
create function fGetCTN(@MaHDN varchar(10), @MaSP varchar(10))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaHDN) from CHITIETNHAP where MaHDN = @MaHDN and MaSP = @MaSP

	if @count > 0
		return 1
	return 0
end
go

-- SP Thêm chi tiết hóa đơn
create proc pThemCTN
(@MaHDN varchar(10), @MaSP varchar(10), @SoLuongNhap int, @DonGiaNhap int, @ThanhTien int)
as
begin
	declare @Count int
	set @Count = (select COUNT(MaHDN) from NHAP where MaHDN = @MaHDN )
	if (@Count < 1) 
		begin
			return
		end
	
	if (dbo.fGetCTN(@MaHDN, @MaSP) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into CHITIETNHAP
		(MaHDN, MaSP, SoLuongNhap,ThanhTien,DonGiaNhap)
		Values
			(@MaHDN, @MaSP, @SoLuongNhap, @ThanhTien, @DonGiaNhap)
	end
end
go


-- SP Sửa Chi Tiết Nhập
create proc pSuaCTN
(@MaHDN varchar(10), @MaSP varchar(10), @SoLuongNhap int, @ThanhTien int, @DonGiaNhap int)
As
Begin
	declare @Count int
	set @Count = (select COUNT(MaHDN) from NHAP where MaHDN = @MaHDN)
	if (@Count < 1) 
		begin
			return
		end
	set @Count = (select COUNT(MaSP) from HANG where MaSP = @MaSP )
	if (@Count < 1) 
		begin
			return
		end
	Update CHITIETNHAP
	set  MaHDN = @MaHDN, MaSP = @MaSP, SoLuongNhap = @SoLuongNhap, ThanhTien = @ThanhTien, DonGiaNhap = @DonGiaNhap
	where  MaHDN = @MaHDN and MaSP = @MaSP 
End
Go

-- SP tìm kiếm hóa đơn chi tiết

create proc pTimKiemCTN (@Text nvarchar(100))
as
begin
	
		select ctn.*, h.TenSP
		from CHITIETNHAP as ctn join HANG as h on h.MaSP = ctn.MaSP
								join NHAP as n on n.MaHDN = ctn.MaHDN
		where n.MaHDN like CONCAT('%', @Text ,'%') or h.TenSP like CONCAT('%', @Text ,'%')
	
end
go



----------------------------------------------------HANG
--Select Hàng
go
create proc pSelectHang
as
begin
	select * from HANG
end

--SP xóa sản phẩm
create proc pXoaHang (@MaSP varchar(10))
as
begin
	Delete From HANG where MaSP = @MaSP
end
go

-- Hàm Trường hợp trùng tên hàng
create function fGetSP(@TenSP nvarchar(50))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaSP) from HANG where TenSP = @TenSP 

	if @count > 0
		return 1
	return 0
end
go
-- Tự tăng Mã sản phẩm
create function fGetNewMaSP ()
returns varchar(10)
as
begin
	declare @iCount int,  @MaSP_new varchar(10)
	select @iCount = COUNT(MaSP) from HANG
	if (@iCount <= 0) 
	begin
		set @MaSP_new = 'SP' + '001'
	end
	else
	begin
		select @MaSP_new = MAX(RIGHT(MaSP, 3)) + 1 from HANG
		set @MaSP_new = 'SP' + RIGHT(REPLICATE('0', 7) + @MaSP_new, 3)
	end
	return @MaSP_new
end
go


-- SP Thêm hàng mới
create proc pThemHang 
( @TenSP nvarchar(50), @Soluong int,@DonGia int, @Donvitinh nvarchar(10))
as
begin
	if (dbo.fGetSP(@TenSP) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into HANG
		(MaSP, TenSP,DonViTinh, DonGia,SoLuong)
		Values
			(dbo.fGetNewMaSP(), @TenSP, @Donvitinh, @DonGia, @Soluong)
	end
end
go

-- SP Sửa hàng
create proc pSuaHang
(@MaSP varchar(10), @tenSP nvarchar(100), @DonViTinh nvarchar(10),@DonGia int, @Soluong int )
As
Begin
	Update HANG
	set  TenSP = @tenSP, DonViTinh = @DonViTinh, DonGia = @DonGia, SoLuong = @Soluong
	where MaSP = @MaSP
End
Go

--SP Tìm kiếm hàng
go
create proc pTimKiemHang ( @Text nvarchar(100))
as
begin
	select * from  HANG where TenSP like CONCAT('%', @Text ,'%') or MaSP like CONCAT('%', @Text ,'%')
end
go

------------------------------------------------BAN

--Select Hoa don
go
create proc pSelectHDB
as
begin
	select BAN.MaHDB, KHACHHANG.MaKH, KHACHHANG.TenKH, ThoiGian,  Sum(BANCHITIET.ThanhTien) as ThanhTien, BAN.KhuyenMai,
	(Sum(BANCHITIET.ThanhTien) - BAN.KhuyenMai) as TongTien
	from BAN full outer join BANCHITIET on Ban.MaHDB = BANCHITIET.MaHDB 
			 full outer join HANG on HANG.MaSP = BANCHITIET.MaSP
			 join KHACHHANG on KHACHHANG.MaKH = BAN.MaKH
	group by BAN.MaHDB, KHACHHANG.MaKH,KHACHHANG.TenKH, BAN.KhuyenMai, ThoiGian 
end

exec pSelectHDB
select * from BAN

--Xoa hoa don
create proc pXoaHDB (@mahdb varchar(10))
as
begin
	delete from BAN where MaHDB = @mahdb 
end
--Tim kiem hoa don
go
create proc pTkHDB (@text varchar(10))
as
begin
	select BAN.MaHDB, KHACHHANG.MaKH, KHACHHANG.TenKH, ThoiGian, Sum(BANCHITIET.ThanhTien) as ThanhTien,  BAN.KhuyenMai,
	(Sum(BANCHITIET.ThanhTien) - BAN.KhuyenMai) as TongTien
	from BAN full outer join BANCHITIET on BAN.MaHDB = BANCHITIET.MaHDB 
			 full outer join HANG on HANG.MaSP = BANCHITIET.MaSP
			 join KHACHHANG on KHACHHANG.MaKH = BAN.MaKH
	where BAN.MaHDB like CONCAT('%', @text ,'%') or KHACHHANG.TenKH  like CONCAT('%', @text ,'%')
	group by BAN.MaHDB, KHACHHANG.MaKH, KHACHHANG.TenKH,BAN.KhuyenMai ,ThoiGian 
end
go

declare @tx varchar(10)
exec pTkHDB 'HD011'
print @tx
--Sua hoa don
go
create proc pSuaHDB (@Mahdb varchar(10), 
					 @MaKH varchar(10),		
					 @NgayBan date,
					 @KhuyenMai int,
					 @PhaiTra int)
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KHACHHANG where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			return
		end
	Update BAN set MaKH = @MaKH, ThoiGian = @NgayBan, KhuyenMai = @Khuyenmai, TongTien = @PhaiTra
	where MaHDB = @Mahdb
end



--Tu dong tang ma
go
create function fNewMaHDB ()
returns varchar(10)
as
begin
	declare @iCount int, @NewMaHDB varchar(10)
	select @iCount = COUNT(MaHDB) from BAN
	if (@iCount <= 0) 
	begin
		set @NewMaHDB = 'HD' + '00000001'
	end
	else
	begin
		select @NewMaHDB = MAX(RIGHT(MaHDB, 8)) + 1 from BAN
		set @NewMaHDB = 'HD' + RIGHT(REPLICATE('0', 7) + @NewMaHDB, 8)
	end
	return @NewMaHDB
end
--Them hoa don
go
create proc pThemHDB (@MaKH varchar(10), @NgayBan date)
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KHACHHANG where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			return
		end
	Insert Into BAN (MaHDB, MaKH, ThoiGian)
	Values
		(dbo.fNewMaHDB(), @MaKH, @NgayBan)
end
go


---------------------------------------BANCHITIET
--Xoa CHITIETBAN
go
create proc pXoaCTHDB (@MaHDB varchar(10), @MaSP varchar(10))
as
begin
	delete from BANCHITIET where MaHDB = @MaHDB and MaSP = @MaSP
end
--Select Chi tiet Ban
go
create proc pSelectCTHDB
as
begin
	select BANCHITIET.MaHDB, BANCHITIET.MaSP, HANG.TenSP,BANCHITIET.SoLuongBan, HANG.DonGia, BANCHITIET.ThanhTien
	from BANCHITIET join HANG on BANCHITIET.MaSP = HANG.MaSP
end

exec pSelectCTHDB

--Tim kiem 
go
create proc pTimKiemCTHDB (@Text nvarchar(100))
as
begin
		select BANCHITIET.MaHDB, BANCHITIET.MaSP, HANG.TenSP,BANCHITIET.SoLuongBan, HANG.DonGia, BANCHITIET.ThanhTien
		from BANCHITIET join HANG on BANCHITIET.MaSP = HANG.MaSP
		where MaHDB like CONCAT('%', @Text ,'%') or HANG.TenSP like CONCAT('%', @Text ,'%')
end
go


--Sua
go
create proc pSuaCTHDB (@MaHDB varchar(10), @MaSP varchar(10), @SoLuongBan INT, @ThanhTien int)
As
Begin
	declare @iCount int
	set @iCount = (select COUNT(MaHDB) from BANCHITIET where MaHDB = @MaHDB and MaSP = @MaSP)
	if (@iCount < 1) 
		begin
			return
		end
	set @iCount = (select COUNT(MaSP) from HANG where MaSP = @MaSP )
	if (@iCount < 1) 
		begin
			return
		end
	
	Update BANCHITIET
	set  SoLuongBan = @SoLuongBan, ThanhTien = @ThanhTien
	from HANG join BANCHITIET on HANG.MaSP = BANCHITIET.MaSP
	where  MaHDB = @MaHDB and HANG.MaSP = @MaSP
End



-- Trường hợp trùng MaHD và MaSP
go
create function fGetCTHD(@MaHDB varchar(10), @MaSP varchar(10))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaHDB) from BANCHITIET where MaHDB = @MaHDB and MaSP = @MaSP

	if @count > 0
		return 1
	return 0
end
go

-- SP Thêm chi tiết hóa đơn
create proc pThemCTHD (@MaHDB varchar(10), @MaSP varchar(10), @SoLuongBan int, @ThanhTien float )
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaHDB) from BAN where MaHDB = @MaHDB )
	if (@iCount < 1) 
		begin
			return
		end
	set @iCount = (select COUNT(MaSP) from HANG where MaSP = @MaSP )
	if (@iCount < 1) 
		begin
			return
		end
	if (dbo.fGetCTHD(@MaHDB, @MaSP) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into BANCHITIET
		(MaHDB, MaSP, SoLuongBan, ThanhTien)
		Values
			(@MaHDB, @MaSP, @SoLuongBan, @ThanhTien)
	end
end
go

--Chon pham se hien don gia
create proc pDonGia (@MaSP varchar(10))
as
begin
	select DonGia from HANG where MaSP = @MaSP
end
select * from TAIKHOAN




-------------------------------------------------------------------------------------------------------
------------------ TẠO INDEX ------------------
CREATE NONCLUSTERED INDEX Index_1 on HANG(MaSP)

-------------------MÃ HÓA---------------------

Alter Table TAIKHOAN /*Tạo cột để lưu dữ liệu mã hoá*/
Add [Encrypted MK] varbinary(MAX)
go
 Update TAIKHOAN  /*Cập nhật dữ liệu được mã hoá vào cột vừa tạo*/
Set [Encrypted MK] = ENCRYPTBYPASSPHRASE('MK', CONVERT(varchar(100),MatKhau))
select * from TAIKHOAN

Alter Table TAIKHOAN drop column MatKhau /*Xoá bỏ cột dữ liệu chưa được mã hoá và truy vấn dữ liệu*/
go
Select * From TAIKHOAN
 

Select TenTK, CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('MK', [Encrypted MK]))) as MatKhau  /* Giải mã dữ liệu */
go
--------------------------BACKUP------------------------------
BACKUP DATABASE BANHANG TO DISK = 'D:\Kỳ 2021-2022\Quản trị cơ sở dữ liệu\nhóm\Back up CSDL' WITH INIT