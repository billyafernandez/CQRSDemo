

USE [CQRS_Demo]
GO

/****** Object:  Table [dbo].[images]    Script Date: 06/13/2016 15:58:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TweetId] [nvarchar](255) NOT NULL,
	[text] [nvarchar](255) NOT NULL,
	[media_url] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_images_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


