CREATE PROCEDURE EliminarHistorialPorUsuario
    @CorreoUsuario NVARCHAR(255)
AS
BEGIN
    DELETE FROM Historial
    WHERE CorreoElectronico = @CorreoUsuario;
END
