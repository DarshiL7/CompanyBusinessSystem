USE [master]
GO
/****** Object:  Database [CompanyBusinessDb]    Script Date: 28-03-2020 01:01:03 AM ******/
CREATE DATABASE [CompanyBusinessDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CompanyBusinessDb', FILENAME = N'E:\Program Files (x86)\Microsoft-Express\MSSQL14.SQLEXPRESS\MSSQL\DATA\CompanyBusinessDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CompanyBusinessDb_log', FILENAME = N'E:\Program Files (x86)\Microsoft-Express\MSSQL14.SQLEXPRESS\MSSQL\DATA\CompanyBusinessDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CompanyBusinessDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CompanyBusinessDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CompanyBusinessDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CompanyBusinessDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CompanyBusinessDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CompanyBusinessDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CompanyBusinessDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CompanyBusinessDb] SET  MULTI_USER 
GO
ALTER DATABASE [CompanyBusinessDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CompanyBusinessDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CompanyBusinessDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CompanyBusinessDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CompanyBusinessDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CompanyBusinessDb] SET QUERY_STORE = OFF
GO
USE [CompanyBusinessDb]
GO
/****** Object:  Table [dbo].[BusinessUnits]    Script Date: 28-03-2020 01:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusinessUnits](
	[BusinessUnitId] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [varchar](50) NOT NULL,
	[UnitAddress] [varchar](50) NOT NULL,
	[ProjectId] [int] NOT NULL,
 CONSTRAINT [PK_BusinessUnits] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 28-03-2020 01:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[EmpAddress] [varchar](50) NOT NULL,
	[EmpMobile] [varchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[ProjectId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leaves]    Script Date: 28-03-2020 01:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leaves](
	[LeaveId] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[LeaveReason] [varchar](50) NOT NULL,
	[EmpId] [int] NOT NULL,
 CONSTRAINT [PK_Leaves] PRIMARY KEY CLUSTERED 
(
	[LeaveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 28-03-2020 01:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[ManagerId] [int] IDENTITY(1,1) NOT NULL,
	[ManagerName] [varchar](50) NOT NULL,
	[ManagerAddress] [varchar](50) NOT NULL,
	[ManagerMobile] [varchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 28-03-2020 01:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [varchar](50) NOT NULL,
	[ProjectEndDate] [date] NOT NULL,
	[ManagerId] [int] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BusinessUnits]  WITH CHECK ADD  CONSTRAINT [FK_BusinessUnits_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
GO
ALTER TABLE [dbo].[BusinessUnits] CHECK CONSTRAINT [FK_BusinessUnits_Projects]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Projects]
GO
ALTER TABLE [dbo].[Leaves]  WITH CHECK ADD  CONSTRAINT [FK_Leaves_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([EmpId])
GO
ALTER TABLE [dbo].[Leaves] CHECK CONSTRAINT [FK_Leaves_Employees]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Managers] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Managers] ([ManagerId])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Managers]
GO
USE [master]
GO
ALTER DATABASE [CompanyBusinessDb] SET  READ_WRITE 
GO
