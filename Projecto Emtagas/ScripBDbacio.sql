USE [EMTAGAS]
GO
/****** Object:  Table [dbo].[CargoSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CargoSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreCargo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CargoSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConyugueSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConyugueSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ci_Conyugue] [nvarchar](max) NULL,
	[Nombre_Conyugue] [nvarchar](max) NULL,
	[Apellido_Conyugue] [nvarchar](max) NULL,
	[FechaNacimiento_Conyugue] [nvarchar](max) NULL,
	[Genero_Conyugue] [nvarchar](max) NULL,
	[Persona_Id] [int] NOT NULL,
 CONSTRAINT [PK_ConyugueSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EstadoSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreEstado] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_EstadoSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HijoSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HijoSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ci_Hijo] [nvarchar](max) NOT NULL,
	[Nombre_Hijo] [nvarchar](max) NOT NULL,
	[Apellido_Hijo] [nvarchar](max) NOT NULL,
	[FechaNaciemiento_Hijo] [nvarchar](max) NOT NULL,
	[Genero_Hijo] [nvarchar](max) NOT NULL,
	[Persona_Id] [int] NOT NULL,
 CONSTRAINT [PK_HijoSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NivelSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreNivel] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NivelSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HaberBasico] [nvarchar](max) NOT NULL,
	[FechaIngreso] [nvarchar](max) NOT NULL,
	[FechaRegistro] [nvarchar](max) NOT NULL,
	[DireccionRegional] [nvarchar](max) NOT NULL,
	[Persona_Id] [int] NOT NULL,
	[Cargo1_Id] [int] NOT NULL,
	[Tipo_Contrato_Id] [int] NOT NULL,
	[Nivel1_Id] [int] NOT NULL,
	[Usuario_Id] [int] NOT NULL,
	[Estado_Id] [int] NOT NULL,
 CONSTRAINT [PK_PersonalSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonaSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonaSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ci] [nvarchar](max) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Genero] [nvarchar](max) NOT NULL,
	[FechaNacimiento] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Foto] [nvarchar](max) NULL,
	[Profesion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PersonaSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reporte_edicionSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte_edicionSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Edicion] [nvarchar](max) NOT NULL,
	[Persona_Editada] [nvarchar](max) NOT NULL,
	[Tipo_edicion] [nvarchar](max) NOT NULL,
	[Usario_Editor] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Reporte_edicionSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_ContratoSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_ContratoSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_TipoContrato] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tipo_ContratoSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioSet]    Script Date: 24/01/2018 23:34:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Passsword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UsuarioSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[ConyugueSet]  WITH CHECK ADD  CONSTRAINT [FK_ConyuguePersona] FOREIGN KEY([Persona_Id])
REFERENCES [dbo].[PersonaSet] ([Id])
GO
ALTER TABLE [dbo].[ConyugueSet] CHECK CONSTRAINT [FK_ConyuguePersona]
GO
ALTER TABLE [dbo].[HijoSet]  WITH CHECK ADD  CONSTRAINT [FK_PersonaHijo] FOREIGN KEY([Persona_Id])
REFERENCES [dbo].[PersonaSet] ([Id])
GO
ALTER TABLE [dbo].[HijoSet] CHECK CONSTRAINT [FK_PersonaHijo]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_CargoPersonal] FOREIGN KEY([Cargo1_Id])
REFERENCES [dbo].[CargoSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_CargoPersonal]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_EstadoPersonal] FOREIGN KEY([Estado_Id])
REFERENCES [dbo].[EstadoSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_EstadoPersonal]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_NivelPersonal] FOREIGN KEY([Nivel1_Id])
REFERENCES [dbo].[NivelSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_NivelPersonal]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_PersonaPersonal] FOREIGN KEY([Persona_Id])
REFERENCES [dbo].[PersonaSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_PersonaPersonal]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_ContratoPersonal] FOREIGN KEY([Tipo_Contrato_Id])
REFERENCES [dbo].[Tipo_ContratoSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_Tipo_ContratoPersonal]
GO
ALTER TABLE [dbo].[PersonalSet]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPersonal] FOREIGN KEY([Usuario_Id])
REFERENCES [dbo].[UsuarioSet] ([Id])
GO
ALTER TABLE [dbo].[PersonalSet] CHECK CONSTRAINT [FK_UsuarioPersonal]
GO
