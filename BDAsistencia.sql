--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'BDAsistencia')
	drop database BDAsistencia
go
create database BDAsistencia
go
--------------------------------------------------------------------------
-- CREACION DE LAS TABLAS
--------------------------------------------------------------------------
use BDAsistencia
go

--tabla usuario
create table TUsuario
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	NombreUsuario varchar(10) unique not null,
	Contraseña varchar(8) not null,
	Rol varchar(20) not null,
)
go
--Tabla docente
create table TDocente
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	IdUsuario INT,
	DNI varchar (8) unique not null,
	Nombre varchar (20) not null,
	ApPaterno varchar(20) not null,
	ApMaterno varchar(20) not null,
	Direccion varchar (100),
	Telefono varchar (10),
	foreign key (IdUsuario) references TUsuario(Id),
)
go
--Tabla personal
create table TPersonal
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	IdUsuario INT,
	DNI varchar (8) unique not null,
	Nombre varchar (20) not null,
	ApPaterno varchar(20) not null,
	ApMaterno varchar(20) not null,
	Direccion varchar (100),
	Telefono varchar (10),
	foreign key (IdUsuario) references TUsuario(Id),
)
go
--Tabla asignatura
create table TAsignatura
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	NombreAsignatura varchar(50) not null,
)
go
--Tabla grado
create table TGrado
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	Grado varchar(2) not null,
	Seccion varchar (20) not null,
	Nivel varchar(8)
)
go
--Tabla carga Academica 
create table TCargaAcademica
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	CodDocente INT,
	CodAsignatura INT,
	CodGrado INT,
	foreign key (CodDocente) references TDocente(Id),
	foreign key (CodAsignatura) references TAsignatura(Id),
	foreign key (CodGrado) references TGrado(Id),
)
go
--Tabla Alumno
create table TAlumno
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	DNI varchar (8) unique not null,
	Nombre varchar (100) not null,
	Direccion varchar (100),
	Telefono varchar (10)
)
go
--Tabla Padres
create table TPadresFamilia
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	DNIPadre varchar(8) not null,
	DNIMadre varchar(8) not null,
	NombresPadre varchar(100) not null,
	NombresMadre varchar(100) not null,
	TelefonoPadre varchar(10),
	TelefonoMadre varchar(10),
	CodHijo INT,
	foreign key (CodHijo) references TAlumno(Id),
)
go
--Tabla Matricula
create table TMatricula
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	CodAlumno INT,
	CodGrado INT,
	AñoCurricular varchar(8) not null,
	foreign key (CodAlumno) references TAlumno(Id),
	foreign key (CodGrado) references TGrado(Id),
)
go
--Tabla asistencia
create table TAsistenciaAlumno
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	Fecha DATE DEFAULT (GETDATE()),
	CodAlumno INT,
	CodUsuario INT,
	AñoCurricular varchar(8) not null,
	Estado varchar(8) not null,
	Observacion varchar (50) not null,
	foreign key (CodAlumno) references TAlumno(Id),
	foreign key (CodUsuario) references TUsuario(Id),
)
go

--Tabla incidencias
create table TIncidencias
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	CodAlumno INT,
	CodDocente INT,
	Fecha datetime Default (Getdate()),
	Descripcion varchar(255) not null,
	foreign key (CodAlumno) references TAlumno(Id),
	foreign key (CodDocente) references TDocente(Id),
)
go
--Tabla Justificaciones
create table TJustificaciones
(	Id INT IDENTITY(1,1) PRIMARY KEY,
	CodAlumno INT,
	Responsable varchar(100) not null,
	Motivo varchar(100) not null,
	Fecha datetime default (getdate()),
	Descripcion varchar(255) not null,
	DocSustentatorio varchar(255) not null,
	foreign key (CodAlumno) references TAlumno(Id)
)
go