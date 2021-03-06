USE [master]
GO

/****** Object:  Database [S1Hotel]    Script Date: 2019/8/8 16:11:04 ******/
CREATE DATABASE [S1Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'S1Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\S1Hotel.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'S1Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\S1Hotel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [S1Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [S1Hotel] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [S1Hotel] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [S1Hotel] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [S1Hotel] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [S1Hotel] SET ARITHABORT OFF 
GO

ALTER DATABASE [S1Hotel] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [S1Hotel] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [S1Hotel] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [S1Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [S1Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [S1Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [S1Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [S1Hotel] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [S1Hotel] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [S1Hotel] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [S1Hotel] SET  DISABLE_BROKER 
GO

ALTER DATABASE [S1Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [S1Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [S1Hotel] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [S1Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [S1Hotel] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [S1Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [S1Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [S1Hotel] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [S1Hotel] SET  MULTI_USER 
GO

ALTER DATABASE [S1Hotel] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [S1Hotel] SET DB_CHAINING OFF 
GO

ALTER DATABASE [S1Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [S1Hotel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [S1Hotel] SET  READ_WRITE 
GO


USE [S1HOTEL]
GO
/****** Object:  Table [dbo].[CheckInTable]    Script Date: 2019/8/8 16:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckInTable](
	[OrderID] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[CarID] [nvarchar](50) NOT NULL,
	[RoomID] [nvarchar](50) NOT NULL,
	[CheckInTime] [nvarchar](50) NOT NULL,
	[PreDepartureTime] [nvarchar](50) NOT NULL,
	[Operator] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CheckoutTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckoutTable](
	[OrderID] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[TotalCost] [decimal](18, 2) NOT NULL,
	[BalancePayment] [decimal](18, 2) NULL,
	[PaymentMethod] [nvarchar](50) NOT NULL,
	[CheckoutTime] [nvarchar](50) NOT NULL,
	[Operator] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Commodity]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commodity](
	[Name] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[BuyingPrice] [decimal](18, 2) NOT NULL,
	[RetailPrice] [decimal](18, 2) NOT NULL,
	[Type] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CommodityType]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommodityType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CommodityType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerRecharge]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerRecharge](
	[RechargeTime] [nvarchar](50) NOT NULL,
	[RechargeAmount] [decimal](18, 2) NOT NULL,
	[RechargeIDCardNumber] [nvarchar](50) NOT NULL,
	[Gifts] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
	[Name] [nvarchar](20) NOT NULL,
	[CarID] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Balance] [decimal](18, 2) NOT NULL,
	[Type] [int] NOT NULL,
	[Sex] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerTypeTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTypeTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [nvarchar](50) NOT NULL,
	[Discount] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CustomerTypeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Expenditure]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenditure](
	[DateTime] [nvarchar](50) NOT NULL,
	[Money] [decimal](18, 2) NOT NULL,
	[Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HotelName]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelName](
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MembershipConsumptionList]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MembershipConsumptionList](
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[AmountOfMoney] [decimal](18, 2) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MerchandiseOrderTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchandiseOrderTable](
	[OrderTable] [nvarchar](50) NOT NULL,
	[CollectMoney] [decimal](18, 2) NOT NULL,
	[PaymentMethod] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[OrderID] [nvarchar](50) NOT NULL,
	[RoomID] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[Deposit] [decimal](18, 2) NOT NULL,
	[CheckInTime] [nvarchar](50) NOT NULL,
	[PreDepartureTime] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[CustomerType] [nvarchar](50) NOT NULL,
	[CompanyName] [decimal](18, 2) NOT NULL,
	[Remarks] [nvarchar](500) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Discounts] [nvarchar](50) NOT NULL,
	[AmountReceived] [decimal](18, 2) NOT NULL,
	[PaymentMethod] [nvarchar](50) NOT NULL,
	[Operator] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PredeterminedTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PredeterminedTable](
	[reservationNumber] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[RoomID] [nvarchar](50) NOT NULL,
	[RoomType] [nvarchar](50) NOT NULL,
	[PreconditioningTime] [nvarchar](50) NOT NULL,
	[PreDepartureTime] [nvarchar](50) NOT NULL,
	[Operator] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RemindTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemindTable](
	[RooID] [nvarchar](50) NOT NULL,
	[Remind] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomIDCard]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomIDCard](
	[RoomID] [nvarchar](50) NOT NULL,
	[RoomCard] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomStateTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomStateTable](
	[ID] [int] NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RoomStateTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTable](
	[RoomID] [nvarchar](50) NOT NULL,
	[Floor] [nvarchar](10) NOT NULL,
	[TypeID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
 CONSTRAINT [PK_RoomTable] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomTypeTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypeTable](
	[ID] [int] NOT NULL,
	[TypeName] [nvarchar](20) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[HourRoom] [decimal](18, 2) NULL,
 CONSTRAINT [PK_RoomTypeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 2019/8/8 16:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserName] [nvarchar](10) NOT NULL,
	[PassWord] [nvarchar](10) NOT NULL,
	[CarID] [nvarchar](50) NOT NULL,
	[EmployeeName] [nvarchar](10) NOT NULL,
	[Jurisdiction] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906002', N'周琦', N'17620040808', CAST(20.00 AS Decimal(18, 2)), CAST(220.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 08:57:41', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906003', N'张志强', N'18808809999', CAST(201.00 AS Decimal(18, 2)), CAST(99.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 08:59:52', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906013', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:29:56', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906014', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:30:21', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906015', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:30:50', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906001', N'刘志仁', N'17796772233', CAST(300.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-06 08:55:27', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906016', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:30:55', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906017', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:31:07', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907009', N'周琦', N'17620040808', CAST(60.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-07 16:41:36', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180911001', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-11 14:25:24', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180101008', N'哈哈', N'18808804444', CAST(20.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'现金+余额', N'2018-01-07 14:32:27', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180915001', N'周琦', N'17620040808', CAST(610.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-15 14:51:07', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180918001', N'周琦', N'17620040808', CAST(770.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-18 11:31:36', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919001', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:38:25', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919002', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:38:40', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919003', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:43:03', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919004', N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:43:17', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919005', N'hsdh', N'15773316051', CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:48:42', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180919006', N'hsdh', N'15773316051', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-19 15:49:05', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920001', N'lll', N'15200000000', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 18:43:28', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920004', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 08:30:17', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920005', N'阿修罗', N'18808886666', CAST(550.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 18:52:36', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920006', N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 18:52:58', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920007', N'娃哈哈', N'17620040808', CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 18:53:06', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920008', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-20 18:53:13', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920009', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 18:53:18', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920010', N'kkk', N'15200000000', CAST(600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 19:11:32', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920011', N'周琦', N'17620040808', CAST(900.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-20 19:22:19', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921001', N'哇哈哈', N'17708809999', CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 14:20:22', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921002', N'何婷', N'15211104534', CAST(250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 14:42:32', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921004', N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 16:17:08', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921005', N'zzq', N'15673385796', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 16:17:17', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921006', N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 16:17:24', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921008', N'无', N'17620040808', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 21:47:31', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921009', N'呜呜', N'18809998888', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 21:47:37', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921010', N'自动', N'1223133112', CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 21:47:43', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921011', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-21 21:47:48', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180922001', N'周琦', N'17620040808', CAST(225.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-22 08:57:54', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906004', N'周琦', N'17620040808', CAST(130.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 09:01:05', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906005', N'张志强', N'18808809999', CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 09:01:24', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906006', N'张志强', N'18808809999', CAST(201.00 AS Decimal(18, 2)), CAST(99.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 09:01:42', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906007', N'张志强', N'18808809999', CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 09:01:49', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906008', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-06 10:12:08', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906009', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:13:52', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906010', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:14:33', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906011', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:14:58', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906012', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-06 10:26:24', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907001', N'张志强', N'18808809999', CAST(0.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-07 14:31:25', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906018', N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-06 14:38:48', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180906019', N'张志强', N'18808809999', CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-06 14:38:54', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907002', N'周琦', N'17620040808', CAST(160.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-07 10:07:28', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907003', N'周琦', N'17620040808', CAST(200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-07 10:07:34', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907004', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-07 14:11:01', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907005', N'周琦', N'17620040808', CAST(120.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-07 14:11:11', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907006', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), N'账户余额', N'2018-09-07 14:11:22', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907007', N'周琦', N'17620040808', CAST(240.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-07 14:11:33', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180907008', N'周琦', N'17620040808', CAST(20.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-07 14:32:27', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921003', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-21 14:44:16', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180921007', N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), N'现金+余额', N'2018-09-21 20:15:46', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920002', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 19:23:15', N'1')
INSERT [dbo].[CheckoutTable] ([OrderID], [UName], [Phone], [TotalCost], [BalancePayment], [PaymentMethod], [CheckoutTime], [Operator]) VALUES (N'20180920003', N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'现金支付', N'2018-09-20 19:24:47', N'1')
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'芙蓉王', N'包', N'137', CAST(20.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'白沙', N'包', N'89', CAST(5.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'可乐', N'瓶', N'127', CAST(2.00 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), 2)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'扑克', N'副', N'2968', CAST(1.80 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'农夫山泉', N'瓶', N'99', CAST(1.00 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), 5)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'娃哈哈', N'瓶', N'1000', CAST(1.10 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'旺仔牛奶', N'瓶', N'93', CAST(12.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Commodity] ([Name], [Company], [Number], [BuyingPrice], [RetailPrice], [Type]) VALUES (N'XO', N'瓶', N'200', CAST(2.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[CommodityType] ON 

INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (1, N'烟酒')
INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (2, N'饮料')
INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (3, N'棋牌')
INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (4, N'零食')
INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (5, N'纯净水')
INSERT [dbo].[CommodityType] ([ID], [TypeName]) VALUES (6, N'其他')
SET IDENTITY_INSERT [dbo].[CommodityType] OFF
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-9-3', CAST(1000.00 AS Decimal(18, 2)), N'431129199909255241', N'可乐')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-04 17:49:39', CAST(3000.00 AS Decimal(18, 2)), N'430223199602034213', N'芙蓉王')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-14 16:15:54', CAST(6000.00 AS Decimal(18, 2)), N'430123199603304567', N'新开会员')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-20 19:15:28', CAST(1000.00 AS Decimal(18, 2)), N'430223199908088801', N'白沙')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-21 14:19:18', CAST(800.00 AS Decimal(18, 2)), N'430223199602034213', N'白沙')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-21 19:23:33', CAST(2000.00 AS Decimal(18, 2)), N'430123199909095566', N'新开会员')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-22 08:22:39', CAST(3000.00 AS Decimal(18, 2)), N'500242199804122876', N'新开会员')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-22 09:00:14', CAST(2000.00 AS Decimal(18, 2)), N'500242199804122876', N'新开会员')
INSERT [dbo].[CustomerRecharge] ([RechargeTime], [RechargeAmount], [RechargeIDCardNumber], [Gifts]) VALUES (N'2018-09-22 09:00:36', CAST(300.00 AS Decimal(18, 2)), N'430223199602034213', N'扑克')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'周琦', N'430223199602034213', N'17620040808', CAST(13295.00 AS Decimal(18, 2)), 1, N'男', N'22')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'张志强', N'430223199908088801', N'18808809999', CAST(10451.00 AS Decimal(18, 2)), 2, N'女', N'19')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'刘志仁', N'430125197808086953', N'17796772233', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'40')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'卢克', N'430432196612131112', N'17616628859', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'52')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'娃哈哈', N'430125197808087953', N'15673360231', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'40')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'修罗', N'430125197808086553', N'15585586656', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'40')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'剑魂', N'430125197808026953', N'15688983321', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'40')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'安图恩', N'430123199603304567', N'18899662233', CAST(6000.00 AS Decimal(18, 2)), 4, N'女', N'22')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'kkk', N'430211200011281810', N'15200000000', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'18')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'lll', N'432503199806117013', N'15200000000', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'娃哈哈', N'430123197408089986', N'17620040808', CAST(0.00 AS Decimal(18, 2)), 1, N'女', N'44')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'阿修罗', N'430322199808089966', N'18808886666', CAST(0.00 AS Decimal(18, 2)), 1, N'女', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'哇哈哈', N'430223199906068848', N'17708809999', CAST(0.00 AS Decimal(18, 2)), 1, N'女', N'19')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'zzq', N'430281199811016611', N'15673385796', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'何婷', N'430225199707172015', N'15211104534', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'21')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'哈哈', N'430122199909098080', N'无', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'19')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'呜呜', N'430221199909098808', N'18809998888', CAST(0.00 AS Decimal(18, 2)), 1, N'女', N'19')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'无', N'430223199806062233', N'17620040808', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'冉波', N'430123199909095566', N'18856652233', CAST(2000.00 AS Decimal(18, 2)), 2, N'女', N'19')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'自动', N'500242199804122876', N'15897556214', CAST(3000.00 AS Decimal(18, 2)), 3, N'男', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'冉波', N'500242199804122876', N'17620040808', CAST(2000.00 AS Decimal(18, 2)), 2, N'男', N'20')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'阿修罗', N'430223198808088899', N'18808886666', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'30')
INSERT [dbo].[CustomerTable] ([Name], [CarID], [Phone], [Balance], [Type], [Sex], [Age]) VALUES (N'自动', N'500242199804122876', N'1223133112', CAST(0.00 AS Decimal(18, 2)), 1, N'男', N'20')
SET IDENTITY_INSERT [dbo].[CustomerTypeTable] ON 

INSERT [dbo].[CustomerTypeTable] ([ID], [Grade], [Discount]) VALUES (1, N'普通用户', N'不打折')
INSERT [dbo].[CustomerTypeTable] ([ID], [Grade], [Discount]) VALUES (2, N'黄金会员', N'0.9')
INSERT [dbo].[CustomerTypeTable] ([ID], [Grade], [Discount]) VALUES (3, N'钻石会员', N'0.8')
INSERT [dbo].[CustomerTypeTable] ([ID], [Grade], [Discount]) VALUES (4, N'陨石会员', N'0.5')
SET IDENTITY_INSERT [dbo].[CustomerTypeTable] OFF
INSERT [dbo].[Expenditure] ([DateTime], [Money], [Type]) VALUES (N'2018-09-21', CAST(2000.00 AS Decimal(18, 2)), N'进货')
INSERT [dbo].[HotelName] ([Name]) VALUES (N'卡布奇诺')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:12:08')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:13:52')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:14:33')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:14:58')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:26:24')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:29:56')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(120.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:30:21')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(120.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:30:50')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 10:07:28')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 10:07:34')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(120.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:11:01')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:11:11')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(120.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:11:22')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:11:33')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(60.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:32:27')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(30.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-15 14:51:07')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(30.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-18 11:31:36')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:38:25')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:38:40')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:43:03')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:43:17')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'hsdh', N'15773316051', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:48:42')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'hsdh', N'15773316051', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-19 15:49:05')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'lll', N'15200000000', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:43:28')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 08:30:17')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'阿修罗', N'18808886666', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:52:36')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:52:58')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'娃哈哈', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:53:06')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:53:13')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 18:53:18')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'kkk', N'15200000000', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 19:11:32')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 19:22:19')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'哇哈哈', N'17708809999', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 14:20:22')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'何婷', N'15211104534', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 14:42:32')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 14:44:16')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 16:17:08')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'zzq', N'15673385796', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 16:17:17')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 16:17:24')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'无', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 21:47:31')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'呜呜', N'18809998888', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 21:47:37')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'自动', N'1223133112', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 21:47:43')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(45.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 21:47:48')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-22 08:57:54')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(80.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:30:55')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(40.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 10:31:07')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'张志强', N'18808809999', CAST(150.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 14:31:25')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 14:38:48')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'张志强', N'18808809999', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-06 14:38:54')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(100.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-07 16:41:36')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(240.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-11 14:25:24')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(90.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-21 20:15:46')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 19:23:15')
INSERT [dbo].[MembershipConsumptionList] ([Name], [Phone], [AmountOfMoney], [Type], [Time]) VALUES (N'周琦', N'17620040808', CAST(0.00 AS Decimal(18, 2)), N'房间消费', N'2018-09-20 19:24:47')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-04 15:22:43', CAST(3000.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-05 15:43:33', CAST(31.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-14 10:56:48', CAST(440.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-14 11:00:57', CAST(618.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-14 11:02:17', CAST(800.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-20 18:56:55', CAST(21.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-20 19:02:15', CAST(25.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-20 19:10:34', CAST(210.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-21 14:18:24', CAST(480.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[MerchandiseOrderTable] ([OrderTable], [CollectMoney], [PaymentMethod]) VALUES (N'2018-09-26 09:07:05', CAST(99.00 AS Decimal(18, 2)), N'现金支付')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907005', N'A201', N'周琦', N'22', CAST(30.00 AS Decimal(18, 2)), N'2018-09-07 14:31:15', N'2018-09-17 7:51:00', N'17620040808', N'钻石会员', CAST(50.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907005', N'A209', N'周琦', N'22', CAST(30.00 AS Decimal(18, 2)), N'2018-09-07 14:31:15', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(50.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919001', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:37:52', N'2018-09-20 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919001', N'A203', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:37:52', N'2018-09-20 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919002', N'A201', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:42:40', N'2018-09-20 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919002', N'A202', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:42:40', N'2018-09-20 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919002', N'A205', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:42:40', N'2018-09-20 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919003', N'A208', N'hsdh', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:47:11', N'2018-09-20 12:00:00', N'15773316051', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919003', N'A202', N'hsdh', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:47:11', N'2018-09-20 12:00:00', N'15773316051', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919003', N'A205', N'hsdh', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 15:47:11', N'2018-09-20 12:00:00', N'15773316051', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180919004', N'A208', N'kkk', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-19 18:30:05', N'2018-09-26 12:00:00', N'15200000000', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'不打折', CAST(700.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920001', N'A201', N'lll', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 18:34:52', N'2018-09-25 12:00:00', N'15200000000', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省娄底地区', N'不打折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920002', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:21:47', N'2018-09-26 12:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(480.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920003', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:23:46', N'2018-09-25 12:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(280.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920004', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:28:39', N'2018-09-25 12:00:00', N'17620040808', N'钻石会员', CAST(480.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(480.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920004', N'A203', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:28:39', N'2018-09-23 12:00:00', N'17620040808', N'钻石会员', CAST(180.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(180.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920006', N'A205', N'娃哈哈', N'44', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 08:28:15', N'2018-09-21 12:00:00', N'17620040808', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'嘿', N'已结账', N'湖南省长沙市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920007', N'B212', N'阿修罗', N'30', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(200.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(200.00 AS Decimal(18, 2)), N'现金支付', N'1', N'200')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920007', N'A209', N'阿修罗', N'30', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920007', N'A210', N'阿修罗', N'30', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920007', N'B304', N'阿修罗', N'30', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(400.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(400.00 AS Decimal(18, 2)), N'现金支付', N'1', N'400')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920007', N'A302', N'阿修罗', N'30', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(300.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'300')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920008', N'A207', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-20 18:43:35', N'2018-09-21 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920009', N'B212', N'阿修罗', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(200.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省湘潭市', N'不打折', CAST(200.00 AS Decimal(18, 2)), N'现金支付', N'1', N'200')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920009', N'A209', N'阿修罗', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省湘潭市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920009', N'A210', N'阿修罗', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省湘潭市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920009', N'B304', N'阿修罗', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(400.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省湘潭市', N'不打折', CAST(400.00 AS Decimal(18, 2)), N'现金支付', N'1', N'400')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920009', N'A302', N'阿修罗', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-24 12:00:00', N'18808886666', N'普通用户', CAST(300.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省湘潭市', N'不打折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'300')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920010', N'A208', N'kkk', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:07:39', N'2018-09-21 12:00:00', N'15200000000', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920010', N'A201', N'kkk', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:07:39', N'2018-09-21 12:00:00', N'15200000000', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920010', N'D1001', N'kkk', N'18', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:07:39', N'2018-09-21 12:00:00', N'15200000000', N'普通用户', CAST(1000.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(1000.00 AS Decimal(18, 2)), N'现金支付', N'1', N'1000')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907001', N'A202', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:18:16', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(300.00 AS Decimal(18, 2)), N'w', N'已结账', N'湖南省株洲市', N'8折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907001', N'A203', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:18:16', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(300.00 AS Decimal(18, 2)), N'w', N'已结账', N'湖南省株洲市', N'8折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907001', N'A209', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:18:16', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(300.00 AS Decimal(18, 2)), N'w', N'已结账', N'湖南省株洲市', N'8折', CAST(300.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907002', N'A201', N'周琦', N'22', CAST(240.00 AS Decimal(18, 2)), N'2018-09-07 10:23:05', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(240.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907002', N'A205', N'周琦', N'22', CAST(240.00 AS Decimal(18, 2)), N'2018-09-07 10:23:05', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(240.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907002', N'A207', N'周琦', N'22', CAST(240.00 AS Decimal(18, 2)), N'2018-09-07 10:23:05', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(240.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100.00')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907003', N'A206', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-07 10:24:51', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907003', N'A208', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-07 10:24:51', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907003', N'A209', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-07 10:24:51', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907004', N'A210', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:25:15', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907004', N'A211', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:25:15', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907004', N'B304', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-07 10:25:15', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(320.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(320.00 AS Decimal(18, 2)), N'现金支付', N'1', N'400')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907006', N'A201', N'周琦', N'22', CAST(25.00 AS Decimal(18, 2)), N'2018-09-07 16:40:22', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(55.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907006', N'A208', N'周琦', N'22', CAST(25.00 AS Decimal(18, 2)), N'2018-09-07 16:40:22', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(55.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907006', N'A202', N'周琦', N'22', CAST(25.00 AS Decimal(18, 2)), N'2018-09-07 16:40:22', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(55.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180907006', N'A205', N'周琦', N'22', CAST(25.00 AS Decimal(18, 2)), N'2018-09-07 16:40:22', N'2018-09-08 14:00:00', N'17620040808', N'钻石会员', CAST(55.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180910001', N'A201', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-10 20:15:01', N'2018-09-14 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180910001', N'A205', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-10 20:15:01', N'2018-09-14 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180910001', N'A203', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-10 20:15:01', N'2018-09-14 14:00:00', N'17620040808', N'钻石会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920011', N'D1101', N'周琦', N'22', CAST(80.00 AS Decimal(18, 2)), N'2018-09-20 19:19:54', N'2018-09-21 14:00:00', N'17620040808', N'钻石会员', CAST(900.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(980.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921003', N'B207', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-21 10:17:00', N'2018-09-23 12:00:00', N'17620040808', N'钻石会员', CAST(160.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(160.00 AS Decimal(18, 2)), N'现金支付', N'1', N'200')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921004', N'A207', N'哇哈哈', N'19', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-21 10:19:00', N'17708809999', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921004', N'A210', N'哇哈哈', N'19', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 00:00:00', N'2018-09-23 12:00:00', N'17708809999', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921005', N'A209', N'zzq', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-21 14:16:58', N'2018-09-22 12:00:00', N'15673385796', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921006', N'A301', N'何婷', N'21', CAST(0.00 AS Decimal(18, 2)), N'2018-09-21 14:38:24', N'2018-09-24 12:00:00', N'15211104534', N'普通用户', CAST(900.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(900.00 AS Decimal(18, 2)), N'现金支付', N'1', N'500')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180923002', N'A200', N'无', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-23 00:00:00', N'2018-09-24 12:00:00', N'17620040808', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180922001', N'C808', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 08:47:35', N'2018-09-22 9:20:00', N'17620040808', N'黄金会员', CAST(450.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'9折', CAST(450.00 AS Decimal(18, 2)), N'现金支付', N'1', N'500')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180922002', N'A210', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 08:53:48', N'2018-09-22 9:14:00', N'17620040808', N'黄金会员', CAST(90.00 AS Decimal(18, 2)), N'', N'新开单', N'湖南省株洲市', N'9折', CAST(90.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180922002', N'A209', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 08:53:48', N'2018-09-25 13:00:00', N'17620040808', N'黄金会员', CAST(90.00 AS Decimal(18, 2)), N'', N'新开单', N'湖南省株洲市', N'9折', CAST(90.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180922002', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-22 08:53:48', N'2018-09-25 13:00:00', N'17620040808', N'黄金会员', CAST(90.00 AS Decimal(18, 2)), N'', N'新开单', N'湖南省株洲市', N'9折', CAST(90.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180922003', N'A200', N'周琦', N'22', CAST(90.00 AS Decimal(18, 2)), N'2018-09-22 08:58:07', N'2018-09-23 13:00:00', N'17620040808', N'黄金会员', CAST(0.00 AS Decimal(18, 2)), N'', N'新开单', N'湖南省株洲市', N'9折', CAST(90.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920005', N'A201', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:54:38', N'2018-09-21 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180920005', N'A209', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-20 19:54:38', N'2018-09-21 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921001', N'A208', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-21 07:48:00', N'2018-09-22 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921002', N'A201', N'周琦', N'22', CAST(0.00 AS Decimal(18, 2)), N'2018-09-21 07:48:42', N'2018-09-25 14:00:00', N'17620040808', N'钻石会员', CAST(80.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'8折', CAST(80.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180923001', N'A203', N'呜呜', N'19', CAST(0.00 AS Decimal(18, 2)), N'2018-09-23 00:00:00', N'2018-09-24 12:00:00', N'18809998888', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省株洲市', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921007', N'A209', N'周琦', N'22', CAST(420.00 AS Decimal(18, 2)), N'2018-09-21 20:13:39', N'2018-09-28 12:00:00', N'17620040808', N'黄金会员', CAST(250.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'9折', CAST(670.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921007', N'A205', N'周琦', N'22', CAST(420.00 AS Decimal(18, 2)), N'2018-09-21 20:13:39', N'2018-09-26 13:00:00', N'17620040808', N'黄金会员', CAST(50.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'9折', CAST(470.00 AS Decimal(18, 2)), N'现金+余额', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180923003', N'A204', N'自动', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-23 00:00:00', N'2018-09-25 12:00:00', N'1223133112', N'普通用户', CAST(100.00 AS Decimal(18, 2)), N'无', N'已结账', N'湖南省', N'不打折', CAST(100.00 AS Decimal(18, 2)), N'现金支付', N'1', N'100')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180926001', N'B207', N'自动', N'20', CAST(0.00 AS Decimal(18, 2)), N'2018-09-26 00:00:00', N'2018-09-27 12:00:00', N'18877490098', N'普通用户', CAST(200.00 AS Decimal(18, 2)), N'无', N'新开单', N'湖南省', N'不打折', CAST(200.00 AS Decimal(18, 2)), N'现金支付', N'1', N'200')
INSERT [dbo].[OrderTable] ([OrderID], [RoomID], [UName], [Age], [Deposit], [CheckInTime], [PreDepartureTime], [Phone], [CustomerType], [CompanyName], [Remarks], [State], [Address], [Discounts], [AmountReceived], [PaymentMethod], [Operator], [Price]) VALUES (N'20180921008', N'A205', N'周琦', N'22', CAST(90.00 AS Decimal(18, 2)), N'2018-09-21 21:23:09', N'2018-09-23 13:00:00', N'17620040808', N'黄金会员', CAST(0.00 AS Decimal(18, 2)), N'', N'已结账', N'湖南省株洲市', N'9折', CAST(90.00 AS Decimal(18, 2)), N'账户余额', N'1', N'100')
INSERT [dbo].[PredeterminedTable] ([reservationNumber], [Name], [Phone], [RoomID], [RoomType], [PreconditioningTime], [PreDepartureTime], [Operator], [Price], [Type]) VALUES (N'20180922001', N'冉波', N'17620048808', N'D1001', N'总统套房', N'2018-09-22 09:20:00', N'2018-09-25 12:00:00', N'1', N'1000.00', N'取消预定')
INSERT [dbo].[PredeterminedTable] ([reservationNumber], [Name], [Phone], [RoomID], [RoomType], [PreconditioningTime], [PreDepartureTime], [Operator], [Price], [Type]) VALUES (N'20180922002', N'周琦', N'123456312354', N'D1101', N'总统套房', N'2018-09-27 00:00:00', N'2018-09-29 12:00:00', N'1', N'1000.00', N'取消预定')
INSERT [dbo].[PredeterminedTable] ([reservationNumber], [Name], [Phone], [RoomID], [RoomType], [PreconditioningTime], [PreDepartureTime], [Operator], [Price], [Type]) VALUES (N'20180922003', N'冉波', N'18677490918', N'B207', N'豪华单人间', N'2018-09-26 00:00:00', N'2018-09-27 12:00:00', N'1', N'200.00', N'已入住')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A201', N'房间到期提醒', N'已读', N'2018-09-15')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A201', N'房间到期提醒', N'已读', N'2018-09-17')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A207', N'房间到期提醒', N'已读', N'2018-09-21')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A200', N'预定到期提醒', N'已读', N'2018-09-21')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A200', N'预定到期提醒', N'已读', N'2018-09-21')
INSERT [dbo].[RemindTable] ([RooID], [Remind], [Type], [Time]) VALUES (N'A210', N'房间到期提醒', N'已读', N'2018-09-22')
INSERT [dbo].[RoomIDCard] ([RoomID], [RoomCard]) VALUES (N'A200', N'200')
INSERT [dbo].[RoomIDCard] ([RoomID], [RoomCard]) VALUES (N'A210', N'210')
INSERT [dbo].[RoomIDCard] ([RoomID], [RoomCard]) VALUES (N'B207', N'207')
INSERT [dbo].[RoomStateTable] ([ID], [StateName]) VALUES (1, N'空净')
INSERT [dbo].[RoomStateTable] ([ID], [StateName]) VALUES (2, N'待客')
INSERT [dbo].[RoomStateTable] ([ID], [StateName]) VALUES (3, N'空脏')
INSERT [dbo].[RoomStateTable] ([ID], [StateName]) VALUES (4, N'预定')
INSERT [dbo].[RoomStateTable] ([ID], [StateName]) VALUES (5, N'停用')
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A200', N'二楼', 1, 2)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A201', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A203', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A204', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A205', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A206', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A207', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A208', N'二楼', 1, 2)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A209', N'二楼', 1, 2)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A210', N'二楼', 1, 2)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A211', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A301', N'三楼', 3, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'A302', N'三楼', 3, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B207', N'二楼', 2, 2)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B208', N'二楼', 2, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B209', N'二楼', 1, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B212', N'二楼', 2, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B303', N'三楼', 4, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B304', N'三楼', 4, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'B305', N'三楼', 4, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'C808', N'八楼', 5, 3)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'C809', N'八楼', 5, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'D1001', N'十楼', 6, 1)
INSERT [dbo].[RoomTable] ([RoomID], [Floor], [TypeID], [StateID]) VALUES (N'D1101', N'十一楼', 6, 1)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (1, N'标准单人间', CAST(120.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (2, N'豪华单人间', CAST(200.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (3, N'标准双人间', CAST(300.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (4, N'豪华双人间', CAST(400.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (5, N'商务套房', CAST(500.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[RoomTypeTable] ([ID], [TypeName], [Price], [HourRoom]) VALUES (6, N'总统套房', CAST(1000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[UserTable] ([UserName], [PassWord], [CarID], [EmployeeName], [Jurisdiction]) VALUES (N'1', N'1', N'1', N'超级管理员', N'超级管理员')
INSERT [dbo].[UserTable] ([UserName], [PassWord], [CarID], [EmployeeName], [Jurisdiction]) VALUES (N'123', N'123', N'123456789111111111', N'冯文灿', N'超级管理员')
