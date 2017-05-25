--Usuario

USE [FastFood]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_idENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] NOT NULL idENTITY(1,1),
	[usuario] [nchar](50) NOT NULL,
	[password] [nchar](50) NOT NULL,
	[titular] [nchar](50) NOT NULL,
	[rut] [nchar](15) NOT NULL,
	[tipoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



--Pedido

USE [FastFood]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_idENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[id_pedido] [int] NOT NULL idENTITY(1,1),
	[descripcion][nchar](255),
	[valor] [int] NOT NULL,
    [fecha] [DATE] NOT NULL,
    [estado] [nchar](50),
	[usuario_id_usuario] [int] NOT NULL,

 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Usuarios] FOREIGN KEY([usuario_id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO

ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedidos_Usuarios]
GO

--Producto

USE [FastFood]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_idENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] NOT NULL idENTITY(1,1),
    [nombre] [nchar](50) NOT NULL,
    [cantidad] [int] NOT NULL,
    [valor] [int] NOT NULL,
	[pedido_id_pedido] [int],

 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Pedidos] FOREIGN KEY([pedido_id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO

ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Productos_Pedidos]
GO

--Boleta

USE [FastFood]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_idENTIFIER ON
GO
CREATE TABLE [dbo].[Boleta](
	[id_boleta] [int] NOT NULL idENTITY(1,1),
    [descripcion] [nchar](255) NOT NULL,
    [pedido_id_pedido] [int] NOT NULL,

 CONSTRAINT [PK_Boleta] PRIMARY KEY CLUSTERED 
(
	[id_boleta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Boleta]  WITH CHECK ADD  CONSTRAINT [FK_Boletas_Pedidos] FOREIGN KEY([pedido_id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO

ALTER TABLE [dbo].[Boleta] CHECK CONSTRAINT [FK_Boletas_Pedidos]
GO
