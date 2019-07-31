USE [ProyectoFinal]
GO

/****** Object:  Table [dbo].[TblContactosGA]    Script Date: 04/06/2019 0:46:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblContactosGA](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[Numero Exterior] [varchar](25) NOT NULL,
	[Numero Interior] [varchar](25) NULL,
	[Codigo Postal] [varchar](10) NOT NULL,
	[Colonia] [varchar](50) NOT NULL,
	[Municipio] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Telefono] [varchar](25) NULL,
	[Celular] [varchar](25) NULL,
	[Correo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TblContactosGA] PRIMARY KEY CLUSTERED 
(
	[IdContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


