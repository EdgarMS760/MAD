use app_MAD
CREATE VIEW VistaUsuariosInactivos
AS
SELECT CorreoElectronico, Estado
FROM Usuario
WHERE Estado = 'INACTIVO';
go
CREATE VIEW VewEstadoUsuario AS
SELECT CorreoElectronico, Estado
FROM Usuario;
go
Create TRIGGER TR_InsertarEnHistorial
ON Consulta
AFTER INSERT
AS
BEGIN
    DECLARE @CorreoElectronico VARCHAR(50);
    DECLARE @PalabrasClave VARCHAR(50);
    DECLARE @FechaHora DATETIME;
    DECLARE @ID_Consulta INT;

    SELECT
        @CorreoElectronico = i.CorreoElectronico,
        @PalabrasClave = i.palabrasClave,
        @FechaHora = GETDATE(),
        @ID_Consulta = i.ID_consultas
    FROM
        inserted i;

    INSERT INTO Historial (CorreoElectronico, Palabra, FechaHora, ID_consultas)
    VALUES (@CorreoElectronico, @PalabrasClave, @FechaHora, @ID_Consulta);
END;
go
CREATE FUNCTION AutenticarUsuario
(
    @CorreoElectronico VARCHAR(50),
    @Contrasena VARCHAR(15)
)
RETURNS INT
AS
BEGIN
    DECLARE @Resultado INT;
    SET @Resultado = 0;

    IF EXISTS (
        SELECT 1
        FROM Usuario u
        INNER JOIN Contrasena c ON u.CorreoElectronico = c.CorreoElectronico
        WHERE u.CorreoElectronico = @CorreoElectronico
        AND (BINARY_CHECKSUM(c.ContrasenaActual) = BINARY_CHECKSUM(@Contrasena))
    )
    BEGIN
        --exito
        SET @Resultado = 1;
    END
    ELSE
    BEGIN
        
        IF EXISTS (
            SELECT 1
            FROM Usuario
            WHERE CorreoElectronico = @CorreoElectronico
        )
        BEGIN
            -- pass inocrrecta
            SET @Resultado = 2;
        END
        ELSE
        BEGIN
            -- correo mal
            SET @Resultado = 3;
        END
    END

    RETURN @Resultado;
END;
go
CREATE FUNCTION AutenticarUsuarioPassTemporal
(
    @CorreoElectronico VARCHAR(50),
    @Contrasena VARCHAR(15)
)
RETURNS INT
AS
BEGIN
    DECLARE @Resultado INT;
    SET @Resultado = 0;

    IF EXISTS (
        SELECT 1
        FROM Usuario u
        INNER JOIN Contrasena c ON u.CorreoElectronico = c.CorreoElectronico
        WHERE u.CorreoElectronico = @CorreoElectronico
        AND (BINARY_CHECKSUM(c.ContrasenaTemporal) = BINARY_CHECKSUM(@Contrasena))
    )
    BEGIN
        --exito
		
        SET @Resultado = 1;
    END
    ELSE
    BEGIN
        
        IF EXISTS (
            SELECT 1
            FROM Usuario
            WHERE CorreoElectronico = @CorreoElectronico
        )
        BEGIN
            -- pass inocrrecta
            SET @Resultado = 2;
        END
        ELSE
        BEGIN
            -- correo mal
            SET @Resultado = 3;
        END
    END

    RETURN @Resultado;
END;
go
CREATE FUNCTION FavRepetido
(
    @NombreLibro VARCHAR(20),
    @NumeroCap TINYINT,
    @NumeroVers TINYINT,
    @CorreoElectronico VARCHAR(50)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Repetido BIT;

    SET @Repetido = 0;

    IF EXISTS (
        SELECT 1
        FROM Favorito
        WHERE LibroFav = @NombreLibro
          AND CapituloFav = @NumeroCap
          AND VersiculosFav = @NumeroVers
          AND CorreoElectronico = @CorreoElectronico
    )
    BEGIN
        SET @Repetido = 1;
    END

    RETURN @Repetido;
END;
go
CREATE FUNCTION BuscarUsuario
(
    @CorreoElectronico VARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT TOP 1
	    CorreoElectronico,
        Estado,
        AdminOrNot
    FROM
        Usuario
    WHERE
        CorreoElectronico = @CorreoElectronico
);
go
CREATE PROCEDURE GuardarFav
(
    @NombreLibro VARCHAR(20),
    @NumeroCap TINYINT,
    @NumeroVers TINYINT,
    @CorreoElectronico VARCHAR(50),
    @Resultado INT OUTPUT
)
AS
BEGIN
    DECLARE @Existe BIT;

    SET @Existe = dbo.FavRepetido(@NombreLibro, @NumeroCap, @NumeroVers, @CorreoElectronico);

    IF @Existe = 0
    BEGIN
        INSERT INTO Favorito (LibroFav, CapituloFav, VersiculosFav, CorreoElectronico)
        VALUES (@NombreLibro, @NumeroCap, @NumeroVers, @CorreoElectronico);

        SET @Resultado = 1;
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
    END
END;
go
create proc addPassTemporal
(
 @temporalPass varchar(15),
 @CorreoElectronico Varchar (50)
)
as 
begin
 update Contrasena set ContrasenaTemporal=@temporalPass where CorreoElectronico=@CorreoElectronico
 end;
 
 go
 
 CREATE PROCEDURE updAdmin
 (
 @CorreoElectronico VARCHAR(50),
 @accion tinyint
 )
 as
 begin 
     begin if @accion=1
     update Usuario set AdminOrNot=1 where CorreoElectronico=@CorreoElectronico;
	 else 
	 update Usuario set AdminOrNot=0 where CorreoElectronico=@CorreoElectronico;
	 end;
end;
 go
 go
 CREATE PROCEDURE ObtenerUsuariosInactivos
AS
BEGIN
    SELECT * FROM VistaUsuariosInactivos;
END;
go
CREATE PROCEDURE ProcViewEstadoUsuario
    @CorreoElectronico NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Estado
    FROM VewEstadoUsuario
    WHERE CorreoElectronico = @CorreoElectronico;
END;

go
CREATE PROCEDURE loginPassTemporal
(@CorreoElectronico NVARCHAR(50),
 @Contrasena VARCHAR(50)
)
as begin
UPDATE Contrasena set ContrasenaActual=@Contrasena, ContrasenaTemporal = null where CorreoElectronico=@CorreoElectronico;
UPDATE Usuario set FechaBaja=null, Estado='ACTIVO' where CorreoElectronico=@CorreoElectronico;
end;
go