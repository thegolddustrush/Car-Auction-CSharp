USE [auction]
GO
/****** Object:  Table [dbo].[BidInformation]    Script Date: 3/13/2018 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidInformation](
	[UserBidId] [int] IDENTITY(1,1) NOT NULL,
	[carId] [int] NOT NULL,
	[bid] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buyer]    Script Date: 3/13/2018 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buyer](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[emailAddress] [nchar](512) NOT NULL,
	[password] [nchar](100) NULL,
	[Name] [nchar](255) NULL,
	[Surname] [nchar](255) NULL,
	[DateOfBirth] [nchar](100) NULL,
	[Question] [nchar](100) NULL,
	[Answer] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarInformation]    Script Date: 3/13/2018 8:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarInformation](
	[carID] [int] IDENTITY(1,1) NOT NULL,
	[brand] [nchar](100) NULL,
	[model] [nchar](100) NULL,
	[year] [nchar](10) NULL,
	[Kilometers] [int] NULL,
	[startingBid] [float] NULL,
	[description] [nchar](255) NULL,
	[photo] [nchar](255) NULL,
	[closingDate] [datetime] NULL,
	[estValue] [float] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BidInformation] ON 

INSERT [dbo].[BidInformation] ([UserBidId], [carId], [bid]) VALUES (1, 1, 10000)
SET IDENTITY_INSERT [dbo].[BidInformation] OFF
SET IDENTITY_INSERT [dbo].[Buyer] ON 

INSERT [dbo].[Buyer] ([userId], [emailAddress], [password], [Name], [Surname], [DateOfBirth], [Question], [Answer]) VALUES (1, N'test                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', N'test                                                                                                ', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Buyer] ([userId], [emailAddress], [password], [Name], [Surname], [DateOfBirth], [Question], [Answer]) VALUES (2, N'test2                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ', N'test2                                                                                               ', N'test2                                                                                                                                                                                                                                                          ', N'test2                                                                                                                                                                                                                                                          ', N'test2                                                                                               ', N'test2                                                                                               ', N'test2                                                                                               ')
SET IDENTITY_INSERT [dbo].[Buyer] OFF
SET IDENTITY_INSERT [dbo].[CarInformation] ON 

INSERT [dbo].[CarInformation] ([carID], [brand], [model], [year], [Kilometers], [startingBid], [description], [photo], [closingDate], [estValue]) VALUES (1, N'BMW                                                                                                 ', N'1m                                                                                                  ', N'2012      ', 20000, 200000, N'BMW                                                                                                                                                                                                                                                            ', N'BMW 1M 2012.jpg                                                                                                                                                                                                                                                ', CAST(N'2018-10-16T00:00:00.000' AS DateTime), 532500)
INSERT [dbo].[CarInformation] ([carID], [brand], [model], [year], [Kilometers], [startingBid], [description], [photo], [closingDate], [estValue]) VALUES (2, N'chev                                                                                                ', N'lumina                                                                                              ', N'2009      ', 1, 500000, N'test                                                                                                                                                                                                                                                           ', N'8aca1752-8688-4290-9ab9-7d9f74e148f4.jpg                                                                                                                                                                                                                       ', CAST(N'2018-09-08T00:00:00.000' AS DateTime), 700000)
INSERT [dbo].[CarInformation] ([carID], [brand], [model], [year], [Kilometers], [startingBid], [description], [photo], [closingDate], [estValue]) VALUES (3, N'lamborghini                                                                                         ', N'aventador                                                                                           ', N'2012      ', 10000, 1000000, N'lambo                                                                                                                                                                                                                                                          ', N'Lamborghini Aventador 2012.jpg                                                                                                                                                                                                                                 ', CAST(N'2018-11-12T00:00:00.000' AS DateTime), 5700000)
INSERT [dbo].[CarInformation] ([carID], [brand], [model], [year], [Kilometers], [startingBid], [description], [photo], [closingDate], [estValue]) VALUES (4, N'honda                                                                                               ', N'crv                                                                                                 ', N'2014      ', 10000, 100000, N'blue                                                                                                                                                                                                                                                           ', N'                                                                                                                                                                                                                                                               ', CAST(N'2018-03-20T17:27:56.000' AS DateTime), 100000)
SET IDENTITY_INSERT [dbo].[CarInformation] OFF
