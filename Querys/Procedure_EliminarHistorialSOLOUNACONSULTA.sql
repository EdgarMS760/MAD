CREATE PROCEDURE EliminarHistorialPorFecha
    @FechaRegistro DATETIME
AS
BEGIN
    DELETE FROM Historial
    WHERE FechaHora = @FechaRegistro;
END
