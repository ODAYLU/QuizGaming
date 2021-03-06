USE [master]
Create database [QuizGame]
USE [QuizGame]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1/17/2022 6:44:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuestion]    Script Date: 1/17/2022 6:44:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuestion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](400) NULL,
	[Choice1] [nvarchar](50) NULL,
	[Choice2] [nvarchar](50) NULL,
	[Choice3] [nvarchar](50) NULL,
	[Choice4] [nvarchar](50) NULL,
	[CorrectAnswer] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblQuestion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/17/2022 6:44:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Mount] [nvarchar](8) NULL,
	[NumCorrect] [int] NULL,
	[NumMistakes] [int] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([id], [UserName], [Password]) VALUES (1, N'Admin', N'123456')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[tblQuestion] ON 

INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (22, N'What number comes after 9?', N'4', N'8', N'11', N'10', N'10')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (23, N'What language do people speak in Germany?
', N'French ', N'Russian ', N'German', N'American', N'German')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (24, N'What color is a banana?', N'Red ', N'Yellow ', N'White', N'Black', N'Yellow ')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (26, N'What animal has a really long neck?', N'A giraffe', N'A parrot', N'A gorilla', N'dtjuri', N'A giraffe')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (28, N'What shines at night when the sun has gone?', N'The moon', N'A cloud', N'A cookie', N'the sun', N'The moon')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (29, N'What sea creature has 8 legs?', N' An octopus', N'A dolphin', N'A crocodile', N'Whale', N' An octopus')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (30, N'What time of day do we have breakfast?', N'In the afternoon', N'In the evening', N'In the morning', N'In the nigth', N'In the morning')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (33, N'5 * 5 = ', N'10', N'15', N'20', N'25', N'25')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (36, N'9 * 8 = ', N'72', N'63', N'55', N'56', N'72')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (37, N'6 * 6 = ', N'49', N'56', N'36', N'35', N'36')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (38, N'8 * 7 = ', N'56', N'55', N'50', N'63', N'56')
INSERT [dbo].[tblQuestion] ([Id], [Question], [Choice1], [Choice2], [Choice3], [Choice4], [CorrectAnswer]) VALUES (39, N'9 * 9', N'81', N'36', N'72', N'56', N'81')
SET IDENTITY_INSERT [dbo].[tblQuestion] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (34, N'oday', N'700$', 7, 0, CAST(N'2022-01-14T13:33:20.230' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (35, N'safasf', N'100$', 1, 0, CAST(N'2022-01-14T15:34:42.317' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (36, N'\fcasf', N'0', 0, 0, CAST(N'2022-01-14T15:43:55.590' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (37, N'aWR', N'0', 0, 0, CAST(N'2022-01-14T15:58:50.730' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (38, N'sdv', N'200$', 2, 0, CAST(N'2022-01-15T09:49:22.210' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (39, N'AD', N'400$', 4, 0, CAST(N'2022-01-15T09:57:38.230' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (40, N'age', N'0', 0, 0, CAST(N'2022-01-15T10:12:24.457' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (41, N'oaldk', N'600$', 6, 1, CAST(N'2022-01-15T19:10:14.297' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (42, N'Qretg', N'400$', 4, 3, CAST(N'2022-01-15T19:12:31.287' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (43, N'ADAD', N'0', 0, 0, CAST(N'2022-01-16T13:00:18.067' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (44, N'User Name', N'0', 0, 0, CAST(N'2022-01-16T13:47:50.100' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (45, N'oday', N'0', 0, 0, CAST(N'2022-01-16T14:19:41.363' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (46, N'User Name', N'0', 0, 0, CAST(N'2022-01-16T14:54:32.757' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (47, N'User Name', N'0', 0, 0, CAST(N'2022-01-16T14:54:52.447' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (48, N'User Name', N'0', 0, 0, CAST(N'2022-01-16T19:08:11.390' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (49, N'klio', N'500$', 5, 2, CAST(N'2022-01-17T08:10:19.427' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (50, N'User Name', N'300$', 3, 4, CAST(N'2022-01-17T08:11:02.337' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (51, N'srye', N'200$', 2, 1, CAST(N'2022-01-17T08:45:33.350' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (52, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T08:50:00.613' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (53, N'User Name', N'300$', 3, 4, CAST(N'2022-01-17T08:51:11.720' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (54, N'User Name', N'200$', 2, 0, CAST(N'2022-01-17T08:51:36.613' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (55, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T08:52:34.657' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (56, N'User Name', N'500$', 5, 3, CAST(N'2022-01-17T09:48:20.707' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (57, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T09:50:48.963' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (58, N'User Name', N'200$', 2, 5, CAST(N'2022-01-17T09:51:45.950' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (59, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T09:52:06.243' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (60, N'df', N'100$', 1, 0, CAST(N'2022-01-17T10:58:04.633' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (61, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T11:08:10.517' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (62, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T11:08:15.920' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (63, N'swxcd', N'200$', 2, 0, CAST(N'2022-01-17T11:41:50.440' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (64, N'wrhtb', N'200$', 2, 0, CAST(N'2022-01-17T12:13:09.153' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (65, N'\fgs', N'200$', 2, 5, CAST(N'2022-01-17T12:16:41.613' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (66, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T12:25:48.020' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (67, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T12:26:27.510' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (68, N'User Name', N'900$', 9, 19, CAST(N'2022-01-17T12:28:54.447' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (69, N'User Name', N'100$', 1, 0, CAST(N'2022-01-17T12:31:57.863' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (70, N'User Name', N'300$', 3, 2, CAST(N'2022-01-17T13:01:37.330' AS DateTime))
INSERT [dbo].[Users] ([Id], [UserName], [Mount], [NumCorrect], [NumMistakes], [Date]) VALUES (71, N'User Name', N'0', 0, 0, CAST(N'2022-01-17T13:03:03.400' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Date]  DEFAULT (getdate()) FOR [Date]
GO
