USE [l3Solutions]
GO

ALTER TABLE [dbo].[Telefone] DROP CONSTRAINT [FK_Telefone_Cliente]
GO

/****** Object:  Table [dbo].[Telefone]    Script Date: 9/17/2018 5:08:13 PM ******/
DROP TABLE [dbo].[Telefone]
GO

/****** Object:  Table [dbo].[Telefone]    Script Date: 9/17/2018 5:08:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Telefone](
	[Id] [int] NOT NULL,
	[Numero] [numeric](18, 0) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Telefone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_Telefone_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Telefone] CHECK CONSTRAINT [FK_Telefone_Cliente]
GO


