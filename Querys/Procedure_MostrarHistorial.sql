ALTER PROCEDURE ObtenerHistorialCompleto
    @CorreoElectronico VARCHAR(50)
AS
BEGIN
    SELECT
        H.Palabra,
        H.FechaHora,
        C.Libro,
        C.Capitulo,
        C.Versiculos
    FROM Historial H
    INNER JOIN Consulta C ON H.ID_consultas = C.ID_consultas
    WHERE H.CorreoElectronico = @CorreoElectronico;
END;
