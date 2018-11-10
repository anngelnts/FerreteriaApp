USE FerreteriaApp
GO

CREATE PROCEDURE USP_S_SerieCorrelativo
(
	@Tipo VARCHAR(10)
)
AS
BEGIN
	DECLARE @Type VARCHAR(10)
	DECLARE @Correlativo VARCHAR(8)
	DECLARE @Serie VARCHAR(4)
	DECLARE @StringSerie VARCHAR(4)
	SET @Type = @Tipo
	IF(@Type = '01') SET @Serie = 'F'
	IF(@Type = '03') SET @Serie = 'B'
	SET @StringSerie = (SELECT TOP 1 Serie FROM TblVenta WHERE TipoComprobante = @Type ORDER BY Serie DESC)
	SET @Correlativo = (SELECT COUNT(ID) FROM TblVenta WHERE TipoComprobante = @Type)
	IF(CONVERT(INT, @Correlativo) + 1 > 99999999)
	BEGIN
	SET @Correlativo = 1
	IF(@StringSerie IS NULL)
	SET @Serie = @Serie + REPLICATE('0', 3 - LEN('1')) + '1'
	ELSE
	SET @Serie = CONCAT(@Serie, REPLICATE('0', 3 - LEN(CONVERT(INT, SUBSTRING(@StringSerie,2,3)))) +  CONVERT(VARCHAR(3), SUBSTRING(@StringSerie,2,3) + 1))
	END
	ELSE
	BEGIN
	SET @Correlativo = @Correlativo + 1
	IF(@StringSerie IS NULL)
	SET @Serie = @Serie + REPLICATE('0', 3 - LEN('1')) + '1'
	ELSE
	SET @Serie = @StringSerie
	END
	SELECT @Serie as 'Serie', REPLICATE('0', 8 - LEN(@Correlativo)) + @Correlativo AS 'Correlativo'
END
GO


EXEC USP_S_SerieCorrelativo @Tipo = '01'
GO