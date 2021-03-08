--=======================================================================================
-------------        Proc Listar Docentes           --------
if exists (select * from dbo.sysobjects where name = 'spuTDocente_Listar')
	drop procedure spuTDocente_Listar
go
create procedure spuTDocente_Listar
as
begin
	select IdUsuario, Nombre+' '+ApPaterno+' '+ApMaterno as Docente,DNI,Direccion, Telefono from TDocente
end
go

exec spuTDocente_Listar



--=======================================================================================
-- Proc Listar Alumno por Grado, Seccion y Nivel
if exists (select * from dbo.sysobjects where name = 'spuAlumnosListar')
	drop procedure spuAlumnosListar
go
create procedure spuAlumnosListar
	@Grado varchar(2),
	@Seccion varchar(2),
	@Nivel varchar(8)
as
begin
	select M.CodAlumno,M.CodGrado,A.Nombre into #TempA from TMatricula M JOIN  TAlumno A on M.CodAlumno=A.Id
	select CodAlumno,Nombre from #TempA T JOIN TGrado G on T.CodGrado=G.Id where G.Grado=@Grado AND G.Seccion=@Seccion AND G.Nivel=@Nivel
end
go

--exec spuAlumnosListar '5','B','S'

--=======================================================================================
-- Proc Listar Alumnos de Docente
create procedure spuAlumnosDocenteListar
	@CodDocente varchar(2)
as
begin
	select M.CodAlumno,M.CodGrado,A.Nombre into #TempC from TMatricula M JOIN  TAlumno A on M.CodAlumno=A.Id
	select CodAlumno,Nombre from #TempC T JOIN TCargaAcademica C on T.CodGrado=C.CodGrado where C.CodDocente=@CodDocente
end
go

--=======================================================================================
-- SPU Validar Usuario
if exists (select * from dbo.sysobjects where name = 'spuTUsuario_Validar')
	drop procedure spuTUsuario_Validar
go
create procedure spuTUsuario_Validar
	@Nombre varchar (8),
	@Contraseña varchar(20)
	
as
DECLARE @Rol varchar(8)
begin
	if (exists (select Rol from TUsuario where NombreUsuario = @Nombre and Contraseña = @Contraseña))
	begin
		select CodError = 0, Mensaje = 'Existe usuario en la BD'
	end
	else
		select CodError = 1, Mensaje = 'No existe usuario en la BD'	
end
go

--exec spuTUsuario_Validar 'Andres', '1234'

--Select G.Grado ,G.Seccion from TDocente join TGrado
	