USE [master]

CREATE DATABASE [EXIT_FEEDBACK]
GO
USE [EXIT_FEEDBACK]
GO
/****** Object:  Table [dbo].[CARRERA]    Script Date: 03/05/2019 12:25:27 ******/
CREATE TABLE [dbo].[CARRERA](
	[CARRERA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_CARRERA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CARRERA] PRIMARY KEY CLUSTERED 
(
	[CARRERA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[CATEGORIA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_CATEGORIA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[CATEGORIA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CELDA]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CELDA](
	[CELDA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CELDA] PRIMARY KEY CLUSTERED 
(
	[CELDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CENTRO]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CENTRO](
	[CENTRO_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_CENTRO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CENTRO] PRIMARY KEY CLUSTERED 
(
	[CENTRO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATO_CALIFICACION]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATO_CALIFICACION](
	[DATO_CALIFICACION_ID] [int] IDENTITY(1,1) NOT NULL,
	[PROCESO_SELECCION_NOTA] [int] NOT NULL,
	[PROCESO_SELECCION_COMENTARIO] [varchar](200) NULL,
	[INTEGRACION_NOTA] [int] NOT NULL,
	[INTEGRACION_COMENTARIO] [varchar](200) NULL,
	[TUTOR_NOTA] [int] NOT NULL,
	[TUTOR_COMENTARIO] [varchar](200) NULL,
	[RETRIBUCION_NOTA] [int] NOT NULL,
	[RETRIBUCION_COMENTARIO] [varchar](200) NULL,
	[HORARIO_NOTA] [int] NOT NULL,
	[HORARIO_COMENTARIO] [varchar](200) NULL,
	[FORMACION_NOTA] [int] NOT NULL,
	[FORMACION_COMENTARIO] [varchar](200) NULL,
	[SUPERVISORES_NOTA] [int] NOT NULL,
	[SUPERVISORES_COMENTARIO] [varchar](200) NULL,
	[COMUNICACION_INTERNA_NOTA] [int] NOT NULL,
	[COMUNICACION_INTERNA_COMENTARIO] [varchar](200) NULL,
 CONSTRAINT [PK_DatoCalificacion] PRIMARY KEY CLUSTERED 
(
	[DATO_CALIFICACION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATO_EMPLEADO]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATO_EMPLEADO](
	[DATO_EMPLEADO_ID] [int] IDENTITY(1,1) NOT NULL,
	[CARRERA_ID] [int] NOT NULL,
	[TECNOLOGIA_ID] [int] NOT NULL,
	[TITULACION_ID] [int] NOT NULL,
	[TITULACION_TIPIFICADA_ID] [int] NOT NULL,
	[PROYECTO_ID] [int] NOT NULL,
	[TIEMPO_PROYECTO_ID] [int] NOT NULL,
	[SUPERVISOR] [varchar](50) NOT NULL,
	[TUTOR] [varchar](50) NOT NULL,
	[NUM_EMPLEADO] [int] NOT NULL,
 CONSTRAINT [PK_DatoEmpleado] PRIMARY KEY CLUSTERED 
(
	[DATO_EMPLEADO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATO_ENTREVISTA]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATO_ENTREVISTA](
	[DATO_ENTREVISTA_ID] [int] IDENTITY(1,1) NOT NULL,
	[COMENTARIO_ENTREVISTADOR] [varchar](200) NULL,
	[INFORMACION_SUPERVISOR] [varchar](200) NULL,
	[FECHA_ENTREVISTA] [date] NOT NULL,
	[NOMBRE_ENTREVISTADOR] [varchar](60) NULL,
 CONSTRAINT [PK_DatosEntrevista] PRIMARY KEY CLUSTERED 
(
	[DATO_ENTREVISTA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATO_SALIDA]    Script Date: 03/05/2019 12:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATO_SALIDA](
	[DATOS_SALIDA_ID] [int] IDENTITY(1,1) NOT NULL,
	[TIPO_SALIDA_ID] [int] NOT NULL,
	[MOTIVO_SALIDA_1] [varchar](200) NULL,
	[SUB_MOTIVO_1] [varchar](200) NULL,
	[MOTIVO_SALIDA_2] [varchar](200) NULL,
	[SUB_MOTIVO_2] [varchar](200) NULL,
	[TIPO_BUSQUEDA_ID] [int] NOT NULL,
	[SECTOR_EMPRESA_DESTINO_ID] [int] NULL,
	[TIPO_EMPRESA_DESTINO_ID] [int] NULL,
	[EMPRESA_DESTINO] [varchar](50) NULL,
	[INCREMENTO_SALARIAL] [varchar](50) NULL,
	[NUEVO_PUESTO] [varchar](50) NULL,
	[UBICACION] [varchar](50) NULL,
	[OBSERVACIONES_NUEVO_EMPLEO] [varchar](50) NULL,
	[FECHA_BAJA] [date] NOT NULL,
 CONSTRAINT [PK_DatosSalida] PRIMARY KEY CLUSTERED 
(
	[DATOS_SALIDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[EMPLEADO_ID] [int] IDENTITY(1,1) NOT NULL,
	[NUM_EMPLEADO] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDOS] [varchar](50) NOT NULL,
	[CATEGORIA_ID] [int] NULL,
	[LINEA_ID] [int] NULL,
	[CELDA_ID] [int] NULL,
	[CENTRO_ID] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[EMPLEADO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LINEA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LINEA](
	[LINEA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_LINEA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LINEA] PRIMARY KEY CLUSTERED 
(
	[LINEA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOTIVO_SALIDA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOTIVO_SALIDA](
	[MOTIVO_SALIDA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_MOTIVO_SALIDA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MOTIVO_SALIDA] PRIMARY KEY CLUSTERED 
(
	[MOTIVO_SALIDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROYECTO]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROYECTO](
	[PROYECTO_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_PROYECTO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PROYECTO] PRIMARY KEY CLUSTERED 
(
	[PROYECTO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REGISTRO]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REGISTRO](
	[REGISTRO_ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_EMPLEADO_ID] [int] NOT NULL,
	[FK_DATOS_EMPLEADO_ID] [int] NULL,
	[FK_DATOS_CALIFICAIONES_ID] [int] NULL,
	[FK_DATOS_SALIDA_ID] [int] NULL,
	[FK_DATOS_ENTREVISTA_ID] [int] NULL,
	[FK_STATUS] [int] NOT NULL,
 CONSTRAINT [PK_REGISTRO] PRIMARY KEY CLUSTERED 
(
	[REGISTRO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECTOR]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECTOR](
	[SECTOR_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_SECTOR] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SECTOR] PRIMARY KEY CLUSTERED 
(
	[SECTOR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STATUS]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STATUS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STATUS] [varchar](50) NOT NULL,
 CONSTRAINT [PK_STATUS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TECNOLOGIA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TECNOLOGIA](
	[TECNOLOGIA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TECNOLOGIA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TECNOLOGIA] PRIMARY KEY CLUSTERED 
(
	[TECNOLOGIA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIEMPO_EN_PROYECTO]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIEMPO_EN_PROYECTO](
	[TIEMPO_EN_PROYECTO_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TIEMPO_EN_PROYECTO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIEMPO_EN_PROYECTO] PRIMARY KEY CLUSTERED 
(
	[TIEMPO_EN_PROYECTO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_BUSQUEDA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_BUSQUEDA](
	[TIPO_BUSQUEDA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TIPO_BUSQUEDA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPO_BUSQUEDA] PRIMARY KEY CLUSTERED 
(
	[TIPO_BUSQUEDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_EMPRESA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_EMPRESA](
	[TIPO_EMPRESA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TIPO_EMPRESA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPO_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[TIPO_EMPRESA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_SALIDA]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_SALIDA](
	[TIPO_SALIDA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TIPO_SALIDA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPO_SALIDA] PRIMARY KEY CLUSTERED 
(
	[TIPO_SALIDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TITULACION]    Script Date: 03/05/2019 12:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TITULACION](
	[TITULACION_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_TITULACION] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TITULACION] PRIMARY KEY CLUSTERED 
(
	[TITULACION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_DATO_CALIFICACION] FOREIGN KEY([FK_DATOS_CALIFICAIONES_ID])
REFERENCES [dbo].[DATO_CALIFICACION] ([DATO_CALIFICACION_ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_DATO_CALIFICACION]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_DATO_EMPLEADO] FOREIGN KEY([FK_DATOS_EMPLEADO_ID])
REFERENCES [dbo].[DATO_EMPLEADO] ([DATO_EMPLEADO_ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_DATO_EMPLEADO]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_DATO_ENTREVISTA] FOREIGN KEY([FK_DATOS_ENTREVISTA_ID])
REFERENCES [dbo].[DATO_ENTREVISTA] ([DATO_ENTREVISTA_ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_DATO_ENTREVISTA]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_DATOS_SALIDA] FOREIGN KEY([FK_DATOS_SALIDA_ID])
REFERENCES [dbo].[DATO_SALIDA] ([DATOS_SALIDA_ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_DATOS_SALIDA]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_EMPLEADO] FOREIGN KEY([FK_EMPLEADO_ID])
REFERENCES [dbo].[EMPLEADO] ([EMPLEADO_ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_EMPLEADO]
GO
ALTER TABLE [dbo].[REGISTRO]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_STATUS] FOREIGN KEY([REGISTRO_ID])
REFERENCES [dbo].[STATUS] ([ID])
GO
ALTER TABLE [dbo].[REGISTRO] CHECK CONSTRAINT [FK_REGISTRO_STATUS]
GO
