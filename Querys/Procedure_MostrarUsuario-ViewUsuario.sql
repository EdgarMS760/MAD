CREATE PROCEDURE ObtenerInfoUsuario
    @CorreoElectronico VARCHAR(50),
    @NombreCompleto VARCHAR(50) OUTPUT,
    @Genero CHAR(1) OUTPUT,
    @FechaNacimiento DATE OUTPUT,
    @Tipo BIT OUTPUT,
    @Estatus CHAR(15) OUTPUT
AS
BEGIN
    SELECT 
        @NombreCompleto = V.NombreCompleto,
        @Genero = V.Genero,
        @FechaNacimiento = V.FechaNacimiento,
        @Tipo = V.Tipo,
        @Estatus = V.Estatus
    FROM VistaInfoUsuario V
    WHERE V.CorreoElectronico = @CorreoElectronico;
END;



ALTER VIEW VistaInfoUsuario AS
SELECT
    U.CorreoElectronico,
    U.AdminOrNot AS Tipo,
    U.Estado AS Estatus,
    I.NombreCompleto,
    I.Genero,
    I.FechaNacimiento
FROM
    Usuario U
JOIN
    InfoPersonal I ON U.CorreoElectronico = I.CorreoElectronico;
