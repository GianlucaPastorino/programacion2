/* INSTERT INDIVIDUAL */
INSERT INTO Alumnos (NOMBRE, APELLIDO, ID_MATERIA) VALUES ('Esteban', 'Prieto', 3);
INSERT INTO Alumnos (NOMBRE, APELLIDO) VALUES ('Caro', 'Scrofani'); /* Si no pongo nada en id materia me lo completa con null */
/* INSERT MULTIPLE */
INSERT INTO Alumnos (NOMBRE, APELLIDO, ID_MATERIA)
VALUES ('Esteban', 'Prieto', 3),
		('Caro', 'Scrofani', NULL);