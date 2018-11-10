/* FERRETERIA MARTIN */
--CREATE DATABASE FerreteriaApp
USE FerreteriaApp
GO

-- TABLA EMPRESA
CREATE TABLE TblEmpresa
(
	ID INT IDENTITY(1,1),
	Ruc VARCHAR(20),
	RazonSocial VARCHAR(200),
	NombreComercial VARCHAR(200),
	Ciudad VARCHAR(100),
	Direccion VARCHAR(200),
	Email VARCHAR(100),
	Telefono VARCHAR(20),
	PRIMARY KEY (ID),
	UNIQUE (Ruc)
)

-- TABLA TIPO DE EXISTENCIA
CREATE TABLE TblTipoExistencia
(
	ID INT IDENTITY(1,1),
	Codigo VARCHAR(10),
	Descripcion VARCHAR(200),
	PRIMARY KEY (ID),
	UNIQUE (Codigo)
)

-- TABLA UNIDAD DE MEDIDA
CREATE TABLE TblUnidadMedida
(
	ID INT IDENTITY(1,1),
	Codigo VARCHAR(10),
	Descripcion VARCHAR(200),
	Abreviatura VARCHAR(10),
	PRIMARY KEY (ID),
	UNIQUE (Codigo)
)

-- TABLA TIPO DE OPERACION
CREATE TABLE TblTipoOperacion
(
	ID INT IDENTITY(1,1),
	Codigo VARCHAR(10),
	Descripcion VARCHAR(200),
	PRIMARY KEY (ID),
	UNIQUE (Codigo)
)

-- TABLA TIPO DE COMPROBANTE DE PAGO O DOCUMENTO
CREATE TABLE TblTipoComprobante
(
	ID INT IDENTITY(1,1),
	Codigo VARCHAR(10),
	Descripcion VARCHAR(200),
	PRIMARY KEY (ID),
	UNIQUE (Codigo)
)

-- TABLA TIPO DE DOCUMENTO DE IDENTIDAD
CREATE TABLE TblTipoDocumentoIdentidad
(
	ID INT IDENTITY(1,1),
	Codigo VARCHAR(10),
	Descripcion VARCHAR(200),
	PRIMARY KEY (ID),
	UNIQUE (Codigo)
)

-- TABLA MARCA DE PRODUCTO
CREATE TABLE TblMarca
(
	ID INT IDENTITY(1,1),
	Nombre VARCHAR(200),
	PRIMARY KEY (ID)
)

-- TABLA CATEGORIA
CREATE TABLE TblCategoria
(
	ID INT IDENTITY(1,1),
	Nombre VARCHAR(200),
	PRIMARY KEY (ID)
)

-- TABLA SUB CATEGORIA
CREATE TABLE TblSubCategoria
(
	ID INT IDENTITY(1,1),
	Categoria INT,
	Nombre VARCHAR(200),
	PRIMARY KEY (ID),
	CONSTRAINT FK_CategoriaSubCategoria FOREIGN KEY (Categoria) REFERENCES TblCategoria (ID)
)

-- TABLA PRODUCTO
CREATE TABLE TblProducto
(
	ID INT IDENTITY(1,1),
	Categoria INT,
	SubCategoria INT,
	Codigo VARCHAR(20),
	Nombre VARCHAR(200),
	Imagen VARCHAR(200),
	TipoExistencia VARCHAR(10),
	UnidadMedida VARCHAR(10),
	Marca INT,
	Estado INT,
	PRIMARY KEY (ID),
	CONSTRAINT U_ProductoCodigo UNIQUE CLUSTERED (Codigo),
	CONSTRAINT FK_CategoriaProducto FOREIGN KEY (Categoria) REFERENCES TblCategoria (ID),
	CONSTRAINT FK_SubCategoriaProducto FOREIGN KEY (SubCategoria) REFERENCES TblSubCategoria (ID),
	CONSTRAINT FK_ProductoTipoExistencia FOREIGN KEY (TipoExistencia) REFERENCES TblTipoExistencia (Codigo),
	CONSTRAINT FK_ProductoUnidadMedida FOREIGN KEY (UnidadMedida) REFERENCES TblUnidadMedida (Codigo),
	CONSTRAINT FK_ProductoMarca FOREIGN KEY (Marca) REFERENCES TblMarca (ID)
)

-- TABLA CLIENTE
CREATE TABLE TblCliente
(
	ID INT IDENTITY(1,1),
	TipoDocumentoIdentidad VARCHAR(10),
	NumeroDocumento VARCHAR(20),
	Nombre VARCHAR(100),
	Apellido VARCHAR(100),
	FechaNacimiento DATE,
	Pais VARCHAR(100),
	Ciudad VARCHAR(100),
	Direccion VARCHAR(200),
	Email VARCHAR(200),
	Telefono VARCHAR(50),
	Estado INT,
	PRIMARY KEY (ID),
	CONSTRAINT U_ClienteNumeroDocumento UNIQUE CLUSTERED (NumeroDocumento),
	CONSTRAINT FK_ClienteTipoDocumentoIdentidad FOREIGN KEY (TipoDocumentoIdentidad) REFERENCES TblTipoDocumentoIdentidad (Codigo)
)

-- TABLA CARGO
CREATE TABLE TblCargo
(
	ID INT IDENTITY(1,1),
	Descripcion VARCHAR(100),
	PRIMARY KEY (ID)
)

CREATE TABLE TblEmpleado
(
	ID INT IDENTITY(1,1),
	Cargo INT,
	TipoDocumentoIdentidad VARCHAR(10),
	NumeroDocumento VARCHAR(20),
	Nombre VARCHAR(100),
	Apellido VARCHAR(100),
	FechaNacimiento DATE,
	Pais VARCHAR(100),
	Ciudad VARCHAR(100),
	Direccion VARCHAR(200),
	Email VARCHAR(200),
	Telefono VARCHAR(50),
	Estado INT,
	PRIMARY KEY (ID),
	CONSTRAINT U_EmpleadoNumeroDocumento UNIQUE CLUSTERED (NumeroDocumento),
	CONSTRAINT FK_EmpleadoCargo FOREIGN KEY (Cargo) REFERENCES TblCargo (ID),
	CONSTRAINT FK_EmpleadoTipoDocumentoIdentidad FOREIGN KEY (TipoDocumentoIdentidad) REFERENCES TblTipoDocumentoIdentidad (Codigo)
)

-- TABLA PROVEEDOR
CREATE TABLE TblProveedor
(
	ID INT IDENTITY(1,1),
	Ruc VARCHAR(20),
	RazonSocial VARCHAR(200),
	Ciudad VARCHAR(100),
	Direccion VARCHAR(200),
	Email VARCHAR(100),
	Telefono VARCHAR(20),
	PRIMARY KEY (ID),
	CONSTRAINT U_ProveedorRuc UNIQUE CLUSTERED (Ruc)
)

-- TABLA VENTA
CREATE TABLE TblVenta
(
	ID INT IDENTITY(1,1),
	Cliente INT,
	Empleado INT,
	TipoComprobante VARCHAR(10),
	Serie VARCHAR(4),
	Numero VARCHAR(8),
	Fecha DATE,
	Hora TIME,
	SubTotal DECIMAL(10,2),
	Igv DECIMAL(10,2),
	Total DECIMAL(10,2),
	Estado INT,
	PRIMARY KEY (ID),
	CONSTRAINT FK_VentaCliente FOREIGN KEY (Cliente) REFERENCES TblCliente (ID),
	CONSTRAINT FK_VentaEmpleado FOREIGN KEY (Empleado) REFERENCES TblEmpleado (ID),
	CONSTRAINT FK_VentaTipoComprobante FOREIGN KEY (TipoComprobante) REFERENCES TblTipoComprobante (Codigo),
	CONSTRAINT USN_Venta UNIQUE CLUSTERED (Serie, Numero)
)

CREATE INDEX IndexVentaFecha ON TblVenta (Fecha)

-- TABLA DETALLE VENTA
CREATE TABLE TblDetalleVenta
(
	ID INT IDENTITY(1,1),
	Serie VARCHAR(4),
	Numero VARCHAR(8),
	Producto VARCHAR(20),
	Precio DECIMAL(10,2),
	Cantidad INT,
	Importe DECIMAL(10,2),
	PRIMARY KEY(ID),
	CONSTRAINT FK_DetalleVentaSerieNumero FOREIGN KEY (Serie,Numero) REFERENCES TblVenta (Serie,Numero),
	CONSTRAINT FK_DetalleVentaProducto FOREIGN KEY (Producto) REFERENCES TblProducto (Codigo)
)

-- TABLA COMPRA
CREATE TABLE TblCompra
(
	ID INT IDENTITY(1,1),
	Proveedor INT,
	Empleado INT,
	TipoComprobante VARCHAR(10),
	Serie VARCHAR(4),
	Numero VARCHAR(8),
	Fecha DATE,
	SubTotal DECIMAL(10,2),
	Igv DECIMAL(10,2),
	Total DECIMAL(10,2),
	Estado INT,
	PRIMARY KEY (ID),
	CONSTRAINT FK_CompraProveedor FOREIGN KEY (Proveedor) REFERENCES TblProveedor (ID),
	CONSTRAINT FK_CompraEmpleado FOREIGN KEY (Empleado) REFERENCES TblEmpleado (ID),
	CONSTRAINT FK_CompraTipoComprobante FOREIGN KEY (TipoComprobante) REFERENCES TblTipoComprobante (Codigo),
	CONSTRAINT USN_Compra UNIQUE CLUSTERED (Serie, Numero)
)

CREATE INDEX IndexCompraFecha ON TblCompra (Fecha)

-- TABLA DETALLE COMPRA
CREATE TABLE TblDetalleCompra
(
	ID INT IDENTITY(1,1),
	Serie VARCHAR(4),
	Numero VARCHAR(8),
	Producto VARCHAR(20),
	PrecioUnitario DECIMAL(10,2),
	Cantidad INT,
	PrecioTotal DECIMAL(10,2),
	PRIMARY KEY(ID),
	CONSTRAINT FK_DetalleCompraSerieNumero FOREIGN KEY (Serie,Numero) REFERENCES TblCompra (Serie,Numero),
	CONSTRAINT FK_DetalleCompraProducto FOREIGN KEY (Producto) REFERENCES TblProducto (Codigo)
)

-- TABLA MOVIMIENTO (KARDEX)
CREATE TABLE TblMovimiento
(
	ID INT IDENTITY(1,1),
	Fecha DATE,
	TipoComprobante VARCHAR(10),
	Serie VARCHAR(4),
	Numero VARCHAR(8),
	TipoOperacion VARCHAR(10),
	Producto VARCHAR(20),
	CantidadEntrada INT,
	CostoUnitarioEntrada DECIMAL(10,2),
	CostoTotalEntrada DECIMAL(10,2),
	CantidadSalida INT,
	CostoUnitarioSalida DECIMAL(10,2),
	CostoTotalSalida DECIMAL(10,2),
	CantidadFinal INT,
	CostoUnitarioFinal DECIMAL(10,2),
	CostoTotalFinal DECIMAL(10,2),
	PRIMARY KEY (ID),
	CONSTRAINT FK_KardexTipoComprobante FOREIGN KEY (TipoComprobante) REFERENCES TblTipoComprobante (Codigo),
	CONSTRAINT FK_KardexTipoOperacion FOREIGN KEY (TipoOperacion) REFERENCES TblTipoOperacion (Codigo),
	CONSTRAINT FK_KardexProducto FOREIGN KEY (Producto) REFERENCES TblProducto (Codigo)
)

CREATE INDEX IndexMovimiento ON TblMovimiento (Fecha, Producto)

-- TABLA INVENTARIO
CREATE TABLE TblInventario
(
	ID INT IDENTITY(1,1),
	Producto VARCHAR(20),
	ValorUnitario DECIMAL(10,2),
	Existencias INT,
	ValorInventario DECIMAL(10,2),
	PRIMARY KEY (ID, Producto),
	CONSTRAINT FK_InventarioProducto FOREIGN KEY (Producto) REFERENCES TblProducto (Codigo)
)

CREATE INDEX IndexInventarioProducto ON TblInventario (Producto)


-- TABLA USUARIO
CREATE TABLE TblUsuario
(
	ID INT IDENTITY(1,1),
	Username VARCHAR(100),
	Password VARCHAR(200),
	Estado INT,
	PRIMARY KEY(ID),
	UNIQUE (Username)
)


