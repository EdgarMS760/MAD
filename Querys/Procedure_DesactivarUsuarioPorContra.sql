CREATE PROCEDURE sp_DesactivarUsuario
    @Correo VARCHAR(50)
AS
BEGIN
    UPDATE Usuario
    SET Estado = 'INACTIVO'
    WHERE CorreoElectronico = @Correo;
END;

CREATE PROCEDURE sp_IncrementarIntentosFallidos
    @Correo VARCHAR(50)
AS
BEGIN
    UPDATE Usuario
    SET IntentosIngre = ISNULL(IntentosIngre, 0) + 1
    WHERE CorreoElectronico = @Correo;
END;


CREATE PROCEDURE sp_ObtenerIntentosFallidos
    @Correo VARCHAR(50),
    @IntentosFallidos INT OUTPUT
AS
BEGIN
    SELECT @IntentosFallidos = ISNULL(IntentosIngre, 0)
    FROM Usuario
    WHERE CorreoElectronico = @Correo;
END;

CREATE PROCEDURE sp_ReiniciarIntentosFallidos
    @Correo VARCHAR(50)
AS
BEGIN
    UPDATE Usuario
    SET IntentosIngre = 0
    WHERE CorreoElectronico = @Correo;
END;
