USE [FerreteriaApp]
GO
SET IDENTITY_INSERT [dbo].[TblTipoExistencia] ON 

INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (1, N'01', N'MERCADERÍA')
INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (2, N'02', N'PRODUCTO TERMINADO')
INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (3, N'03', N'MATERIAS PRIMAS Y AUXILIARES - MATERIALES')
INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (4, N'04', N'ENVASES Y EMBALAJES')
INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (5, N'05', N'SUMINISTROS DIVERSOS')
INSERT [dbo].[TblTipoExistencia] ([ID], [Codigo], [Descripcion]) VALUES (6, N'99', N'OTROS (ESPECIFICAR)')
SET IDENTITY_INSERT [dbo].[TblTipoExistencia] OFF
SET IDENTITY_INSERT [dbo].[TblUnidadMedida] ON 

INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (1, N'01', N'KILOGRAMOS', N'KG')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (2, N'02', N'LIBRAS', N'LB')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (3, N'03', N'TONELADAS LARGAS', N'TL')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (4, N'04', N'TONELADAS MÉTRICAS', N'TM')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (5, N'05', N'TONELADAS CORTAS', N'TC')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (6, N'06', N'GRAMOS', N'G')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (7, N'07', N'UNIDADES', N'UD')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (8, N'08', N'LITROS', N'LT')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (9, N'09', N'GALONES', N'GAL')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (10, N'10', N'BARRILES', N'BRR')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (11, N'11', N'LATAS', N'LA')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (12, N'12', N'CAJAS', N'CAJ')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (13, N'13', N'MILLARES', N'MLL')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (14, N'14', N'METROS CÚBICOS', N'CM')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (15, N'15', N'METROS', N'M')
INSERT [dbo].[TblUnidadMedida] ([ID], [Codigo], [Descripcion], [Abreviatura]) VALUES (16, N'99', N'OTROS (ESPECIFICAR)', N'NA')
SET IDENTITY_INSERT [dbo].[TblUnidadMedida] OFF
SET IDENTITY_INSERT [dbo].[TblMarca] ON 

INSERT [dbo].[TblMarca] ([ID], [Nombre]) VALUES (1, N'Tekno')
INSERT [dbo].[TblMarca] ([ID], [Nombre]) VALUES (2, N'Vencedor')
INSERT [dbo].[TblMarca] ([ID], [Nombre]) VALUES (3, N'CPP')
SET IDENTITY_INSERT [dbo].[TblMarca] OFF
SET IDENTITY_INSERT [dbo].[TblCategoria] ON 

INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (1, N'Pinturas')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (2, N'Pegamentos y Cola')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (3, N'Techos y Tanques')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (4, N'Accesorios para el Hogar')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (5, N'Drywall')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (6, N'Ferreteria')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (7, N'Herramientas')
INSERT [dbo].[TblCategoria] ([ID], [Nombre]) VALUES (8, N'Pisos')
SET IDENTITY_INSERT [dbo].[TblCategoria] OFF
SET IDENTITY_INSERT [dbo].[TblSubCategoria] ON 

INSERT [dbo].[TblSubCategoria] ([ID], [Categoria], [Nombre]) VALUES (2, 1, N'Látex')
INSERT [dbo].[TblSubCategoria] ([ID], [Categoria], [Nombre]) VALUES (3, 1, N'Esmalte')
INSERT [dbo].[TblSubCategoria] ([ID], [Categoria], [Nombre]) VALUES (4, 7, N'Herramientas Eléctricas')
INSERT [dbo].[TblSubCategoria] ([ID], [Categoria], [Nombre]) VALUES (5, 8, N'Laminados')
INSERT [dbo].[TblSubCategoria] ([ID], [Categoria], [Nombre]) VALUES (6, 6, N'Bisagras')
SET IDENTITY_INSERT [dbo].[TblSubCategoria] OFF
SET IDENTITY_INSERT [dbo].[TblProducto] ON 

INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (2, 1, 2, N'SNT.PI.000034', N'Pintura Latex Pintek Crema x 1GL', N'SNT.PI.000034.jpg', N'01', N'09', 1, 1)
INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (5, 1, 2, N'SNT.PI.000106', N'Pintura Latex Supermate Cactus X 1GL', N'SNT.PI.000106.jpg', N'01', N'09', 2, 1)
INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (6, 1, 2, N'SNT.PI.000119', N'Pintura Latex Vencelatex Blanco X 1GL', N'SNT.PI.000119.jpg', N'01', N'09', 2, 1)
INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (3, 1, 2, N'SNT.PI.000238', N'Pintura Latex Tekno Color Azul Ege x 1GL', N'SNT.PI.000238.jpg', N'01', N'09', 1, 1)
INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (7, 1, 2, N'SNT.PI.000609', N'Pintura Esmalte Pato Celeste CPP X 1GL', N'SNT.PI.000609.jpg', N'01', N'09', 3, 1)
INSERT [dbo].[TblProducto] ([ID], [Categoria], [SubCategoria], [Codigo], [Nombre], [Imagen], [TipoExistencia], [UnidadMedida], [Marca], [Estado]) VALUES (4, 1, 2, N'SNT.PI.000932', N'Pintura Latex Alabastro Tekno X 1GL', N'SNT.PI.000932.jpg', N'01', N'09', 1, 1)
SET IDENTITY_INSERT [dbo].[TblProducto] OFF
SET IDENTITY_INSERT [dbo].[TblTipoOperacion] ON 

INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (1, N'01', N'VENTA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (2, N'02', N'COMPRA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (3, N'03', N'CONSIGNACIÓN RECIBIDA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (4, N'04', N'CONSIGNACIÓN ENTREGADA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (5, N'05', N'DEVOLUCIÓN RECIBIDA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (6, N'06', N'DEVOLUCIÓN ENTREGADA')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (7, N'07', N'PROMOCIÓN')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (8, N'08', N'PREMIO')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (9, N'09', N'DONACIÓN')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (10, N'10', N'SALIDA A PRODUCCIÓN')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (11, N'11', N'TRANSFERENCIA ENTRE ALMACENES')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (12, N'12', N'RETIRO')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (13, N'13', N'MERMAS')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (14, N'14', N'DESMEDROS')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (15, N'15', N'DESTRUCCIÓN')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (16, N'16', N'SALDO INICIAL')
INSERT [dbo].[TblTipoOperacion] ([ID], [Codigo], [Descripcion]) VALUES (17, N'99', N'OTROS (ESPECIFICAR)')
SET IDENTITY_INSERT [dbo].[TblTipoOperacion] OFF
SET IDENTITY_INSERT [dbo].[TblTipoComprobante] ON 

INSERT [dbo].[TblTipoComprobante] ([ID], [Codigo], [Descripcion]) VALUES (1, N'01', N'FACTURA')
INSERT [dbo].[TblTipoComprobante] ([ID], [Codigo], [Descripcion]) VALUES (2, N'03', N'BOLETA DE VENTA')
INSERT [dbo].[TblTipoComprobante] ([ID], [Codigo], [Descripcion]) VALUES (3, N'07', N'NOTA DE CRÉDITO')
INSERT [dbo].[TblTipoComprobante] ([ID], [Codigo], [Descripcion]) VALUES (4, N'08', N'NOTA DE DÉBITO')
INSERT [dbo].[TblTipoComprobante] ([ID], [Codigo], [Descripcion]) VALUES (5, N'09', N'GUÍA DE REMISIÓN - REMITENTE')
SET IDENTITY_INSERT [dbo].[TblTipoComprobante] OFF
SET IDENTITY_INSERT [dbo].[TblMovimiento] ON 

INSERT [dbo].[TblMovimiento] ([ID], [Fecha], [TipoComprobante], [Serie], [Numero], [TipoOperacion], [Producto], [CantidadEntrada], [CostoUnitarioEntrada], [CostoTotalEntrada], [CantidadSalida], [CostoUnitarioSalida], [CostoTotalSalida], [CantidadFinal], [CostoUnitarioFinal], [CostoTotalFinal]) VALUES (1, CAST(N'2018-11-06' AS Date), N'01', N'F000', N'00000001', N'02', N'SNT.PI.000034', 10, CAST(18.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 10, CAST(18.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)))
INSERT [dbo].[TblMovimiento] ([ID], [Fecha], [TipoComprobante], [Serie], [Numero], [TipoOperacion], [Producto], [CantidadEntrada], [CostoUnitarioEntrada], [CostoTotalEntrada], [CantidadSalida], [CostoUnitarioSalida], [CostoTotalSalida], [CantidadFinal], [CostoUnitarioFinal], [CostoTotalFinal]) VALUES (2, CAST(N'2018-11-06' AS Date), N'01', N'F000', N'00000001', N'02', N'SNT.PI.000106', 5, CAST(18.00 AS Decimal(10, 2)), CAST(90.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 5, CAST(18.00 AS Decimal(10, 2)), CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[TblMovimiento] ([ID], [Fecha], [TipoComprobante], [Serie], [Numero], [TipoOperacion], [Producto], [CantidadEntrada], [CostoUnitarioEntrada], [CostoTotalEntrada], [CantidadSalida], [CostoUnitarioSalida], [CostoTotalSalida], [CantidadFinal], [CostoUnitarioFinal], [CostoTotalFinal]) VALUES (3, CAST(N'2018-11-06' AS Date), N'01', N'F001', N'00000002', N'02', N'SNT.PI.000034', 20, CAST(18.50 AS Decimal(10, 2)), CAST(370.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 30, CAST(18.33 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)))
INSERT [dbo].[TblMovimiento] ([ID], [Fecha], [TipoComprobante], [Serie], [Numero], [TipoOperacion], [Producto], [CantidadEntrada], [CostoUnitarioEntrada], [CostoTotalEntrada], [CantidadSalida], [CostoUnitarioSalida], [CostoTotalSalida], [CantidadFinal], [CostoUnitarioFinal], [CostoTotalFinal]) VALUES (4, CAST(N'2018-11-07' AS Date), N'01', N'F001', N'00000001', N'01', N'SNT.PI.000034', 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 5, CAST(18.33 AS Decimal(10, 2)), CAST(91.65 AS Decimal(10, 2)), 25, CAST(18.33 AS Decimal(10, 2)), CAST(458.35 AS Decimal(10, 2)))
INSERT [dbo].[TblMovimiento] ([ID], [Fecha], [TipoComprobante], [Serie], [Numero], [TipoOperacion], [Producto], [CantidadEntrada], [CostoUnitarioEntrada], [CostoTotalEntrada], [CantidadSalida], [CostoUnitarioSalida], [CostoTotalSalida], [CantidadFinal], [CostoUnitarioFinal], [CostoTotalFinal]) VALUES (5, CAST(N'2018-11-07' AS Date), N'03', N'B001', N'00000001', N'01', N'SNT.PI.000034', 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 2, CAST(18.33 AS Decimal(10, 2)), CAST(36.66 AS Decimal(10, 2)), 23, CAST(18.33 AS Decimal(10, 2)), CAST(421.69 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[TblMovimiento] OFF
SET IDENTITY_INSERT [dbo].[TblTipoDocumentoIdentidad] ON 

INSERT [dbo].[TblTipoDocumentoIdentidad] ([ID], [Codigo], [Descripcion]) VALUES (1, N'0', N'OTROS TIPOS DE DOCUMENTOS')
INSERT [dbo].[TblTipoDocumentoIdentidad] ([ID], [Codigo], [Descripcion]) VALUES (2, N'1', N'DOCUMENTO NACIONAL DE IDENTIDAD (DNI)')
INSERT [dbo].[TblTipoDocumentoIdentidad] ([ID], [Codigo], [Descripcion]) VALUES (3, N'4', N'CARNET DE EXTRANJERIA')
INSERT [dbo].[TblTipoDocumentoIdentidad] ([ID], [Codigo], [Descripcion]) VALUES (4, N'6', N'REGISTRO ÚNICO DE CONTRIBUYENTES')
INSERT [dbo].[TblTipoDocumentoIdentidad] ([ID], [Codigo], [Descripcion]) VALUES (5, N'7', N'PASAPORTE')
SET IDENTITY_INSERT [dbo].[TblTipoDocumentoIdentidad] OFF
SET IDENTITY_INSERT [dbo].[TblCliente] ON 

INSERT [dbo].[TblCliente] ([ID], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (5, N'1', N'04639566', N'Magaly', N'Eyzaguirre Retamozo', CAST(N'1995-09-30' AS Date), N'Perú', N'Tacna', N'tacna', N'magalier@yahoo.com', N'', 1)
INSERT [dbo].[TblCliente] ([ID], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (2, N'1', N'16368713', N'Gerardo Esteban', N'Gomez Orellana', CAST(N'1987-07-09' AS Date), N'Perú', N'Tacna', N'Tacna', N'gerardo.gomez9787@gmail.com', N'995892329', 1)
INSERT [dbo].[TblCliente] ([ID], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (4, N'1', N'72169768', N'Lilia del Carmen', N'Guevara Liria', CAST(N'1999-03-29' AS Date), N'Perú', N'Tacna', N'Tacna', N'lilita.2008@hotmail.com', N'952004522', 1)
INSERT [dbo].[TblCliente] ([ID], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (3, N'1', N'72630980', N'Daniela Nicole', N'Ticona Loloy', CAST(N'1992-07-17' AS Date), N'Perú', N'Tacna', N'Tacna', N'', N'', 1)
INSERT [dbo].[TblCliente] ([ID], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (1, N'1', N'74358190', N'Hector', N'Torres Alvarez', CAST(N'1956-07-17' AS Date), N'Perú', N'Perú', N'Perú', N'vlidice@vtr.net', N'951026245', 1)
SET IDENTITY_INSERT [dbo].[TblCliente] OFF
SET IDENTITY_INSERT [dbo].[TblCargo] ON 

INSERT [dbo].[TblCargo] ([ID], [Descripcion]) VALUES (1, N'Vendedor')
INSERT [dbo].[TblCargo] ([ID], [Descripcion]) VALUES (2, N'Gerente')
SET IDENTITY_INSERT [dbo].[TblCargo] OFF
SET IDENTITY_INSERT [dbo].[TblEmpleado] ON 

INSERT [dbo].[TblEmpleado] ([ID], [Cargo], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (1, 2, N'1', N'46735151', N'Luis Angel', N'Moreno Mulluni', CAST(N'2018-11-06' AS Date), N'Perú', N'Tacna', N'Tacna', N'Anngel.Nts@gmail.com', N'951026112', 1)
INSERT [dbo].[TblEmpleado] ([ID], [Cargo], [TipoDocumentoIdentidad], [NumeroDocumento], [Nombre], [Apellido], [FechaNacimiento], [Pais], [Ciudad], [Direccion], [Email], [Telefono], [Estado]) VALUES (2, 1, N'1', N'46735152', N'Luis', N'Moreno', CAST(N'2018-11-03' AS Date), N'Perú', N'Tacna', N'Tacna', N'Anngel.Nts@hotmail.com', N'951026112', 1)
SET IDENTITY_INSERT [dbo].[TblEmpleado] OFF
SET IDENTITY_INSERT [dbo].[TblVenta] ON 

INSERT [dbo].[TblVenta] ([ID], [Cliente], [Empleado], [TipoComprobante], [Serie], [Numero], [Fecha], [Hora], [SubTotal], [Igv], [Total], [Estado]) VALUES (2, 4, 1, N'03', N'B001', N'00000001', CAST(N'2018-11-07' AS Date), NULL, CAST(40.39 AS Decimal(10, 2)), CAST(7.27 AS Decimal(10, 2)), CAST(47.66 AS Decimal(10, 2)), 1)
INSERT [dbo].[TblVenta] ([ID], [Cliente], [Empleado], [TipoComprobante], [Serie], [Numero], [Fecha], [Hora], [SubTotal], [Igv], [Total], [Estado]) VALUES (1, 5, 1, N'01', N'F001', N'00000001', CAST(N'2018-11-07' AS Date), NULL, CAST(100.97 AS Decimal(10, 2)), CAST(18.18 AS Decimal(10, 2)), CAST(119.15 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[TblVenta] OFF
SET IDENTITY_INSERT [dbo].[TblProveedor] ON 

INSERT [dbo].[TblProveedor] ([ID], [Ruc], [RazonSocial], [Ciudad], [Direccion], [Email], [Telefono]) VALUES (7, N'20100073723', N'CORPORACION PERUANA DE PRODUCTOS QUIMICOS S.A. - CPPQ S.A.', N'El Agustino, Lima, Perú', N'Av. Cesar Vallejo Nro. 1851 Zona Cerenza (Puente la Atarjea)', N'ventas@cppq.com.pe', N'6126000')
INSERT [dbo].[TblProveedor] ([ID], [Ruc], [RazonSocial], [Ciudad], [Direccion], [Email], [Telefono]) VALUES (1, N'20451603788', N'APYD DISTRIBUIDORA SAC', N'Ate, Lima, Perú', N'Av. Prol. Javier Prado Este Nro. 7315 Int. 101', N'ventas@apyd.com.pe', N'6239534')
SET IDENTITY_INSERT [dbo].[TblProveedor] OFF
SET IDENTITY_INSERT [dbo].[TblCompra] ON 

INSERT [dbo].[TblCompra] ([ID], [Proveedor], [Empleado], [TipoComprobante], [Serie], [Numero], [Fecha], [SubTotal], [Igv], [Total], [Estado]) VALUES (1, 7, 1, N'01', N'F000', N'00000001', CAST(N'2018-11-06' AS Date), CAST(228.81 AS Decimal(10, 2)), CAST(41.19 AS Decimal(10, 2)), CAST(270.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[TblCompra] ([ID], [Proveedor], [Empleado], [TipoComprobante], [Serie], [Numero], [Fecha], [SubTotal], [Igv], [Total], [Estado]) VALUES (2, 1, 1, N'01', N'F001', N'00000002', CAST(N'2018-11-06' AS Date), CAST(313.56 AS Decimal(10, 2)), CAST(56.44 AS Decimal(10, 2)), CAST(370.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[TblCompra] OFF
SET IDENTITY_INSERT [dbo].[TblDetalleVenta] ON 

INSERT [dbo].[TblDetalleVenta] ([ID], [Serie], [Numero], [Producto], [Precio], [Cantidad], [Importe]) VALUES (1, N'F001', N'00000001', N'SNT.PI.000034', CAST(23.83 AS Decimal(10, 2)), 5, CAST(119.15 AS Decimal(10, 2)))
INSERT [dbo].[TblDetalleVenta] ([ID], [Serie], [Numero], [Producto], [Precio], [Cantidad], [Importe]) VALUES (2, N'B001', N'00000001', N'SNT.PI.000034', CAST(23.83 AS Decimal(10, 2)), 2, CAST(47.66 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[TblDetalleVenta] OFF
SET IDENTITY_INSERT [dbo].[TblDetalleCompra] ON 

INSERT [dbo].[TblDetalleCompra] ([ID], [Serie], [Numero], [Producto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (1, N'F000', N'00000001', N'SNT.PI.000034', CAST(18.00 AS Decimal(10, 2)), 10, CAST(180.00 AS Decimal(10, 2)))
INSERT [dbo].[TblDetalleCompra] ([ID], [Serie], [Numero], [Producto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (2, N'F000', N'00000001', N'SNT.PI.000106', CAST(18.00 AS Decimal(10, 2)), 5, CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[TblDetalleCompra] ([ID], [Serie], [Numero], [Producto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (3, N'F001', N'00000002', N'SNT.PI.000034', CAST(18.50 AS Decimal(10, 2)), 20, CAST(370.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[TblDetalleCompra] OFF
SET IDENTITY_INSERT [dbo].[TblInventario] ON 

INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (1, N'SNT.PI.000034', CAST(18.33 AS Decimal(10, 2)), 23, CAST(421.69 AS Decimal(10, 2)))
INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (2, N'SNT.PI.000238', CAST(0.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (3, N'SNT.PI.000932', CAST(0.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (4, N'SNT.PI.000106', CAST(18.00 AS Decimal(10, 2)), 5, CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (5, N'SNT.PI.000119', CAST(0.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[TblInventario] ([ID], [Producto], [ValorUnitario], [Existencias], [ValorInventario]) VALUES (6, N'SNT.PI.000609', CAST(0.00 AS Decimal(10, 2)), 0, CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[TblInventario] OFF
SET IDENTITY_INSERT [dbo].[TblUsuario] ON 

INSERT [dbo].[TblUsuario] ([ID], [Username], [Password], [Estado]) VALUES (1, N'46735151', N'123', 1)
INSERT [dbo].[TblUsuario] ([ID], [Username], [Password], [Estado]) VALUES (2, N'46735152', N'46735152', 1)
SET IDENTITY_INSERT [dbo].[TblUsuario] OFF
