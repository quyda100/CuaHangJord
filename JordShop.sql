USE [JordShop]
GO
/****** Object:  Table [dbo].[tbLoaiKH]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbLoaiKH](
	[MaLoaiKH] [varchar](5) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbLoaiKH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbLoaiKH] ([MaLoaiKH], [TenLoai]) VALUES (N'1', N'Đồng')
INSERT [dbo].[tbLoaiKH] ([MaLoaiKH], [TenLoai]) VALUES (N'2', N'Bạc')
INSERT [dbo].[tbLoaiKH] ([MaLoaiKH], [TenLoai]) VALUES (N'3', N'Vàng')
INSERT [dbo].[tbLoaiKH] ([MaLoaiKH], [TenLoai]) VALUES (N'4', N'Bạch Kim')
/****** Object:  Table [dbo].[tbKichThuoc]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbKichThuoc](
	[MaSize] [varchar](5) NOT NULL,
	[Size] [int] NULL,
 CONSTRAINT [PK_tbKichThuoc] PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'1', 34)
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'2', 35)
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'3', 36)
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'4', 37)
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'5', 38)
INSERT [dbo].[tbKichThuoc] ([MaSize], [Size]) VALUES (N'6', 39)
/****** Object:  Table [dbo].[tbNhaSanXuat]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbNhaSanXuat](
	[MaNSX] [varchar](5) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbNhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbNhaSanXuat] ([MaNSX], [TenNSX]) VALUES (N'1', N'Nike')
INSERT [dbo].[tbNhaSanXuat] ([MaNSX], [TenNSX]) VALUES (N'2', N'Adidas')
INSERT [dbo].[tbNhaSanXuat] ([MaNSX], [TenNSX]) VALUES (N'3', N'Puma')
INSERT [dbo].[tbNhaSanXuat] ([MaNSX], [TenNSX]) VALUES (N'4', N'Vans')
INSERT [dbo].[tbNhaSanXuat] ([MaNSX], [TenNSX]) VALUES (N'5', N'Converse')
/****** Object:  Table [dbo].[tbChucVu]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbChucVu](
	[MaChucVu] [varchar](5) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'1', N'Quản lí')
INSERT [dbo].[tbChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'2', N'Nhân viên')
INSERT [dbo].[tbChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'4', N'Giám đốc')
INSERT [dbo].[tbChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'5', N'Quản trị viên')
/****** Object:  Table [dbo].[tbSanPham]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbSanPham](
	[MaSP] [varchar](5) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [smallint] NULL,
	[HinhAnh] [varchar](50) NULL,
	[MaSize] [varchar](5) NULL,
	[MaNSX] [varchar](5) NULL,
	[DaXoa] [bit] NULL,
	[NgayTao] [datetime] NULL,
 CONSTRAINT [PK_tbSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'101', N'NIKE AIR FORCE 1 LOW', 740000, 5, N'nike-air-force-1-low-white.jpg', N'2', N'1', 0, NULL)
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'102', N'NIKE JORDAN 1 LOW', 790000, 2, N'giay-nike-air-jordan-1-low.jpg', N'4', N'1', 1, NULL)
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'203', N'Adidas Prophere Blue REPLICA', 620000, 3, N'Adidas-Prophere-Blue-REPLICA.jpg', N'3', N'2', 0, NULL)
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'204', N'ADIDAS ULTRA BOOST 4.0', 590000, 2, N'ADIDAS-ULTRA-BOOST-4-0.jpg', N'3', N'2', 0, NULL)
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'405', N'VANS OFF THE WALL', 590000, 5, N'vans-off-the-wall-1.jpg', N'3', N'4', 0, NULL)
INSERT [dbo].[tbSanPham] ([MaSP], [TenSP], [DonGia], [SoLuong], [HinhAnh], [MaSize], [MaNSX], [DaXoa], [NgayTao]) VALUES (N'506', N'CONVERSE 1970S CHUCK TAYLOR 2', 715000, 7, N'Giay-the-thao-converse-70s-low-1.jpg', N'2', N'5', 0, NULL)
/****** Object:  Table [dbo].[tbNhanVien]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbNhanVien](
	[MaNV] [varchar](5) NOT NULL,
	[TenNV] [nchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[NgayVaoLam] [datetime] NULL,
	[MaChucVu] [varchar](5) NULL,
	[HinhAnh] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_tbNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [MaChucVu], [HinhAnh], [MatKhau], [DaXoa]) VALUES (N'101', N'Huỳnh Trần', CAST(0x00005D1C00000000 AS DateTime), N'Nam', N'Lâm Đồng', 335861472, CAST(0x0000AA4500000000 AS DateTime), N'1', N'', N'xMpCOKC5I4INzFCab3WEmw==', 0)
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [MaChucVu], [HinhAnh], [MatKhau], [DaXoa]) VALUES (N'202', N'Ngọc Quỳnh', CAST(0x0000889000000000 AS DateTime), N'Nữ', N'Tp. Thủ Đức, Tp. Hồ Chí Minh', 348624921, CAST(0x0000AC8C00000000 AS DateTime), N'2', NULL, N'xMpCOKC5I4INzFCab3WEmw==', 0)
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [MaChucVu], [HinhAnh], [MatKhau], [DaXoa]) VALUES (N'403', N'Minh Nhật ', CAST(0x00008AEB00000000 AS DateTime), N'Nam', N'Quận 4, Tp. Hồ Chí Minh', 335896412, CAST(0x0000AC8C00000000 AS DateTime), N'4', NULL, N'xMpCOKC5I4INzFCab3WEmw==', 0)
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [MaChucVu], [HinhAnh], [MatKhau], [DaXoa]) VALUES (N'504', N'Minh Khải ', CAST(0x00008F3D00000000 AS DateTime), N'Nam', N'Quận 1, Tp. Hồ Chí Minh', 369481256, CAST(0x0000AC8C00000000 AS DateTime), N'5', NULL, N'xMpCOKC5I4INzFCab3WEmw==', 0)
/****** Object:  Table [dbo].[tbKhachHang]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbKhachHang](
	[MaKH] [varchar](5) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](13) NULL,
	[MaLoaiKH] [varchar](5) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_tbKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbKhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [SDT], [MaLoaiKH], [DaXoa]) VALUES (N'102', N'Hữu Thắng', N'Nam', N'Bình Dương', N'3333333333', N'1', 0)
INSERT [dbo].[tbKhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [SDT], [MaLoaiKH], [DaXoa]) VALUES (N'103', N'Minh Hằng', N'Nam', N'Cà Mau', N'1111111111', N'1', 0)
INSERT [dbo].[tbKhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [SDT], [MaLoaiKH], [DaXoa]) VALUES (N'201', N'Trịnh Thị Trang', N'Nữ', N'Đồng Nai', N'2222222222', N'2', 0)
INSERT [dbo].[tbKhachHang] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [SDT], [MaLoaiKH], [DaXoa]) VALUES (N'304', N'Kim Liên', N'Nữ', N'Đồng Tháp', N'1111111111', N'3', 0)
/****** Object:  Table [dbo].[tbHoaDon]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbHoaDon](
	[MaHD] [varchar](5) NOT NULL,
	[TongTien] [int] NULL,
	[NgayLap] [datetime] NULL,
	[MaNVLap] [varchar](5) NULL,
	[MaKhachHang] [varchar](5) NULL,
 CONSTRAINT [PK_tbHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbHoaDon] ([MaHD], [TongTien], [NgayLap], [MaNVLap], [MaKhachHang]) VALUES (N'UM7W3', 620000, CAST(0x0000AEC100DB4F5C AS DateTime), N'101', N'103')
/****** Object:  View [dbo].[View_1]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT     dbo.tbSanPham.MaSP, dbo.tbSanPham.TenSP, dbo.tbSanPham.DonGia, dbo.tbSanPham.SoLuong, dbo.tbSanPham.HinhAnh, dbo.tbKichThuoc.Size, dbo.tbNhaSanXuat.TenNSX
FROM         dbo.tbSanPham INNER JOIN
                      dbo.tbNhaSanXuat ON dbo.tbSanPham.MaNSX = dbo.tbNhaSanXuat.MaNSX INNER JOIN
                      dbo.tbKichThuoc ON dbo.tbSanPham.MaSize = dbo.tbKichThuoc.MaSize
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[27] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbSanPham"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbNhaSanXuat"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 96
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbKichThuoc"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 96
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
/****** Object:  Table [dbo].[tbChiTietHoaDon]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbChiTietHoaDon](
	[MaHD] [varchar](5) NOT NULL,
	[MaSP] [varchar](5) NOT NULL,
	[SoLuong] [smallint] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tbC_T_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia]) VALUES (N'UM7W3', N'203', 1, 620000)
/****** Object:  View [dbo].[CTHoaDon]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CTHoaDon]
AS
SELECT     dbo.tbC_T_HoaDon.MaSP, dbo.tbSanPham.TenSP, dbo.tbC_T_HoaDon.SoLuong, dbo.tbC_T_HoaDon.DonGia, dbo.tbHoaDon.NgayLap, dbo.tbNhanVien.TenNV, dbo.tbKhachHang.TenKH, 
                      dbo.tbHoaDon.TongTien, dbo.tbHoaDon.MaHD
FROM         dbo.tbC_T_HoaDon INNER JOIN
                      dbo.tbHoaDon ON dbo.tbC_T_HoaDon.MaHD = dbo.tbHoaDon.MaHD INNER JOIN
                      dbo.tbKhachHang ON dbo.tbHoaDon.MaKhachHang = dbo.tbKhachHang.MaKH INNER JOIN
                      dbo.tbNhanVien ON dbo.tbHoaDon.MaNVLap = dbo.tbNhanVien.MaNV INNER JOIN
                      dbo.tbSanPham ON dbo.tbC_T_HoaDon.MaSP = dbo.tbSanPham.MaSP
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[23] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbC_T_HoaDon"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbHoaDon"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbKhachHang"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbNhanVien"
            Begin Extent = 
               Top = 145
               Left = 108
               Bottom = 265
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbSanPham"
            Begin Extent = 
               Top = 126
               Left = 306
               Bottom = 246
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CTHoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CTHoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CTHoaDon'
GO
/****** Object:  View [dbo].[HoaDon]    Script Date: 07/11/2022 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HoaDon]
AS
SELECT     dbo.tbHoaDon.MaHD, dbo.tbHoaDon.TongTien, dbo.tbHoaDon.NgayLap, dbo.tbNhanVien.TenNV, dbo.tbKhachHang.TenKH
FROM         dbo.tbKhachHang INNER JOIN
                      dbo.tbHoaDon ON dbo.tbKhachHang.MaKH = dbo.tbHoaDon.MaKhachHang INNER JOIN
                      dbo.tbNhanVien ON dbo.tbHoaDon.MaNVLap = dbo.tbNhanVien.MaNV
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbKhachHang"
            Begin Extent = 
               Top = 3
               Left = 327
               Bottom = 123
               Right = 487
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbNhanVien"
            Begin Extent = 
               Top = 47
               Left = 535
               Bottom = 167
               Right = 695
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbHoaDon"
            Begin Extent = 
               Top = 18
               Left = 54
               Bottom = 138
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HoaDon'
GO
/****** Object:  StoredProcedure [dbo].[getChiTietHoaDon]    Script Date: 07/11/2022 19:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getChiTietHoaDon](@ma varchar(5))
as
begin
	SELECT dbo.tbChiTietHoaDon.MaSP, dbo.tbSanPham.TenSP, dbo.tbChiTietHoaDon.SoLuong, dbo.tbChiTietHoaDon.DonGia, dbo.tbHoaDon.NgayLap, dbo.tbNhanVien.TenNV, dbo.tbKhachHang.TenKH, 
            dbo.tbHoaDon.TongTien, dbo.tbHoaDon.MaHD
	FROM  dbo.tbChiTietHoaDon INNER JOIN
          dbo.tbHoaDon ON dbo.tbChiTietHoaDon.MaHD = dbo.tbHoaDon.MaHD INNER JOIN
          dbo.tbKhachHang ON dbo.tbHoaDon.MaKhachHang = dbo.tbKhachHang.MaKH INNER JOIN
          dbo.tbNhanVien ON dbo.tbHoaDon.MaNVLap = dbo.tbNhanVien.MaNV INNER JOIN
          dbo.tbSanPham ON dbo.tbChiTietHoaDon.MaSP = dbo.tbSanPham.MaSP
    Where dbo.tbChiTietHoaDon.MaHD = @ma
end
GO
/****** Object:  Default [DF_tbKhachHang_DaXoa]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbKhachHang] ADD  CONSTRAINT [DF_tbKhachHang_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_tbNhanVien_NgayVaoLam]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbNhanVien] ADD  CONSTRAINT [DF_tbNhanVien_NgayVaoLam]  DEFAULT (getdate()) FOR [NgayVaoLam]
GO
/****** Object:  Default [DF_tbNhanVien_MatKhau]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbNhanVien] ADD  CONSTRAINT [DF_tbNhanVien_MatKhau]  DEFAULT ('xMpCOKC5I4INzFCab3WEmw==') FOR [MatKhau]
GO
/****** Object:  Default [DF_tbNhanVien_DaXoa]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbNhanVien] ADD  CONSTRAINT [DF_tbNhanVien_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_tbSanPham_MaSize]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbSanPham] ADD  CONSTRAINT [DF_tbSanPham_MaSize]  DEFAULT ('Default.png') FOR [MaSize]
GO
/****** Object:  Default [DF_tbSanPham_DaXoa]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbSanPham] ADD  CONSTRAINT [DF_tbSanPham_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_tbSanPham_NgayTao]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbSanPham] ADD  CONSTRAINT [DF_tbSanPham_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  ForeignKey [FK_tbC_T_HoaDon_tbHoaDon]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbC_T_HoaDon_tbHoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tbHoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[tbChiTietHoaDon] CHECK CONSTRAINT [FK_tbC_T_HoaDon_tbHoaDon]
GO
/****** Object:  ForeignKey [FK_tbC_T_HoaDon_tbSanPham]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbC_T_HoaDon_tbSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tbSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tbChiTietHoaDon] CHECK CONSTRAINT [FK_tbC_T_HoaDon_tbSanPham]
GO
/****** Object:  ForeignKey [FK_tbHoaDon_tbKhachHang]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbHoaDon_tbKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tbKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tbHoaDon] CHECK CONSTRAINT [FK_tbHoaDon_tbKhachHang]
GO
/****** Object:  ForeignKey [FK_tbHoaDon_tbNhanVien]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbHoaDon_tbNhanVien] FOREIGN KEY([MaNVLap])
REFERENCES [dbo].[tbNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbHoaDon] CHECK CONSTRAINT [FK_tbHoaDon_tbNhanVien]
GO
/****** Object:  ForeignKey [FK_tbKhachHang_tbLoaiKH]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tbKhachHang_tbLoaiKH] FOREIGN KEY([MaLoaiKH])
REFERENCES [dbo].[tbLoaiKH] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[tbKhachHang] CHECK CONSTRAINT [FK_tbKhachHang_tbLoaiKH]
GO
/****** Object:  ForeignKey [FK_tbNhanVien_tbChucVu]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbNhanVien_tbChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[tbChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[tbNhanVien] CHECK CONSTRAINT [FK_tbNhanVien_tbChucVu]
GO
/****** Object:  ForeignKey [FK_tbSanPham_tbKichThuoc]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tbSanPham_tbKichThuoc] FOREIGN KEY([MaSize])
REFERENCES [dbo].[tbKichThuoc] ([MaSize])
GO
ALTER TABLE [dbo].[tbSanPham] CHECK CONSTRAINT [FK_tbSanPham_tbKichThuoc]
GO
/****** Object:  ForeignKey [FK_tbSanPham_tbNhaSanXuat]    Script Date: 07/11/2022 19:27:11 ******/
ALTER TABLE [dbo].[tbSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tbSanPham_tbNhaSanXuat] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[tbNhaSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[tbSanPham] CHECK CONSTRAINT [FK_tbSanPham_tbNhaSanXuat]
GO
