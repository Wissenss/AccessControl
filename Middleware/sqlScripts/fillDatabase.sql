-- Persona --
INSERT INTO Persona VALUES 
(1, 'Leonardo', 'Merino Garfias', '449 233 4242', 'lmerino@gmail.com'),
(2, 'David', 'Delgado Villalobos', '449 332 2332', 'ddelgado@gmail.com'),
(3, 'Andres Esteban', 'Escudero Robles', '449 233 1042', 'aescudero@gmail.com'),
(4, 'Alejandro', 'Medina Castañeda', '449 233 3042', 'amedina@gmail.com'),
(5, 'Diego', 'Lopez Mendoza', '449 243 1362', 'dlopez@gmail.com'),
(6, 'Leslie Miroslava', 'Benites Marin', '449 533 1395', 'lbenites@gmail.com');

-- Grupo Persona--
INSERT INTO GrupoPersona VALUES 
(1, "Guardias", "Encargados de la seguridad"),
(2, "Clientes", "Visitantes a las intalaciones"),
(3, "Administradores", "Encargados de la gestión");

INSERT INTO DetalleGrupoPersona VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 2),
(4, 4, 2),
(5, 5, 3),
(6, 6, 3);

-- Grupo Puerta --
INSERT INTO grupopuerta VALUES 
(-1, "Sin Asignar", "Puertas sin área asignada"),
(1, "Investigación", "Puertas del área de investigación"),
(2, "Almacenes", "Almacenes de uso general"),
(3, "Administración", "Puertas del área administrativa");

-- Puerta --
INSERT INTO Puerta VALUES
(1, "Laboratorio 60", "Investigación", "Sin Observaciones", 1),
(2, "Laboratorio 23", "Investigación", "Sin Observaciones", 1),
(3, "Almacén A23", "Almacenes", "En Remodelación", 2),
(23, "Oficina Administrativa", "Adminstracion", "Sin Observaciones", 3),
(4, "Puerta de prueba sin asignar", "Sin zona", "Sin Observaciones", -1),
(5, "Otra puerta de prueba sin asignar", "Sin zona", "Sin Observaciones", -1);