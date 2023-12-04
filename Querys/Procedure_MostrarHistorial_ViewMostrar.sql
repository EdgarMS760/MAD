ALTER VIEW VistaHistorialCompleto AS
SELECT
    C.palabrasClave,
    H.FechaHora,
    C.Libro,
    C.Capitulo,
    C.Versiculos,
	C.Version,
	C.Idioma,
    H.CorreoElectronico
FROM Historial H
INNER JOIN Consulta C ON H.ID_consultas = C.ID_consultas;

ALTER PROCEDURE ObtenerHistorialCompleto
    @CorreoElectronico VARCHAR(50)
AS
BEGIN
    SELECT
        palabrasClave,
        FechaHora,
        Libro,
        Capitulo,
        Versiculos,
		Version,
		Idioma
    FROM VistaHistorialCompleto
    WHERE CorreoElectronico = @CorreoElectronico;
END;
