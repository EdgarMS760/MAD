ALTER PROCEDURE sp_AltaUsuario
    @Correo NVARCHAR(50),
    @ContrasenaActual NVARCHAR(15),
    @UsuarioExistente BIT OUTPUT
AS
BEGIN

    BEGIN TRANSACTION


    IF EXISTS (SELECT 1 FROM Usuario WHERE CorreoElectronico = @Correo)
    BEGIN

        SET @UsuarioExistente = 1;
    END
    ELSE
    BEGIN

        INSERT INTO Usuario (CorreoElectronico) 
        VALUES (@Correo);


        INSERT INTO Contrasena (CorreoElectronico, ContrasenaActual, ContrasenaTemporal, ContrasenaAnterior1, ContrasenaAnterior2)
        VALUES (@Correo, @ContrasenaActual, NULL, NULL, NULL);


        SET @UsuarioExistente = 0;
    END


    COMMIT TRANSACTION
END

CREATE TRIGGER trg_AfterInsertUsuario
ON Usuario
AFTER INSERT
AS
BEGIN

    INSERT INTO InfoPersonal (CorreoElectronico)
    SELECT CorreoElectronico
    FROM inserted;
END;
