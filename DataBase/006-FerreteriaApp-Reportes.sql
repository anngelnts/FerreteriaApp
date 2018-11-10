USE FerreteriaApp
GO

-- REPORTE VENTAS DEL DIA
CREATE PROCEDURE USP_R_VentasdelDia
AS
BEGIN
SELECT TC.Descripcion AS 'Comprobante', V.Serie, V.Numero, V.Fecha, V.SubTotal, V.Igv, V.Total,
E.Nombre+' '+E.Apellido AS 'Empleado', C.Nombre+' '+C.Apellido AS 'Cliente'
FROM TblVenta AS V LEFT JOIN TblCliente AS C ON V.Cliente = C.ID
LEFT JOIN TblEmpleado AS E ON E.ID = V.Empleado
LEFT JOIN TblTipoComprobante AS TC ON TC.Codigo = V.TipoComprobante
WHERE Fecha = CONVERT (date, GETDATE())
END
GO

-- REPORTE DE PRODUCTOS VENDIDOS
CREATE PROCEDURE USP_R_ProductosVendidos
AS
BEGIN
SELECT V.Fecha, V.Serie+'-'+V.Numero AS 'Comprobante', P.Codigo, P.Nombre AS 'Producto', I.ValorUnitario AS 'PrecioCompra', DV.Precio AS 'PrecioVenta', DV.Cantidad, DV.Importe AS 'Total', (DV.Importe - (I.ValorUnitario * DV.Cantidad)) AS 'Ganancia'  
FROM TblVenta AS V 
LEFT JOIN TblDetalleVenta AS DV ON V.Serie = DV.Serie AND V.Numero = DV.Numero
LEFT JOIN TblProducto AS P ON P.Codigo = DV.Producto
LEFT JOIN TblInventario AS I ON I.Producto = P.Codigo
END
GO

-- REPORTE DE EXISTENCIAS DE PRODUCTO ORDERNADO POR EXISTENCIAS
CREATE PROCEDURE USP_R_ExistenciaProductosOrderExistencia
AS
BEGIN
SELECT P.Codigo, P.Nombre, I.Existencias, I.ValorUnitario, I.ValorInventario
FROM TblProducto AS P LEFT JOIN TblInventario AS I ON P.Codigo = I.Producto
ORDER BY I.Existencias DESC
END
GO

-- REPORTE VENTAS POR EMPLEADO
