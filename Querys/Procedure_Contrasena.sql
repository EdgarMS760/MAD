CREATE FUNCTION dbo.ValidarNuevaContrasena
(
    @CorreoUsu VARCHAR(50),
    @NuevaContrasena VARCHAR(15)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Resultado BIT;

    IF @NuevaContrasena = (SELECT ContrasenaAnterior1 FROM Contrasena WHERE CorreoElectronico = @CorreoUsu) OR
       @NuevaContrasena = (SELECT ContrasenaAnterior2 FROM Contrasena WHERE CorreoElectronico = @CorreoUsu) OR
       @NuevaContrasena = (SELECT ContrasenaActual FROM Contrasena WHERE CorreoElectronico = @CorreoUsu)
    BEGIN
        SET @Resultado = 0; -- Operación no exitosa (contraseña nueva igual a una existente)
    END
    ELSE
    BEGIN
        SET @Resultado = 1; -- Operación exitosa
    END;

    RETURN @Resultado;
END;

ALTER PROCEDURE sp_CambiarContrasena
    @CorreoUsu VARCHAR(50),
    @ContrasenaActual VARCHAR(15),
    @NuevaContrasena VARCHAR(15),
    @OperacionExitosa BIT OUTPUT
AS
BEGIN
    -- Validar la nueva contraseña
    SET @OperacionExitosa = dbo.ValidarNuevaContrasena(@CorreoUsu, @NuevaContrasena);

    IF @OperacionExitosa = 0
    BEGIN
        -- Operación no exitosa, salida temprana
        RETURN;
    END

    -- Resto del código para la actualización de la contraseña
    DECLARE @AnteriorContrasena VARCHAR(15);
    DECLARE @Anterior2Contrasena VARCHAR(15);

    -- Obtener la contraseña actual antes de la actualización
    SELECT @AnteriorContrasena = ContrasenaActual
    FROM Contrasena
    WHERE CorreoElectronico = @CorreoUsu;

    -- Obtener la contraseña anterior1 antes de la actualización
    SELECT @Anterior2Contrasena = ContrasenaAnterior1
    FROM Contrasena
    WHERE CorreoElectronico = @CorreoUsu;

    -- Actualizar las contraseñas
    UPDATE Contrasena
    SET ContrasenaAnterior2 = @Anterior2Contrasena,
        ContrasenaAnterior1 = @AnteriorContrasena,
        ContrasenaActual = @NuevaContrasena
    WHERE CorreoElectronico = @CorreoUsu;

    SET @OperacionExitosa = 1; -- Operación exitosa
END;
