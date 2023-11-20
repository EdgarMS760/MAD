CREATE PROCEDURE EliminarFavorito
    @CorreoElectronico VARCHAR(50),
    @LibroFav NVARCHAR(20),
    @CapituloFav INT,
    @VersiculosFav INT
AS
BEGIN
    DELETE FROM Favorito
    WHERE
        CorreoElectronico = @CorreoElectronico
        AND LibroFav = @LibroFav
        AND CapituloFav = @CapituloFav
        AND VersiculosFav = @VersiculosFav;
END;
