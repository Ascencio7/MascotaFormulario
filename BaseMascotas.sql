CREATE DATABASE BaseMascotas
GO 
USE BaseMascotas
GO

CREATE TABLE DatosMascotas(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(100) NOT NULL,
	Apellido VARCHAR(100) NOT NULL,
	Raza VARCHAR(100) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Contacto VARCHAR(20) NOT NULL
);

drop table DatosMascotas

INSERT INTO DatosMascotas (Nombre, Apellido, Raza, FechaNacimiento, Contacto) 
VALUES ('Jack','Kart','Pitbull','2020-12-08','78963245');

SELECT * FROM DatosMascotas