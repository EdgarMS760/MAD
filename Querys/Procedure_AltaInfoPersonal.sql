

ALTER PROCEDURE sp_ActualizaInfoPersonal
    @Correo VARCHAR(50),
    @Genero CHAR(1),
    @NombreCompleto VARCHAR(50),
    @FechaNacimiento DATE
AS
BEGIN
    -- Actualizar información adicional para el usuario existente
    UPDATE InfoPersonal
    SET Genero = @Genero,
        NombreCompleto = @NombreCompleto,
        FechaNacimiento = @FechaNacimiento
    WHERE CorreoElectronico = @Correo;
END;

