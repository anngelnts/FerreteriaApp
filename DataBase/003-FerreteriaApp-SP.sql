/* FERRETERIA MARTIN */
-- PROCEDIMIENTOS ALMACENADOS
USE FerreteriaApp
GO

-- EMPRESA
-- SP MODIFICAR EMPRESA
CREATE PROCEDURE USP_U_ModificarEmpresa
(
	@ID INT,
	@Ruc VARCHAR(20),
	@RazonSocial VARCHAR(200),
	@NombreComercial VARCHAR(200),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(100),
	@Telefono VARCHAR(20)
)
AS
BEGIN
UPDATE TblEmpresa SET 
Ruc = @Ruc,
RazonSocial = @RazonSocial,
NombreComercial = @NombreComercial,
Ciudad = @Ciudad,
Direccion = @Direccion,
Email = @Email,
Telefono = @Telefono
WHERE ID = @ID
END
GO

-- SP SELECCIONAR EMPRESA
CREATE PROCEDURE USP_S_SeleccionarEmpresa
(
	@Ruc VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblEmpresa WHERE Ruc = @Ruc
END
GO

-- TIPO DE EXISTENCIA
-- SP LISTAR TIPO DE EXISTENCIA
CREATE PROCEDURE USP_S_ListarTipoExistencia
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoExistencia
END
GO

-- SP SELECCIONAR TIPO DE EXISTENCIA
CREATE PROCEDURE USP_S_SeleccionarTipoExistencia
(
	@Codigo VARCHAR(10)
)
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoExistencia WHERE Codigo = @Codigo
END
GO

-- UNIDAD DE MEDIDA
-- SP LISTAR UNIDAD DE MEDIDA
CREATE PROCEDURE USP_S_ListarUnidadMedida
AS
BEGIN
SELECT Codigo, Descripcion, Abreviatura FROM TblUnidadMedida
END
GO

-- SP SELECCIONAR UNIDAD DE MEDIDA
CREATE PROCEDURE USP_S_SeleccionarUnidadMedida
(
	@Codigo VARCHAR(10)
)
AS
BEGIN
SELECT Codigo, Descripcion, Abreviatura FROM TblUnidadMedida WHERE Codigo = @Codigo
END
GO

-- TIPO DE OPERACION
-- SP LISTAR TIPO DE OPERACION
CREATE PROCEDURE USP_S_ListarTipoOperacion
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoOperacion
END
GO

-- SP SELECCIONAR UNIDAD DE MEDIDA
CREATE PROCEDURE USP_S_SeleccionarTipoOperacion
(
	@Codigo VARCHAR(10)
)
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoOperacion WHERE Codigo = @Codigo
END
GO

-- TIPO DE COMPROBANTE
-- SP LISTAR TIPO DE COMPROBANTE
CREATE PROCEDURE USP_S_ListarTipoComprobante
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoComprobante
END
GO

-- SP SELECCIONAR UNIDAD DE MEDIDA
CREATE PROCEDURE USP_S_SeleccionarTipoComprobante
(
	@Codigo VARCHAR(10)
)
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoComprobante WHERE Codigo = @Codigo
END
GO

-- DOCUMENTO DE IDENTIDAD
-- SP LISTAR TIPO DE DOCUMENTO DE IDENTIDAD
CREATE PROCEDURE USP_S_ListarTipoDocumentoIdentidad
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoDocumentoIdentidad
END
GO

-- SP SELECCIONAR UNIDAD DE MEDIDA
CREATE PROCEDURE USP_S_SeleccionarTipoDocumentoIdentidad
(
	@Codigo VARCHAR(10)
)
AS
BEGIN
SELECT Codigo, Descripcion FROM TblTipoDocumentoIdentidad WHERE Codigo = @Codigo
END
GO

-- CARGO
-- SP AGREGAR CARGO
CREATE PROCEDURE USP_I_AgregarCargo
(
	@Descripcion VARCHAR(100)
)
AS
BEGIN
INSERT INTO TblCargo(Descripcion) VALUES(@Descripcion)
END
GO

-- SP MODIFICAR CARGO
CREATE PROCEDURE USP_U_ModificarCargo
(
	@ID INT,
	@Descripcion VARCHAR(100)
)
AS
BEGIN
UPDATE TblCargo SET Descripcion = @Descripcion WHERE ID = @ID
END
GO

-- SP LISTAR CARGO
CREATE PROCEDURE USP_S_ListarCargo
AS
BEGIN
SELECT * FROM TblCargo
END
GO

-- SP SELECCIONAR CARGO
CREATE PROCEDURE USP_S_SeleccionarCargo
(
	@ID INT
)
AS
BEGIN
SELECT * FROM TblCargo WHERE ID = @ID
END
GO

-- EMPLEADO
-- SP AGREGAR EMPLEADO
CREATE PROCEDURE USP_I_AgregarEmpleado
(
	@Cargo INT,
	@TipoDocumentoIdentidad VARCHAR(10),
	@NumeroDocumento VARCHAR(20),
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@FechaNacimiento DATE,
	@Pais VARCHAR(100),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(200),
	@Telefono VARCHAR(50),
	@Estado INT
)
AS
BEGIN
INSERT INTO TblEmpleado(Cargo,TipoDocumentoIdentidad,NumeroDocumento,Nombre,Apellido,FechaNacimiento,Pais,Ciudad,Direccion,Email,Telefono,Estado)
VALUES(@Cargo,@TipoDocumentoIdentidad,@NumeroDocumento,@Nombre,@Apellido,@FechaNacimiento,@Pais,@Ciudad,@Direccion,@Email,@Telefono,@Estado)
END
GO

-- SP MODIFICAR EMPLEADO
CREATE PROCEDURE USP_U_ModificarEmpleado
(
	@Cargo INT,
	@NumeroDocumento VARCHAR(20),
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@FechaNacimiento DATE,
	@Pais VARCHAR(100),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(200),
	@Telefono VARCHAR(50)
)
AS
BEGIN
UPDATE TblEmpleado SET
Cargo = @Cargo,
Nombre = @Nombre,
Apellido = @Apellido,
FechaNacimiento = @FechaNacimiento,
Pais = @Pais,
Ciudad = @Ciudad,
Direccion = @Direccion,
Email = @Email,
Telefono = @Telefono
WHERE NumeroDocumento = @NumeroDocumento
END
GO

-- SP LISTAR EMPLEADO
CREATE PROCEDURE USP_S_ListarEmpleado
AS
BEGIN
SELECT * FROM TblEmpleado
END
GO

-- SP SELECCIONAR EMPLEADO
CREATE PROCEDURE USP_S_SeleccionarEmpleado
(
	@NumeroDocumento INT
)
AS
BEGIN
SELECT * FROM TblEmpleado WHERE  NumeroDocumento = @NumeroDocumento
END
GO

-- SP LISTAR EMPLEADO
CREATE PROCEDURE USP_S_BuscarEmpleado
(
	@KeyWoard VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblEmpleado WHERE (NumeroDocumento LIKE '%'+@KeyWoard+'%' OR Apellido LIKE '%'+@KeyWoard+'%')
END
GO

-- SP VERIFICAR NUMERO DOCUMENTO EMPLEADO
CREATE PROCEDURE USP_S_VerificarNumeroDocumentoEmpleado
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT COUNT(*) AS 'Cantidad' FROM TblEmpleado WHERE NumeroDocumento = @NumeroDocumento
END
GO


-- CATEGORIA
-- SP AGREGAR CATEGORIA
CREATE PROCEDURE USP_I_AgregarCategoria
(
	@Nombre VARCHAR(200)
)
AS
BEGIN
INSERT INTO TblCategoria(Nombre) VALUES(@Nombre)
END
GO

-- SP MODIFICAR CATEGORIA
CREATE PROCEDURE USP_U_ModificarCategoria
(
	@ID INT,
	@Nombre VARCHAR(200)
)
AS
BEGIN
UPDATE TblCategoria SET Nombre = @Nombre WHERE ID = @ID
END
GO

-- SP LISTAR CATEGORIA
CREATE PROCEDURE USP_S_ListarCategoria
AS
BEGIN
SELECT * FROM TblCategoria
END
GO

-- SP SELECCIONAR CATEGORIA
CREATE PROCEDURE USP_S_SeleccionarCategoria
(
	@ID INT
)
AS
BEGIN
SELECT * FROM TblCategoria WHERE ID = @ID
END
GO

-- SUB CATEGORIA
-- SP AGREGAR SUB CATEGORIA
CREATE PROCEDURE USP_I_AgregarSubCategoria
(
	@Categoria INT,
	@Nombre VARCHAR(200)
)
AS
BEGIN
INSERT INTO TblSubCategoria(Categoria,Nombre) VALUES(@Categoria,@Nombre)
END
GO


-- SP MODIFICAR SUB CATEGORIA
CREATE PROCEDURE USP_U_ModificarSubCategoria
(
	@ID INT,
	@Categoria INT,
	@Nombre VARCHAR(200)
)
AS
BEGIN
UPDATE TblSubCategoria SET Categoria = @Categoria, Nombre = @Nombre WHERE ID = @ID
END
GO

-- SP LISTAR SUB CATEGORIA
CREATE PROCEDURE USP_S_ListarSubCategoria
AS
BEGIN
SELECT * FROM TblSubCategoria
END
GO

-- SP LISTAR SUB CATEGORIA
CREATE PROCEDURE USP_S_ListarSubCategoriaxCategoria
(
	@Categoria INT
)
AS
BEGIN
SELECT * FROM TblSubCategoria WHERE Categoria = @Categoria
END
GO

-- SP SELECCIONAR SUB CATEGORIA
CREATE PROCEDURE USP_S_SeleccionarSubCategoria
(
	@ID INT
)
AS
BEGIN
SELECT * FROM TblSubCategoria WHERE ID = @ID
END
GO

-- PRODUCTO
-- SP AGREGAR PRODUCTO
CREATE PROCEDURE USP_I_AgregarProducto
(
	@Categoria INT,
	@SubCategoria INT,
	@Codigo VARCHAR(20),
	@Nombre VARCHAR(200),
	@Imagen VARCHAR(200),
	@TipoExistencia VARCHAR(10),
	@UnidadMedida VARCHAR(10),
	@Marca INT,
	@Estado INT
)
AS
BEGIN
INSERT INTO TblProducto(Categoria,SubCategoria,Codigo,Nombre,Imagen,TipoExistencia,UnidadMedida,Marca,Estado)
VALUES(@Categoria,@SubCategoria,@Codigo,@Nombre,@Imagen,@TipoExistencia,@UnidadMedida,@Marca,@Estado)
END
GO

-- SP MODIFICAR PRODUCTO
CREATE PROCEDURE USP_U_ModificarProducto
(
	@Categoria INT,
	@SubCategoria INT,
	@Codigo VARCHAR(20),
	@Nombre VARCHAR(200),
	@Imagen VARCHAR(200),
	@TipoExistencia VARCHAR(10),
	@UnidadMedida VARCHAR(10),
	@Marca INT
)
AS
BEGIN
UPDATE TblProducto SET
Categoria = @Categoria,
SubCategoria = @SubCategoria,
Nombre = @Nombre,
Imagen = @Imagen,
TipoExistencia = @TipoExistencia,
UnidadMedida = @UnidadMedida,
Marca = @Marca
WHERE Codigo = @Codigo
END
GO

-- SP LISTAR PRODUCTO
CREATE PROCEDURE USP_S_ListarProducto
AS
BEGIN
SELECT * FROM TblProducto
END
GO

-- SP SELECCIONAR PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarProducto
(
	@Codigo VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblProducto WHERE Codigo = @Codigo
END
GO

-- SP VERIFICAR NUMERO DOCUMENTO PRODUCTO
CREATE PROCEDURE USP_S_VerificarCodigoProducto
(
	@Codigo VARCHAR(20)
)
AS
BEGIN
SELECT COUNT(*) AS 'Cantidad' FROM TblProducto WHERE Codigo = @Codigo
END
GO

-- SP BUSCAR PRODUCTO
CREATE PROCEDURE USP_S_BuscarProducto
(
	@KeyWoard VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblProducto WHERE (Codigo LIKE '%'+@KeyWoard+'%' OR Nombre LIKE '%'+@KeyWoard+'%')
END
GO

-- MARCA
-- SP AGREGAR MARCA
CREATE PROCEDURE USP_I_AgregarMarca
(
	@Nombre VARCHAR(200)
)
AS
BEGIN
INSERT INTO TblMarca(Nombre) VALUES(@Nombre)
END
GO

-- SP MODIFICAR MARCA
CREATE PROCEDURE USP_U_ModificarMarca
(
	@ID INT,
	@Nombre VARCHAR(200)
)
AS
BEGIN
UPDATE TblMarca SET Nombre = @Nombre WHERE ID = @ID
END
GO

-- SP LISTAR MARCA
CREATE PROCEDURE USP_S_ListarMarca
AS
BEGIN
SELECT * FROM TblMarca
END
GO

-- SP SELECCIONAR MARCA
CREATE PROCEDURE USP_S_SeleccionarMarca
(
	@ID INT
)
AS
BEGIN
SELECT * FROM TblMarca WHERE ID = @ID
END
GO

-- INVENTARIO
-- SP AGREGAR INVENTARIO
CREATE PROCEDURE USP_I_AgregarInventario
(
	@Producto VARCHAR(20),
	@ValorUnitario DECIMAL(10,2),
	@Existencias INT,
	@ValorInventario DECIMAL(10,2)
)
AS
BEGIN
INSERT INTO TblInventario(Producto,ValorUnitario,Existencias,ValorInventario)
VALUES(@Producto,@ValorUnitario,@Existencias,@ValorInventario)
END
GO

-- SP MODIFICAR INVENTARIO
CREATE PROCEDURE USP_U_ModificarInventario
(
	@Producto VARCHAR(20),
	@ValorUnitario DECIMAL(10,2),
	@Existencias INT,
	@ValorInventario DECIMAL(10,2)
)
AS
BEGIN
UPDATE TblInventario SET
ValorUnitario = @ValorUnitario,
Existencias = @Existencias,
ValorInventario = @ValorInventario
WHERE Producto = @Producto
END
GO

-- SP LISTAR INVENTARIO
CREATE PROCEDURE USP_S_ListarInventario
AS
BEGIN
SELECT * FROM TblInventario
END
GO

-- SP SELECCIONAR INVENTARIO
CREATE PROCEDURE USP_S_SeleccionarInventario
(
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblInventario WHERE Producto = @Producto
END
GO

-- SP BUSCAR INVENTARIO
CREATE PROCEDURE USP_S_BuscarInventario
(
	@KeyWoard VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblInventario WHERE (Producto LIKE '%'+@KeyWoard+'%')
END
GO

-- PROVEEDOR
-- SP AGREGAR PROVEEDOR
CREATE PROCEDURE USP_I_AgregarProveedor
(
	@Ruc VARCHAR(20),
	@RazonSocial VARCHAR(200),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(100),
	@Telefono VARCHAR(20)
)
AS
BEGIN
INSERT INTO TblProveedor(Ruc,RazonSocial,Ciudad,Direccion,Email,Telefono)
VALUES(@Ruc,@RazonSocial,@Ciudad,@Direccion,@Email,@Telefono)
END
GO

-- SP MODIFICAR PROVEEDOR
CREATE PROCEDURE USP_U_ModificarProveedor
(
	@Ruc VARCHAR(20),
	@RazonSocial VARCHAR(200),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(100),
	@Telefono VARCHAR(20)
)
AS
BEGIN
UPDATE TblProveedor SET
RazonSocial = @RazonSocial,
Ciudad = @Ciudad,
Direccion = @Direccion,
Email = @Email,
Telefono = @Telefono
WHERE Ruc = @Ruc
END
GO

-- SP LISTAR PROVEEDOR
CREATE PROCEDURE USP_S_ListarProveedor
AS
BEGIN
SELECT * FROM TblProveedor
END
GO

-- SP SELECCIONAR PROVEEDOR
CREATE PROCEDURE USP_S_SeleccionarProveedor
(
	@Ruc VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblProveedor WHERE Ruc = @Ruc
END
GO

-- SP BUSCAR PROVEEDOR
CREATE PROCEDURE USP_S_BuscarProveedor
(
	@KeyWoard VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblProveedor WHERE (Ruc LIKE '%'+@KeyWoard+'%')
END
GO

-- CLIENTE
-- SP AGREGAR CLIENTE
CREATE PROCEDURE USP_I_AgregarCliente
(
	@TipoDocumentoIdentidad VARCHAR(10),
	@NumeroDocumento VARCHAR(20),
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@FechaNacimiento DATE,
	@Pais VARCHAR(100),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(200),
	@Telefono VARCHAR(50),
	@Estado INT
)
AS
BEGIN
INSERT INTO TblCliente(TipoDocumentoIdentidad,NumeroDocumento,Nombre,Apellido,FechaNacimiento,Pais,Ciudad,Direccion,Email,Telefono,Estado)
VALUES(@TipoDocumentoIdentidad,@NumeroDocumento,@Nombre,@Apellido,@FechaNacimiento,@Pais,@Ciudad,@Direccion,@Email,@Telefono,@Estado)
END
GO

-- SP MODIFICAR CLIENTE
CREATE PROCEDURE USP_U_ModificarCliente
(
	@NumeroDocumento VARCHAR(20),
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@FechaNacimiento DATE,
	@Pais VARCHAR(100),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(200),
	@Telefono VARCHAR(50)
)
AS
BEGIN
UPDATE TblCliente SET
Nombre = @Nombre,
Apellido = @Apellido,
FechaNacimiento = @FechaNacimiento,
Pais = @Pais,
Ciudad = @Ciudad,
Direccion = @Direccion,
Email = @Email,
Telefono = @Telefono
WHERE NumeroDocumento = @NumeroDocumento
END
GO

-- SP LISTAR CLIENTE
CREATE PROCEDURE USP_S_ListarCliente
AS
BEGIN
SELECT * FROM TblCliente
END
GO

-- SP SELECCIONAR CLIENTE
CREATE PROCEDURE USP_S_SeleccionarCliente
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblCliente WHERE NumeroDocumento = @NumeroDocumento
END
GO

-- SP VERIFICAR NUMERO DOCUMENTO CLIENTE
CREATE PROCEDURE USP_S_VerificarNumeroDocumentoCliente
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT COUNT(*) AS 'Cantidad' FROM TblCliente WHERE NumeroDocumento = @NumeroDocumento
END
GO

-- SP LISTAR CLIENTE
CREATE PROCEDURE USP_S_BuscarCliente
(
	@KeyWoard VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblCliente WHERE (NumeroDocumento LIKE '%'+@KeyWoard+'%' OR Apellido LIKE '%'+@KeyWoard+'%')
END
GO


-- VENTA
-- SP AGREGAR VENTA
CREATE PROCEDURE USP_I_AgregarVenta
(
	@Cliente INT,
	@Empleado INT,
	@TipoComprobante VARCHAR(10),
	@Serie VARCHAR(4),
	@Numero VARCHAR(8),
	@Fecha DATE,
	@Hora TIME,
	@SubTotal DECIMAL(10,2),
	@Igv DECIMAL(10,2),
	@Total DECIMAL(10,2),
	@Estado INT
)
AS
BEGIN
INSERT INTO TblVenta(Cliente,Empleado,TipoComprobante,Serie,Numero,Fecha,Hora,SubTotal,Igv,Total,Estado)
VALUES(@Cliente,@Empleado,@TipoComprobante,@Serie,@Numero,@Fecha,@Hora,@SubTotal,@Igv,@Total,@Estado)
END
GO

-- SP LISTAR VENTAS
CREATE PROCEDURE USP_S_ListarVentas
AS
BEGIN
SELECT * FROM TblVenta
END
GO

-- SP SELECCIONAR VENTA
CREATE PROCEDURE USP_S_SeleccionarVenta
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT * FROM TblVenta WHERE Serie = @Serie AND Numero = @Numero
END
GO

-- SP ANULAR VENTA
CREATE PROCEDURE USP_U_AnularVenta
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
UPDATE TblVenta SET Estado = 0 WHERE Serie = @Serie AND Numero = @Numero
END
GO

-- DETALLE VENTA
-- SP AGREGAR DETALLE VENTA
CREATE PROCEDURE USP_I_AgregarDetalleVenta
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8),
	@Producto VARCHAR(20),
	@Precio DECIMAL(10,2),
	@Cantidad INT,
	@Importe DECIMAL(10,2)
)
AS
BEGIN
INSERT INTO TblDetalleVenta(Serie,Numero,Producto,Precio,Cantidad,Importe)
VALUES(@Serie,@Numero,@Producto,@Precio,@Cantidad,@Importe)
END
GO

-- SP SELECCIONAR DETALLE VENTA
CREATE PROCEDURE USP_S_SeleccionarDetalleVenta
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT * FROM TblDetalleVenta WHERE Serie = @Serie AND Numero = @Numero
END
GO

-- COMPRA
-- SP AGREGAR COMPRA
CREATE PROCEDURE USP_I_AgregarCompra
(
	@Proveedor INT,
	@Empleado INT,
	@TipoComprobante VARCHAR(10),
	@Serie VARCHAR(4),
	@Numero VARCHAR(8),
	@Fecha DATE,
	@SubTotal DECIMAL(10,2),
	@Igv DECIMAL(10,2),
	@Total DECIMAL(10,2),
	@Estado INT
)
AS
BEGIN
INSERT INTO TblCompra(Proveedor,Empleado,TipoComprobante,Serie,Numero,Fecha,SubTotal,Igv,Total,Estado)
VALUES(@Proveedor,@Empleado,@TipoComprobante,@Serie,@Numero,@Fecha,@SubTotal,@Igv,@Total,@Estado)
END
GO

-- SP LISTAR COMPRAS
CREATE PROCEDURE USP_S_ListarCompras
AS
BEGIN
SELECT * FROM TblCompra
END
GO

-- SP SELECCIONAR COMPRA
CREATE PROCEDURE USP_S_SeleccionarCompra
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT * FROM TblCompra WHERE Serie = @Serie AND Numero = @Numero
END
GO

-- DETALLE COMPRA
-- SP AGREGAR DETALLE COMPRA
CREATE PROCEDURE USP_I_AgregarDetalleCompra
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8),
	@Producto VARCHAR(20),
	@PrecioUnitario DECIMAL(10,2),
	@Cantidad INT,
	@PrecioTotal DECIMAL(10,2)
)
AS
BEGIN
INSERT INTO TblDetalleCompra(Serie,Numero,Producto,PrecioUnitario,Cantidad,PrecioTotal)
VALUES(@Serie,@Numero,@Producto,@PrecioUnitario,@Cantidad,@PrecioTotal)
END
GO

-- SP SELECCIONAR DETALLE COMPRA
CREATE PROCEDURE USP_S_SeleccionarDetalleCompra
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT * FROM TblDetalleCompra WHERE Serie = @Serie AND Numero = @Numero
END
GO


-- MOVIMIENTO (KARDEX)
-- SP AGREGAR MOVIMIENTO
CREATE PROCEDURE USP_I_AgregarMovimiento
(
	@Fecha DATE,
	@TipoComprobante VARCHAR(10),
	@Serie VARCHAR(4),
	@Numero VARCHAR(8),
	@TipoOperacion VARCHAR(10),
	@Producto VARCHAR(20),
	@CantidadEntrada INT,
	@CostoUnitarioEntrada DECIMAL(10,2),
	@CostoTotalEntrada DECIMAL(10,2),
	@CantidadSalida INT,
	@CostoUnitarioSalida DECIMAL(10,2),
	@CostoTotalSalida DECIMAL(10,2),
	@CantidadFinal INT,
	@CostoUnitarioFinal DECIMAL(10,2),
	@CostoTotalFinal DECIMAL(10,2)
)
AS
BEGIN
INSERT INTO TblMovimiento(Fecha,TipoComprobante,Serie,Numero,TipoOperacion,Producto,CantidadEntrada,CostoUnitarioEntrada,CostoTotalEntrada,CantidadSalida,CostoUnitarioSalida,CostoTotalSalida,CantidadFinal,CostoUnitarioFinal,CostoTotalFinal)
VALUES(@Fecha,@TipoComprobante,@Serie,@Numero,@TipoOperacion,@Producto,@CantidadEntrada,@CostoUnitarioEntrada,@CostoTotalEntrada,@CantidadSalida,@CostoUnitarioSalida,@CostoTotalSalida,@CantidadFinal,@CostoUnitarioFinal,@CostoTotalFinal)
END
GO

-- SP LISTAR MOVIMIENTOS
CREATE PROCEDURE USP_S_ListarMovimientos
AS
BEGIN
SELECT * FROM TblMovimiento
END
GO

-- SP SELECCIONAR MOVIMIENTO PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarMovimientoProducto
(
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblMovimiento WHERE Producto = @Producto
END
GO

-- SP SELECCIONAR MOVIMIENTO POR FECHAS PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarMovimientoFechasProducto
(
	@FirstDate DATE,
	@LastDate DATE,
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblMovimiento WHERE Fecha BETWEEN @FirstDate AND @LastDate AND Producto = @Producto
END
GO

-- SP SELECCIONAR MOVIMIENTO POR PERIODO PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarMovimientoPeriodoProducto
(
	@Periodo DATE,
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblMovimiento WHERE YEAR(Fecha) = YEAR(@Periodo) AND Producto = @Producto
END
GO


-- SP SELECCIONAR ULTIMO MOVIMIENTO DEL PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarUltimoMovimientoProducto
(
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT TOP 1 * FROM TblMovimiento WHERE Producto = @Producto ORDER BY ID DESC
END
GO

-- SP SELECCIONAR ULTIMO MOVIMIENTO DEL PRODUCTO SALDO FINAL
CREATE PROCEDURE USP_S_SeleccionarUltimoMovimientoProductoFinal
(
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT TOP 1 CantidadFinal, CostoUnitarioFinal, CostoTotalFinal FROM TblMovimiento WHERE Producto = @Producto ORDER BY ID DESC
END
GO


-- USUARIO
-- SP AGREGAR USUARIO
CREATE PROCEDURE USP_I_AgregarUsuario
(
	@Username VARCHAR(100),
	@Password VARCHAR(200),
	@Estado INT
)
AS
BEGIN
INSERT INTO TblUsuario(Username,Password,Estado) VALUES(@Username,@Password,@Estado)
END
GO

-- SP CAMBIAR CLAVE USUARIO
CREATE PROCEDURE USP_U_CambiarClaveUsuario
(
	@Username VARCHAR(100),
	@Password VARCHAR(200)
)
AS
BEGIN
UPDATE TblUsuario SET Password = @Password WHERE Username = @Username
END
GO

-- SP LOGIN USUARIO
CREATE PROCEDURE USP_S_LoginUsuario
(
	@Username VARCHAR(100),
	@Password VARCHAR(200)
)
AS
BEGIN
SELECT * FROM TblUsuario WHERE Username = @Username AND Password = @Password
END
GO

-- SP OBTENER PERFIL BASICO USUARIO
CREATE PROCEDURE USP_S_PerfilBasicoUsuario
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT E.Nombre, E.Apellido, C.Descripcion FROM TblEmpleado AS E LEFT JOIN TblCargo AS C ON E.Cargo = C.ID WHERE E.NumeroDocumento = @NumeroDocumento
END
GO


-- SP OBTENER INFORMACION DEL EMPLEADO
CREATE PROCEDURE USP_S_ObtenerInformacionEmpleado
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT TD.Descripcion, E.NumeroDocumento, C.Descripcion, E.Nombre, E.Apellido, E.FechaNacimiento, E.Pais, E.Ciudad, E.Direccion, E.Email, E.Telefono 
FROM TblEmpleado AS E LEFT JOIN TblCargo AS C ON E.Cargo = C.ID LEFT JOIN TblTipoDocumentoIdentidad AS TD ON E.TipoDocumentoIdentidad = TD.Codigo 
WHERE E.NumeroDocumento = @NumeroDocumento
END
GO

-- SP MODIFICAR EMPLEADO POR USUARIO
CREATE PROCEDURE USP_U_ModificarEmpleadoUsuario
(
	@NumeroDocumento VARCHAR(20),
	@Nombre VARCHAR(100),
	@Apellido VARCHAR(100),
	@FechaNacimiento DATE,
	@Pais VARCHAR(100),
	@Ciudad VARCHAR(100),
	@Direccion VARCHAR(200),
	@Email VARCHAR(200),
	@Telefono VARCHAR(50)
)
AS
BEGIN
UPDATE TblEmpleado SET
Nombre = @Nombre,
Apellido = @Apellido,
FechaNacimiento = @FechaNacimiento,
Pais = @Pais,
Ciudad = @Ciudad,
Direccion = @Direccion,
Email = @Email,
Telefono = @Telefono
WHERE NumeroDocumento = @NumeroDocumento
END
GO

-- SP OBTENER ID EMPLEADO
CREATE PROCEDURE USP_S_ObtenerIDEmpleado
(
	@NumeroDocumento VARCHAR(20)
)
AS
BEGIN
SELECT ID FROM TblEmpleado WHERE NumeroDocumento = @NumeroDocumento
END
GO


--- NUEVOS 07/11/2018
-- VISTA PREVIA VENTA
-- SP SELECCIONAR DETALLE DE VENTA (DETALLADO)
CREATE PROCEDURE USP_S_SeleccionarDetalleVentaInfo
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT DV.ID, DV.Serie, DV.Numero, P.Codigo, P.Nombre, UM.Abreviatura AS 'Unidad', DV.Precio, DV.Cantidad, DV.Importe 
FROM TblDetalleVenta AS DV LEFT JOIN TblProducto AS P ON DV.Producto = P.Codigo
LEFT JOIN TblUnidadMedida AS UM ON P.UnidadMedida = UM.Codigo WHERE DV.Serie = @Serie AND DV.Numero = @Numero
END
GO

-- SP SELECCIONAR INFORMACION DE VENTA (DETALLADO)
CREATE PROCEDURE USP_S_SeleccionarVentaInfo
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT V.ID, TC.Descripcion AS 'Tipo', V.Serie, V.Numero, V.Fecha, V.SubTotal, V.Igv, V.Total,
C.NumeroDocumento AS 'NDC', C.Nombre AS 'CNombre', C.Apellido AS 'CApellido', C.Ciudad AS 'CCiudad', C.Direccion AS 'CDireccion',
E.NumeroDocumento AS 'NDE', E.Nombre AS 'ENombre', E.Apellido AS 'EApellido'
FROM TblVenta AS V 
LEFT JOIN TblTipoComprobante AS TC ON TC.Codigo = V.TipoComprobante
LEFT JOIN TblCliente AS C ON C.ID = V.Cliente 
LEFT JOIN TblEmpleado AS E ON E.ID = V.Empleado WHERE V.Serie = @Serie AND V.Numero = @Numero
END
GO


--- NUEVOS 07/11/2018
-- VISTA PREVIA COMPRA
-- SP SELECCIONAR DETALLE DE COMPRA (DETALLADO)
CREATE PROCEDURE USP_S_SeleccionarDetalleCompraInfo
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT DC.ID, DC.Serie, DC.Numero, P.Codigo, P.Nombre, UM.Abreviatura AS 'Unidad', DC.PrecioUnitario, DC.Cantidad, DC.PrecioTotal 
FROM TblDetalleCompra AS DC LEFT JOIN TblProducto AS P ON DC.Producto = P.Codigo
LEFT JOIN TblUnidadMedida AS UM ON P.UnidadMedida = UM.Codigo WHERE DC.Serie = @Serie AND DC.Numero = @Numero
END
GO

-- SP SELECCIONAR INFORMACION DE COMPRA (DETALLADO)
CREATE PROCEDURE USP_S_SeleccionarCompraInfo
(
	@Serie VARCHAR(4),
	@Numero VARCHAR(8)
)
AS
BEGIN
SELECT C.ID, TC.Descripcion AS 'Tipo', C.Serie, C.Numero, C.Fecha, C.SubTotal, C.Igv, C.Total,
P.Ruc AS 'RUC', P.RazonSocial AS 'RazonSocial', P.Email, P.Telefono, P.Ciudad AS 'PCiudad', P.Direccion AS 'PDireccion',
E.NumeroDocumento AS 'NDE', E.Nombre AS 'ENombre', E.Apellido AS 'EApellido'
FROM TblCompra AS C 
LEFT JOIN TblTipoComprobante AS TC ON TC.Codigo = C.TipoComprobante
LEFT JOIN TblProveedor AS P ON P.ID = C.Proveedor 
LEFT JOIN TblEmpleado AS E ON E.ID = C.Empleado WHERE C.Serie = @Serie AND C.Numero = @Numero
END
GO

-- SP LISTAR COMPRAS POR FECHAS
CREATE PROCEDURE USP_S_ListarCompraxFecha
(
	@FirstDate DATE,
	@LastDate DATE
)
AS
BEGIN
SELECT * FROM TblCompra WHERE Fecha BETWEEN @FirstDate AND @LastDate
END
GO

-- SP LISTAR VENTAS POR FECHAS
CREATE PROCEDURE USP_S_ListarVentaxFecha
(
	@FirstDate DATE,
	@LastDate DATE
)
AS
BEGIN
SELECT * FROM TblVenta WHERE Fecha BETWEEN @FirstDate AND @LastDate
END
GO

-- SP SELECCIONAR MOVIMIENTO POR PERIODO PRODUCTO
CREATE PROCEDURE USP_S_SeleccionarMovimientoxPeriodoProducto
(
	@Periodo VARCHAR(20),
	@Producto VARCHAR(20)
)
AS
BEGIN
SELECT * FROM TblMovimiento WHERE YEAR(Fecha) = @Periodo AND Producto = @Producto
END
GO