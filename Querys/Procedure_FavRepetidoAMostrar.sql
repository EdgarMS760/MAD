USE [app_MAD1]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FavRepetidoAMostrar]
(
    @NombreLibro VARCHAR(20),
    @NumeroCap TINYINT,
    @NumeroVers TINYINT,
    @CorreoElectronico VARCHAR(50),
    @Resultado BIT OUTPUT
)
AS
BEGIN
    DECLARE @Existe BIT;

    SET @Existe = 0;

    -- Verificar si ya existe un registro con los mismos valores
    IF EXISTS (
        SELECT 1
        FROM Favorito
        WHERE LibroFav = @NombreLibro
          AND CapituloFav = @NumeroCap
          AND VersiculosFav = @NumeroVers
          AND CorreoElectronico = @CorreoElectronico
    )
    BEGIN
        SET @Existe = 1;
    END

    SET @Resultado = @Existe;
END;
