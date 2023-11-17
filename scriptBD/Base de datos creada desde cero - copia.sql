CREATE DATABASE NSG;
USE NSG;

CREATE TABLE categoria (
    idcategoria INT IDENTITY(1,1) PRIMARY KEY,
    categoria VARCHAR(30) NOT NULL
);

CREATE TABLE marca (
    idmarca INT IDENTITY(1,1) PRIMARY KEY,
    marca VARCHAR(30) NOT NULL
);

CREATE TABLE articulos (
    idarticulo INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(80) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    marca_idmarca INT NOT NULL,
    categoria_idcategoria INT NOT NULL,
    FOREIGN KEY (marca_idmarca) REFERENCES marca (idmarca),
    FOREIGN KEY (categoria_idcategoria) REFERENCES categoria (idcategoria)
);

CREATE TABLE roles (
    idrol INT IDENTITY(1,1) PRIMARY KEY,
    rol   VARCHAR(18)
);

CREATE TABLE usuarios (
    iduser      INT IDENTITY(1,1) PRIMARY KEY,
    nombre      VARCHAR(20) NOT NULL,
    contrasena  VARCHAR(30) NOT NULL,
    roles_idrol INT NOT NULL,
	FOREIGN KEY (roles_idrol) REFERENCES roles (idrol)
);

CREATE TABLE tecnico (
	idTecnico              INT IDENTITY(1,1) PRIMARY KEY,
    dni_tecnico            CHAR(8) NOT NULL,
    nombres                VARCHAR(20) NOT NULL,
    apellido_paterno       VARCHAR(15) NOT NULL,
    apellido_materno       VARCHAR(15) NOT NULL,
    telefono               CHAR(9) NOT NULL,
	CONSTRAINT dni_unico UNIQUE (dni_tecnico)
);

CREATE TABLE informe (
    nro_de_informe        INT IDENTITY(1,1) PRIMARY KEY,
    nombre_de_cliente     VARCHAR(20) NOT NULL,
    apellido_paterno      VARCHAR(15) NOT NULL,
    apellido_materno      VARCHAR(15) NOT NULL,
    dni                   CHAR(8) NOT NULL,
    telefono              CHAR(9) NOT NULL,
    email                 VARCHAR(50),
    fecha                 DATETIME NOT NULL DEFAULT GETDATE(),
    monto_total           DECIMAL(10, 2) NOT NULL,
    direccion_instalacion VARCHAR(80) NOT NULL,
    notas_adicionales     TEXT,
    redactor              INT NOT NULL,
    articulos_vend        INT NOT NULL,
    tecnico               INT NOT NULL,
    FOREIGN KEY (tecnico) REFERENCES tecnico (idTecnico),
	FOREIGN KEY (redactor) REFERENCES usuarios (idUser)
);

UPDATE informe
SET monto_total = av.total_monto
FROM informe
JOIN (
    SELECT info_idInforme, SUM(monto_total) AS total_monto
    FROM art_vend
    GROUP BY info_idInforme
) AS av ON informe.nro_de_informe = av.info_idInforme

SELECT * FROM informe

CREATE TABLE art_vend (
    art_idArt      INT NOT NULL,
    info_idInforme INT NOT NULL,
	FOREIGN KEY (art_idArt) REFERENCES articulos (idarticulo),
	FOREIGN KEY (info_idInforme) REFERENCES informe (nro_de_informe)
);

ALTER TABLE art_vend
ADD cantidad INT NOT NULL,
    monto_total DECIMAL(10, 2) NOT NULL;

ALTER TABLE art_vend
ADD CONSTRAINT DF_art_vend_monto_total DEFAULT 0 FOR monto_total;


INSERT INTO categoria (categoria) VALUES
('Radios'),
('Sonares'),
('Cámaras'),
('Alarmas'),
('Control acceso'),
('Intercomunicadores'),
('Megafonía');

INSERT INTO marca (marca) VALUES
('Axis'),
('Bosch'),
('Pelco'),
('Sony'),
('Avigilon'),
('LTS'),
('Samsung'),
('Panasonic'),
('Honeywell'),
('Genetec'),
('FLIR'),
('Geovision'),
('IDIS'),
('Milestone');

INSERT INTO articulos (nombre, precio, marca_idmarca, categoria_idcategoria) VALUES
('Camara de seguridad exterior', 149.99, 1, 3),
('Kit de videovigilancia HD', 299.99, 2, 3),
('Controlador de acceso biométrico', 199.99, 4, 5),
('Detector de humo inteligente', 49.99, 13, 4),
('Intercomunicador IP', 89.99, 8, 6),
('Megáfono portátil', 39.99, 10, 7),
('Antena amplificadora de señal', 29.99, 11, 5),
('Cerradura electrónica inteligente', 129.99, 12, 5),
('Vehículo de patrulla', 249.99, 14, 4),
('Cámara submarina', 179.99, 5, 3);

INSERT INTO roles (rol) VALUES
('Administrador'),
('Operario');

INSERT INTO usuarios(nombre, contrasena, roles_idrol) VALUES
('Martin','sgcomunicaciones', 1),
('David', 'moto123', 2);

INSERT INTO tecnico (dni_tecnico, nombres, apellido_paterno, apellido_materno, telefono) VALUES
('75438745', 'David', 'Chapoñan', 'Santamaría', 949741899),
('76605834', 'Wilder', 'Cachay', 'Elias', 928872004),
('74978225','Jonathan','Altamirano','Romero',983597122),
('77523548','Junior','Santisteban','Valdera',912126501);
	SELECT * FROM informe
INSERT INTO informe (nombre_de_cliente, apellido_paterno, apellido_materno, dni, telefono, email, monto_total, direccion_instalacion, notas_adicionales, redactor, articulos_vend, tecnico)
VALUES
('Juan', 'Pérez', 'Gómez', '12345678', '987654321', 'juan.perez@example.com', 100.50, 'Calle Principal 123', 'Notas adicionales 1', 1, 5, 3),
('María', 'López', 'García', '87654321', '123456789', 'maria.lopez@example.com', 250.75, 'Avenida Central 456', 'Notas adicionales 2', 2, 8, 2),
('Carlos', 'González', 'Martínez', '65432187', '987654321', 'carlos.gonzalez@example.com', 50.25, 'Calle Secundaria 789', 'Notas adicionales 3', 2, 2, 1),
('Luis', 'Rodríguez', 'Sánchez', '98765432', '987654321', 'luis.rodriguez@example.com', 350.25, 'Avenida Principal 987', 'Notas adicionales 4', 1, 4, 3),
('Ana', 'Hernández', 'López', '56789012', '123456789', 'ana.hernandez@example.com', 75.50, 'Calle Secundaria 654', 'Notas adicionales 5', 1, 7, 4),
('Pedro', 'García', 'Martínez', '10987654', '987654321', 'pedro.garcia@example.com', 200.00, 'Avenida Central 321', 'Notas adicionales 6', 2, 3, 1),
('Sofía', 'López', 'Hernández', '43210987', '123456789', 'sofia.lopez@example.com', 150.00, 'Calle Principal 654', 'Notas adicionales 7', 1, 9, 3),
('Miguel', 'Martínez', 'González', '21098765', '987654321', 'miguel.martinez@example.com', 80.75, 'Avenida Secundaria 123', 'Notas adicionales 8', 2, 6, 2),
('Laura', 'Sánchez', 'Rodríguez', '67890123', '123456789', 'laura.sanchez@example.com', 175.25, 'Calle Secundaria 987', 'Notas adicionales 9', 2, 10, 1),
('Javier', 'Gómez', 'Pérez', '34567890', '987654321', 'javier.gomez@example.com', 300.50, 'Avenida Principal 456', 'Notas adicionales 10', 1, 1, 4);

SELECT * FROM art_vend

INSERT INTO art_vend (art_idArt, info_idInforme, cantidad)
VALUES
(5, 1, 4),
(8, 1, 5),
(2, 2, 10),
(4, 2, 7),
(2, 3, 12),
(1, 3, 20),
(4, 4, 45),
(7, 4, 14),
(9, 5, 4),
(3, 5, 2),
(7, 6, 9),
(4, 6, 1),
(3, 7, 8),
(5, 7, 38),
(9, 8, 19),
(6, 8, 20),
(10, 9, 60),
(1, 9, 5),
(6, 10, 2),
(2, 10, 12);
