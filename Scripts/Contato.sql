USE [l3Solutions]
GO

ALTER TABLE [dbo].[Contato] DROP CONSTRAINT [FK_Contato_Cliente]
GO

/****** Object:  Table [dbo].[Contato]    Script Date: 9/17/2018 5:09:38 PM ******/
DROP TABLE [dbo].[Contato]
GO

/****** Object:  Table [dbo].[Contato]    Script Date: 9/17/2018 5:09:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contato](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Cargo] [nvarchar](max) NULL,
	[Data de Nascimento] [nvarchar](max) NULL,
	[Telefone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Id_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Contato] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Contato]  WITH CHECK ADD  CONSTRAINT [FK_Contato_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Contato] CHECK CONSTRAINT [FK_Contato_Cliente]
GO


