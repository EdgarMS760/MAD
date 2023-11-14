CREATE PROCEDURE sp_BajaUsuario
    @Correo VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado y la fecha de baja
    UPDATE Usuario
    SET Estado = 'INACTIVO',
        FechaBaja = GETDATE()  -- Obtiene la fecha y hora actual
    WHERE CorreoElectronico = @Correo;
END;
