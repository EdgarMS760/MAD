CREATE PROCEDURE ObtenerFavoritos
    @CorreoElectronico NVARCHAR(255)
AS
BEGIN
    SELECT
        LibroFav,
        CapituloFav,
        VersiculosFav
    FROM
        Favorito
    WHERE
        CorreoElectronico = @CorreoElectronico;
END;