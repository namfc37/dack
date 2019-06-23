USE [master]
GO
/****** Object:  Database [quanlythuvien]    Script Date: 6/23/2019 6:36:44 PM ******/
CREATE DATABASE [quanlythuvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlythuvien', FILENAME = N'C:\Program Files (x86)\MSSQL11.SQLEXPRESS\MSSQL\DATA\quanlythuvien.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlythuvien_log', FILENAME = N'C:\Program Files (x86)\MSSQL11.SQLEXPRESS\MSSQL\DATA\quanlythuvien_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlythuvien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlythuvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlythuvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlythuvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlythuvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlythuvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlythuvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlythuvien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [quanlythuvien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [quanlythuvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlythuvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlythuvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlythuvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlythuvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlythuvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlythuvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlythuvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlythuvien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [quanlythuvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlythuvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlythuvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlythuvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlythuvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlythuvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlythuvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlythuvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlythuvien] SET  MULTI_USER 
GO
ALTER DATABASE [quanlythuvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlythuvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlythuvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlythuvien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [quanlythuvien]
GO
/****** Object:  Table [dbo].[docgia]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docgia](
	[idDocGia] [int] NOT NULL,
	[TaiKhoan] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[idLoaiSach] [int] NOT NULL,
	[TenLoaiSach] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nguoidung]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoidung](
	[idUser] [int] NOT NULL,
	[diachi] [nvarchar](50) NULL,
	[CMND] [nvarchar](9) NULL,
	[ngaysinh] [date] NULL,
	[LoaiNguoiDung] [int] NULL,
	[MatKhau] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNhanVien] [int] NOT NULL,
	[VaiTro] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuon_Sach]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon_Sach](
	[id] [int] NOT NULL,
	[idPhieuMuon] [int] NULL,
	[idSach] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuonSach]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonSach](
	[idPhieuMuon] [int] NOT NULL,
	[NguoiMuon] [int] NULL,
	[Sach] [int] NULL,
	[NgayMuon] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[NgayTraDuKien] [date] NULL,
	[GiaMuon] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 6/23/2019 6:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[idSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[LoaiSach] [int] NULL,
	[SoLuong] [int] NULL,
	[Gia] [money] NULL,
	[NamSanXuat] [int] NULL,
	[NhaSanXuat] [nvarchar](40) NULL,
	[ViTri] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[LoaiSach] ([idLoaiSach], [TenLoaiSach]) VALUES (1, N'Truyện Dài')
INSERT [dbo].[LoaiSach] ([idLoaiSach], [TenLoaiSach]) VALUES (2, N'Truyện Tranh')
INSERT [dbo].[LoaiSach] ([idLoaiSach], [TenLoaiSach]) VALUES (3, N'Truyên Tình')
INSERT [dbo].[nguoidung] ([idUser], [diachi], [CMND], [ngaysinh], [LoaiNguoiDung], [MatKhau]) VALUES (1, N'Nghe An', N'1612398', CAST(N'2019-01-15' AS Date), 1, N'abc')
INSERT [dbo].[nguoidung] ([idUser], [diachi], [CMND], [ngaysinh], [LoaiNguoiDung], [MatKhau]) VALUES (2, N'Ha Noi', N'1612389', CAST(N'2019-01-15' AS Date), 2, N'abcd')
INSERT [dbo].[nguoidung] ([idUser], [diachi], [CMND], [ngaysinh], [LoaiNguoiDung], [MatKhau]) VALUES (3, N'Vinh', N'admin', CAST(N'2019-01-02' AS Date), 1, N'admin')
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (1, 3, 1)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (2, 4, 2)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (3, 5, 1)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (4, 5, 2)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (5, 5, 3)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (6, 6, 2)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (7, 6, 2)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (8, 6, 2)
INSERT [dbo].[PhieuMuon_Sach] ([id], [idPhieuMuon], [idSach]) VALUES (9, 6, 2)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (1, 2, NULL, CAST(N'2019-06-23' AS Date), N'1', CAST(N'2019-06-24' AS Date), 500000.0000)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (2, 3, NULL, CAST(N'2019-06-23' AS Date), N'binh thuong', NULL, 60000.0000)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (3, 3, NULL, CAST(N'2019-06-23' AS Date), N'binh thuong', NULL, 600000.0000)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (4, 3, NULL, CAST(N'2019-06-23' AS Date), N'binh thuong', NULL, 40000.0000)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (5, 3, NULL, CAST(N'2019-06-23' AS Date), N'binh thuong', NULL, 180000.0000)
INSERT [dbo].[PhieuMuonSach] ([idPhieuMuon], [NguoiMuon], [Sach], [NgayMuon], [TinhTrang], [NgayTraDuKien], [GiaMuon]) VALUES (6, 3, NULL, CAST(N'2019-06-23' AS Date), N'binh thuong', CAST(N'2019-06-27' AS Date), 40000.0000)
INSERT [dbo].[Sach] ([idSach], [TenSach], [LoaiSach], [SoLuong], [Gia], [NamSanXuat], [NhaSanXuat], [ViTri]) VALUES (1, N'HarryPoter', 1, 1, 150000.0000, 2015, N'Bluehote', N'D12')
INSERT [dbo].[Sach] ([idSach], [TenSach], [LoaiSach], [SoLuong], [Gia], [NamSanXuat], [NhaSanXuat], [ViTri]) VALUES (2, N'Doraemon', 2, 5, 10000.0000, 2018, N'Japan', N'C13')
INSERT [dbo].[Sach] ([idSach], [TenSach], [LoaiSach], [SoLuong], [Gia], [NamSanXuat], [NhaSanXuat], [ViTri]) VALUES (3, N'Naruto', 2, 10, 20000.0000, 2019, N'Japan', N'C22')
INSERT [dbo].[Sach] ([idSach], [TenSach], [LoaiSach], [SoLuong], [Gia], [NamSanXuat], [NhaSanXuat], [ViTri]) VALUES (4, N'aaaa', 5, 3, 200.0000, 2011, N'ssa', N'C14')
USE [master]
GO
ALTER DATABASE [quanlythuvien] SET  READ_WRITE 
GO
