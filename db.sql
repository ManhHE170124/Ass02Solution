USE [master]
GO
/****** Object:  Database [SalesManagement]    Script Date: 2/29/2024 10:28:34 PM ******/
CREATE DATABASE [SalesManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KHOADA\MSSQL\DATA\SalesManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalesManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KHOADA\MSSQL\DATA\SalesManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SalesManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SalesManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SalesManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalesManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SalesManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalesManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalesManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SalesManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [SalesManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SalesManagement]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2/29/2024 10:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[CompanyName] [varchar](255) NOT NULL,
	[City] [varchar](255) NOT NULL,
	[Country] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2/29/2024 10:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2/29/2024 10:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [date] NOT NULL,
	[ShippedDate] [date] NOT NULL,
	[Freight] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/29/2024 10:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](255) NOT NULL,
	[Weight] [varchar](255) NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'thiendt@gmail.com', N'Google', N'Vinh', N'VietNam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'minhpq@gmail.com', N'FPT', N'HaNoi', N'VietNam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'cuonghv@gmail.com', N'FPT', N'HoaBinh', N'VietNam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'vynt@gmail.com', N'NASA', N'Hue', N'VietNam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'thanhpm@gmail.com', N'NextTech', N'HoChiMinh', N'VietNam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'quatbt@gmail.com', N'Google', N'Vinh', N'VietNam', N'123')
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 3, CAST(20000.00 AS Decimal(10, 2)), 1, CAST(0.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2024-02-29' AS Date), CAST(N'2024-03-02' AS Date), CAST(N'2024-03-07' AS Date), CAST(20000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 3, N'Water', N'100', CAST(200.50 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 2, N'Candy', N'70', CAST(15000.00 AS Decimal(10, 2)), 146)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 3, N'Cake', N'123', CAST(20000.00 AS Decimal(10, 2)), 456)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Milk', N'69', CAST(1000.00 AS Decimal(10, 2)), 235)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Member__A9D1053484C9B2E0]    Script Date: 2/29/2024 10:28:34 PM ******/
ALTER TABLE [dbo].[Member] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
USE [master]
GO
ALTER DATABASE [SalesManagement] SET  READ_WRITE 
GO
