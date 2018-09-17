USE [l3Solutions]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 9/17/2018 5:07:16 PM ******/
DROP TABLE [dbo].[Usuario]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 9/17/2018 5:07:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [int] NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[Usuario] [varchar](max) NOT NULL,
	[Senha] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


