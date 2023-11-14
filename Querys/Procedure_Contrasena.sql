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
        SET @Resultado = 0; -- Operaci�n no exitosa (contrase�a nueva igual a una existente)
    END
    ELSE
    BEGIN
        SET @Resultado = 1; -- Operaci�n exitosa
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
    -- Validar la nueva contrase�a
    SET @OperacionExitosa = dbo.ValidarNuevaContrasena(@CorreoUsu, @NuevaContrasena);

    IF @OperacionExitosa = 0
    BEGIN
        -- Operaci�n no exitosa, salida temprana
        RETURN;
    END

    -- Resto del c�digo para la actualizaci�n de la contrase�a
    DECLARE @AnteriorContrasena VARCHAR(15);
    DECLARE @Anterior2Contrasena VARCHAR(15);

    -- Obtener la contrase�a actual antes de la actualizaci�n
    SELECT @AnteriorContrasena = ContrasenaActual
    FROM Contrasena
    WHERE CorreoElectronico = @CorreoUsu;

    -- Obtener la contrase�a anterior1 antes de la actualizaci�n
    SELECT @Anterior2Contrasena = ContrasenaAnterior1
    FROM Contrasena
    WHERE CorreoElectronico = @CorreoUsu;

    -- Actualizar las contrase�as
    UPDATE Contrasena
    SET ContrasenaAnterior2 = @Anterior2Contrasena,
        ContrasenaAnterior1 = @AnteriorContrasena,
        ContrasenaActual = @NuevaContrasena
    WHERE CorreoElectronico = @CorreoUsu;

    SET @OperacionExitosa = 1; -- Operaci�n exitosa
END;
