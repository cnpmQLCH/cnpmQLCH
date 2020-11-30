create database QLCH
go

use QLCH
go

--Nhanvien
-- Khachhang
-- Nhaccungcap
-- Sanpham
-- Hoadon
-- ChitietHD
-- Phieunhap
-- ChitietPN
-- Phieuxuat
-- ChitietPX

create table Nhanvien(
	MA_NV nvarchar(50) NOT NULL primary key,
	TEN_NV nvarchar(50) NOT NULL,
	NAMSINH int NOT NULL,
	GIOITINH char(10) NOT NULL,
	SDT nvarchar(50) NOT NULL,
	DIACHI nvarchar(50) NOT NULL
)
go

create table Khachhang(
	MA_KH nvarchar(50) NOT NULL primary key,
	TEN_KH nvarchar(50) NOT NULL,
	SDT nvarchar(50) NOT NULL,
	DIACHI nvarchar(50) NOT NULL
)
go

create table Nhaccungcap(
	MA_NCC nvarchar(50) NOT NULL primary key,
	TEN_NCC nvarchar(50) NOT NULL,
	SDT nvarchar(50) NOT NULL,
	DIACHI nvarchar(50) NOT NULL,
	EMAIL nvarchar(50) NOT NULL
)
go

create table Sanpham(
	MA_SP nvarchar(50) NOT NULL primary key,
	TEN_SP nvarchar(50) NOT NULL,
	LOAI_SP nvarchar(50) NOT NULL,
	MA_NCC nvarchar(50) NOT NULL,
	DONGIA float NOT NULL,
	MOTA nvarchar(max),
	SOLUONG int

	foreign key(MA_NCC) references Nhaccungcap(MA_NCC)
)
go

create table Hoadon(
	MA_HD nvarchar(50) NOT NULL primary key,
	MA_NV nvarchar(50) NOT NULL,
	MA_KH nvarchar(50) NOT NULL,
	NGAYTAO datetime

	foreign key(MA_NV) references Nhanvien(MA_NV),
	foreign key(MA_KH) references Khachhang(MA_KH)
)
go

create table ChitietHD(
	MA_HD nvarchar(50) NOT NULL,
	MA_SP nvarchar(50) NOT NULL,
	DONGIA float NOT NULL,
	SOLUONG int,
	THANHTIEN float

	foreign key(MA_HD) references Hoadon(MA_HD),
	foreign key(MA_SP) references Sanpham(MA_SP),

	primary key(MA_HD,MA_SP)
)
go

create table Phieuxuat(
	MA_PX nvarchar(50) NOT NULL primary key,
	MA_NV nvarchar(50) NOT NULL,
	TEN_NGUOINHAN nvarchar(50) NOT NULL,
	NGAYTAO datetime,
	LYDO nvarchar(max)

	foreign key(MA_NV) references Nhanvien(MA_NV)
)
go

create table ChitietPX(
	MA_PX nvarchar(50) NOT NULL,
	MA_SP nvarchar(50) NOT NULL,
	DONGIA float NOT NULL,
	SOLUONG int,
	THANHTIEN float

	foreign key(MA_PX) references Phieuxuat(MA_PX),
	foreign key(MA_SP) references Sanpham(MA_SP),
	primary key(MA_PX,MA_SP)
)
go

create table Phieunhap(
	MA_PN nvarchar(50) NOT NULL primary key,
	MA_NV nvarchar(50) NOT NULL,
	MA_NCC nvarchar(50) NOT NULL,
	NGAYTAO datetime

	foreign key(MA_NV) references Nhanvien(MA_NV),
	foreign key(MA_NCC) references Nhaccungcap(MA_NCC)
)
go

create table ChitietPN(
	MA_PN nvarchar(50) NOT NULL,
	MA_SP nvarchar(50) NOT NULL,
	DONGIA float NOT NULL,
	SOLUONG int,
	THANHTIEN float

	foreign key(MA_PN) references Phieunhap(MA_PN),
	foreign key(MA_SP) references Sanpham(MA_SP),
	primary key(MA_PN,MA_SP)
)
go

ALTER TABLE Nhanvien ADD PASSWORD nvarchar(50);
