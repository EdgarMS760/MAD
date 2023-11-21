CREATE VIEW VistaHistorialCompleto AS
SELECT
    H.Palabra,
    H.FechaHora,
    C.Libro,
    C.Capitulo,
    C.Versiculos,
    H.CorreoElectronico
FROM Historial H
INNER JOIN Consulta C ON H.ID_consultas = C.ID_consultas;

ALTER PROCEDURE ObtenerHistorialCompleto
    @CorreoElectronico VARCHAR(50)
AS
BEGIN
    SELECT
        Palabra,
        FechaHora,
        Libro,
        Capitulo,
        Versiculos
    FROM VistaHistorialCompleto
    WHERE CorreoElectronico = @CorreoElectronico;
END;
