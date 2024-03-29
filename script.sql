USE [master]
GO
/****** Object:  Database [dbi520540_s2grp2zoo]    Script Date: 02/13/2024 5:43:32 PM ******/
CREATE DATABASE [dbi520540_s2grp2zoo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbi520540_s2grp2zoo', FILENAME = N'D:\SQL\Data\dbi520540_s2grp2zoo.mdf' , SIZE = 8192KB , MAXSIZE = 1048576KB , FILEGROWTH = 2048KB )
 LOG ON 
( NAME = N'dbi520540_s2grp2zoo_log', FILENAME = N'D:\SQL\Log\dbi520540_s2grp2zoo_log.ldf' , SIZE = 8192KB , MAXSIZE = 262144KB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbi520540_s2grp2zoo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET  MULTI_USER 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbi520540_s2grp2zoo', N'ON'
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET QUERY_STORE = OFF
GO
USE [dbi520540_s2grp2zoo]
GO
/****** Object:  Table [dbo].[AnimalRelationships]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalRelationships](
	[RelationShipType] [bit] NOT NULL,
	[AnimalOneID] [int] NOT NULL,
	[AnimalTwoID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[AnimalID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Species] [nvarchar](50) NOT NULL,
	[BirthDate] [smalldatetime] NOT NULL,
	[Origin] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Endangerment] [nvarchar](30) NOT NULL,
	[Enclosure] [int] NOT NULL,
	[Availability] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[AnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheckinCheckout]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckinCheckout](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BarcodeString] [decimal](13, 0) NOT NULL,
	[Checkin] [datetime] NOT NULL,
	[Checkout] [datetime] NULL,
 CONSTRAINT [PK_CheckinCheckout] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[ContractID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[WeeklyHours] [int] NOT NULL,
	[Salary] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount_codes]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount_codes](
	[discount_code] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiscountName] [nvarchar](max) NOT NULL,
	[DiscountValue] [decimal](16, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmergencyContacts]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmergencyContacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[ContactFirstName] [nvarchar](50) NOT NULL,
	[ContactLastName] [nvarchar](50) NOT NULL,
	[Relationship] [nvarchar](50) NOT NULL,
	[ContactPhone] [nvarchar](50) NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_EmergencyContacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Birthdate] [date] NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](13) NOT NULL,
	[Password] [nvarchar](40) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[EmployeeType] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holiday]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday](
	[employee_id] [int] NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shifts]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shifts](
	[ShiftId] [int] IDENTITY(1,1) NOT NULL,
	[ShiftEmployeeId] [int] NOT NULL,
	[ShiftTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Shifts] PRIMARY KEY CLUSTERED 
(
	[ShiftId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskEmployeeRelation]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskEmployeeRelation](
	[TaskAssigmentID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[TaskID] [int] NOT NULL,
 CONSTRAINT [PK_TaskEmployeeRelationship] PRIMARY KEY CLUSTERED 
(
	[TaskAssigmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](50) NOT NULL,
	[TaskDescription] [nvarchar](500) NOT NULL,
	[TaskDate] [datetime] NOT NULL,
	[TaskDuration] [int] NOT NULL,
	[TaskStatus] [nvarchar](50) NOT NULL,
	[TaskSpecies] [nvarchar](50) NOT NULL,
	[TaskZone] [nvarchar](50) NOT NULL,
	[TaskEnclosureNumber] [int] NOT NULL,
	[TaskAnimalID] [int] NULL,
	[Repetitive] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[TicketID] [int] IDENTITY(1,1) NOT NULL,
	[TicketType] [nvarchar](max) NOT NULL,
	[TicketPrice] [decimal](16, 2) NOT NULL,
	[ValidDate] [date] NOT NULL,
	[BarcodeString] [decimal](13, 0) NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfer]    Script Date: 02/13/2024 5:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfer](
	[TransferId] [int] IDENTITY(1,1) NOT NULL,
	[ZooName] [nvarchar](50) NOT NULL,
	[ZooAddress] [nvarchar](50) NOT NULL,
	[ZooPhone] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[AnimalId] [int] NOT NULL,
 CONSTRAINT [PK_Transfer] PRIMARY KEY CLUSTERED 
(
	[TransferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Animals]    Script Date: 02/13/2024 5:43:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Animals] ON [dbo].[Animals]
(
	[AnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Animals_1]    Script Date: 02/13/2024 5:43:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Animals_1] ON [dbo].[Animals]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Animals_2]    Script Date: 02/13/2024 5:43:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Animals_2] ON [dbo].[Animals]
(
	[Species] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transfer]    Script Date: 02/13/2024 5:43:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Transfer] ON [dbo].[Transfer]
(
	[AnimalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AnimalRelationships]  WITH CHECK ADD  CONSTRAINT [AnimalRelationship(Child/FemaleMate)] FOREIGN KEY([AnimalTwoID])
REFERENCES [dbo].[Animals] ([AnimalID])
GO
ALTER TABLE [dbo].[AnimalRelationships] CHECK CONSTRAINT [AnimalRelationship(Child/FemaleMate)]
GO
ALTER TABLE [dbo].[AnimalRelationships]  WITH CHECK ADD  CONSTRAINT [AnimalRelationship(Parent/MaleMate)] FOREIGN KEY([AnimalOneID])
REFERENCES [dbo].[Animals] ([AnimalID])
GO
ALTER TABLE [dbo].[AnimalRelationships] CHECK CONSTRAINT [AnimalRelationship(Parent/MaleMate)]
GO
ALTER TABLE [dbo].[CheckinCheckout]  WITH CHECK ADD  CONSTRAINT [FK_CheckinCheckout_CheckinCheckout] FOREIGN KEY([ID])
REFERENCES [dbo].[CheckinCheckout] ([ID])
GO
ALTER TABLE [dbo].[CheckinCheckout] CHECK CONSTRAINT [FK_CheckinCheckout_CheckinCheckout]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Employees]
GO
ALTER TABLE [dbo].[EmergencyContacts]  WITH CHECK ADD  CONSTRAINT [FK_EmergencyContacts_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmergencyContacts] CHECK CONSTRAINT [FK_EmergencyContacts_Employees]
GO
ALTER TABLE [dbo].[TaskEmployeeRelation]  WITH CHECK ADD  CONSTRAINT [FK_TaskEmployeeRelationship_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[TaskEmployeeRelation] CHECK CONSTRAINT [FK_TaskEmployeeRelationship_Employees]
GO
ALTER TABLE [dbo].[TaskEmployeeRelation]  WITH CHECK ADD  CONSTRAINT [FK_TaskEmployeeRelationship_Tasks] FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tasks] ([TaskID])
GO
ALTER TABLE [dbo].[TaskEmployeeRelation] CHECK CONSTRAINT [FK_TaskEmployeeRelationship_Tasks]
GO
ALTER TABLE [dbo].[Transfer]  WITH CHECK ADD  CONSTRAINT [FK_Transfer_Animals] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([AnimalID])
GO
ALTER TABLE [dbo].[Transfer] CHECK CONSTRAINT [FK_Transfer_Animals]
GO
USE [master]
GO
ALTER DATABASE [dbi520540_s2grp2zoo] SET  READ_WRITE 
GO
