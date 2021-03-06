USE [master]
GO
/****** Object:  Database [VentaDeCelulares]    Script Date: 26/07/2019 11:44:20 p. m. ******/
CREATE DATABASE [VentaDeCelulares]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VentaDeCelulares', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\VentaDeCelulares.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VentaDeCelulares_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\VentaDeCelulares_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VentaDeCelulares] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VentaDeCelulares].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VentaDeCelulares] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET ARITHABORT OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VentaDeCelulares] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VentaDeCelulares] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VentaDeCelulares] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VentaDeCelulares] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VentaDeCelulares] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VentaDeCelulares] SET  MULTI_USER 
GO
ALTER DATABASE [VentaDeCelulares] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VentaDeCelulares] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VentaDeCelulares] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VentaDeCelulares] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VentaDeCelulares] SET DELAYED_DURABILITY = DISABLED 
GO
USE [VentaDeCelulares]
GO
/****** Object:  Table [dbo].[Accesorio]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accesorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Referencia] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Descripción] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Id_marca] [int] NOT NULL,
	[Id_color] [int] NOT NULL,
	[Id_tipo_de_accesorio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Celular]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Celular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Referencia] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Descripción] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Id_marca] [int] NOT NULL,
	[Id_color] [int] NOT NULL,
	[Almacenamiento] [int] NOT NULL,
	[RAM] [int] NOT NULL,
	[Resolución] [int] NOT NULL,
	[Tipo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Primer_apellido] [varchar](50) NOT NULL,
	[Segundo_apellido] [varchar](50) NOT NULL,
	[Cédula] [varchar](50) NOT NULL,
	[Correo_electrónico] [varchar](50) NOT NULL,
	[Dirección] [varchar](50) NOT NULL,
	[Teléfono] [varchar](50) NOT NULL,
	[Género] [char](1) NOT NULL,
	[Edad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Color]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Color](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Total] [float] NOT NULL,
	[Id_cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compra_accesorio]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_accesorio](
	[Id_compra] [int] NOT NULL,
	[Id_accesorio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_compra] ASC,
	[Id_accesorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compra_celular]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_celular](
	[Id_compra] [int] NOT NULL,
	[id_celular] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_compra] ASC,
	[id_celular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_de_accesorio]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_de_accesorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripción] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/07/2019 11:44:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Rol] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Accesorio]  WITH CHECK ADD  CONSTRAINT [FK_Accesorio_ToTipoDeAccesorio] FOREIGN KEY([Id_tipo_de_accesorio])
REFERENCES [dbo].[Tipo_de_accesorio] ([Id])
GO
ALTER TABLE [dbo].[Accesorio] CHECK CONSTRAINT [FK_Accesorio_ToTipoDeAccesorio]
GO
ALTER TABLE [dbo].[Accesorio]  WITH CHECK ADD  CONSTRAINT [FK_Table_ToColor] FOREIGN KEY([Id_color])
REFERENCES [dbo].[Color] ([Id])
GO
ALTER TABLE [dbo].[Accesorio] CHECK CONSTRAINT [FK_Table_ToColor]
GO
ALTER TABLE [dbo].[Accesorio]  WITH CHECK ADD  CONSTRAINT [FK_Table_ToMarca] FOREIGN KEY([Id_marca])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Accesorio] CHECK CONSTRAINT [FK_Table_ToMarca]
GO
ALTER TABLE [dbo].[Celular]  WITH CHECK ADD  CONSTRAINT [FK_Artículo_ToColor] FOREIGN KEY([Id_color])
REFERENCES [dbo].[Color] ([Id])
GO
ALTER TABLE [dbo].[Celular] CHECK CONSTRAINT [FK_Artículo_ToColor]
GO
ALTER TABLE [dbo].[Celular]  WITH CHECK ADD  CONSTRAINT [FK_Artículo_ToMarca] FOREIGN KEY([Id_marca])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Celular] CHECK CONSTRAINT [FK_Artículo_ToMarca]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_ToCliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_ToCliente]
GO
ALTER TABLE [dbo].[Compra_accesorio]  WITH CHECK ADD  CONSTRAINT [FK_Compra_accesorio_ToAccesorio] FOREIGN KEY([Id_accesorio])
REFERENCES [dbo].[Accesorio] ([Id])
GO
ALTER TABLE [dbo].[Compra_accesorio] CHECK CONSTRAINT [FK_Compra_accesorio_ToAccesorio]
GO
ALTER TABLE [dbo].[Compra_accesorio]  WITH CHECK ADD  CONSTRAINT [FK_Compra_accesorio_ToCompra] FOREIGN KEY([Id_compra])
REFERENCES [dbo].[Compra] ([Id])
GO
ALTER TABLE [dbo].[Compra_accesorio] CHECK CONSTRAINT [FK_Compra_accesorio_ToCompra]
GO
ALTER TABLE [dbo].[Compra_celular]  WITH CHECK ADD  CONSTRAINT [FK_Compra_celular_ToCelular] FOREIGN KEY([id_celular])
REFERENCES [dbo].[Celular] ([Id])
GO
ALTER TABLE [dbo].[Compra_celular] CHECK CONSTRAINT [FK_Compra_celular_ToCelular]
GO
ALTER TABLE [dbo].[Compra_celular]  WITH CHECK ADD  CONSTRAINT [FK_Compra_celular_ToCompra] FOREIGN KEY([Id_compra])
REFERENCES [dbo].[Compra] ([Id])
GO
ALTER TABLE [dbo].[Compra_celular] CHECK CONSTRAINT [FK_Compra_celular_ToCompra]
GO
USE [master]
GO
ALTER DATABASE [VentaDeCelulares] SET  READ_WRITE 
GO
