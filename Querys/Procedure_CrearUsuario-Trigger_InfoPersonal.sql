ALTER PROCEDURE sp_AltaUsuario
    @Correo NVARCHAR(50),
    @ContrasenaActual NVARCHAR(15),
    @UsuarioExistente BIT OUTPUT
AS
BEGIN
    -- Iniciar una transacción para asegurar la consistencia de los datos
    BEGIN TRANSACTION

    -- Verificar si el usuario ya existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE CorreoElectronico = @Correo)
    BEGIN
        -- El usuario ya existe, establecer @UsuarioExistente en 1 (verdadero)
        SET @UsuarioExistente = 1;
    END
    ELSE
    BEGIN
        -- El usuario no existe, proceder con la inserción en la tabla Usuario
        INSERT INTO Usuario (CorreoElectronico) 
        VALUES (@Correo);

        -- Insertar en la tabla de contraseñas
        INSERT INTO Contrasena (CorreoElectronico, ContrasenaActual, ContrasenaTemporal, ContrasenaAnterior1, ContrasenaAnterior2)
        VALUES (@Correo, @ContrasenaActual, NULL, NULL, NULL);

        -- El usuario no existe, establecer @UsuarioExistente en 0 (falso)
        SET @UsuarioExistente = 0;
    END

    -- Confirmar la transacción
    COMMIT TRANSACTION
END

CREATE TRIGGER trg_AfterInsertUsuario
ON Usuario
AFTER INSERT
AS
BEGIN
    -- Insertar en la tabla InfoPersonal
    INSERT INTO InfoPersonal (CorreoElectronico)
    SELECT CorreoElectronico
    FROM inserted;
END;
