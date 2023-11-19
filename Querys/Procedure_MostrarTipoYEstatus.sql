CREATE PROCEDURE ObtenerTipoYEstado
    @CorreoElectronico VARCHAR(50),
    @Tipo BIT OUTPUT,
    @Estatus CHAR(15) OUTPUT
AS
BEGIN
    SELECT 
        @Tipo = U.AdminOrNot,
        @Estatus = U.Estado
    FROM Usuario U
    WHERE U.CorreoElectronico = @CorreoElectronico;
END;
