USE [ProyectoFinal]
GO

/****** Object:  Table [dbo].[TblGuiasA]    Script Date: 04/06/2019 0:57:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblGuiasA](
	[IdGuia] [int] IDENTITY(1,1) NOT NULL,
	[NombreGuia] [varchar](150) NOT NULL,
	[CEnvia] [varchar](150) NOT NULL,
	[CRecibe] [varchar](150) NOT NULL,
	[Prioridad] [varchar](50) NOT NULL,
	[COrigen] [varchar](150) NOT NULL,
	[CDestino] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TblGuiasA] PRIMARY KEY CLUSTERED 
(
	[IdGuia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


