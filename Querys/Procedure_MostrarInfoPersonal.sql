CREATE PROCEDURE ObtenerInfoPersonal
    @CorreoElectronico VARCHAR(50),
    @NombreCompleto VARCHAR(50) OUTPUT,
    @Genero CHAR(1) OUTPUT,
    @FechaNacimiento DATE OUTPUT
AS
BEGIN
    SELECT 
        @NombreCompleto = NombreCompleto,
        @Genero = Genero,
        @FechaNacimiento = FechaNacimiento
    FROM InfoPersonal
    WHERE CorreoElectronico = @CorreoElectronico;
END;
