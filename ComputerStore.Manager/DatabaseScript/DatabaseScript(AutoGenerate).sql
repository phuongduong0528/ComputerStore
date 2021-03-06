USE [ComputerStore]
GO
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHanh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BaoHanh](
	[MaBH] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
	[NgayKichHoatBH] [date] NULL,
	[NgayKetThucBH] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HangSanXuat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HangSanXuat](
	[MaHSX] [char](10) NOT NULL,
	[TenHSX] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDon]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[ThanhTien] [bigint] NULL,
	[TienKhachTra] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[HoDemKH] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiHang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoaiHang](
	[MaLH] [char](10) NOT NULL,
	[TenLoaiHang] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MatHang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MatHang](
	[MaMH] [char](10) NOT NULL,
	[MaLH] [char](10) NOT NULL,
	[MaHSX] [char](10) NOT NULL,
	[MaNPP] [char](10) NOT NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[GiaNiemYet] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MatHangDuocBan]    Script Date: 11/28/2018 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MatHangDuocBan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MatHangDuocBan](
	[ID] [char](10) NOT NULL,
	[MaHD] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[KhuyenMai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/28/2018 20:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[MatKhau] [char](64) NOT NULL,
	[QuyenHan] [nvarchar](10) NOT NULL,
	[KhoaTK] [int] NOT NULL,
	[HoDem] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 11/28/2018 20:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhaPhanPhoi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNPP] [char](10) NOT NULL,
	[TenNhaPhanPhoi] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/28/2018 20:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SanPham]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[MaMH] [char](10) NOT NULL,
	[Serial] [nvarchar](20) NOT NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[NgayXuat] [date] NULL,
	[TinhTrang] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000001', N'Apple')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000002', N'Dell')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000003', N'HP')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000004', N'Asus')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000005', N'Acer')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000006', N'Lenovo')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000007', N'Microsoft')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000008', N'Sony')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000009', N'Samsung')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX]) VALUES (N'0000000010', N'LG')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Email], [SDT], [HoDemKH]) VALUES (N'0000000000', N'Guest', CAST(N'1970-01-01' AS Date), N'N/A', N'N/A', N'N/A', N'')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Email], [SDT], [HoDemKH]) VALUES (N'0000000001', N'Nam', CAST(N'1995-12-22' AS Date), N'Ha Noi', N'nam123@yahoo.com', N'0831478523', N'Nguyen Van')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Email], [SDT], [HoDemKH]) VALUES (N'0173057038', N'An', CAST(N'1992-10-28' AS Date), N'Thai Binh', N'mva2810@gmail.com', N'0831254785', N'Mai Van ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Email], [SDT], [HoDemKH]) VALUES (N'0276135818', N'Ba', CAST(N'1995-12-12' AS Date), N'Ha Noi', N'ba987@yahoo.com', N'0987412563', N'Nguyen Van ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Email], [SDT], [HoDemKH]) VALUES (N'1138747510', N'Thai', CAST(N'1995-01-22' AS Date), N'Ha Noi', N'thainv@yahoo.com', N'0831174589', N'Nguyen Van ')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000001', N'Smartphone')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000002', N'Tablet')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000003', N'Laptop-Regular')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000004', N'Laptop-Bussiness')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000005', N'Laptop-Gamming')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000006', N'PC-Regular')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000007', N'PC-Gamming')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000008', N'Server')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000009', N'Monitor')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000010', N'Keyboard')
INSERT [dbo].[LoaiHang] ([MaLH], [TenLoaiHang]) VALUES (N'0000000011', N'Mouse')
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000001', N'0000000004', N'0000000001', N'0000000001', N'MacBookPro 15 2018', 49990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000002', N'0000000002', N'0000000001', N'0000000001', N'iPad 11'' 2018 256GB', 21990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000003', N'0000000004', N'0000000002', N'0000000001', N'XPS 15'' 2018', 44990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000004', N'0000000005', N'0000000004', N'0000000001', N'ROG Zephyrus', 59990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000005', N'0000000005', N'0000000004', N'0000000001', N'ROG Strix', 27990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0000000006', N'0000000009', N'0000000010', N'0000000001', N'27MD5KA UltraFine 27'' 5K', 25490000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0509400873', N'0000000004', N'0000000001', N'0000000001', N'MacBookAir 2018', 39990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'0815403771', N'0000000004', N'0000000010', N'0000000001', N'Gram', 25990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1005005413', N'0000000002', N'0000000007', N'0000000001', N'Surface Pro', 35990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1175035629', N'0000000001', N'0000000001', N'0000000001', N'iPhone XR', 23490000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1302410131', N'0000000001', N'0000000001', N'0000000001', N'iPhone XS 256GB', 24990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1474403885', N'0000000010', N'0000000001', N'0000000001', N'iPhone XS Max 512GB', 39990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1569251006', N'0000000006', N'0000000002', N'0000000001', N'Dell XPS 13''', 25990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1658477664', N'0000000010', N'0000000007', N'0000000001', N'Surface Studio', 59990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1668332721', N'0000000001', N'0000000001', N'0000000001', N'iPhone XS Max 256GB', 32990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1809982610', N'0000000008', N'0000000002', N'0000000001', N'Dell Precision 5520', 79990000)
INSERT [dbo].[MatHang] ([MaMH], [MaLH], [MaHSX], [MaNPP], [TenMatHang], [GiaNiemYet]) VALUES (N'1823769049', N'0000000004', N'0000000001', N'0000000001', N'MacBookPro 13 2018', 29990000)
INSERT [dbo].[NhanVien] ([MaNV], [NgaySinh], [DiaChi], [Email], [SDT], [MatKhau], [QuyenHan], [KhoaTK], [HoDem], [Ten]) VALUES (N'0000000001', CAST(N'1988-02-20' AS Date), N'Ha Noi', N'manh111@gmail.com', N'0836547890', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Admin', 0, N'Nguyen Van', N'Manh')
INSERT [dbo].[NhanVien] ([MaNV], [NgaySinh], [DiaChi], [Email], [SDT], [MatKhau], [QuyenHan], [KhoaTK], [HoDem], [Ten]) VALUES (N'0000000002', CAST(N'1990-02-28' AS Date), N'Nam Dinh', N'maint@gmail.com', N'0987412555', N'2eab737d095f86d7e5a1fc616298ac81169cc91b09d1035b44706bc0a1c10ecf', N'Normal', 0, N'Nguyen Thi', N'Mai')
INSERT [dbo].[NhaPhanPhoi] ([MaNPP], [TenNhaPhanPhoi], [DiaChi], [SDT]) VALUES (N'0000000001', N'FPT', N'N/A', N'N/A')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000001', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000002', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000003', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000004', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000005', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000006', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000007', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000008', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000009', N'0000000001', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000010', N'0000000002', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000011', N'0000000002', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-27' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000012', N'0000000002', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000013', N'0000000003', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000014', N'0000000003', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000015', N'0000000002', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-27' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000016', N'0000000002', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000017', N'0000000004', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000018', N'0000000006', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'2018-11-28' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000019', N'0000000003', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000020', N'0000000003', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000021', N'0000000003', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000022', N'0000000004', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000023', N'0000000004', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0000000024', N'0000000006', N'0000000000', N'Chi?c', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0591559186', N'0000000006', N'7AYDHV9A8C', N'Chiec', CAST(N'2018-11-27' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0691887122', N'0000000006', N'A8ND7V8BO1', N'Chiec', CAST(N'2018-11-27' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'0820821919', N'0000000001', N'4A5S2C6U7', N'Chiec', CAST(N'2018-11-27' AS Date), CAST(N'2018-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'1265938450', N'0000000001', N'9A8D9A8D8A', N'Chiec', CAST(N'2018-11-25' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'1413939267', N'0000000002', N'7AGC8ANCA8', N'Chiec', CAST(N'2018-11-27' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
INSERT [dbo].[SanPham] ([MaSP], [MaMH], [Serial], [DonViTinh], [NgayNhap], [NgayXuat], [TinhTrang]) VALUES (N'1885653154', N'0000000002', N'7AGC8ANCA9', N'Chiec', CAST(N'2018-11-27' AS Date), CAST(N'1900-01-01' AS Date), N'OK')
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__KhachHang__HoDem__628FA481]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ('') FOR [HoDemKH]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__NhanVien__QuyenH__5EBF139D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ('') FOR [QuyenHan]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__NhanVien__KhoaTK__5FB337D6]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [KhoaTK]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__NhanVien__HoDem__60A75C0F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ('') FOR [HoDem]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__NhanVien__Ten__619B8048]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ('') FOR [Ten]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaoHanh_KhachHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaoHanh]'))
ALTER TABLE [dbo].[BaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_BaoHanh_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaoHanh_KhachHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaoHanh]'))
ALTER TABLE [dbo].[BaoHanh] CHECK CONSTRAINT [FK_BaoHanh_KhachHang]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaoHanh_SanPham]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaoHanh]'))
ALTER TABLE [dbo].[BaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_BaoHanh_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BaoHanh_SanPham]') AND parent_object_id = OBJECT_ID(N'[dbo].[BaoHanh]'))
ALTER TABLE [dbo].[BaoHanh] CHECK CONSTRAINT [FK_BaoHanh_SanPham]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HoaDon_KhachHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[HoaDon]'))
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HoaDon_KhachHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[HoaDon]'))
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HoaDon_NhanVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[HoaDon]'))
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HoaDon_NhanVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[HoaDon]'))
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_HangSanXuat]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_HangSanXuat] FOREIGN KEY([MaHSX])
REFERENCES [dbo].[HangSanXuat] ([MaHSX])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_HangSanXuat]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_HangSanXuat]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_LoaiHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiHang] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoaiHang] ([MaLH])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_LoaiHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_LoaiHang]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_NhaPhanPhoi]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_NhaPhanPhoi] FOREIGN KEY([MaNPP])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNPP])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHang_NhaPhanPhoi]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHang]'))
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_NhaPhanPhoi]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHangDuocBan_HoaDon]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHangDuocBan]'))
ALTER TABLE [dbo].[MatHangDuocBan]  WITH CHECK ADD  CONSTRAINT [FK_MatHangDuocBan_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHangDuocBan_HoaDon]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHangDuocBan]'))
ALTER TABLE [dbo].[MatHangDuocBan] CHECK CONSTRAINT [FK_MatHangDuocBan_HoaDon]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHangDuocBan_SanPham]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHangDuocBan]'))
ALTER TABLE [dbo].[MatHangDuocBan]  WITH CHECK ADD  CONSTRAINT [FK_MatHangDuocBan_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MatHangDuocBan_SanPham]') AND parent_object_id = OBJECT_ID(N'[dbo].[MatHangDuocBan]'))
ALTER TABLE [dbo].[MatHangDuocBan] CHECK CONSTRAINT [FK_MatHangDuocBan_SanPham]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SanPham_MatHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[SanPham]'))
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SanPham_MatHang]') AND parent_object_id = OBJECT_ID(N'[dbo].[SanPham]'))
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_MatHang]
GO
