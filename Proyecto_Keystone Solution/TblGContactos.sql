USE [ProyectoFinal]
GO

/****** Object:  Table [dbo].[TblContactos]    Script Date: 28/05/2019 15:43:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblGContactos](
	[PKIdContacto] [varchar](50) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[NumeroExterior] [varchar](25) NOT NULL,
	[NumeroInterior] [varchar](25) NOT NULL,
	[CodigoPostal] [varchar](10) NOT NULL,
	[Colonia] [varchar](50) NOT NULL,
	[Municipio] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Celular] [varchar](25) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKIdContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


