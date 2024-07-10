CREATE DATABASE SARH;
GO

USE SARH;
GO


CREATE TABLE Empleados (
    ID_empleado VARCHAR(6) PRIMARY KEY,
    Nombre VARCHAR(30),
    Puesto VARCHAR(20),
    Cargo VARCHAR(20),
    Salario VARCHAR(10)
);
GO

CREATE TABLE Horas_trabajadas (
    FK_ID_empleado VARCHAR(6),
    Horas_trabajadas VARCHAR(10),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO


CREATE TABLE Vacaciones (
    ID_vacacion VARCHAR(6) PRIMARY KEY,
    FK_ID_empleado VARCHAR(6),
    Fecha_Inicio VARCHAR(20),
    Fecha_Final VARCHAR(20),
    Estado VARCHAR(15),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO

CREATE TABLE Registro_Inss (
    FK_ID_empleado VARCHAR(6),
    FK_Salario VARCHAR(10),
    Inss VARCHAR(10),
    IR VARCHAR(10),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO

CREATE TABLE Asistencia (
    FK_ID_empleado VARCHAR(6),
    FK_Nombre VARCHAR(30),
    Inasistencias VARCHAR(20),
    Asistencias VARCHAR(20),
    Meses VARCHAR(12),
    Justificaciones VARCHAR(30),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO


CREATE TABLE Permisos (
    ID_permiso VARCHAR(6) PRIMARY KEY,
    FK_ID_empleado VARCHAR(6),
    Fecha_Inicio VARCHAR(20),
    Fecha_Final VARCHAR(20),
    Motivo VARCHAR(30),
    Estado VARCHAR(15),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO

CREATE TABLE Desempeño (
    FK_ID_empleado VARCHAR(6),
    FK_Nombre VARCHAR(30),
    Competencias VARCHAR(20),
    Tipo VARCHAR(20),
    Nivel_Requerido VARCHAR(20),
    Nivel_Obtenido VARCHAR(20),
    FOREIGN KEY (FK_ID_empleado) REFERENCES Empleados(ID_empleado)
);
GO

---Tabla de empleados
INSERT INTO Empleados VALUES ('E12345', 'Juan Perez', 'Desarrollador', 'Senior', '2000');
INSERT INTO Empleados VALUES ('E12346', 'Maria Lopez', 'Analita', 'Junior', '1500');
INSERT INTO Empleados VALUES ('E12347', 'Carlos Ruiz', 'Gerente', 'Middle', '2500');
INSERT INTO Empleados VALUES ('E12348', 'Ana Gomez', 'Soporte', 'Junior', '1300');
INSERT INTO Empleados VALUES ('E12349', 'Luis Martinez', 'Interno', 'Intern', '1000');

-- Tabla Horas_trabajadas
INSERT INTO Horas_trabajadas VALUES ('E12345', '160');
INSERT INTO Horas_trabajadas VALUES ('E12346', '150');
INSERT INTO Horas_trabajadas VALUES ('E12347', '170');
INSERT INTO Horas_trabajadas VALUES ('E12348', '140');
INSERT INTO Horas_trabajadas VALUES ('E12349', '100');

-- Tabla Vacaciones
INSERT INTO Vacaciones VALUES ('V12345', 'E12345', '2023-01-01', '2023-01-15', 'Aprobado');
INSERT INTO Vacaciones VALUES ('V12346', 'E12346', '2023-02-01', '2023-02-10', 'Espera');
INSERT INTO Vacaciones VALUES ('V12347', 'E12347', '2023-03-01', '2023-03-15', 'Denegado');
INSERT INTO Vacaciones VALUES ('V12348', 'E12348', '2023-04-01', '2023-04-20', 'Aprobado');
INSERT INTO Vacaciones VALUES ('V12349', 'E12349', '2023-05-01', '2023-05-10', 'Espera');

-- Tabla Registro_Inss
INSERT INTO Registro_Inss VALUES ('E12345', '2000', '100', '50');
INSERT INTO Registro_Inss VALUES ('E12346', '1500', '75', '35');
INSERT INTO Registro_Inss VALUES ('E12347', '2500', '125', '60');
INSERT INTO Registro_Inss VALUES ('E12348', '1300', '65', '30');
INSERT INTO Registro_Inss VALUES ('E12349', '1000', '50', '25');

-- Tabla Asistencia
INSERT INTO Asistencia VALUES ('E12345', 'Juan Perez', '0', '20', 'Enero', 'Ninguna');
INSERT INTO Asistencia VALUES ('E12346', 'Maria Lopez', '1', '19', 'Febrero', 'Enfermedad');
INSERT INTO Asistencia VALUES ('E12347', 'Carlos Ruiz', '2', '18', 'Marzo', 'Vacaciones');
INSERT INTO Asistencia VALUES ('E12348', 'Ana Gomez', '3', '17', 'Abril', 'Personal');
INSERT INTO Asistencia VALUES ('E12349', 'Luis Martinez', '4', '16', 'Mayo', 'Ninguna');

-- Tabla Permisos
INSERT INTO Permisos VALUES ('P12345', 'E12345', '2023-06-01', '2023-06-05', 'Personal', 'Aprobado');
INSERT INTO Permisos VALUES ('P12346', 'E12346', '2023-07-01', '2023-07-03', 'Enfermedad', 'Espera');
INSERT INTO Permisos VALUES ('P12347', 'E12347', '2023-08-01', '2023-08-07', 'Vacaciones', 'Denegado');
INSERT INTO Permisos VALUES ('P12348', 'E12348', '2023-09-01', '2023-09-04', 'Personal', 'Aprobado');
INSERT INTO Permisos VALUES ('P12349', 'E12349', '2023-10-01', '2023-10-02', 'Enfermedad', 'Espera');

-- Tabla Desempeño
INSERT INTO Desempeño (FK_ID_empleado, FK_Nombre, Competencias, Tipo, Nivel_Requerido, Nivel_Obtenido)
VALUES ('E12345', 'Juan Perez', 'Automotivacion', 'Valores', 'Óptimo', 'Alto');
GO
INSERT INTO Desempeño (FK_ID_empleado, FK_Nombre, Competencias, Tipo, Nivel_Requerido, Nivel_Obtenido)
VALUES ('E12346', 'Maria Lopez', 'Trabajo en equipo', 'Empresa y cliente', 'Regular', 'Óptimo');
GO
INSERT INTO Desempeño (FK_ID_empleado, FK_Nombre, Competencias, Tipo, Nivel_Requerido, Nivel_Obtenido)
VALUES ('E12347', 'Carlos Ruiz', 'Comunicacion', 'Competencias', 'Alto', 'Alto');
GO
INSERT INTO Desempeño (FK_ID_empleado, FK_Nombre, Competencias, Tipo, Nivel_Requerido, Nivel_Obtenido)
VALUES ('E12348', 'Ana Gomez', 'Adaptacion', 'Valores', 'Deficiente', 'Regular');
GO
INSERT INTO Desempeño (FK_ID_empleado, FK_Nombre, Competencias, Tipo, Nivel_Requerido, Nivel_Obtenido)
VALUES ('E12349', 'Luis Martinez', 'Calidad', 'Empresa y cliente', 'Óptimo', 'Óptimo');
GO

---Ver cada una de las tablas
SELECT * FROM Empleados;
GO

SELECT * FROM Horas_trabajadas;
GO

SELECT * FROM Vacaciones;
GO

SELECT * FROM Registro_Inss;
GO

SELECT * FROM Asistencia;
GO

SELECT * FROM Permisos;
GO

SELECT * FROM Desempeño;
GO
