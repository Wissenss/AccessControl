-- Persona --
INSERT INTO Persona VALUES 
(1, 'Leonardo', 'Merino Garfias', '449 233 4242', 'lmerino@gmail.com', '1234', '49FK3939568823KDKFÑ04', NULL),
(2, 'David', 'Delgado Villalobos', '449 332 2332', 'ddelgado@gmail.com', '2773', '49FK393956882DKDJK78FÑ04', NULL),
(3, 'Andres Esteban', 'Escudero Robles', '449 233 1042', 'aescudero@gmail.com', '4242', '49FK3939DHT8823KDKFÑ04', NULL),
(4, 'Alejandro', 'Medina Castañeda', '449 233 3042', 'amedina@gmail.com', '4242', 'DJFK3939568DKWSIKW8FÑ04', NULL),
(5, 'Diego', 'Lopez Mendoza', '449 243 1362', 'dlopez@gmail.com', '4242', 'SSKDOOE939568823KDKFÑ04', NULL),
(6, 'Leslie Miroslava', 'Benites Marin', '449 533 1395', 'lbenites@gmail.com', '7232', '49FK39395688233DKD04', NULL);

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


-- SemanaTipo --
INSERT INTO accesscontrol.semanatipo VALUES 
(2222, "Semana de prueba", "2023-06-12"),
(2223, "Semana 2 de prueba", "2023-06-04");

-- AccesosSemana --
INSERT INTO accesscontrol.accesossemana VALUES 
(1, "Lunes", 8, 1, 1, 2222),
(2, "Lunes", 9, 1, 3, 2222),
(3, "Lunes", 8, 1, 2, 2222),
(4, "Martes", 9, 1, 1, 2222),
(5, "Martes", 10, 1, 1, 2222),
(6, "Jueves", 11, 2, 1, 2222);