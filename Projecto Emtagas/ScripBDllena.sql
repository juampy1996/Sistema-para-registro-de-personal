USE [EMTAGAS]
GO
/****** Object:  Table [dbo].[CargoSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[ConyugueSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[EstadoSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[HijoSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[NivelSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[PersonalSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[PersonaSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[Reporte_edicionSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[Tipo_ContratoSet]    Script Date: 24/01/2018 23:33:44 ******/
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
/****** Object:  Table [dbo].[UsuarioSet]    Script Date: 24/01/2018 23:33:44 ******/
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
SET IDENTITY_INSERT [dbo].[CargoSet] ON 

INSERT [dbo].[CargoSet] ([Id], [NombreCargo]) VALUES (1, N'Gerente')
INSERT [dbo].[CargoSet] ([Id], [NombreCargo]) VALUES (2, N'Recurso Humanos')
INSERT [dbo].[CargoSet] ([Id], [NombreCargo]) VALUES (3, N'Sistemas')
SET IDENTITY_INSERT [dbo].[CargoSet] OFF
SET IDENTITY_INSERT [dbo].[ConyugueSet] ON 

INSERT [dbo].[ConyugueSet] ([Id], [Ci_Conyugue], [Nombre_Conyugue], [Apellido_Conyugue], [FechaNacimiento_Conyugue], [Genero_Conyugue], [Persona_Id]) VALUES (1, N'106979862', N'Maritza', N'Pacheco', N'03/01/2018 0:00:00', N'Femenino', 2)
SET IDENTITY_INSERT [dbo].[ConyugueSet] OFF
SET IDENTITY_INSERT [dbo].[EstadoSet] ON 

INSERT [dbo].[EstadoSet] ([Id], [NombreEstado]) VALUES (1, N'Activo')
INSERT [dbo].[EstadoSet] ([Id], [NombreEstado]) VALUES (2, N'Inactivo')
SET IDENTITY_INSERT [dbo].[EstadoSet] OFF
SET IDENTITY_INSERT [dbo].[HijoSet] ON 

INSERT [dbo].[HijoSet] ([Id], [Ci_Hijo], [Nombre_Hijo], [Apellido_Hijo], [FechaNaciemiento_Hijo], [Genero_Hijo], [Persona_Id]) VALUES (1, N'10694982', N'Jorge', N'Arroyo', N'21/01/2017 0:00:00', N'Masculino', 2)
SET IDENTITY_INSERT [dbo].[HijoSet] OFF
SET IDENTITY_INSERT [dbo].[NivelSet] ON 

INSERT [dbo].[NivelSet] ([Id], [NombreNivel]) VALUES (1, N'1')
INSERT [dbo].[NivelSet] ([Id], [NombreNivel]) VALUES (2, N'2')
INSERT [dbo].[NivelSet] ([Id], [NombreNivel]) VALUES (3, N'3')
SET IDENTITY_INSERT [dbo].[NivelSet] OFF
SET IDENTITY_INSERT [dbo].[PersonalSet] ON 

INSERT [dbo].[PersonalSet] ([Id], [HaberBasico], [FechaIngreso], [FechaRegistro], [DireccionRegional], [Persona_Id], [Cargo1_Id], [Tipo_Contrato_Id], [Nivel1_Id], [Usuario_Id], [Estado_Id]) VALUES (1, N'3500', N'20/01/2018 0:00:00', N'20/01/2018 22:57:36', N'circunvalacion', 1, 3, 1, 1, 1, 1)
INSERT [dbo].[PersonalSet] ([Id], [HaberBasico], [FechaIngreso], [FechaRegistro], [DireccionRegional], [Persona_Id], [Cargo1_Id], [Tipo_Contrato_Id], [Nivel1_Id], [Usuario_Id], [Estado_Id]) VALUES (2, N'1800', N'20/01/2008 0:00:00', N'20/01/2018 23:08:57', N'centro', 2, 3, 2, 2, 2, 2)
INSERT [dbo].[PersonalSet] ([Id], [HaberBasico], [FechaIngreso], [FechaRegistro], [DireccionRegional], [Persona_Id], [Cargo1_Id], [Tipo_Contrato_Id], [Nivel1_Id], [Usuario_Id], [Estado_Id]) VALUES (3, N'10000', N'24/01/2018 0:00:00', N'24/01/2018 22:03:14', N'circunvalacion', 3, 1, 1, 2, 3, 1)
SET IDENTITY_INSERT [dbo].[PersonalSet] OFF
SET IDENTITY_INSERT [dbo].[PersonaSet] ON 

INSERT [dbo].[PersonaSet] ([Id], [Ci], [Nombre], [Apellido], [Genero], [FechaNacimiento], [Telefono], [Direccion], [Foto], [Profesion]) VALUES (1, N'10694981', N'juan pablo', N'meriles', N'Masculino', N'26/04/1962 0:00:00', N'76812623', N'villa bush', N'C:\Users\usuario\Desktop\Projecto Emtagas\Proyecto\bin\Debug\FotosDePerfil\juan pablo meriles.jpg', N'ing sistemas')
INSERT [dbo].[PersonaSet] ([Id], [Ci], [Nombre], [Apellido], [Genero], [FechaNacimiento], [Telefono], [Direccion], [Foto], [Profesion]) VALUES (2, N'10665659', N'deibi ', N'arroyo', N'Masculino', N'03/01/2018 0:00:00', N'76856320', N'sella', NULL, N'informatico')
INSERT [dbo].[PersonaSet] ([Id], [Ci], [Nombre], [Apellido], [Genero], [FechaNacimiento], [Telefono], [Direccion], [Foto], [Profesion]) VALUES (3, N'10624689', N'Elizabeth', N'Zambrana', N'Femenino', N'26/06/1995 0:00:00', N'77195978', N'san roque', N'no foto', N'lic. administracion de empresas')
SET IDENTITY_INSERT [dbo].[PersonaSet] OFF
SET IDENTITY_INSERT [dbo].[Reporte_edicionSet] ON 

INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (1, N'20/01/2018 22:57:36', N'juan pablo meriles', N'Registro', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (2, N'20/01/2018 23:02:30', N'juan pablo meriles', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (3, N'20/01/2018 23:02:45', N'juan pablo meriles', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (4, N'20/01/2018 23:08:57', N'deibi  arroyo', N'Registro', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (5, N'21/01/2018 0:15:25', N'deibi  arroyo', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (6, N'21/01/2018 11:06:40', N'deibi  arroyo', N'Registro Conyugue', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (7, N'21/01/2018 11:11:50', N'deibi  arroyo', N'Registro de hijo', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (8, N'21/01/2018 11:38:08', N'deibi  arroyo', N'Hijo Editado', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (9, N'21/01/2018 11:39:36', N'deibi  arroyo', N'Hijo Editado', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (10, N'21/01/2018 11:40:24', N'deibi  arroyo', N'Hijo Editado', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (11, N'21/01/2018 12:12:37', N'deibi  arroyo', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (12, N'21/01/2018 12:13:33', N'deibi  arroyo', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (13, N'21/01/2018 12:21:36', N'juan pablo meriles', N'Edicion', N'Admin')
INSERT [dbo].[Reporte_edicionSet] ([Id], [Fecha_Edicion], [Persona_Editada], [Tipo_edicion], [Usario_Editor]) VALUES (14, N'24/01/2018 22:03:14', N'Elizabeth Zambrana', N'Registro', N'Admin')
SET IDENTITY_INSERT [dbo].[Reporte_edicionSet] OFF
SET IDENTITY_INSERT [dbo].[Tipo_ContratoSet] ON 

INSERT [dbo].[Tipo_ContratoSet] ([Id], [Nombre_TipoContrato]) VALUES (1, N'Item')
INSERT [dbo].[Tipo_ContratoSet] ([Id], [Nombre_TipoContrato]) VALUES (2, N'Contrato')
SET IDENTITY_INSERT [dbo].[Tipo_ContratoSet] OFF
SET IDENTITY_INSERT [dbo].[UsuarioSet] ON 

INSERT [dbo].[UsuarioSet] ([Id], [Login], [Passsword]) VALUES (1, N'juan', N'1234')
INSERT [dbo].[UsuarioSet] ([Id], [Login], [Passsword]) VALUES (2, N'deibi', N'1234')
INSERT [dbo].[UsuarioSet] ([Id], [Login], [Passsword]) VALUES (3, N'ely', N'1234')
SET IDENTITY_INSERT [dbo].[UsuarioSet] OFF
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
