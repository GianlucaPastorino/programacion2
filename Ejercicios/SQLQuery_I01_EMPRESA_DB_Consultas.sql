USE EMPRESA_DB;

--2 Insertar los siguientes registros a la tabla PUESTOS:
/*INSERT INTO PUESTOS (ID_PUESTO, NOMBRE, NIVEL_AUTORIZACION)
VALUES (1, 'Director', 3),
		(2, 'Gerente', 3),
		(5, 'Jefe de sector', 2),
		(4, 'Administrativo', 1),
		(3, 'Vendedor', 0),
		(6, 'Secretario', 2);*/

-- 3 Insertar los siguientes registros a la tabla EMPLEADOS:
/*INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_PUESTO, SALARIO, ESTA_ACTIVO, FECHA_ALTA, FECHA_BAJA, MAIL)
VALUES ('Leilani', 'Kinney', 1, 383946.80, 1, '1996-03-21', NULL, 'lkinney@gmail.com'),
		('Igor', 'England', 5, 283558.85, 1, '2013-03-28', NULL, 'iengland@hotmail.com'),
		('Maya', 'Brock', 3, 164546.09, 1, '1993-10-24', NULL, NULL),
		('Hayden', 'Moss', 4, 211695.50, 0, '2012-06-07', '2015-02-19', 'hmoss@gmail.com'),
		('Amal', 'Colon', 2, 388933.60, 1, '2019-09-23', NULL, NULL);*/

--4 Realizar las siguientes consultas:
--Todos los empleados con todos sus datos.
SELECT * FROM EMPLEADOS;
--El nombre (y sólo eso) de todos los puestos.
SELECT NOMBRE FROM PUESTOS;
--Sólo los empleados que estén activos (ESTA_ACTIVO = 1).
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1;
--Los empleados cuyo salario sea mayor a $200.000,00.
SELECT * FROM EMPLEADOS WHERE SALARIO > 200000.00;
--Los empleados cuya fecha de alta sea menor o igual al 07/06/2012.
SELECT * FROM EMPLEADOS WHERE FECHA_ALTA <= '2012-06-07';
--Los empleados que no tengan mail cargado.
SELECT * FROM EMPLEADOS WHERE MAIL IS NULL;
--Los empleados que tengan mail cargado.
SELECT * FROM EMPLEADOS WHERE MAIL IS NOT NULL;
--Los empleados cuyo mail sea de gmail.
SELECT * FROM EMPLEADOS WHERE MAIL LIKE '%@GMAIL.COM';
--Los empleados cuyo apellido empiece con la letra "B".
SELECT * FROM EMPLEADOS WHERE APELLIDO LIKE 'B%';

--5 Realizar las siguientes consultas:
--Los empleados que estén activos y ganen más de $300.000,00.
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1 AND SALARIO > 300000;
--Los empleados que no tengan mail o no estén activos.
SELECT * FROM EMPLEADOS WHERE MAIL IS NULL OR ESTA_ACTIVO = 0;
--Los empleados que tengan mail y su nombre contenga la letra "a".
SELECT * FROM EMPLEADOS WHERE MAIL IS NOT NULL AND NOMBRE LIKE '%a%';
--Los empleados que ganen $250.000,00 o más y hayan ingresado después del año 2000 inclusive,
--o aquellos que ganen menos de $250.000,00 y hayan ingresado antes del año 2000 sin incluir.
SELECT * FROM EMPLEADOS WHERE SALARIO >= 250000 AND FECHA_ALTA >= '2000'
OR SALARIO < 250000 AND FECHA_ALTA < '2000';
--Los empleados cuyo salario esté entre $100.000,00 y $250.000,00.
SELECT * FROM EMPLEADOS WHERE SALARIO BETWEEN 100000 AND 250000;
--Los empleados cuyo salario NO esté entre $100.000,00 y $250.000,00.
SELECT * FROM EMPLEADOS WHERE SALARIO NOT BETWEEN 100000 AND 250000;
--Los puestos con nivel de autorización 0, 1 o 2.
SELECT * FROM PUESTOS WHERE NIVEL_AUTORIZACION BETWEEN 0 AND 2;
--Los puestos con nivel de autorización distinto a 0, 1 y 2.
SELECT * FROM PUESTOS WHERE NIVEL_AUTORIZACION NOT BETWEEN 0 AND 2;

--6 Realizar las siguientes consultas:
--Los empleados activos ordenados alfabéticamente por su apellido de manera ascendente.
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1 ORDER BY APELLIDO;
--Los tres empleados más viejos.
SELECT TOP(3) * FROM EMPLEADOS ORDER BY FECHA_ALTA;
--Los tres empleados que más ganan
SELECT TOP(3) * FROM EMPLEADOS ORDER BY SALARIO DESC;
--Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
SELECT * FROM EMPLEADOS ORDER BY SALARIO DESC;
--Los distintos niveles de autorización de los puestos, sin repetir.
SELECT DISTINCT NIVEL_AUTORIZACION FROM PUESTOS;

--7 Realizar las siguientes consultas:
--El nombre y apellido de los empleados, junto al nombre de su puesto.
SELECT CONCAT (e.NOMBRE, ' ', APELLIDO) AS 'NOMBRE COMPLETO', p.NOMBRE AS 'PUESTO'
FROM EMPLEADOS e INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO;
--Los empleados que tengan un puesto con nivel de autorización igual a 3.
SELECT e.NOMBRE, e.APELLIDO, p.NOMBRE AS 'PUESTO', p.NIVEL_AUTORIZACION
FROM EMPLEADOS e INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO
WHERE p.NIVEL_AUTORIZACION = 3;
--El nombre y apellido de los empleados, junto al nombre de su puesto,
--ordenados alfabéticamente por apellido del empleado de manera ascendente.
SELECT e.NOMBRE, APELLIDO, p.NOMBRE AS 'PUESTO' FROM EMPLEADOS e
INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO ORDER BY e.APELLIDO;
--El nombre y apellido de los empleados, junto al nombre de su puesto,
--ordenados alfabéticamente por nombre del puesto de manera ascendente.
SELECT e.NOMBRE, APELLIDO, p.NOMBRE AS 'PUESTO' FROM EMPLEADOS e
INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO ORDER BY p.NOMBRE;
--Nombre, apellido y nombre del puesto de los empleados que estén activos,
--ordenados por su nivel de autorización de forma ascendente.
SELECT e.NOMBRE, APELLIDO, p.NOMBRE AS 'PUESTO' FROM EMPLEADOS e
INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO
WHERE e.ESTA_ACTIVO = 1 ORDER BY P.NIVEL_AUTORIZACION;
--Los puestos que no tengan empleados asociados.
SELECT p.NOMBRE FROM PUESTOS p LEFT JOIN EMPLEADOS e ON p.ID_PUESTO = e.ID_PUESTO
WHERE e.ID_PUESTO IS NULL;
--Los puestos que tienen empleados asociados.
SELECT p.NOMBRE FROM PUESTOS p LEFT JOIN EMPLEADOS e ON p.ID_PUESTO = e.ID_PUESTO
WHERE e.ID_PUESTO IS NOT NULL;

--8 Realizar las siguientes consultas:
--El promedio de los salarios de todos los empleados que estén activos.
SELECT AVG(SALARIO) 'SALARIO PROMEDIO EMP. ACTIVOS' FROM EMPLEADOS WHERE ESTA_ACTIVO = 1;
--La suma de los salarios de todos los empleados que estén activos.
SELECT SUM(SALARIO) 'SUMA SALARIOS EMP. ACTIVOS' FROM EMPLEADOS WHERE ESTA_ACTIVO = 1;
--La cantidad de empleados que ganan más de $250.000,00.
SELECT COUNT(NOMBRE) 'CANT. EMP. SALARIO +250K' FROM EMPLEADOS WHERE SALARIO > 250000;
--La cantidad de empleados que ingresaron antes del año 2010.
SELECT COUNT(NOMBRE) 'CANT. EMP. PRE 2010' FROM EMPLEADOS WHERE FECHA_ALTA < '2010';
--El salario más alto.
SELECT MAX(SALARIO) 'SALARIO MÁS ALTO' FROM EMPLEADOS;
--Los puestos con el nivel de autorización más bajo.
SELECT NOMBRE FROM PUESTOS WHERE NIVEL_AUTORIZACION = 0; 
--El nombre completo de todos los empleados (concatenado).
SELECT CONCAT (NOMBRE, ' ', APELLIDO) AS 'NOMBRE COMPLETO' FROM EMPLEADOS;
--El nombre completo de todos los empleados (concatenado), 
--el nombre de su puesto y su nivel de autorización.
SELECT CONCAT (e.NOMBRE, ' ', e.APELLIDO) AS 'NOMBRE', p.NOMBRE 'PUESTO', p.NIVEL_AUTORIZACION
FROM EMPLEADOS e INNER JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO;
--El nombre completo de todos los empleados (concatenado), el nombre de su puesto
--y su nivel de autorización. Y los puestos con su nivel de autorización que no tengan
--empleados asociados. Todo en una misma consulta.
SELECT CONCAT (e.NOMBRE, ' ', e.APELLIDO) AS 'NOMBRE', p.NOMBRE 'PUESTO', p.NIVEL_AUTORIZACION
FROM EMPLEADOS e RIGHT JOIN PUESTOS p ON e.ID_PUESTO = p.ID_PUESTO;

--9 Realizar las siguientes consultas:
/* HACER CON GROUP BY Y HAVING */

--10 Agregar el mail mbrock@yahoo.com a Maya Brock filtrando por su ID_EMPLEADO.
-- Verificar con una consulta la correcta ejecución del comando.
UPDATE EMPLEADOS SET MAIL = 'mbrock@yahoo.com' WHERE ID_EMPLEADO = 8;
SELECT * FROM EMPLEADOS WHERE ID_EMPLEADO = 8;

--11 Cambiar el puesto de Maya Brock a Administrativo y su salario a $210.000,00.
UPDATE EMPLEADOS SET ID_PUESTO = 4, SALARIO = 210000 WHERE ID_EMPLEADO = 8;

--12 Dar un aumento del 25% a todos los empleados que ganen menos de $250.000,00.
UPDATE EMPLEADOS SET SALARIO = SALARIO*1.25 WHERE SALARIO < 250000;

--14 Hacer una baja lógica del empleado con ID = 1, sin olvidar cargar su fecha de baja.
--Verificar con una consulta la correcta ejecución del comando.
UPDATE EMPLEADOS SET ESTA_ACTIVO = 0, FECHA_BAJA = GETDATE() WHERE ID_EMPLEADO = 6;
SELECT * FROM EMPLEADOS WHERE ID_EMPLEADO = 6;

--15 Hacer una baja física a todos los empleados que no estén activos.
-- Verificar con una consulta la correcta ejecución del comando.
DELETE FROM EMPLEADOS WHERE ESTA_ACTIVO = 0;
SELECT * FROM EMPLEADOS;