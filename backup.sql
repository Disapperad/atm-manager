USE [master]
GO
/****** Object:  Database [FedotovPractice]    Script Date: 16.05.2022 15:12:21 ******/
CREATE DATABASE [FedotovPractice]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FedotovPractice', FILENAME = N'D:\Students_DB\DATA\FedotovPractice.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FedotovPractice_log', FILENAME = N'D:\Students_DB\LOGS\FedotovPractice_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FedotovPractice] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FedotovPractice].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FedotovPractice] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FedotovPractice] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FedotovPractice] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FedotovPractice] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FedotovPractice] SET ARITHABORT OFF 
GO
ALTER DATABASE [FedotovPractice] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FedotovPractice] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FedotovPractice] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FedotovPractice] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FedotovPractice] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FedotovPractice] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FedotovPractice] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FedotovPractice] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FedotovPractice] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FedotovPractice] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FedotovPractice] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FedotovPractice] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FedotovPractice] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FedotovPractice] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FedotovPractice] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FedotovPractice] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FedotovPractice] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FedotovPractice] SET RECOVERY FULL 
GO
ALTER DATABASE [FedotovPractice] SET  MULTI_USER 
GO
ALTER DATABASE [FedotovPractice] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FedotovPractice] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FedotovPractice] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FedotovPractice] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FedotovPractice] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FedotovPractice] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FedotovPractice', N'ON'
GO
ALTER DATABASE [FedotovPractice] SET QUERY_STORE = OFF
GO
USE [FedotovPractice]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [varchar](17) NOT NULL,
	[PersonName] [varchar](50) NOT NULL,
	[Cash] [money] NOT NULL,
 CONSTRAINT [PK_accounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[AccountNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[atms]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[atms](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [varchar](6) NULL,
	[Bank] [int] NOT NULL,
 CONSTRAINT [PK_atms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[banks]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](25) NULL,
 CONSTRAINT [PK_banks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaction]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaction](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FromIDCard] [int] NOT NULL,
	[TransactionTime] [datetime] NOT NULL,
	[TransactionType] [int] NOT NULL,
	[ToIDCard] [int] NULL,
	[ATMID] [int] NULL,
	[Cash] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactiontypes]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactiontypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_transactiontypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddAccount]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAccount]
    @AccountNumber varchar(17),
    @PersonName varchar(50),
	@ID int out
AS
INSERT INTO dbo.accounts(AccountNumber, PersonName, Cash) 
VALUES(@AccountNumber, @PersonName, 0)

SET @ID = SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[GetAtms]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAtms]
@NUMBER VARCHAR(6)
AS
SELECT TOP 25 *
FROM dbo.atms WHERE SerialNumber LIKE @NUMBER + '%';
GO
/****** Object:  StoredProcedure [dbo].[RemoveAccount]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RemoveAccount]
@AccountID INT
AS
DELETE FROM [dbo].[accounts]
      WHERE ID = @AccountID
GO
/****** Object:  StoredProcedure [dbo].[SearchAccounts]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchAccounts]
@Action INT = 0,
@AccountNumber VARCHAR(17) = '',
@FIO VARCHAR(50) = '',
@Cash MONEY = 0
AS
IF @Action = 3
SELECT TOP 25 * FROM dbo.accounts
WHERE AccountNumber LIKE @AccountNumber + '%' AND PersonName LIKE @FIO + '%' AND Cash = @Cash
ELSE IF @Action = 4
SELECT TOP 25 * FROM dbo.accounts
WHERE AccountNumber LIKE @AccountNumber + '%' AND PersonName LIKE @FIO + '%' AND Cash > @Cash
ELSE IF @Action = 5
SELECT TOP 25 * FROM dbo.accounts
WHERE AccountNumber LIKE @AccountNumber + '%' AND PersonName LIKE @FIO + '%' AND Cash < @Cash
ELSE
SELECT TOP 25 * FROM dbo.accounts
WHERE AccountNumber LIKE @AccountNumber + '%' AND PersonName LIKE @FIO + '%'
GO
/****** Object:  StoredProcedure [dbo].[TransactionByPerson]    Script Date: 16.05.2022 15:12:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TransactionByPerson]
@NUMBER INT
AS
SELECT TOP 25 dbo.[transaction].ID, dbo.[transaction].FromIDCard, dbo.[transaction].TransactionTime, dbo.[transaction].TransactionType, dbo.[transaction].ToIDCard, dbo.[transaction].ATMID, dbo.[transaction].Cash
FROM dbo.accounts INNER JOIN dbo.[transaction] ON dbo.accounts.ID = dbo.[transaction].ID WHERE (dbo.accounts.ID = @NUMBER)
GO
USE [master]
GO
ALTER DATABASE [FedotovPractice] SET  READ_WRITE 
GO
