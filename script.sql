USE [master]
GO
/****** Object:  Database [QLHocvien]    Script Date: 19/12/2018 23:01:34 ******/
CREATE DATABASE [QLHocvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLHocvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLHocvien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLHocvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLHocvien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLHocvien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHocvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHocvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLHocvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLHocvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLHocvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLHocvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLHocvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLHocvien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLHocvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLHocvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLHocvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLHocvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLHocvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLHocvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLHocvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLHocvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLHocvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLHocvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLHocvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLHocvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLHocvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLHocvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLHocvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLHocvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLHocvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLHocvien] SET  MULTI_USER 
GO
ALTER DATABASE [QLHocvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLHocvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLHocvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLHocvien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLHocvien]
GO
/****** Object:  Table [dbo].[Hocvien]    Script Date: 19/12/2018 23:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hocvien](
	[Manganh] [nvarchar](3) NULL,
	[Mahv] [nvarchar](3) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Nganhsinh] [nchar](10) NULL,
	[Gioitinh] [int] NULL,
	[Khoahoc] [int] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hocvien] PRIMARY KEY CLUSTERED 
(
	[Mahv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoadaotao]    Script Date: 19/12/2018 23:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoadaotao](
	[Makhoa] [int] NOT NULL,
	[Tenkhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoadaotao] PRIMARY KEY CLUSTERED 
(
	[Makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nganhdaotao]    Script Date: 19/12/2018 23:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganhdaotao](
	[Makhoa] [int] NULL,
	[Manganh] [nchar](10) NOT NULL,
	[Tennganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nganhdaotao] PRIMARY KEY CLUSTERED 
(
	[Manganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Hocvien] ([Manganh], [Mahv], [Hoten], [Nganhsinh], [Gioitinh], [Khoahoc], [Diachi], [Ghichu]) VALUES (N'1', N'hv1', N'Le Van Quyen', N'1997-1-1  ', 1, 2, N'hatinh', NULL)
INSERT [dbo].[Hocvien] ([Manganh], [Mahv], [Hoten], [Nganhsinh], [Gioitinh], [Khoahoc], [Diachi], [Ghichu]) VALUES (N'2', N'hv2', N'le van nam', N'1996-1-1  ', 1, 2, N'nghe an', NULL)
INSERT [dbo].[Khoadaotao] ([Makhoa], [Tenkhoa]) VALUES (1, N'Toan')
INSERT [dbo].[Khoadaotao] ([Makhoa], [Tenkhoa]) VALUES (2, N'CNTT')
INSERT [dbo].[Khoadaotao] ([Makhoa], [Tenkhoa]) VALUES (3, N'Van')
INSERT [dbo].[Nganhdaotao] ([Makhoa], [Manganh], [Tennganh]) VALUES (1, N'1         ', N'su pham')
INSERT [dbo].[Nganhdaotao] ([Makhoa], [Manganh], [Tennganh]) VALUES (2, N'2         ', N'CuNhan')
INSERT [dbo].[Nganhdaotao] ([Makhoa], [Manganh], [Tennganh]) VALUES (3, N'4         ', N'su pham van')
INSERT [dbo].[Nganhdaotao] ([Makhoa], [Manganh], [Tennganh]) VALUES (1, N'5         ', N'sp tin')
INSERT [dbo].[Nganhdaotao] ([Makhoa], [Manganh], [Tennganh]) VALUES (1, N'6         ', N'ke toan')
USE [master]
GO
ALTER DATABASE [QLHocvien] SET  READ_WRITE 
GO
