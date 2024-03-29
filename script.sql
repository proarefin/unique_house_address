USE [DB_Address]
GO
/****** Object:  Table [dbo].[Anschrift]    Script Date: 10/29/2019 3:54:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anschrift](
	[AnschriftID] [int] IDENTITY(1,1) NOT NULL,
	[StraßeName] [varchar](150) NOT NULL,
	[WohnungNummer] [varchar](10) NOT NULL,
	[PLZ] [varchar](10) NOT NULL,
	[StadtId] [int] NULL,
	[LandId] [int] NOT NULL,
	[HashValue] [binary](16) NULL,
	[HashCode] [varchar](50) NULL,
 CONSTRAINT [PK_Anschrift] PRIMARY KEY CLUSTERED 
(
	[AnschriftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 10/29/2019 3:54:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryCode] [varchar](5) NOT NULL,
	[CountryName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stadt]    Script Date: 10/29/2019 3:54:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadt](
	[StadtID] [int] IDENTITY(1,1) NOT NULL,
	[StadtCode] [varchar](5) NOT NULL,
	[StadtName] [varchar](30) NOT NULL,
	[LandCode] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Stadt] PRIMARY KEY CLUSTERED 
(
	[StadtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Anschrift]  WITH CHECK ADD  CONSTRAINT [FK_Anschrift_Country] FOREIGN KEY([LandId])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[Anschrift] CHECK CONSTRAINT [FK_Anschrift_Country]
GO
ALTER TABLE [dbo].[Anschrift]  WITH CHECK ADD  CONSTRAINT [FK_Anschrift_Stadt] FOREIGN KEY([StadtId])
REFERENCES [dbo].[Stadt] ([StadtID])
GO
ALTER TABLE [dbo].[Anschrift] CHECK CONSTRAINT [FK_Anschrift_Stadt]
GO
