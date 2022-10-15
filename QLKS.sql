USE [master];
GO
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('QLKS')
EXEC(@kill);

IF exists (SELECT * FROM sysdatabases WHERE NAME = 'QLKS')
	DROP DATABASE QLKS
GO 

CREATE DATABASE QLKS
GO
USE [QLKS]
GO

/****** Object:  Table [dbo].[tKhach]    Script Date: 10/15/2022 11:57:03 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPhong]    Script Date: 10/15/2022 11:57:03 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThietBi]    Script Date: 10/15/2022 11:57:03 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThuePhong]    Script Date: 10/15/2022 11:57:03 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTrangBi]    Script Date: 10/15/2022 11:57:03 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K001', N'Nguyễn Vinh Đạt', N'20020100012    ', N'0908145861 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K002', N'Nguyễn Tiến Lợi', N'20020123412    ', N'0822300982 ')
INSERT [dbo].[tKhach] ([MaKhach], [TenKhach], [SoCMND], [DienThoai]) VALUES (N'K003', N'Nguyễn Duy Hiếu', N'20020153432    ', N'0723928527 ')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P001', 100000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P002', 100000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P003', 150000, N'No ')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P004', 150000, N'Yes')
INSERT [dbo].[tPhong] ([SoPhong], [GiaTien], [ConSuDung]) VALUES (N'P005', 200000, N'No ')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB001', N'TV', CAST(N'2021-11-20T00:00:00.000' AS DateTime), 5000000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB002', N'Tủ Lạnh', CAST(N'2021-11-02T00:00:00.000' AS DateTime), 4400000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB003', N'Điều Hòa', CAST(N'2021-11-12T00:00:00.000' AS DateTime), 3000000, N'New')
INSERT [dbo].[tThietBi] ([MaThietBi], [TenThietBi], [NgayMua], [GiaMua], [TinhTrang]) VALUES (N'TB004', N'Bàn là', CAST(N'2021-12-10T00:00:00.000' AS DateTime), 500000, N'New')
SET IDENTITY_INSERT [dbo].[tThuePhong] ON 

INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (1, N'P001', N'K001', CAST(N'2022-02-02T00:00:00.000' AS DateTime), CAST(N'2022-02-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (2, N'P002', N'K002', CAST(N'2022-02-02T00:00:00.000' AS DateTime), CAST(N'2022-02-04T00:00:00.000' AS DateTime))
INSERT [dbo].[tThuePhong] ([STT], [SoPhong], [MaKhach], [NgayNhanPhong], [NgayTraPhong]) VALUES (3, N'P003', N'K003', CAST(N'2022-02-04T00:00:00.000' AS DateTime), CAST(N'2022-02-06T00:00:00.000' AS DateTime))
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
