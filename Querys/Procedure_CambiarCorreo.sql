ALTER PROCEDURE sp_CambiarCorreoElectronico
    @CorreoActual VARCHAR(50),
    @NuevoCorreo VARCHAR(50)
AS
BEGIN
    -- Deshabilitar restricciones de clave foránea temporalmente
    ALTER TABLE InfoPersonal NOCHECK CONSTRAINT ALL;
    ALTER TABLE Contrasena NOCHECK CONSTRAINT ALL;

    -- Actualizar las tablas dependientes
    UPDATE InfoPersonal
    SET CorreoElectronico = @NuevoCorreo
    WHERE CorreoElectronico = @CorreoActual;

    UPDATE Contrasena
    SET CorreoElectronico = @NuevoCorreo
    WHERE CorreoElectronico = @CorreoActual;

    -- Actualizar la tabla Usuario
    UPDATE Usuario
    SET CorreoElectronico = @NuevoCorreo
    WHERE CorreoElectronico = @CorreoActual;

    -- Habilitar restricciones de clave foránea
    ALTER TABLE InfoPersonal WITH CHECK CHECK CONSTRAINT ALL;
    ALTER TABLE Contrasena WITH CHECK CHECK CONSTRAINT ALL;
END;
