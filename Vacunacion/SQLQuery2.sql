use Roles_Permisos

--Vacunas
CREATE TABLE Vacunas (
Cod_Vacuna	int PRIMARY KEY NOT NULL,
Cod_Proveedor int NOT NULL,
Cod_Laboratorio int NOT NULL,
Nombre_Vacuna	varchar(200) NOT NULL,
Nombre_Enfermedad varchar(200) NOT NULL,
Estatus	varchar(1) NOT NULL
);

--Usuario
CREATE TABLE DatosUsuario (
Cedula_Usuario numeric(11, 0) PRIMARY KEY NOT NULL,
Nombre_Usuario varchar(200) NOT NULL,
Apellido_Usuario varchar(200) NOT NULL,
Tiene_Seguro varchar(1) NOT NULL,
Cod_Seguro int,
Estatus varchar(1) NOT NULL
);

--Laboratorios
CREATE TABLE Laboratorios(
Cod_Laboratorio int PRIMARY KEY NOT NULL,
Cod_CentroVac int NOT NULL,
Nombre_Laboratorio varchar(200) NOT NULL,
Estatus varchar(1) NOT NULL
);

--Centro de Vacunacion
CREATE TABLE CentroVacunacion(
Cod_CentroVac int PRIMARY KEY NOT NULL,
Cod_Vacuna int NOT NULL,
Nombre_CentroVac varchar(200) NOT NULL,
Estatus varchar(1) NOT NULL
);

--Proveedores
CREATE TABLE Proveedores(
Cod_Proveedor int PRIMARY KEY NOT NULL,
Nombre_Proveedor varchar(200) NOT NULL,
Estatus varchar(1) NOT NULL
);

--Vacunador
CREATE TABLE Vacunador(
Cedula_Vac numeric(11,0) PRIMARY KEY NOT NULL,
Nombre_Vac varchar(200) NOT NULL,
Apellido_Vac varchar(200) NOT NULL,
Cod_Vacuna int NOT NULL,
Estatus varchar(1) NOT NULL
);

--Seguro
CREATE TABLE Seguros(
Cod_Seguro int PRIMARY KEY NOT NULL,
Cod_Vacuna int NOT NULL,
Nombre_Seguro varchar(200) NOT NULL,
Estatus varchar(1) NOT NULL
);

--FOREIGN KEYS
ALTER TABLE Vacunas ADD FOREIGN KEY (Cod_Proveedor) REFERENCES Proveedores (Cod_Proveedor);
ALTER TABLE Vacunas ADD FOREIGN KEY (Cod_Laboratorio) REFERENCES Laboratorios (Cod_Laboratorio);

ALTER TABLE Laboratorios ADD FOREIGN KEY (Cod_CentroVac) REFERENCES CentroVacunacion (Cod_CentroVac);

ALTER TABLE CentroVacunacion ADD FOREIGN KEY (Cod_Vacuna) REFERENCES Vacunas (Cod_Vacuna);

ALTER TABLE Seguros ADD FOREIGN KEY (Cod_Vacuna) REFERENCES Vacunas (Cod_Vacuna);