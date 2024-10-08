USE [EmployeeManagement]
GO
/****** Object:  Table [dbo].[CompanyMaster]    Script Date: 01-09-2024 9.14.59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMaster](
	[CMPId] [uniqueidentifier] NOT NULL,
	[CMPName] [nvarchar](50) NULL,
	[CMPIsActive] [bit] NULL,
	[CMPCreatedDate] [datetime] NULL,
	[CMPUpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_CompanyMaster] PRIMARY KEY CLUSTERED 
(
	[CMPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentMappingMaster]    Script Date: 01-09-2024 9.14.59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentMappingMaster](
	[DMPId] [uniqueidentifier] NOT NULL,
	[CMPId] [uniqueidentifier] NULL,
	[DPTId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_DepartmentMappingMaster] PRIMARY KEY CLUSTERED 
(
	[DMPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentMaster]    Script Date: 01-09-2024 9.14.59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentMaster](
	[DPTId] [uniqueidentifier] NOT NULL,
	[DPTName] [nvarchar](50) NULL,
	[DPTIsActive] [bit] NULL,
	[DPTCreatedDate] [datetime] NULL,
	[DPTUpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_DepartmentMaster] PRIMARY KEY CLUSTERED 
(
	[DPTId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 01-09-2024 9.14.59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeMaster](
	[EMPId] [uniqueidentifier] NOT NULL,
	[EMPFirstName] [nvarchar](50) NULL,
	[EMPLastName] [nvarchar](50) NULL,
	[EMPImage] [nvarchar](50) NULL,
	[EMPDob] [date] NULL,
	[EMPPhone] [nvarchar](15) NULL,
	[EMPGender] [nvarchar](10) NULL,
	[EMPQualification] [nvarchar](50) NULL,
	[EMPCity] [nvarchar](50) NULL,
	[EMPState] [nvarchar](50) NULL,
	[EMPPincode] [nvarchar](50) NULL,
	[EMPAddress] [nvarchar](50) NULL,
	[EMPEmail] [nvarchar](50) NULL,
	[CMPId] [uniqueidentifier] NULL,
	[DPTId] [uniqueidentifier] NULL,
	[EMPJoiningDate] [datetime] NULL,
	[EMPIsActive] [bit] NULL,
	[EMPCreatedDate] [datetime] NULL,
	[EMPUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_EmployeeMaster] PRIMARY KEY CLUSTERED 
(
	[EMPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CompanyMaster] ([CMPId], [CMPName], [CMPIsActive], [CMPCreatedDate], [CMPUpdatedDate]) VALUES (N'b5358cd8-e54e-4b66-9abf-f689be174469', N'My Test Demo', 1, CAST(N'2024-09-01T19:04:45.990' AS DateTime), CAST(N'2024-09-01T20:46:32.993' AS DateTime))
GO
INSERT [dbo].[DepartmentMappingMaster] ([DMPId], [CMPId], [DPTId]) VALUES (N'1729189f-5260-4c57-8142-1322d184722a', N'b5358cd8-e54e-4b66-9abf-f689be174469', N'4fced336-f776-43d6-ac75-7db8b75960f0')
INSERT [dbo].[DepartmentMappingMaster] ([DMPId], [CMPId], [DPTId]) VALUES (N'ee0abf0d-3ed6-483f-8e6d-5315647d385a', N'b5358cd8-e54e-4b66-9abf-f689be174469', N'f2223d6f-51bf-4614-8ec0-43a0f95d71a9')
INSERT [dbo].[DepartmentMappingMaster] ([DMPId], [CMPId], [DPTId]) VALUES (N'1aee20b9-c99b-4d25-9a31-badf4ae7f35d', N'b5358cd8-e54e-4b66-9abf-f689be174469', N'd2e86b21-fc89-47bd-9f7e-08da81b2e1e1')
INSERT [dbo].[DepartmentMappingMaster] ([DMPId], [CMPId], [DPTId]) VALUES (N'c2fc50b8-ddf2-49cb-bd83-d9d0ba293e9b', N'b5358cd8-e54e-4b66-9abf-f689be174469', N'e51e8504-4657-42d2-8187-d028106824a8')
GO
INSERT [dbo].[DepartmentMaster] ([DPTId], [DPTName], [DPTIsActive], [DPTCreatedDate], [DPTUpdatedDate]) VALUES (N'd2e86b21-fc89-47bd-9f7e-08da81b2e1e1', N'dpartment1', 1, CAST(N'2024-09-01T13:15:01.757' AS DateTime), CAST(N'2024-09-01T13:15:01.757' AS DateTime))
INSERT [dbo].[DepartmentMaster] ([DPTId], [DPTName], [DPTIsActive], [DPTCreatedDate], [DPTUpdatedDate]) VALUES (N'f2223d6f-51bf-4614-8ec0-43a0f95d71a9', N'dpartment2', 1, CAST(N'2024-09-01T13:16:54.210' AS DateTime), CAST(N'2024-09-01T13:16:54.210' AS DateTime))
INSERT [dbo].[DepartmentMaster] ([DPTId], [DPTName], [DPTIsActive], [DPTCreatedDate], [DPTUpdatedDate]) VALUES (N'4fced336-f776-43d6-ac75-7db8b75960f0', N'dpartment4', 1, CAST(N'2024-09-01T15:40:36.660' AS DateTime), CAST(N'2024-09-01T15:40:36.660' AS DateTime))
INSERT [dbo].[DepartmentMaster] ([DPTId], [DPTName], [DPTIsActive], [DPTCreatedDate], [DPTUpdatedDate]) VALUES (N'e51e8504-4657-42d2-8187-d028106824a8', N'dpartment3', 1, CAST(N'2024-09-01T13:17:00.960' AS DateTime), CAST(N'2024-09-01T13:17:00.960' AS DateTime))
GO
INSERT [dbo].[EmployeeMaster] ([EMPId], [EMPFirstName], [EMPLastName], [EMPImage], [EMPDob], [EMPPhone], [EMPGender], [EMPQualification], [EMPCity], [EMPState], [EMPPincode], [EMPAddress], [EMPEmail], [CMPId], [DPTId], [EMPJoiningDate], [EMPIsActive], [EMPCreatedDate], [EMPUpdateDate]) VALUES (N'ac26b75e-23e8-460d-bb23-5d0601c6f710', N'empfname', N'emplname', N'01092024075106.png', CAST(N'2024-09-07' AS Date), N'09898787844', N'Male', N'MCA', N'Kadi', N'gujrat', N'382715', N'dhaval plaza', N'm@gmail.com', N'b5358cd8-e54e-4b66-9abf-f689be174469', N'4fced336-f776-43d6-ac75-7db8b75960f0', CAST(N'2024-09-07T00:00:00.000' AS DateTime), 1, CAST(N'2024-09-01T19:51:08.307' AS DateTime), CAST(N'2024-09-01T19:51:08.597' AS DateTime))
GO
ALTER TABLE [dbo].[CompanyMaster] ADD  CONSTRAINT [DF_CompanyMaster_CMPId]  DEFAULT (newid()) FOR [CMPId]
GO
ALTER TABLE [dbo].[DepartmentMappingMaster] ADD  CONSTRAINT [DF_DepartmentMappingMaster_DMPId]  DEFAULT (newid()) FOR [DMPId]
GO
ALTER TABLE [dbo].[DepartmentMaster] ADD  CONSTRAINT [DF_DepartmentMaster_DPTId]  DEFAULT (newid()) FOR [DPTId]
GO
