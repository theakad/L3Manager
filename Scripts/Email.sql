USE [l3Solutions]
GO

ALTER TABLE [dbo].[Email] DROP CONSTRAINT [FK_Email_Cliente]
GO

/****** Object:  Table [dbo].[Email]    Script Date: 9/17/2018 5:09:18 PM ******/
DROP TABLE [dbo].[Email]
GO

/****** Object:  Table [dbo].[Email]    Script Date: 9/17/2018 5:09:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Email](
	[Id] [int] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Id_Cliente] [int] NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Email]  WITH CHECK ADD  CONSTRAINT [FK_Email_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Email] CHECK CONSTRAINT [FK_Email_Cliente]
GO


