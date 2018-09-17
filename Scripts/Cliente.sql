USE [l3Solutions]
GO

ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_Cliente_Usuario]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 9/17/2018 5:08:31 PM ******/
DROP TABLE [dbo].[Cliente]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 9/17/2018 5:08:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [bit] NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Documento] [numeric](18, 0) NULL,
	[Data_Hora_Cadastro] [datetime] NOT NULL,
	[Vencimento_Licenca] [datetime] NULL,
	[Id_Vendedor] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([Id_Vendedor])
REFERENCES [dbo].[Usuario] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]
GO


