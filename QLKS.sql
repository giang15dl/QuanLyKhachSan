use master
go

--Tạo database Quản Lý Khách Sạn
if exists (select * from sysdatabases where name='QLKS')
	drop database QLKS
go 

create database QLKS
go

use QLKS
go

--Viết các câu lệnh SQL để thực hiện các thao tác
if exists (select * from sysobjects where name='tPhong')
	drop table tPhong
go

if exists (select * from sysobjects where name='tThietBi')
	drop table tThietBi
go

if exists (select * from sysobjects where name='tTrangBi')
	drop table tTrangBi
go

if exists (select * from sysobjects where name='tKhach')
	drop table tKhach
go

if exists (select * from sysobjects where name='tThuePhong')
	drop table tThuePhong
go

--create bảng Phòng
create table tPhong
(
	SoPhong char(4) primary key,
    GiaTien int not null,
    ConSuDung char(3) not null
)
go

--create bảng Thiết Bị
create table tThietBi
(
	MaThietBi char(5) primary key,
    TenThietBi nvarchar(30) not null,
    NgayMua datetime not null,
    GiaMua int not null,
    TinhTrang char(3) not null
)
go

--create bảng Trang Bị
create table tTrangBi
(
	SoPhong char(4) not null,
    MaThietBi char(5) not null,
    NgayBatDauTrangBi datetime not null,
    NgayKetThucTrangBi datetime not null
)
go

--create bảng Khách
create table tKhach
(
	MaKhach char(4) primary key,
    TenKhach nvarchar(30) not null,
    SoCMND char(15) not null,
    DienThoai char(11) not null
)
go

--create bảng Thuê Phòng
create table tThuePhong
(
	STT int IDENTITY(1,1) not null,
    SoPhong char(4) not null,
    MaKhach char(4) not null,
    NgayNhanPhong datetime not null,
    NgayTraPhong datetime not null
)
go

--add Foreign Key và primary key
alter table tTrangBi add constraint ttb_pk primary key (SoPhong, MaThietBi)
alter table tTrangBi add constraint ttb_fk_sophong foreign key (SoPhong) references tPhong(SoPhong)
alter table tTrangBi add constraint ttb_fk_matb foreign key (MaThietBi) references tThietBi(MaThietBi)

alter table tThuePhong add constraint ttp_pk primary key (STT, SoPhong, MaKhach)
alter table tThuePhong add constraint ttp_fk_sophong foreign key (SoPhong) references tPhong(SoPhong)
alter table tThuePhong add constraint ttp_fk_makhach foreign key (MaKhach) references tKhach(MaKhach)

--initialize sample data 

--insert Phòng
insert into tPhong values('P001', 100000, 'Yes')
insert into tPhong values('P002', 100000, 'Yes')
insert into tPhong values('P003', 150000, 'No')
insert into tPhong values('P004', 150000, 'Yes')
insert into tPhong values('P005', 200000, 'No')

--insert Thiết Bị
set dateformat DMY insert into tThietBi values('TB001', N'TV', '20/11/2021', 5000000, 'New')
set dateformat DMY insert into tThietBi values('TB002', N'Tủ Lạnh', '02/11/2021', 4400000, 'New')
set dateformat DMY insert into tThietBi values('TB003', N'Điều Hòa', '12/11/2021', 3000000, 'New')
set dateformat DMY insert into tThietBi values('TB004', N'Bàn là', '10/12/2021', 500000, 'New')

--insert Trang Bị
set dateformat DMY insert into tTrangBi values('P001', 'TB001', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P001', 'TB002', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P001', 'TB003', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P002', 'TB001', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P002', 'TB002', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P002', 'TB003', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P003', 'TB001', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P003', 'TB002', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P003', 'TB003', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P004', 'TB001', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P004', 'TB002', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P004', 'TB003', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P005', 'TB001', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P005', 'TB002', '02/01/2022', '02/04/2022')
set dateformat DMY insert into tTrangBi values('P005', 'TB003', '02/01/2022', '02/04/2022')

--insert Khách
insert into tKhach values('K001', N'Nguyễn Vinh Đạt', '20020100012', '0908145861')
insert into tKhach values('K002', N'Nguyễn Tiến Lợi', '20020123412', '0822300982')
insert into tKhach values('K003', N'Nguyễn Duy Hiếu', '20020153432', '0723928527')

--insert Thuê Phòng
set dateformat DMY insert into tThuePhong values('P001', 'K001', '02/02/2022', '03/02/2022')
set dateformat DMY insert into tThuePhong values('P002', 'K002', '02/02/2022', '04/02/2022')
set dateformat DMY insert into tThuePhong values('P003', 'K003', '04/02/2022', '06/02/2022')
