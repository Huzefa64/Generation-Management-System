USE [master]
GO
/****** Object:  Database [Generation_Management_System]    Script Date: 13-May-21 8:11:50 PM ******/
CREATE DATABASE [Generation_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Generation_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Generation_Management_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Generation_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Generation_Management_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Generation_Management_System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Generation_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Generation_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Generation_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Generation_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Generation_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Generation_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Generation_Management_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Generation_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Generation_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Generation_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Generation_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Generation_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Generation_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Generation_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Generation_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Generation_Management_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Generation_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Generation_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Generation_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Generation_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Generation_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Generation_Management_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Generation_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Generation_Management_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Generation_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [Generation_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Generation_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Generation_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Generation_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Generation_Management_System] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Generation_Management_System', N'ON'
GO
ALTER DATABASE [Generation_Management_System] SET QUERY_STORE = OFF
GO
USE [Generation_Management_System]
GO
/****** Object:  Table [dbo].[tblBirth]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBirth](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[family_no] [varchar](500) NULL,
	[baby_name] [varchar](500) NULL,
	[date_of_birth] [varchar](100) NULL,
	[assign_b_no] [varchar](500) NULL,
 CONSTRAINT [PK_tblBirth] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDead_People]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDead_People](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[total_members] [int] NULL,
	[family_no] [varchar](500) NULL,
	[dead_people] [int] NULL,
	[dead_name] [varchar](500) NULL,
	[cnic] [varchar](500) NOT NULL,
	[death_certaficate] [varchar](500) NULL,
	[birth_date] [varchar](100) NULL,
	[death_date] [varchar](100) NULL,
 CONSTRAINT [PK_tblDead_People_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEducation]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEducation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[f_name] [varchar](100) NULL,
	[education] [varchar](100) NULL,
	[cnic] [varchar](100) NOT NULL,
	[city] [varchar](100) NULL,
	[province] [varchar](100) NULL,
 CONSTRAINT [PK_tblEducation_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFamily_Planning]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFamily_Planning](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[head] [varchar](100) NULL,
	[spouse_name] [varchar](100) NULL,
	[no_of_childern] [varchar](100) NULL,
	[family_no] [varchar](100) NULL,
	[cnic] [varchar](100) NULL,
	[child_gap] [varchar](100) NULL,
 CONSTRAINT [PK_tblFamily_Planning] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGender]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGender](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gender] [varchar](100) NULL,
	[lesbians] [varchar](100) NULL,
	[gay] [varchar](100) NULL,
	[other] [varchar](100) NULL,
	[straight] [varchar](100) NULL,
	[married] [varchar](100) NULL,
	[religion] [varchar](100) NULL,
 CONSTRAINT [PK_tblGender] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin_Admin]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin_Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](500) NULL,
	[email] [varchar](500) NULL,
	[password] [varchar](500) NULL,
 CONSTRAINT [PK_tblLogin_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoginData]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoginData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[password] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[cnic] [varchar](100) NULL,
	[ph_no] [varchar](100) NULL,
 CONSTRAINT [PK_tblLoginData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPeople]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPeople](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](500) NULL,
	[f_name] [varchar](500) NULL,
	[cnic] [varchar](500) NOT NULL,
	[phone_no] [varchar](500) NULL,
	[head] [varchar](500) NULL,
	[total_members] [int] NULL,
	[adress] [varchar](500) NULL,
	[city] [varchar](500) NULL,
	[province] [varchar](500) NULL,
	[family_no] [varchar](500) NULL,
	[material_status] [varchar](100) NULL,
	[gender] [varchar](100) NULL,
	[religion] [varchar](100) NULL,
 CONSTRAINT [PK_tblPeople_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRes_Percentage]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRes_Percentage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[inc_population] [varchar](100) NULL,
	[economy_perce] [varchar](100) NULL,
	[resources_per] [varchar](100) NULL,
	[birth_rate] [varchar](100) NULL,
	[death_rate] [varchar](100) NULL,
 CONSTRAINT [PK_tblRes_Percentage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblResources]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblResources](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[water_res] [varchar](100) NULL,
	[food_res] [varchar](100) NULL,
	[import_export] [varchar](100) NULL,
	[elec_res] [varchar](100) NULL,
	[agri_res] [varchar](100) NULL,
	[allocted_res] [varchar](100) NULL,
 CONSTRAINT [PK_tblResources] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaff]    Script Date: 13-May-21 8:11:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[staff_name] [varchar](500) NULL,
	[staff_f_name] [varchar](500) NULL,
	[email] [varchar](500) NULL,
	[cnic_no] [varchar](500) NOT NULL,
	[ph_no] [varchar](500) NULL,
	[adress] [varchar](500) NULL,
	[staff_designition] [varchar](500) NULL,
	[staff_salary] [varchar](500) NULL,
 CONSTRAINT [PK_tblStaff] PRIMARY KEY CLUSTERED 
(
	[cnic_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblBirth] ON 

INSERT [dbo].[tblBirth] ([id], [family_no], [baby_name], [date_of_birth], [assign_b_no]) VALUES (2, N'sdjkdkjshd8974', N'fsufhuishdf', N'fnsjhdiud', N'fjduifhdsi')
SET IDENTITY_INSERT [dbo].[tblBirth] OFF
GO
SET IDENTITY_INSERT [dbo].[tblDead_People] ON 

INSERT [dbo].[tblDead_People] ([id], [total_members], [family_no], [dead_people], [dead_name], [cnic], [death_certaficate], [birth_date], [death_date]) VALUES (2, 14, N'252565g', 13, N'dhdjha', N'676347676', N'ashshsh', N'dgdjhad', N'dhdhdh')
SET IDENTITY_INSERT [dbo].[tblDead_People] OFF
GO
SET IDENTITY_INSERT [dbo].[tblEducation] ON 

INSERT [dbo].[tblEducation] ([id], [name], [f_name], [education], [cnic], [city], [province]) VALUES (2, N'Mooen', N'Akhtar', N'Bachelors', N'65876763292', N'Lahore', N'Punjab')
SET IDENTITY_INSERT [dbo].[tblEducation] OFF
GO
SET IDENTITY_INSERT [dbo].[tblGender] ON 

INSERT [dbo].[tblGender] ([id], [gender], [lesbians], [gay], [other], [straight], [married], [religion]) VALUES (1008, N'Female', N'NO', N'YES', N'Transgender', N'NO', N'NO', N'Islam')
SET IDENTITY_INSERT [dbo].[tblGender] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLogin_Admin] ON 

INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1, N'Huzefa64', N'huzefa4194@gmail.com', N'a1b2c3d456')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (2, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (3, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (4, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (5, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (6, N'Huzefa64', N'Huzefa4194@gmail.com', N'6547890')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1002, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1003, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1004, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1005, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1006, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1007, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1008, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1009, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1010, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1011, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1012, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1013, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1014, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1015, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1016, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1017, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1018, N'fsdfff', N'ssbjbsdfb', N'53354')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1019, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1020, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1021, N'', N'', N'')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1022, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1023, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1024, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1025, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1026, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1027, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1028, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1029, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1030, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1031, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1032, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1033, N'Huzefa23', N'huzefa23', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1034, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1035, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1036, N'Huzefa23@gmail.com', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1037, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1038, N'huzefa23@gmail.com', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1039, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1040, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1041, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1042, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1043, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1044, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1045, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1046, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1047, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1048, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1049, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1050, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1051, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1052, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1053, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1054, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1055, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1056, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
INSERT [dbo].[tblLogin_Admin] ([id], [user_name], [email], [password]) VALUES (1057, N'Huzefa23', N'huzefa23@gmail.com', N'rana5678')
SET IDENTITY_INSERT [dbo].[tblLogin_Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoginData] ON 

INSERT [dbo].[tblLoginData] ([id], [user_name], [email], [password], [address], [cnic], [ph_no]) VALUES (1002, N'Muhammad Huzefa', N'huzefa23@gmail.com', N'rana5678', N'11faisal block', N'366236536361', N'03114194558')
INSERT [dbo].[tblLoginData] ([id], [user_name], [email], [password], [address], [cnic], [ph_no]) VALUES (1003, N'cjkjcjcjsdiucj', N'jdsnfjkdnfjdkndn', N'ffny8y', N'kjffkj', N'58758975849', N'7837587587')
SET IDENTITY_INSERT [dbo].[tblLoginData] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPeople] ON 

INSERT [dbo].[tblPeople] ([id], [name], [f_name], [cnic], [phone_no], [head], [total_members], [adress], [city], [province], [family_no], [material_status], [gender], [religion]) VALUES (2, N'Alizay', N'Shah', N'443747373', N'57578668756475', N'Shah', 4, N'Gawal MAndi', N'Karachi', N'Sindh', N'hjds78687wv', N'Fucked Up', N'Female(Lesbian)', N'Christian')
INSERT [dbo].[tblPeople] ([id], [name], [f_name], [cnic], [phone_no], [head], [total_members], [adress], [city], [province], [family_no], [material_status], [gender], [religion]) VALUES (3, N'Shah', N'Shafay', N'3746476464', N'7538756', N'Shafay', 5, N'11 Faisal Block', N'Lahore', N'Pnjab', N'hchcgy7877', N'Single', N'Male', N'Islam')
SET IDENTITY_INSERT [dbo].[tblPeople] OFF
GO
SET IDENTITY_INSERT [dbo].[tblRes_Percentage] ON 

INSERT [dbo].[tblRes_Percentage] ([id], [inc_population], [economy_perce], [resources_per], [birth_rate], [death_rate]) VALUES (2, N'dad45', N'34%', N'76%', N'45%', N'90%')
SET IDENTITY_INSERT [dbo].[tblRes_Percentage] OFF
GO
SET IDENTITY_INSERT [dbo].[tblResources] ON 

INSERT [dbo].[tblResources] ([id], [water_res], [food_res], [import_export], [elec_res], [agri_res], [allocted_res]) VALUES (2, N'45%', N'56%', N'96%', N'23%', N'24%', N'67%')
SET IDENTITY_INSERT [dbo].[tblResources] OFF
GO
SET IDENTITY_INSERT [dbo].[tblStaff] ON 

INSERT [dbo].[tblStaff] ([id], [staff_name], [staff_f_name], [email], [cnic_no], [ph_no], [adress], [staff_designition], [staff_salary]) VALUES (2, N'ali ', N'azmat', N'ali7869087@gmail.com', N'8564375675544', N'8595858434590', N'bhjft4dsjhduifh', N'Executive', N'50,000')
SET IDENTITY_INSERT [dbo].[tblStaff] OFF
GO
USE [master]
GO
ALTER DATABASE [Generation_Management_System] SET  READ_WRITE 
GO
