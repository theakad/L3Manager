USE [l3Solutions]
GO

ALTER TABLE [dbo].[Endereco] DROP CONSTRAINT [FK_Endereco_Cliente]
GO

/****** Object:  Table [dbo].[Endereco]    Script Date: 9/17/2018 5:09:05 PM ******/
DROP TABLE [dbo].[Endereco]
GO

/****** Object:  Table [dbo].[Endereco]    Script Date: 9/17/2018 5:09:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Endereco](
	[Id] [int] NOT NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Numero] [int] NULL,
	[Complemento] [nvarchar](max) NULL,
	[Bairro] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[Estado] [nvarchar](max) NULL,
	[Id_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Cliente]
GO


