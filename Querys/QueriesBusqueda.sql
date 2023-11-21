Use app_MAD
go
CREATE PROCEDURE ObtenerIdiomas
AS
BEGIN
    
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT Id_Idioma, Nombre FROM ' + @OtraBaseDatos + '.dbo.Idiomas';

    EXEC sp_executesql @SqlStatement;
END;

go
CREATE PROCEDURE ObtenerLibrosPorIdioma
    @Id_Idioma SMALLINT
AS
BEGIN
    
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT Id_Libro, Nombre FROM ' + @OtraBaseDatos + '.dbo.Libros WHERE Id_Idioma = @Id_Idioma';

    EXEC sp_executesql @SqlStatement, N'@Id_Idioma SMALLINT', @Id_Idioma;
END;
go
CREATE PROCEDURE ObtenerVersionesPorIdioma
    @Id_Idioma SMALLINT
AS
BEGIN

    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT Id_Version, NombreVersion FROM ' + @OtraBaseDatos + '.dbo.Versiones WHERE Id_Idioma = @Id_Idioma';

    EXEC sp_executesql @SqlStatement, N'@Id_Idioma SMALLINT', @Id_Idioma;
END;

go
CREATE PROCEDURE ObtenerTestamentosPorIdioma
    @Id_Idioma SMALLINT
AS
BEGIN
   
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT Id_Testamento, Nombre FROM ' + @OtraBaseDatos + '.dbo.Testamentos WHERE Id_Idioma = @Id_Idioma';

    EXEC sp_executesql @SqlStatement, N'@Id_Idioma SMALLINT', @Id_Idioma;
END;

go
CREATE PROCEDURE ObtenerLibrosPorTestamento
    @Id_Testamento SMALLINT
AS
BEGIN
  
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT Id_Libro, Nombre FROM ' + @OtraBaseDatos + '.dbo.Libros WHERE Id_Testamento = @Id_Testamento';

    EXEC sp_executesql @SqlStatement, N'@Id_Testamento SMALLINT', @Id_Testamento;
END;	
go 
CREATE PROCEDURE ExecuteBuscarVersiculos
(
    @PalabrasClave NVARCHAR(MAX),
    @ID_version TINYINT = NULL,
    @Id_Testamento TINYINT = NULL,
    @Id_libro TINYINT = NULL
)
AS
BEGIN
    DECLARE @OtherDatabase NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'EXEC ' + @OtherDatabase + '.[dbo].[BuscarVersiculos] @PalabrasClave, @ID_version, @Id_Testamento, @Id_libro';

    EXEC sp_executesql @SqlStatement, N'@PalabrasClave NVARCHAR(MAX), @ID_version TINYINT, @Id_Testamento TINYINT, @Id_libro TINYINT', @PalabrasClave, @ID_version, @Id_Testamento, @Id_libro;
END;
go
CREATE PROCEDURE ObtenerCapitulo
    @NombreLibro VARCHAR(20),
    @NumeroCap TINYINT
AS
BEGIN
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';
    DECLARE @SqlStatement NVARCHAR(MAX);

    SET @SqlStatement = 'USE ' + @OtraBaseDatos + '; ' +
                        'SELECT 
                            L.Nombre AS NombreLibro,
                            V.NumeroVers,
                            V.Texto
                        FROM Versiculos V
                        INNER JOIN Libros L ON V.Id_Libro = L.Id_Libro
                        WHERE L.Nombre = @NombreLibro AND V.NumeroCap = @NumeroCap;';

    EXEC sp_executesql @SqlStatement, N'@NombreLibro VARCHAR(20), @NumeroCap TINYINT', @NombreLibro, @NumeroCap;
END;
go
CREATE PROCEDURE ObtenerNumeroCapPorLibro
    @NombreLibro NVARCHAR(50)
AS
BEGIN
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT DISTINCT V.NumeroCap 
                         FROM ' + @OtraBaseDatos + '.dbo.Versiculos V
                         INNER JOIN ' + @OtraBaseDatos + '.dbo.Libros L ON V.Id_Libro = L.Id_Libro
                         WHERE L.Nombre = @NombreLibro';

    EXEC sp_executesql @SqlStatement, N'@NombreLibro NVARCHAR(50)', @NombreLibro;
END;

go
CREATE PROCEDURE ObtenerNumeroVersPorCapitulo
    @NumeroCap TINYINT,
    @NombreLibro NVARCHAR(50)
AS
BEGIN
    DECLARE @OtraBaseDatos NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'SELECT V.NumeroVers 
                         FROM ' + @OtraBaseDatos + '.dbo.Versiculos V
                         INNER JOIN ' + @OtraBaseDatos + '.dbo.Libros L ON V.Id_Libro = L.Id_Libro
                         WHERE V.NumeroCap = @NumeroCap
                         AND L.Nombre = @NombreLibro';

    EXEC sp_executesql @SqlStatement, N'@NumeroCap TINYINT, @NombreLibro NVARCHAR(50)', @NumeroCap, @NombreLibro;
END;
go
CREATE PROCEDURE ExecuteBuscarVersiculos
(
    @PalabrasClave NVARCHAR(MAX),
    @ID_version TINYINT = NULL,
    @Id_Testamento TINYINT = NULL,
    @Id_libro TINYINT = NULL,
    @NumeroCap TINYINT = NULL,
    @NumeroVers TINYINT = NULL
)
AS
BEGIN
    DECLARE @OtherDatabase NVARCHAR(100) = 'DB_Bible';

    DECLARE @SqlStatement NVARCHAR(MAX);
    SET @SqlStatement = 'EXEC ' + @OtherDatabase + '.[dbo].[BuscarVersiculos] @PalabrasClave, @ID_version, @Id_Testamento, @Id_libro, @NumeroCap, @NumeroVers';

    EXEC sp_executesql @SqlStatement, N'@PalabrasClave NVARCHAR(MAX), @ID_version TINYINT, @Id_Testamento TINYINT, @Id_libro TINYINT, @NumeroCap TINYINT, @NumeroVers TINYINT', @PalabrasClave, @ID_version, @Id_Testamento, @Id_libro, @NumeroCap, @NumeroVers;
END;
go
Use DB_Bible
--este se crea en la base de datos de la biblia
go
CREATE PROCEDURE BuscarVersiculos
(
    @PalabrasClave NVARCHAR(MAX),
    @ID_version TINYINT = NULL,
    @Id_Testamento TINYINT = NULL,
    @Id_libro TINYINT = NULL,
    @NumeroCap TINYINT = NULL,
    @NumeroVers TINYINT = NULL
)
AS
BEGIN
    WITH PalabrasClaveCTE AS (
        SELECT value AS Palabra
        FROM STRING_SPLIT(@PalabrasClave, ' ')
    )
    SELECT 
        L.Nombre AS NombreLibro,
        L.OrdenLibro,
        V.NumeroCap,
        V.NumeroVers,
        V.Texto
    FROM Versiculos V
    INNER JOIN Libros L ON V.Id_Libro = L.Id_Libro
    INNER JOIN Testamentos T ON L.Id_Testamento = T.Id_Testamento
    WHERE (
        SELECT COUNT(DISTINCT pc.Palabra)
        FROM PalabrasClaveCTE pc
        WHERE V.Texto LIKE '%' + pc.Palabra + '%'
    ) = (SELECT COUNT(DISTINCT Palabra) FROM PalabrasClaveCTE)
    AND (@ID_version IS NULL OR V.Id_Version = @ID_version)
    AND (@Id_Testamento IS NULL OR L.Id_Testamento = @Id_Testamento)
    AND (@Id_libro IS NULL OR V.Id_Libro = @Id_libro)
    AND (@NumeroCap IS NULL OR V.NumeroCap = @NumeroCap)
    AND (@NumeroVers IS NULL OR V.NumeroVers = @NumeroVers)
    ORDER BY L.OrdenLibro, V.NumeroCap, V.NumeroVers;
END;

go