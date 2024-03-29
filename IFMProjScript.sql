USE [master]
GO
/****** Object:  Database [IFM_Project]    Script Date: 8/13/2019 2:05:08 PM ******/
CREATE DATABASE [IFM_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IFM_Project', FILENAME = N'C:\Users\Matthew Hoy\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v12.0\IFM_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IFM_Project_log', FILENAME = N'C:\Users\Matthew Hoy\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v12.0\IFM_Project.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [IFM_Project] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IFM_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IFM_Project] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [IFM_Project] SET ANSI_NULLS ON 
GO
ALTER DATABASE [IFM_Project] SET ANSI_PADDING ON 
GO
ALTER DATABASE [IFM_Project] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [IFM_Project] SET ARITHABORT ON 
GO
ALTER DATABASE [IFM_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IFM_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IFM_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IFM_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IFM_Project] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [IFM_Project] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [IFM_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IFM_Project] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [IFM_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IFM_Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IFM_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IFM_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IFM_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IFM_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IFM_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IFM_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IFM_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IFM_Project] SET RECOVERY FULL 
GO
ALTER DATABASE [IFM_Project] SET  MULTI_USER 
GO
ALTER DATABASE [IFM_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IFM_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IFM_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IFM_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IFM_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IFM_Project] SET QUERY_STORE = OFF
GO
USE [IFM_Project]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [IFM_Project]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Admin_ID] [int] NOT NULL,
	[First_Name] [varchar](255) NOT NULL,
	[Surname] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Conrtact_Number] [varchar](13) NOT NULL,
	[Position] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AirCooler]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirCooler](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Fan_Size] [varchar](50) NOT NULL,
	[Compatibility] [varchar](255) NOT NULL,
	[Fan_RPM] [varchar](50) NOT NULL,
	[Air_Flow] [varchar](50) NOT NULL,
	[Noise_Level] [varchar](50) NOT NULL,
	[Power_Connector] [varchar](50) NOT NULL,
	[Colour] [varchar](50) NOT NULL,
	[Materials] [varchar](255) NOT NULL,
	[Fan_Dimensions] [varchar](50) NOT NULL,
	[Heatsink_Dimentions] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Features] [varchar](255) NOT NULL,
	[Package_Contents] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaseToMobo]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaseToMobo](
	[Case_Model] [varchar](255) NOT NULL,
	[Mobo_Model] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Case_Model] ASC,
	[Mobo_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[User_ID] [int] NOT NULL,
	[First_Name] [varchar](255) NOT NULL,
	[Surname] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[City] [varchar](255) NOT NULL,
	[Province] [varchar](255) NOT NULL,
	[ZIP_Code] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPU]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPU](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[Architecture] [varchar](50) NOT NULL,
	[Cores] [varchar](50) NOT NULL,
	[Threads] [varchar](50) NOT NULL,
	[Base_Clock] [varchar](50) NOT NULL,
	[Boost_Clock] [varchar](50) NOT NULL,
	[Total_L1_Cache] [varchar](50) NOT NULL,
	[Total_L2_Cache] [varchar](50) NOT NULL,
	[Total_L3_Cache] [varchar](50) NOT NULL,
	[CMOS] [varchar](50) NOT NULL,
	[Pakage] [varchar](50) NOT NULL,
	[TDP] [varchar](50) NOT NULL,
	[Max_Temp] [varchar](50) NOT NULL,
	[System_Memory_Speed] [varchar](50) NOT NULL,
	[System_Memory_Type] [varchar](50) NOT NULL,
	[Memory_Channels] [varchar](50) NOT NULL,
	[Supported_Tech] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CpuToAirCooler]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CpuToAirCooler](
	[CPU_Model] [varchar](255) NOT NULL,
	[Cooler_Model] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CPU_Model] ASC,
	[Cooler_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CpuToLiquidCooler]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CpuToLiquidCooler](
	[CPU_Model] [varchar](255) NOT NULL,
	[Liquid_Cooler_Model] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CPU_Model] ASC,
	[Liquid_Cooler_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fans]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fans](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[RPM] [varchar](50) NOT NULL,
	[Max_Air_Flow] [varchar](50) NOT NULL,
	[Noise] [varchar](50) NOT NULL,
	[Static_Pressure] [varchar](50) NOT NULL,
	[Input_Voltage] [varchar](50) NOT NULL,
	[MBTF] [varchar](50) NOT NULL,
	[Cable_Length] [varchar](50) NOT NULL,
	[Package_Contents] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GPU]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPU](
	[Model] [varchar](255) NOT NULL,
	[Chipset] [varchar](50) NOT NULL,
	[Interface] [varchar](50) NOT NULL,
	[Clock_Speed_Base] [varchar](50) NOT NULL,
	[Clock_Speed_Boost] [varchar](50) NOT NULL,
	[Stream_Processors] [varchar](50) NOT NULL,
	[Memory_Clock] [varchar](50) NOT NULL,
	[Memory_Size] [varchar](50) NOT NULL,
	[Memory_Interface] [varchar](50) NOT NULL,
	[Memory_Type] [varchar](50) NOT NULL,
	[Ports] [varchar](255) NOT NULL,
	[Max_Digital_Resolution] [varchar](255) NOT NULL,
	[VR_Ready] [varchar](50) NOT NULL,
	[CrossFire_Support] [varchar](50) NOT NULL,
	[Recommended_Power_Supply] [varchar](50) NOT NULL,
	[Form_Factor] [varchar](50) NOT NULL,
	[Slot_Width] [varchar](50) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GpuToMonitor]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GpuToMonitor](
	[GPU_Model] [varchar](255) NOT NULL,
	[Monitor_Model] [varchar](255) NOT NULL,
	[Display_Ports] [nchar](10) NOT NULL,
	[HDMI] [nchar](10) NOT NULL,
	[VGA] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GPU_Model] ASC,
	[Monitor_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDD]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDD](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Interface] [varchar](50) NOT NULL,
	[Bytes_Per_Sector] [varchar](50) NOT NULL,
	[Max_Sustained_Transfer_Rate] [varchar](50) NOT NULL,
	[Rotational_Speed] [varchar](50) NOT NULL,
	[Load_Unload_Cycles] [varchar](50) NOT NULL,
	[Workload_Rate_Limit] [varchar](50) NOT NULL,
	[Idle_Power_Usage] [varchar](50) NOT NULL,
	[Typical_Power_Usage] [varchar](50) NOT NULL,
	[Operating_Temp] [varchar](50) NOT NULL,
	[Storage_Temp] [varchar](50) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Headset]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Headset](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NULL,
	[Series] [varchar](255) NULL,
	[Cable_Length] [varchar](50) NULL,
	[Connector] [varchar](50) NULL,
	[Compatibility] [varchar](50) NULL,
	[Frequency_Response] [varchar](50) NULL,
	[Sound_Pressure_Level] [varchar](50) NOT NULL,
	[Microphone] [varchar](50) NOT NULL,
	[MP_Frequency_Response] [varchar](50) NOT NULL,
	[MP_Pickup_Pattern] [varchar](50) NOT NULL,
	[MP_Sensitivity] [varchar](50) NOT NULL,
	[Colour] [varchar](50) NOT NULL,
	[Wearing_Style] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Features] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Keyboard]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Keyboard](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Switches] [varchar](50) NOT NULL,
	[Programmable_Macros] [varchar](50) NOT NULL,
	[Connector] [varchar](50) NOT NULL,
	[LED_BackLight] [varchar](50) NOT NULL,
	[Multimedia_Keys] [varchar](50) NOT NULL,
	[Material] [varchar](255) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquidCooler]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidCooler](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Fan_Size] [varchar](50) NOT NULL,
	[Fan_RPM] [varchar](50) NOT NULL,
	[Fan_PWM_Control] [varchar](50) NOT NULL,
	[Fan_Noise] [varchar](50) NOT NULL,
	[Fan_Max_Air_Flow] [varchar](50) NOT NULL,
	[Fan_Max_Static_Pressure] [varchar](50) NOT NULL,
	[Fan_Input_Voltage] [varchar](50) NOT NULL,
	[Fan_MTBF] [varchar](50) NOT NULL,
	[Pump_RPM] [varchar](50) NOT NULL,
	[Pump_PWM_Control] [varchar](50) NOT NULL,
	[Pump_Max_Pressure] [varchar](50) NOT NULL,
	[Pump_Rated_Input_Power] [varchar](50) NOT NULL,
	[Pump_MTBF] [varchar](50) NOT NULL,
	[Radiator_Housing_Mats] [varchar](50) NOT NULL,
	[Radiator_Fin_Mats] [varchar](50) NOT NULL,
	[Fan_Screw_Threads] [varchar](50) NOT NULL,
	[Radiator_Dimensions] [varchar](50) NOT NULL,
	[Coldplate_Material] [varchar](50) NOT NULL,
	[Thermal_Paste] [varchar](50) NOT NULL,
	[Fittings] [varchar](255) NOT NULL,
	[Tube_Length] [varchar](50) NOT NULL,
	[Tube_Mats] [varchar](50) NOT NULL,
	[Sockets_Supported] [varchar](255) NOT NULL,
	[RGB] [varchar](50) NOT NULL,
	[Package_Contents] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginTable]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTable](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[User_Type] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Microphone]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Microphone](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Pick_Up_Pattern] [varchar](50) NOT NULL,
	[Frequency_Response] [varchar](50) NOT NULL,
	[Sensitivity] [varchar](50) NOT NULL,
	[Cable_Length] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoboToCPU]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoboToCPU](
	[Mobo_Model] [varchar](255) NOT NULL,
	[CPU_Model] [varchar](255) NOT NULL,
	[CPU_Chipset] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mobo_Model] ASC,
	[CPU_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoboToRAM]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoboToRAM](
	[Mobo_Model] [varchar](255) NOT NULL,
	[RAM_Model] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mobo_Model] ASC,
	[RAM_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monitor]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monitor](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[ScreenSize] [varchar](50) NOT NULL,
	[ScreenRatio] [varchar](50) NOT NULL,
	[Brightness] [varchar](50) NOT NULL,
	[ContrastRatio] [varchar](50) NOT NULL,
	[DynamicContrastRatio] [varchar](50) NOT NULL,
	[ViewingAngle] [varchar](50) NOT NULL,
	[ResponseTime] [varchar](50) NOT NULL,
	[Panel Type] [varchar](50) NOT NULL,
	[RefreshRate] [varchar](50) NOT NULL,
	[Resolution] [varchar](50) NOT NULL,
	[Colours] [varchar](50) NOT NULL,
	[DisplayPortInput] [varchar](50) NOT NULL,
	[HDMI] [varchar](50) NOT NULL,
	[VGA] [varchar](50) NOT NULL,
	[Speakers] [varchar](50) NOT NULL,
	[PowerSource] [varchar](50) NOT NULL,
	[PowerSupply] [varchar](50) NOT NULL,
	[EnergyClass] [varchar](50) NOT NULL,
	[Swivel] [varchar](50) NOT NULL,
	[Tilt] [varchar](50) NOT NULL,
	[Pivot] [varchar](50) NOT NULL,
	[Regulations] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motherboard]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motherboard](
	[Model] [varchar](255) NOT NULL,
	[Brand] [nchar](50) NOT NULL,
	[Series] [nchar](50) NOT NULL,
	[Chipset] [nchar](20) NOT NULL,
	[Memory_Type] [varchar](255) NOT NULL,
	[Max_Memory_Size] [int] NOT NULL,
	[Max_Memory_Speed] [int] NOT NULL,
	[Audio] [varchar](255) NOT NULL,
	[LAN] [varchar](255) NOT NULL,
	[Expansion_Slots] [varchar](255) NOT NULL,
	[Storage_Interface] [varchar](255) NOT NULL,
	[Multi_GPU_Tech] [varchar](255) NOT NULL,
	[USB] [varchar](255) NOT NULL,
	[Internal_I/O_Connectors] [varchar](255) NOT NULL,
	[Back_Panel_Connectors] [varchar](255) NOT NULL,
	[I/O_Controller] [nchar](50) NOT NULL,
	[BIOS] [nchar](50) NOT NULL,
	[OS_Support] [nchar](50) NOT NULL,
	[Form_Factor] [nchar](20) NOT NULL,
	[Notes] [varchar](255) NOT NULL,
	[Warranty] [nchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mouse]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mouse](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Sensor] [varchar](50) NOT NULL,
	[Resolution] [varchar](50) NOT NULL,
	[Max_Acceleration] [varchar](50) NOT NULL,
	[Max_Speed] [varchar](50) NOT NULL,
	[Connection_Type] [varchar](50) NOT NULL,
	[Durability] [varchar](50) NOT NULL,
	[PTFE_Feet] [varchar](50) NOT NULL,
	[Battery] [varchar](50) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Cable_Length] [varchar](50) NOT NULL,
	[OS_Support] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MousePad]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MousePad](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Colour] [varchar](255) NOT NULL,
	[Size] [varchar](50) NOT NULL,
	[Materials] [varchar](255) NOT NULL,
	[Base] [varchar](50) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[Features] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OS]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OS](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Bit_Version] [varchar](50) NOT NULL,
	[OS_Version] [varchar](50) NOT NULL,
	[System_Requirements] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PCCase]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCCase](
	[Model] [varchar](255) NOT NULL,
	[Brand] [nchar](50) NOT NULL,
	[Series] [nchar](50) NOT NULL,
	[Colour] [nchar](50) NOT NULL,
	[Dimensions] [nchar](20) NOT NULL,
	[Net_Weight] [nchar](20) NOT NULL,
	[Motherboard_Support] [nchar](20) NOT NULL,
	[Num_5.25"_Drives] [nchar](50) NOT NULL,
	[Num_3.5"_Drives] [nchar](50) NOT NULL,
	[Num_2.5"_Drives] [nchar](50) NOT NULL,
	[I/O_Port] [varchar](100) NOT NULL,
	[Expansion_Slots] [nchar](50) NOT NULL,
	[Num_Top_Fans] [varchar](50) NOT NULL,
	[Num_Bottom_Fans] [varchar](50) NOT NULL,
	[Num_Front_Fans] [varchar](50) NOT NULL,
	[Num_Back_Fans] [varchar](50) NOT NULL,
	[Top_Radiator_Support] [varchar](50) NOT NULL,
	[Front_Radiator_Support] [varchar](50) NOT NULL,
	[PSU_Support] [nchar](50) NOT NULL,
	[GPU_Max_Length] [nchar](20) NOT NULL,
	[CPU_Cooler_Height] [nchar](20) NOT NULL,
	[Warranty] [nchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PSU]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PSU](
	[Model] [varchar](255) NOT NULL,
	[Brand] [nchar](50) NOT NULL,
	[Series] [nchar](50) NOT NULL,
	[Power] [nchar](20) NOT NULL,
	[Certification] [nchar](20) NOT NULL,
	[Modular] [nchar](20) NOT NULL,
	[Connectors] [varchar](255) NOT NULL,
	[MTBF] [nchar](20) NOT NULL,
	[Fan_Size] [nchar](20) NOT NULL,
	[Cables] [varchar](255) NOT NULL,
	[Compatability] [nchar](20) NOT NULL,
	[Package_Content] [varchar](255) NOT NULL,
	[Warranty] [nchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PSUtoCase]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PSUtoCase](
	[Case_Model] [varchar](255) NOT NULL,
	[PSU_Model] [varchar](255) NOT NULL,
	[Max_Watts] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Case_Model] ASC,
	[PSU_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RAM]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RAM](
	[Model] [varchar](255) NOT NULL,
	[Brand] [nchar](20) NOT NULL,
	[Series] [nchar](20) NOT NULL,
	[Capacity] [nchar](20) NOT NULL,
	[Type] [nchar](10) NOT NULL,
	[Speed] [nchar](10) NOT NULL,
	[Latency] [nchar](20) NOT NULL,
	[Voltage] [nchar](10) NOT NULL,
	[SPD_Speed] [nchar](10) NOT NULL,
	[SPD_Voltage] [nchar](10) NOT NULL,
	[Channel_Config] [nchar](10) NOT NULL,
	[Height] [nchar](10) NOT NULL,
	[Warranty] [nchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speaker]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speaker](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Satellite_Dimensions] [varchar](50) NOT NULL,
	[Satellite_Weight] [varchar](50) NOT NULL,
	[SubWoofer_Dimensions] [varchar](50) NOT NULL,
	[SubWoofer_Weight] [varchar](50) NOT NULL,
	[controls] [varchar](50) NOT NULL,
	[System Requirements] [varchar](255) NOT NULL,
	[Features] [varchar](255) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SSD]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SSD](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Form_Factor] [varchar](50) NOT NULL,
	[Capacity] [varchar](50) NOT NULL,
	[Interface] [varchar](50) NOT NULL,
	[Dimensions] [varchar](50) NOT NULL,
	[Max_Sequential_Read] [varchar](50) NOT NULL,
	[Max_Sequential_Write] [varchar](50) NOT NULL,
	[4KB_Random_Read] [varchar](50) NOT NULL,
	[4KB_Random_Write] [varchar](50) NOT NULL,
	[Seek_Time] [varchar](50) NOT NULL,
	[MTBF] [varchar](50) NOT NULL,
	[Operating_Temp] [varchar](50) NOT NULL,
	[Storage_Temp] [varchar](50) NOT NULL,
	[Idle_Power_Usage] [varchar](50) NOT NULL,
	[Max_Power_Usage] [varchar](50) NOT NULL,
	[Warrenty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 8/13/2019 2:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[Model] [varchar](255) NOT NULL,
	[Brand] [varchar](255) NOT NULL,
	[Series] [varchar](255) NOT NULL,
	[Pick_Up_Pattern] [varchar](50) NOT NULL,
	[Frequency_Response] [varchar](50) NOT NULL,
	[Sensitivity] [varchar](50) NOT NULL,
	[Cable_Length] [varchar](50) NOT NULL,
	[Warranty] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([Admin_ID])
REFERENCES [dbo].[LoginTable] ([User_ID])
GO
ALTER TABLE [dbo].[CaseToMobo]  WITH CHECK ADD FOREIGN KEY([Case_Model])
REFERENCES [dbo].[PCCase] ([Model])
GO
ALTER TABLE [dbo].[CaseToMobo]  WITH CHECK ADD FOREIGN KEY([Mobo_Model])
REFERENCES [dbo].[Motherboard] ([Model])
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([User_ID])
REFERENCES [dbo].[LoginTable] ([User_ID])
GO
ALTER TABLE [dbo].[CpuToAirCooler]  WITH CHECK ADD FOREIGN KEY([Cooler_Model])
REFERENCES [dbo].[AirCooler] ([Model])
GO
ALTER TABLE [dbo].[CpuToAirCooler]  WITH CHECK ADD FOREIGN KEY([CPU_Model])
REFERENCES [dbo].[CPU] ([Model])
GO
ALTER TABLE [dbo].[CpuToLiquidCooler]  WITH CHECK ADD FOREIGN KEY([CPU_Model])
REFERENCES [dbo].[CPU] ([Model])
GO
ALTER TABLE [dbo].[CpuToLiquidCooler]  WITH CHECK ADD FOREIGN KEY([Liquid_Cooler_Model])
REFERENCES [dbo].[LiquidCooler] ([Model])
GO
ALTER TABLE [dbo].[GpuToMonitor]  WITH CHECK ADD FOREIGN KEY([GPU_Model])
REFERENCES [dbo].[GPU] ([Model])
GO
ALTER TABLE [dbo].[GpuToMonitor]  WITH CHECK ADD FOREIGN KEY([Monitor_Model])
REFERENCES [dbo].[Monitor] ([Model])
GO
ALTER TABLE [dbo].[MoboToCPU]  WITH CHECK ADD FOREIGN KEY([CPU_Model])
REFERENCES [dbo].[CPU] ([Model])
GO
ALTER TABLE [dbo].[MoboToCPU]  WITH CHECK ADD FOREIGN KEY([Mobo_Model])
REFERENCES [dbo].[Motherboard] ([Model])
GO
ALTER TABLE [dbo].[MoboToRAM]  WITH CHECK ADD FOREIGN KEY([Mobo_Model])
REFERENCES [dbo].[Motherboard] ([Model])
GO
ALTER TABLE [dbo].[MoboToRAM]  WITH CHECK ADD FOREIGN KEY([RAM_Model])
REFERENCES [dbo].[RAM] ([Model])
GO
ALTER TABLE [dbo].[PSUtoCase]  WITH CHECK ADD FOREIGN KEY([Case_Model])
REFERENCES [dbo].[PCCase] ([Model])
GO
ALTER TABLE [dbo].[PSUtoCase]  WITH CHECK ADD FOREIGN KEY([PSU_Model])
REFERENCES [dbo].[PSU] ([Model])
GO
USE [master]
GO
ALTER DATABASE [IFM_Project] SET  READ_WRITE 
GO
