--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'BDControlAsistencia')
	drop database BDControlAsistencia
go
create database BDControlAsistencia
go
--------------------------------------------------------------------------
-- CREACION DE LAS TABLAS
--------------------------------------------------------------------------
use BDControlAsistencia
go
-- Tabla para libros
create table TAlumno
(	-- lista de atributos
	CodAlumno varchar (8) not null,
	DNI varchar (8) not null,
	Nombre varchar (100) not null,
	Direccion varchar (100),
	Telefono varchar (10),
	--Grado varchar (10) not null,
	--Seccion varchar (10),

	-- definicion de la clave foranea
	primary key (CodAlumno)
)
go
--create table TTipoDocente
--(
--	-- Lista de atributos
--	CodTipoDocente varchar(8) not null,
--	TipoDocente varchar(20)not null,

--	primary key (CodTipoDocente)
--)

create table TDocente
(	-- lista de atributos
	CodDocente varchar (8) not null,
	Contrase�a varchar(20) not null, 
	DNI varchar (8) not null,
	Nombre varchar (100) not null,
	Direccion varchar (100),
	Telefono varchar (10),

	-- definicion de la clave foranea
	primary key (CodDocente),

	--foreign key (CodTipoDocente) references TTipoDocente(CodTipoDocente),
)
go
create table TGrado
(
	-- Lista atributos
	CodGrado varchar(8) not null,
	Grado varchar(2) not null,
	Seccion varchar (20) not null,
	Nivel varchar(8)

	primary key (CodGrado)
)
go
--create table TCargo
--(
--	-- Lista atributos
--	CodCargo varchar(8) not null,
--	CodDocente varchar(8) not null,
--	CodGrado varchar(8) not null,
--	CodSeccion varchar(8),
--	Fecha DateTime,

--	primary key (CodCargo),
--	foreign key (CodDocente) references TDocente(CodDocente),
--	foreign key (CodGrado, CodSeccion) references TGrado(CodGrado,CodSeccion),
--)
--go

--create table TRegistrarAsistenciaDocente
--(
--	-- Lista de atributos
--	CodRegistroAsistenciaDocente varchar(8) not null,
--	CodDocente varchar(8) not null,

--	Fecha DateTime,
--	Observacion varchar(50) not null,

--	primary key (CodRegistroAsistenciaDocente),
--	foreign key (CodDocente) references TDocente(CodDocente),
--)
--go

create table TMatricula
(
	A�oCurricular varchar(8) not null,
	CodAlumno varchar(8) not null,
	CodGrado varchar(8) not null,
	CodDocente varchar(8) not null,

	primary key (A�oCurricular,CodAlumno),

	foreign key (CodAlumno) references TAlumno(CodAlumno),
	foreign key (CodGrado) references TGrado(CodGrado),
	foreign key (CodDocente) references TDocente(CodDocente),
	

)

create table TAsistenciaAlumno
(

	-- lista de atributos
	Fecha DateTime,
	CodAlumno varchar(8) not null,
	A�oCurricular varchar(8) not null,
	Estado varchar(8),
	Observacion varchar (50) not null,

	primary key (Fecha,CodAlumno),

	foreign key (A�oCurricular,CodAlumno) references TMatricula(A�oCurricular,CodAlumno),
	--foreign key (CodCargo) references TCargo(CodCargo),
	--foreign key (CodAlumno) references TAlumno(CodAlumno),
)
go

--============================================= ALUMNO ====================================================
set dateformat dmy

Select * from TAlumno
DELETE FROM TAlumno WHERE Id > 0
DBCC CHECKIDENT ('TAlumno') 
DBCC CHECKIDENT ('TAlumno', RESEED, 0) 
insert into TAlumno values('91758846','Aguado L�pez, Mayra','Av. Los chistes Cuadra 3','')
insert into TAlumno values('34251217','Alcus�n Marco, Guillermo','Av. Loritos Cuadra 1','')
insert into TAlumno values('10229388','Bernad Albiol, Mar�a','Urb. Por all�','275891')
insert into TAlumno values('10229388','Concha Rios, Eduardo','Urb. Por all�','275891')
insert into TAlumno values('10529388','Ebrahim Asghar, Zadeh','Urb. Por all�','275891')
insert into TAlumno values('10269388','Harris, Marcela Moira','Urb. Por all�','275891')
insert into TAlumno values('10299388','Gonz�lez S�nchez, Rosana','Urb. Por all�','275891')
insert into TAlumno values('10249388','Mart�nez Lorente, Francisco','Urb. Por all�','275891')
insert into TAlumno values('10229688','Ortiz Ortu�o, Ra�l','Urb. Por all�','275891')
insert into TAlumno values('10223388','Rubio Blaya, Alfonso','Urb. Por all�','275891')
insert into TAlumno values('10220388','Zuzunaga Bed�n, Mirna Ofelia','Urb. Por all�','275891')
insert into TAlumno values('10221388','Spadaro, Davide','Urb. Por all�','275891')
insert into TAlumno values('91758846','Alberola Robles, Rafael','Av. Los chistes Cuadra 3','')
insert into TAlumno values('34251217','Blasco Boix, Jos� Manuel','Av. Loritos Cuadra 1','')
insert into TAlumno values('10227388','Berenguer Borja, Maria E','Urb. Por all�','275891')
insert into TAlumno values('10229388','Chaves Fallas, Lilliana','Urb. Por all�','275891')
insert into TAlumno values('20229388','Dionisio Toledo, Clara','Urb. Por all�','275891')
insert into TAlumno values('30229388','Gil Mu�oz, Fco Javier','Urb. Por all�','275891')
insert into TAlumno values('80229388','Gonz�lez Mart�nez, Raquel','Urb. Por all�','275891')
insert into TAlumno values('20229388','L�pez Calvo, Rebeca, Francisco','Urb. Por all�','275891')
insert into TAlumno values('30229388','Martos S�nchez, Juan A.','Urb. Por all�','275891')
insert into TAlumno values('70259388','Onaindia Yurrebaso, Jone','Urb. Por all�','275891')
insert into TAlumno values('70269388','Par�s Mart�nez, Jorge Luis','Urb. Por all�','275891')
insert into TAlumno values('10229387','Ripolles Moles, Jos� Lu�s','Urb. Por all�','275891')
insert into TAlumno values('91758848','�lvarez Cuartas, Mar�a','Av. Los chistes Cuadra 3','')
insert into TAlumno values('34251218','�lvarez Garc�a, Benito','Av. Loritos Cuadra 1','')
insert into TAlumno values('10229389','Campo Rilo, Paula Del','Urb. Por all�','275891')
insert into TAlumno values('10229398','Fern�ndez Espina, Bruno','Urb. Por all�','275891')
insert into TAlumno values('10229397','Garc�a Garc�a, Beatriz','Urb. Por all�','275891')
insert into TAlumno values('10229368','Iglesias Santirso, Luc�a','Urb. Por all�','275891')
insert into TAlumno values('10229348','Mas Andr�s, Virginia Maria','Urb. Por all�','275891')
insert into TAlumno values('10229338','Ornosa Miravalles, Peru','Urb. Por all�','275891')
insert into TAlumno values('10229318','Ortega Moro, Oriol','Urb. Por all�','275891')
insert into TAlumno values('10221388','Quevedo Alvar�, Mar�a','Urb. Por all�','275891')
insert into TAlumno values('10222388','Rodr�guez Rodr�guez, Javier','Urb. Por all�','275891')
insert into TAlumno values('91753846','Ruiz G�mez, Miriam','Av. Los chistes Cuadra 3','')
insert into TAlumno values('34254217','Sanz De Pedro, H�ctor Miguel','Av. Loritos Cuadra 1','')
insert into TAlumno values('10225388','Serrano Fern�ndez De Travanco, �lvaro','Urb. Por all�','275891')
insert into TAlumno values('10226388','Torrecillas Reig, Ram�n','Urb. Por all�','275891')
insert into TAlumno values('10227388','Villa Carro, Mario','Urb. Por all�','275891')
insert into TAlumno values('10228388','Zapico �lvarez, Jorge','Urb. Por all�','275891')
insert into TAlumno values('10229088','�lvarez Tamargo, Mar�a','Urb. Por all�','275891')
insert into TAlumno values('10121388','Blanco Cu�, Graciela','Urb. Por all�','275891')
insert into TAlumno values('10222388','D�az Ubieta, ��igo','Urb. Por all�','275891')
insert into TAlumno values('10329388','Garc�a Garc�a, Pablo','Urb. Por all�','275891')
insert into TAlumno values('10229658','Nicieza Fern�ndez, V�ctor','Urb. Por all�','275891')
insert into TAlumno values('10329358','P�rez Fern�ndez, Fabi�n','Urb. Por all�','275891')


--============================================= USUARIO ====================================================
insert into TUsuario values('Andres','1234','Docente')
insert into TUsuario values('Maria','1234','Docente')
--=========================================== TIPO DOCENTE ====================================================
--insert into TTipoDocente values('SE','Docente Secundaria')

--============================================= DOCENTE ====================================================
insert into TDocente values('1','24943726','Andres','Medina','Medina','Av. AKLSD','984758836')
insert into TDocente values('2','48495867','Ruben',' Aguirre','Sanchez','Av. Andinoncio','944203953')

insert into TDocente values('DS001','1234','68495867','Rubencito','Av. AKLSD','944203944')
insert into TDocente values('DS002','1234','47495867','Juan Pablo Fern�ndez Trujillo','Av. Cultura','944203933')
insert into TDocente values('DS003','1234','24943726','Encarnaci�n Aguayo Gim�nez','Urb. Michi','984758836')
insert into TDocente values('DS004','1234','48495867','Alessandro Turatti','Av. Andinoncio','944203953')
insert into TDocente values('DI001','1234','68495867','Rubencito','Av. AKLSD','944203944')
insert into TDocente values('AU001','1234','47495867','Alicia Namesny Vallespir','Av. Cultura','944203933')

--============================================= GRADO ====================================================
insert into TGrado values('1','A','P')
insert into TGrado values('1','B','P')
insert into TGrado values('2','A','P')
insert into TGrado values('3','A','P')
insert into TGrado values('3','B','P')
insert into TGrado values('3','C','P')
insert into TGrado values('4','A','P')
insert into TGrado values('5','A','P')
insert into TGrado values('6','A','P')
insert into TGrado values('1','A','S')
insert into TGrado values('2','A','S')
insert into TGrado values('3','A','S')
insert into TGrado values('3','B','S')
insert into TGrado values('4','A','S')
insert into TGrado values('5','A','S')
insert into TGrado values('5','B','S')

Select * from TAlumno
-----============================================= MATRICULA ====================================================
insert into TMatricula values(1,'G01','2021')
insert into TMatricula values(2,'G01','2021')
insert into TMatricula values(3,'G01','2021')
insert into TMatricula values(5,'G01','2021')
insert into TMatricula values(6,'G02','2021')
insert into TMatricula values(7,'G02','2021')
insert into TMatricula values(6,'G02','2021')
insert into TMatricula values(6,'G02','2021')
insert into TMatricula values(6,'G02','2021')
insert into TMatricula values(6,'G02','2021')
insert into TMatricula values(6,'G02','2021')


--============================================= ASISTENCIA ====================================================
--insert into TAsistenciaAlumno values('01/10/2019','A0001','2019','P','El alumno se comport� mal')
--insert into TAsistenciaAlumno values('01/10/2019','A0002','2019','T','')
--insert into TAsistenciaAlumno values('01/10/2019','A0003','2019','F','Sus pap�s pidieron permiso')
--insert into TAsistenciaAlumno values('08/03/2019','A0003','2019','F','Sus pap�s pidieron permiso')

--insert into TAsistenciaAlumno values('08/03/2019','A0004','2019','F','Sus pap�s pidieron permiso')
--insert into TAsistenciaAlumno values('20/02/2019','A0004','2019','F','Sus pap�s pidieron permiso')
--insert into TAsistenciaAlumno values('20/02/2019','A0005','2019','F','Sus pap�s pidieron permiso')
--insert into TAsistenciaAlumno values('20/02/2019','A0004','2016','F','Sus pap�s pidieron permiso')


SELECT * FROM TASISTENCIAaLUMNO