/****** Object:  Database [QLKS]    Script Date: 11/14/2022 8:05:48 PM ******/
USE [master]
GO

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('QLKS')
EXEC(@kill);

IF exists (SELECT * FROM sysdatabases WHERE NAME = 'QLKS')
	DROP DATABASE QLKS
GO 
/****** Object:  Database [QLKS]    Script Date: 11/14/2022 8:05:48 PM ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKS', N'ON'
GO
ALTER DATABASE [QLKS] SET QUERY_STORE = OFF
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[tDichVu]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDichVu](
	[MaDichVu] [char](4) NOT NULL,
	[TenDichVu] [nvarchar](30) NOT NULL,
	[GiaDichVu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaDon]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaDon](
	[MaHoaDon] [char](5) NOT NULL,
	[MaKhach] [char](4) NULL,
	[MaDichVu] [char](4) NULL,
	[SoPhong] [char](4) NULL,
	[NgayTraPhong] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKhach]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhach](
	[MaKhach] [char](4) NOT NULL,
	[TenKhach] [nvarchar](30) NOT NULL,
	[SoCMND] [char](15) NOT NULL,
	[DienThoai] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tLogin]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tLogin](
	[UserN] [varchar](20) NULL,
	[PassW] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPhong]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPhong](
	[SoPhong] [char](4) NOT NULL,
	[GiaTien] [int] NOT NULL,
	[ConSuDung] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThietBi]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tThietBi](
	[MaThietBi] [char](5) NOT NULL,
	[TenThietBi] [nvarchar](30) NOT NULL,
	[NgayMua] [datetime] NOT NULL,
	[GiaMua] [int] NOT NULL,
	[TinhTrang] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThuePhong]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tThuePhong](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[SoPhong] [char](4) NOT NULL,
	[MaKhach] [char](4) NOT NULL,
	[NgayNhanPhong] [datetime] NOT NULL,
	[NgayTraPhong] [datetime] NOT NULL,
 CONSTRAINT [ttp_pk] PRIMARY KEY CLUSTERED 
(
	[STT] ASC,
	[SoPhong] ASC,
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTrangBi]    Script Date: 11/14/2022 8:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tTrangBi](
	[SoPhong] [char](4) NOT NULL,
	[MaThietBi] [char](5) NOT NULL,
	[NgayBatDauTrangBi] [datetime] NOT NULL,
	[NgayKetThucTrangBi] [datetime] NOT NULL,
 CONSTRAINT [ttb_pk] PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV01', N'Nước ngọt', 15000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV02', N'Bánh ngọt', 25000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV03', N'Nước ép', 25000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV04', N'Giặt ủi', 30000, 100)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV05', N'Nước Khoán', 15000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV06', N'Mì tôm', 15000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV07', N'Cơm sường', 40000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV08', N'Phở', 50000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV09', N'Bún bò', 45000, 200)
INSERT [dbo].[tDichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [SoLuong]) VALUES (N'DV10', N'Cháo', 15000, 200)
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K001', N'Nguyễn Vinh Đạt', N'20020100012    ', N'0908145861 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K002', N'Nguyễn Tiến Lợi', N'20020123412    ', N'0822300982 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K003', N'Nguyễn Duy Hiếu', N'20020153432    ', N'0723928527 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K004', N'Hồ Ngọc Vĩnh Phát', N'20040103012    ', N'0909147369 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K005', N'Nguễn Lâm Thùy Trang', N'20020805123    ', N'0764856269 ')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P001', 100000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P002', 100000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P003', 150000, N'No ')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P004', 150000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P005', 200000, N'No ')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P006', 0, N'No ')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB001', N'TV', CAST(N'2021-11-20T00:00:00.000' AS DateTime), 5000000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB002', N'Tủ Lạnh', CAST(N'2021-11-02T00:00:00.000' AS DateTime), 4400000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB003', N'Điều Hòa', CAST(N'2021-11-12T00:00:00.000' AS DateTime), 3000000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB004', N'Bàn là', CAST(N'2021-12-10T00:00:00.000' AS DateTime), 500000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB005', N'Toys', CAST(N'2022-10-26T15:56:22.000' AS DateTime), 0, N'New')
SET IDENTITY_INSERT [dbo].[tThuePhong] ON 

INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (1, N'P001', N'K001', CAST(N'2022-02-02T00:00:00.000' AS DateTime), CAST(N'2022-02-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (2, N'P002', N'K002', CAST(N'2022-02-02T00:00:00.000' AS DateTime), CAST(N'2022-02-04T00:00:00.000' AS DateTime))
INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (3, N'P003', N'K003', CAST(N'2022-02-04T00:00:00.000' AS DateTime), CAST(N'2022-02-06T00:00:00.000' AS DateTime))
INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (1004, N'P006', N'K004', CAST(N'2022-10-26T16:06:46.000' AS DateTime), CAST(N'2022-10-27T16:06:46.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tThuePhong] OFF
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P001', N'TB001', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P001', N'TB002', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P001', N'TB003', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P002', N'TB001', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P002', N'TB002', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P002', N'TB003', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P003', N'TB001', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P003', N'TB002', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P003', N'TB003', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P004', N'TB001', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P004', N'TB002', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P004', N'TB003', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P005', N'TB001', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P005', N'TB002', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P005', N'TB003', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(N'2022-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[tTrangBi] ([SoPhong], [MaThietBi], [NgayBatDauTrangBi], [NgayKetThucTrangBi]) VALUES (N'P006', N'TB005', CAST(N'2022-10-26T16:01:23.110' AS DateTime), CAST(N'2022-10-30T16:01:23.000' AS DateTime))
ALTER TABLE [dbo].[tHoaDon]  WITH CHECK ADD  CONSTRAINT [thd_fk_madichvu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[tDichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[tHoaDon] CHECK CONSTRAINT [thd_fk_madichvu]
GO
ALTER TABLE [dbo].[tHoaDon]  WITH CHECK ADD  CONSTRAINT [thd_fk_makhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tKhach] ([MaKhach])
GO
ALTER TABLE [dbo].[tHoaDon] CHECK CONSTRAINT [thd_fk_makhach]
GO
ALTER TABLE [dbo].[tHoaDon]  WITH CHECK ADD  CONSTRAINT [thd_fk_sophong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[tPhong] ([SoPhong])
GO
ALTER TABLE [dbo].[tHoaDon] CHECK CONSTRAINT [thd_fk_sophong]
GO
ALTER TABLE [dbo].[tThuePhong]  WITH CHECK ADD  CONSTRAINT [ttp_fk_makhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tKhach] ([MaKhach])
GO
ALTER TABLE [dbo].[tThuePhong] CHECK CONSTRAINT [ttp_fk_makhach]
GO
ALTER TABLE [dbo].[tThuePhong]  WITH CHECK ADD  CONSTRAINT [ttp_fk_sophong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[tPhong] ([SoPhong])
GO
ALTER TABLE [dbo].[tThuePhong] CHECK CONSTRAINT [ttp_fk_sophong]
GO
ALTER TABLE [dbo].[tTrangBi]  WITH CHECK ADD  CONSTRAINT [ttb_fk_matb] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[tThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[tTrangBi] CHECK CONSTRAINT [ttb_fk_matb]
GO
ALTER TABLE [dbo].[tTrangBi]  WITH CHECK ADD  CONSTRAINT [ttb_fk_sophong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[tPhong] ([SoPhong])
GO
ALTER TABLE [dbo].[tTrangBi] CHECK CONSTRAINT [ttb_fk_sophong]
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
