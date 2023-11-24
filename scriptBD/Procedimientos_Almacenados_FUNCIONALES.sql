USE NSG;

------------------------------------------------------
--Procedimientos almacenados para la tabla categoria--
------------------------------------------------------

CREATE PROCEDURE InsertarCategorias
	@categoria VARCHAR(30)
AS
BEGIN
	INSERT INTO categoria (categoria)
	VALUES (@categoria)
END

EXEC InsertarCategorias @Categoria = 'Cableria'

------------------------------------------------------

CREATE PROCEDURE ModificarCategoria
    @IdCategoria INT,
    @Categoria VARCHAR(30)
AS
BEGIN
    UPDATE categoria
    SET categoria = @Categoria
    WHERE idcategoria = @IdCategoria
END

EXEC ModificarCategoria @IdCategoria = 8, @Categoria = 'Fibras'

------------------------------------------------------

CREATE PROCEDURE BorrarCategoria
    @IdCategoria INT
AS
BEGIN
    DELETE FROM categoria
    WHERE idcategoria = @IdCategoria
END

EXEC BorrarCategoria @IdCategoria = 8

------------------------------------------------------
----Procedimientos almacenados para la tabla Marca----
------------------------------------------------------

CREATE PROCEDURE InsertarMarca
	@marca VARCHAR(30)
AS
BEGIN
	INSERT INTO marca (marca)
	VALUES (@marca)
END

EXEC InsertarMarca @marca = 'SI'

SELECT * FROM marca

------------------------------------------------------

CREATE PROCEDURE ModificarMarca
    @IdMarca INT,
    @marca VARCHAR(30)
AS
BEGIN
    UPDATE marca
    SET marca = @marca
    WHERE idmarca = @IdMarca
END

EXEC ModificarMarca @IdMarca = 29, @marca = 'Fi'

------------------------------------------------------

CREATE PROCEDURE BorrarMarca
    @IdMarca INT
AS
BEGIN
    DELETE FROM marca
    WHERE idmarca = @IdMarca
END

EXEC BorrarMarca @IdMarca = 29

------------------------------------------------------
--Procedimientos almacenados para la tabla Usuarios---
------------------------------------------------------

CREATE PROCEDURE InsertarUsuario
    @Nombre VARCHAR(20),
    @Contrasena VARCHAR(30),
    @Rol VARCHAR(18)
AS
BEGIN
    -- Verificar si el rol existe en la tabla roles
    IF EXISTS (SELECT 1 FROM roles WHERE rol = @Rol)
    BEGIN
        -- Obtener el ID del rol existente
        DECLARE @IdRol INT
        SELECT @IdRol = idrol FROM roles WHERE rol = @Rol
        
        -- Insertar el nuevo usuario con el rol correspondiente
        INSERT INTO usuarios (nombre, contrasena, roles_idrol)
        VALUES (@Nombre, @Contrasena, @IdRol)
        
        SELECT 'Usuario insertado correctamente.'
    END
    ELSE
    BEGIN
        SELECT 'El rol especificado no existe en la tabla roles.'
    END
END

EXEC InsertarUsuario @Nombre = 'Franz', @Contrasena = 'contraseña1', @Rol = 'Administrador'
EXEC InsertarUsuario @Nombre = 'Emily', @Contrasena = 'contraseña2', @Rol = 'Operario'

--Muestra de la union de las tablas "usuarios" y "roles", solo se muestran las columnas Nombre, Contraseña y Rol--
SELECT u.nombre, u.contrasena, r.rol
FROM usuarios u
JOIN roles r ON u.roles_idrol = r.idrol;

------------------------------------------------------

CREATE PROCEDURE ModificarUsuario
    @Nombre VARCHAR(20),
    @Contrasena VARCHAR(30),
    @Rol VARCHAR(18)
AS
BEGIN
    -- Verificar si el rol existe en la tabla roles
    IF EXISTS (SELECT 1 FROM roles WHERE rol = @Rol)
    BEGIN
        -- Obtener el ID del rol existente
        DECLARE @IdRol INT
        SELECT @IdRol = idrol FROM roles WHERE rol = @Rol
        
        -- Verificar si el usuario existe en la tabla usuarios
        IF EXISTS (SELECT 1 FROM usuarios WHERE nombre = @Nombre)
        BEGIN
            -- Actualizar los datos del usuario existente con el nuevo rol
            UPDATE usuarios
			SET contrasena = @Contrasena, roles_idrol = @IdRol
			WHERE nombre = @Nombre
            
            SELECT 'Usuario modificado correctamente.'
        END
        ELSE
        BEGIN
            SELECT 'El usuario especificado no existe en la tabla usuarios.'
        END
    END
    ELSE
    BEGIN
        SELECT 'El rol especificado no existe en la tabla roles.'
    END
END

EXEC ModificarUsuario @Nombre = 'Franz', @Contrasena = '1342882', @Rol = 'Administrador'

------------------------------------------------------

CREATE PROCEDURE BorrarUsuario
    @Nombre VARCHAR(20)
AS
BEGIN
    -- Verificar si el usuario existe en la tabla usuarios
    IF EXISTS (SELECT 1 FROM usuarios WHERE nombre = @Nombre)
    BEGIN
        -- Eliminar el usuario de la tabla usuarios
        DELETE FROM usuarios WHERE nombre = @Nombre
        
        SELECT 'Usuario borrado correctamente.'
    END
    ELSE
    BEGIN
        SELECT 'El usuario especificado no existe en la tabla usuarios.'
    END
END

EXEC BorrarUsuario @Nombre = 'Franz'
EXEC BorrarUsuario @Nombre = 'Emily'

------------------------------------------------------
-----Procedimientos Almacenados de la tabla Roles-----
------------------------------------------------------

CREATE PROCEDURE InsertarRol
	@rol VARCHAR(18)
AS
BEGIN
	INSERT INTO roles(rol)
	VALUES (@rol)
END

EXEC InsertarRol @rol = 'Contador'

SELECT * FROM roles

------------------------------------------------------

CREATE PROCEDURE ModificarRol
    @IdRol INT,
    @rol VARCHAR(30)
AS
BEGIN
    UPDATE roles
    SET rol = @rol
    WHERE idrol = @IdRol
END

EXEC ModificarRol @IdRol = 3, @rol = 'Cajero'

------------------------------------------------------

CREATE PROCEDURE BorrarRol
    @IdRol INT
AS
BEGIN
    DELETE FROM roles
    WHERE idrol = @IdRol
END

EXEC BorrarRol @IdRol = 3

------------------------------------------------------
----Procedimientos Almacenados de la tabla Tecnico----
------------------------------------------------------
CREATE PROCEDURE InsertarTecnico
	@DNI CHAR(8),
    @Nombres VARCHAR(20),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @Telefono CHAR(9)
AS
BEGIN
    INSERT INTO tecnico (dni_tecnico, nombres, apellido_paterno, apellido_materno, telefono)
    VALUES (@DNI, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Telefono)
END

EXEC InsertarTecnico @DNI = '12345678', @Nombres = 'Juan Andres', @ApellidoPaterno = 'Perez', @ApellidoMaterno = 'Bances', @Telefono = '912345678'

SELECT * FROM tecnico

------------------------------------------------------

CREATE PROCEDURE ModificarTecnico
    @IdTecnico INT,
    @DNI CHAR(8),
    @Nombres VARCHAR(20),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @Telefono CHAR(9)
AS
BEGIN
    UPDATE tecnico
    SET dni_tecnico = @DNI,
        nombres = @Nombres,
        apellido_paterno = @ApellidoPaterno,
        apellido_materno = @ApellidoMaterno,
        telefono = @Telefono
    WHERE idTecnico = @IdTecnico
END

EXEC ModificarTecnico @IdTecnico = 5, @DNI = '12345677',@Nombres = 'Fi', @ApellidoPaterno = 'Si', @ApellidoMaterno = 'Mi', @Telefono = '111111111'

------------------------------------------------------

CREATE PROCEDURE BorrarTecnico
    @IdTecnico INT
AS
BEGIN
    -- Verificar si el técnico tiene informes relacionados
    IF EXISTS (SELECT 1 FROM informe WHERE tecnico = @IdTecnico)
    BEGIN
        -- Mostrar mensaje de advertencia
        SELECT 'El técnico tiene informes relacionados. La eliminación del técnico también eliminará todos los informes asociados.' AS WarningMessage
        
        -- Eliminar los registros relacionados en la tabla art_vend
        DELETE FROM art_vend WHERE info_idInforme IN (SELECT nro_de_informe FROM informe WHERE tecnico = @IdTecnico)
        
        -- Eliminar los informes relacionados
        DELETE FROM informe WHERE tecnico = @IdTecnico
    END
    
    -- Eliminar el técnico
    DELETE FROM tecnico WHERE idTecnico = @IdTecnico
    
    -- Verificar si se eliminó el técnico
    IF @@ROWCOUNT = 0
    BEGIN
        SELECT 'No se encontró ningún técnico con el ID especificado.' AS ErrorMessage
    END
    ELSE
    BEGIN
        SELECT 'Técnico borrado correctamente.' AS SuccessMessage
    END
END

EXEC BorrarTecnico @IdTecnico = 5


------------------------------------------------------
---Procedimientos Almacenados de la tabla Articulos---
------------------------------------------------------

CREATE PROCEDURE InsertarArticulo
    @Nombre VARCHAR(80),
    @Precio DECIMAL(10, 2),
    @Marca VARCHAR(30),
    @Categoria VARCHAR(30)
AS
BEGIN
    -- Verificar si la marca existe en la tabla marca
    IF EXISTS (SELECT 1 FROM marca WHERE marca = @Marca)
    BEGIN
        -- Obtener el ID de la marca existente
        DECLARE @IdMarca INT
        SELECT @IdMarca = idmarca FROM marca WHERE marca = @Marca
        
        -- Verificar si la categoría existe en la tabla categoria
        IF EXISTS (SELECT 1 FROM categoria WHERE categoria = @Categoria)
        BEGIN
            -- Obtener el ID de la categoría existente
            DECLARE @IdCategoria INT
            SELECT @IdCategoria = idcategoria FROM categoria WHERE categoria = @Categoria
            
            -- Insertar el nuevo artículo con las claves foráneas correspondientes
            INSERT INTO articulos (nombre, precio, marca_idmarca, categoria_idcategoria)
            VALUES (@Nombre, @Precio, @IdMarca, @IdCategoria)
            
            SELECT 'Artículo insertado correctamente.'
        END
        ELSE
        BEGIN
            SELECT 'La categoría especificada no existe en la tabla categoria.'
        END
    END
    ELSE
    BEGIN
        SELECT 'La marca especificada no existe en la tabla marca.'
    END
END

EXEC InsertarArticulo @Nombre = 'tv tactico', @Precio = 99.99, @Marca = 'Sony', @Categoria = 'Radios';

SELECT * FROM articulos

--modificacion para añadir el stock--

ALTER PROCEDURE InsertarArticulo
    @Nombre VARCHAR(80),
    @Precio DECIMAL(10, 2),
    @Marca VARCHAR(30),
    @Categoria VARCHAR(30),
    @Stock INT
AS
BEGIN
    -- Verificar si la marca existe en la tabla marca
    IF EXISTS (SELECT 1 FROM marca WHERE marca = @Marca)
    BEGIN
        -- Obtener el ID de la marca existente
        DECLARE @IdMarca INT
        SELECT @IdMarca = idmarca FROM marca WHERE marca = @Marca
        
        -- Verificar si la categoría existe en la tabla categoria
        IF EXISTS (SELECT 1 FROM categoria WHERE categoria = @Categoria)
        BEGIN
            -- Obtener el ID de la categoría existente
            DECLARE @IdCategoria INT
            SELECT @IdCategoria = idcategoria FROM categoria WHERE categoria = @Categoria
            
            -- Insertar el nuevo artículo con las claves foráneas correspondientes
            INSERT INTO articulos (nombre, precio, marca_idmarca, categoria_idcategoria, stock)
            VALUES (@Nombre, @Precio, @IdMarca, @IdCategoria, @Stock)
            
            SELECT 'Artículo insertado correctamente.'
        END
        ELSE
        BEGIN
            SELECT 'La categoría especificada no existe en la tabla categoria.'
        END
    END
    ELSE
    BEGIN
        SELECT 'La marca especificada no existe en la tabla marca.'
    END
END

------------------------------------------------------
CREATE PROCEDURE ModificarArticulo
    @IdArticulo INT,
    @Nombre VARCHAR(80),
    @Precio DECIMAL(10, 2),
    @Marca VARCHAR(30),
    @Categoria VARCHAR(30)
AS
BEGIN
    -- Verificar si el artículo existe en la tabla articulos
    IF EXISTS (SELECT 1 FROM articulos WHERE idarticulo = @IdArticulo)
    BEGIN
        -- Verificar si la marca existe en la tabla marca
        IF EXISTS (SELECT 1 FROM marca WHERE marca = @Marca)
        BEGIN
            -- Obtener el ID de la marca existente
            DECLARE @IdMarca INT
            SELECT @IdMarca = idmarca FROM marca WHERE marca = @Marca
            
            -- Verificar si la categoría existe en la tabla categoria
            IF EXISTS (SELECT 1 FROM categoria WHERE categoria = @Categoria)
            BEGIN
                -- Obtener el ID de la categoría existente
                DECLARE @IdCategoria INT
                SELECT @IdCategoria = idcategoria FROM categoria WHERE categoria = @Categoria
                
                -- Actualizar el artículo con las claves foráneas correspondientes
                UPDATE articulos
                SET nombre = @Nombre, precio = @Precio, marca_idmarca = @IdMarca, categoria_idcategoria = @IdCategoria
                WHERE idarticulo = @IdArticulo
                
                SELECT 'Artículo modificado correctamente.'
            END
            ELSE
            BEGIN
                SELECT 'La categoría especificada no existe en la tabla categoria.'
            END
        END
        ELSE
        BEGIN
            SELECT 'La marca especificada no existe en la tabla marca.'
        END
    END
    ELSE
    BEGIN
        SELECT 'El artículo especificado no existe en la tabla articulos.'
    END
END

EXEC ModificarArticulo @IdArticulo = 11, @Nombre = 'TV monitor', @Precio = 199.99, @Marca = 'Samsung', @Categoria = 'Sonares';

--modificacion para añadir el stock--

ALTER PROCEDURE ModificarArticulo
    @IdArticulo INT,
    @Nombre VARCHAR(80),
    @Precio DECIMAL(10, 2),
    @Marca VARCHAR(30),
    @Categoria VARCHAR(30),
    @Stock INT
AS
BEGIN
    -- Verificar si el artículo existe en la tabla articulos
    IF EXISTS (SELECT 1 FROM articulos WHERE idarticulo = @IdArticulo)
    BEGIN
        -- Verificar si la marca existe en la tabla marca
        IF EXISTS (SELECT 1 FROM marca WHERE marca = @Marca)
        BEGIN
            -- Obtener el ID de la marca existente
            DECLARE @IdMarca INT
            SELECT @IdMarca = idmarca FROM marca WHERE marca = @Marca
            
            -- Verificar si la categoría existe en la tabla categoria
            IF EXISTS (SELECT 1 FROM categoria WHERE categoria = @Categoria)
            BEGIN
                -- Obtener el ID de la categoría existente
                DECLARE @IdCategoria INT
                SELECT @IdCategoria = idcategoria FROM categoria WHERE categoria = @Categoria
                
                -- Actualizar el artículo con las claves foráneas correspondientes
                UPDATE articulos
                SET nombre = @Nombre, precio = @Precio, marca_idmarca = @IdMarca, categoria_idcategoria = @IdCategoria, stock = @Stock
                WHERE idarticulo = @IdArticulo
                
                SELECT 'Artículo modificado correctamente.'
            END
            ELSE
            BEGIN
                SELECT 'La categoría especificada no existe en la tabla categoria.'
            END
        END
        ELSE
        BEGIN
            SELECT 'La marca especificada no existe en la tabla marca.'
        END
    END
    ELSE
    BEGIN
        SELECT 'El artículo especificado no existe en la tabla articulos.'
    END
END

------------------------------------------------------

CREATE PROCEDURE BorrarArticulo
    @IdArticulo INT
AS
BEGIN
    -- Verificar si el artículo existe en la tabla articulos
    IF EXISTS (SELECT 1 FROM articulos WHERE idarticulo = @IdArticulo)
    BEGIN
        -- Eliminar los registros relacionados en la tabla art_vend
        DELETE FROM art_vend WHERE art_idart = @IdArticulo
        
        -- Eliminar el artículo
        DELETE FROM articulos WHERE idarticulo = @IdArticulo
        
        SELECT 'Artículo borrado correctamente.'
    END
    ELSE
    BEGIN
        SELECT 'El artículo especificado no existe en la tabla articulos.'
    END
END

EXEC BorrarArticulo @IdArticulo = 11

------------------------------------------------------
---Procedimientos Almacenados de la tabla Informes----
------------------------------------------------------

ALTER PROCEDURE InsertarInforme
    @NombreCliente VARCHAR(20),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @DNI CHAR(8),
    @Telefono CHAR(9),
    @Email VARCHAR(50),
    @MontoTotal DECIMAL(10, 2),
    @DireccionInstalacion VARCHAR(80),
    @NotasAdicionales TEXT,
    @Redactor INT,
    @ArticulosVend INT,
    @Tecnico INT
AS
BEGIN
    -- Insertar el nuevo informe
    INSERT INTO informe (nombre_de_cliente, apellido_paterno, apellido_materno, dni, telefono, email, monto_total, direccion_instalacion, notas_adicionales, redactor, articulos_vend, tecnico)
    VALUES (@NombreCliente, @ApellidoPaterno, @ApellidoMaterno, @DNI, @Telefono, @Email, @MontoTotal, @DireccionInstalacion, @NotasAdicionales, @Redactor, @ArticulosVend, @Tecnico)
    
    SELECT SCOPE_IDENTITY() AS 'NuevoNumeroInforme'
END

EXEC InsertarInforme @NombreCliente = 'John', @ApellidoPaterno = 'Doe', @ApellidoMaterno = 'Smith', @DNI = '12345678', @Telefono = '123456789', @Email = 'john.doe@example.com', @MontoTotal = 100.00, @DireccionInstalacion = '123 Main Street', @NotasAdicionales = 'Sin notas adicionales', @Redactor = 1, @ArticulosVend = 2, @Tecnico = 3
SELECT * FROM informe

ALTER PROCEDURE InsertarInforme
	@NroInforme int,
    @NombreCliente VARCHAR(20),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @DNI CHAR(8),
    @Telefono CHAR(9),
    @Email VARCHAR(50),
    @MontoTotal DECIMAL(10, 2),
    @DireccionInstalacion VARCHAR(80),
    @NotasAdicionales TEXT,
    @Redactor INT,
    @ArticulosVend INT,
    @Tecnico INT
AS
BEGIN
    -- Insertar el nuevo informe
    INSERT INTO informe (nro_de_informe, nombre_de_cliente, apellido_paterno, apellido_materno, dni, telefono, email, monto_total, direccion_instalacion, notas_adicionales, redactor, articulos_vend, tecnico)
    VALUES (@NroInforme, @NombreCliente, @ApellidoPaterno, @ApellidoMaterno, @DNI, @Telefono, @Email, @MontoTotal, @DireccionInstalacion, @NotasAdicionales, @Redactor, @ArticulosVend, @Tecnico)
    
    SELECT SCOPE_IDENTITY() AS 'NuevoNumeroInforme'
END

------------------------------------------------------

CREATE PROCEDURE ModificarInforme
    @NumeroInforme INT,
    @NombreCliente VARCHAR(20),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @DNI CHAR(8),
    @Telefono CHAR(9),
    @Email VARCHAR(50),
    @MontoTotal DECIMAL(10, 2),
    @DireccionInstalacion VARCHAR(80),
    @NotasAdicionales TEXT,
    @Redactor INT,
    @ArticulosVend INT,
    @Tecnico INT
AS
BEGIN
    -- Verificar si el informe existe
    IF EXISTS (SELECT 1 FROM informe WHERE nro_de_informe = @NumeroInforme)
    BEGIN
        -- Actualizar el informe
        UPDATE informe
        SET nombre_de_cliente = @NombreCliente, apellido_paterno = @ApellidoPaterno, apellido_materno = @ApellidoMaterno, dni = @DNI, telefono = @Telefono, email = @Email, monto_total = @MontoTotal, direccion_instalacion = @DireccionInstalacion, notas_adicionales = @NotasAdicionales, redactor = @Redactor, articulos_vend = @ArticulosVend, tecnico = @Tecnico
        WHERE nro_de_informe = @NumeroInforme
        
        SELECT 'Informe actualizado correctamente.'
    END
    ELSE
    BEGIN
        SELECT 'El informe especificado no existe.'
    END
END

EXEC ModificarInforme @NumeroInforme = '11', @NombreCliente = 'John', @ApellidoPaterno = 'Doe', @ApellidoMaterno = 'Smith', @DNI = '12345688', @Telefono = '123456389', @Email = 'john.pito@example.com', @MontoTotal = 100.00, @DireccionInstalacion = '123 MainPerl', @NotasAdicionales = 'Sin notas adicionales', @Redactor = 2, @ArticulosVend = 5, @Tecnico = 1
SELECT * FROM informe

------------------------------------------------------

CREATE PROCEDURE BorrarInforme
    @NumeroInforme INT
AS
BEGIN
    -- Verificar si el informe existe
    IF EXISTS (SELECT 1 FROM informe WHERE nro_de_informe = @NumeroInforme)
    BEGIN
        -- Borrar el informe
        DELETE FROM informe WHERE nro_de_informe = @NumeroInforme
        
        SELECT 'Informe borrado correctamente.'
    END
    ELSE
    BEGIN
        SELECT 'El informe especificado no existe.'
    END
END


EXEC BorrarInforme @NumeroInforme = '11'

------------------------------------------------------
---Procedimientos para la tabla ART_VEND ----
------------------------------------------------------
CREATE PROCEDURE InsertarArticulosVendidos
    @IdInforme INT,
    @articulo INT,
    @cantidad INT,
    @monto DECIMAL(10, 2)
AS
BEGIN
    -- Insertar los datos en la tabla art_vend
    INSERT INTO art_vend (art_idArt, info_idInforme, cantidad, monto_total)
    VALUES (@articulo, @IdInforme, @cantidad, @monto)
END

------------------------------------------------------
CREATE PROCEDURE ModificarArticulosVendidos
    @IdInforme INT,
    @articulo INT,
    @cantidad INT,
    @monto DECIMAL(10, 2)
AS
BEGIN
    -- Modificar los datos en la tabla art_vend para el artículo y el informe específicos
    UPDATE art_vend
    SET cantidad = @cantidad,
        monto_total = @monto
    WHERE art_idArt = @articulo
      AND info_idInforme = @IdInforme
END
------------------------------------------------------
CREATE PROCEDURE EliminarArticuloVendido
    @IdInforme INT,
    @articulo INT
AS
BEGIN
    -- Eliminar el registro de la tabla art_vend para el artículo y el informe específicos
    DELETE FROM art_vend
    WHERE art_idArt = @articulo
      AND info_idInforme = @IdInforme
END

-----------------------------------------------------------
---Procedimiento Almacenado para corregir los informes ----
-----------------------------------------------------------
CREATE PROCEDURE ActualizarArticulosYMontoTotal
AS
BEGIN
    -- Variables para almacenar el último informe y los valores actualizados
    DECLARE @UltimoInforme INT
    DECLARE @TotalArticulosVendidos INT
    DECLARE @MontoTotal DECIMAL(10, 2)

    -- Obtener el último informe de la tabla "informe"
    SELECT TOP 1 @UltimoInforme = nro_de_informe
    FROM informe
    ORDER BY nro_de_informe DESC

    -- Obtener el total de artículos vendidos y la sumatoria de los montos de la tabla "art_vend"
    SELECT @TotalArticulosVendidos = COUNT(*), @MontoTotal = SUM(monto_total)
    FROM art_vend
    WHERE info_idInforme = @UltimoInforme

    -- Actualizar los campos "articulos_vend" y "monto_total" en el último informe de la tabla "informe"
    UPDATE informe
    SET articulos_vend = @TotalArticulosVendidos, monto_total = @MontoTotal
    WHERE nro_de_informe = @UltimoInforme
END

------------------------------------------------------
---TRIGGER para la cantidad de articulos vendidos ----
------------------------------------------------------
DROP TRIGGER trg_calcularMonto

CREATE TRIGGER trg_calcularMonto
ON art_vend
AFTER INSERT
AS
BEGIN
    UPDATE av
    SET monto_total = (i.cantidad * (
        SELECT precio FROM articulos WHERE idarticulo = i.art_idArt
    ))
    FROM art_vend av
    INNER JOIN inserted i ON av.art_idArt = i.art_idArt;
END;


------------------------------------------------------
---TRIGGER para disminuir stock de los articulos  ----
------------------------------------------------------
CREATE TRIGGER DisminuirStock
ON art_vend
AFTER INSERT
AS
BEGIN
    -- Actualizar el stock en la tabla articulos
    UPDATE articulos
    SET stock = stock - i.cantidad
    FROM articulos a
    INNER JOIN inserted i ON a.idarticulo = i.art_idArt;
END;