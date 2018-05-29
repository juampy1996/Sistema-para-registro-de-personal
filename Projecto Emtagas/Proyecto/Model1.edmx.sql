
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/19/2018 20:10:49
-- Generated from EDMX file: C:\Users\usuario\Desktop\Projecto Emtagas\Proyecto\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EMTAGAS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonaPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_PersonaPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_CargoPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_CargoPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_Tipo_ContratoPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_Tipo_ContratoPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_NivelPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_NivelPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalSet] DROP CONSTRAINT [FK_UsuarioPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_ConyuguePersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConyugueSet] DROP CONSTRAINT [FK_ConyuguePersona];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaHijo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HijoSet] DROP CONSTRAINT [FK_PersonaHijo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet];
GO
IF OBJECT_ID(N'[dbo].[PersonalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonalSet];
GO
IF OBJECT_ID(N'[dbo].[CargoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CargoSet];
GO
IF OBJECT_ID(N'[dbo].[Tipo_ContratoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_ContratoSet];
GO
IF OBJECT_ID(N'[dbo].[NivelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NivelSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[ConyugueSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConyugueSet];
GO
IF OBJECT_ID(N'[dbo].[HijoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HijoSet];
GO
IF OBJECT_ID(N'[dbo].[Reporte_edicionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reporte_edicionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonaSet'
CREATE TABLE [dbo].[PersonaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ci] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL,
    [FechaNacimiento] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Foto] nvarchar(max)  NULL,
    [Profesion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonalSet'
CREATE TABLE [dbo].[PersonalSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HaberBasico] nvarchar(max)  NOT NULL,
    [FechaIngreso] nvarchar(max)  NOT NULL,
    [FechaRegistro] nvarchar(max)  NOT NULL,
    [DireccionRegional] nvarchar(max)  NOT NULL,
    [Persona_Id] int  NOT NULL,
    [Cargo1_Id] int  NOT NULL,
    [Tipo_Contrato_Id] int  NOT NULL,
    [Nivel1_Id] int  NOT NULL,
    [Usuario_Id] int  NOT NULL,
    [Estado_Id] int  NOT NULL
);
GO

-- Creating table 'CargoSet'
CREATE TABLE [dbo].[CargoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreCargo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tipo_ContratoSet'
CREATE TABLE [dbo].[Tipo_ContratoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre_TipoContrato] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NivelSet'
CREATE TABLE [dbo].[NivelSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreNivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Passsword] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConyugueSet'
CREATE TABLE [dbo].[ConyugueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ci_Conyugue] nvarchar(max)  NULL,
    [Nombre_Conyugue] nvarchar(max)  NULL,
    [Apellido_Conyugue] nvarchar(max)  NULL,
    [FechaNacimiento_Conyugue] nvarchar(max)  NULL,
    [Genero_Conyugue] nvarchar(max)  NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'HijoSet'
CREATE TABLE [dbo].[HijoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ci_Hijo] nvarchar(max)  NOT NULL,
    [Nombre_Hijo] nvarchar(max)  NOT NULL,
    [Apellido_Hijo] nvarchar(max)  NOT NULL,
    [FechaNaciemiento_Hijo] nvarchar(max)  NOT NULL,
    [Genero_Hijo] nvarchar(max)  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Reporte_edicionSet'
CREATE TABLE [dbo].[Reporte_edicionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha_Edicion] nvarchar(max)  NOT NULL,
    [Persona_Editada] nvarchar(max)  NOT NULL,
    [Tipo_edicion] nvarchar(max)  NOT NULL,
    [Usario_Editor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstadoSet'
CREATE TABLE [dbo].[EstadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreEstado] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PersonaSet'
ALTER TABLE [dbo].[PersonaSet]
ADD CONSTRAINT [PK_PersonaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [PK_PersonalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CargoSet'
ALTER TABLE [dbo].[CargoSet]
ADD CONSTRAINT [PK_CargoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipo_ContratoSet'
ALTER TABLE [dbo].[Tipo_ContratoSet]
ADD CONSTRAINT [PK_Tipo_ContratoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NivelSet'
ALTER TABLE [dbo].[NivelSet]
ADD CONSTRAINT [PK_NivelSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConyugueSet'
ALTER TABLE [dbo].[ConyugueSet]
ADD CONSTRAINT [PK_ConyugueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HijoSet'
ALTER TABLE [dbo].[HijoSet]
ADD CONSTRAINT [PK_HijoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reporte_edicionSet'
ALTER TABLE [dbo].[Reporte_edicionSet]
ADD CONSTRAINT [PK_Reporte_edicionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoSet'
ALTER TABLE [dbo].[EstadoSet]
ADD CONSTRAINT [PK_EstadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Persona_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_PersonaPersonal]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaPersonal'
CREATE INDEX [IX_FK_PersonaPersonal]
ON [dbo].[PersonalSet]
    ([Persona_Id]);
GO

-- Creating foreign key on [Cargo1_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_CargoPersonal]
    FOREIGN KEY ([Cargo1_Id])
    REFERENCES [dbo].[CargoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CargoPersonal'
CREATE INDEX [IX_FK_CargoPersonal]
ON [dbo].[PersonalSet]
    ([Cargo1_Id]);
GO

-- Creating foreign key on [Tipo_Contrato_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_Tipo_ContratoPersonal]
    FOREIGN KEY ([Tipo_Contrato_Id])
    REFERENCES [dbo].[Tipo_ContratoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_ContratoPersonal'
CREATE INDEX [IX_FK_Tipo_ContratoPersonal]
ON [dbo].[PersonalSet]
    ([Tipo_Contrato_Id]);
GO

-- Creating foreign key on [Nivel1_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_NivelPersonal]
    FOREIGN KEY ([Nivel1_Id])
    REFERENCES [dbo].[NivelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NivelPersonal'
CREATE INDEX [IX_FK_NivelPersonal]
ON [dbo].[PersonalSet]
    ([Nivel1_Id]);
GO

-- Creating foreign key on [Usuario_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_UsuarioPersonal]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPersonal'
CREATE INDEX [IX_FK_UsuarioPersonal]
ON [dbo].[PersonalSet]
    ([Usuario_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'ConyugueSet'
ALTER TABLE [dbo].[ConyugueSet]
ADD CONSTRAINT [FK_ConyuguePersona]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConyuguePersona'
CREATE INDEX [IX_FK_ConyuguePersona]
ON [dbo].[ConyugueSet]
    ([Persona_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'HijoSet'
ALTER TABLE [dbo].[HijoSet]
ADD CONSTRAINT [FK_PersonaHijo]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaHijo'
CREATE INDEX [IX_FK_PersonaHijo]
ON [dbo].[HijoSet]
    ([Persona_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'PersonalSet'
ALTER TABLE [dbo].[PersonalSet]
ADD CONSTRAINT [FK_EstadoPersonal]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[EstadoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPersonal'
CREATE INDEX [IX_FK_EstadoPersonal]
ON [dbo].[PersonalSet]
    ([Estado_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------