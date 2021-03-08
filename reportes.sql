ALTER procedure spuReporteAsistencia
	@Grado varchar(2),
	@Seccion varchar(2),
	@Nivel varchar(12),
	@Mes varchar(2)
as
begin
	select M.CodAlumno, A.Nombre, G.Nivel, G.Grado, G.Seccion
	--drop table #T1
	into #T1
	from TMatricula M inner join TGrado G on M.CodGrado = G.Id inner join TAlumno A on M.CodAlumno=A.Id
	Where G.Grado=@Grado and G.Seccion=@Seccion and G.Nivel=@Nivel

	select Q.Nombre,day(P.Fecha)as DIA, P.Estado 
	--drop table #T2
	into #T2
	from TAsistenciaAlumno P inner join #T1 Q on P.CodAlumno=q.CodAlumno
	where month(P.Fecha)=@Mes

	select Nombre,
		ISNULL([1],'')[1], ISNULL([2],'')[2], ISNULL([3],'')[3], ISNULL([4],'')[4], ISNULL([5],'')[5], ISNULL([6],'')[6],
		ISNULL([7],'')[7], ISNULL([8],'')[8], ISNULL([9],'')[9], ISNULL([10],'')[10], ISNULL([11],'')[11], ISNULL([12],'')[12],
		ISNULL([13],'')[13], ISNULL([14],'')[14], ISNULL([15],'')[15], ISNULL([16],'')[16], ISNULL([17],'')[17], ISNULL([18],'')[18],
		ISNULL([19],'')[19],ISNULL([20],'')[20],ISNULL([21],'')[21],ISNULL([22],'')[22],ISNULL([23],'')[23],ISNULL([24],'')[24],
		ISNULL([25],'')[25],ISNULL([26],'')[26],ISNULL([27],'')[27],ISNULL([28],'')[28],ISNULL([29],'')[29],ISNULL([30],'')[30],ISNULL([31],'')[31]
		from #T2
		PIVOT (MAX(Estado)
		FOR DIA IN ([1],[2],[3],[4],[5], [6],[7], [8], [9], [10], [11], [12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],
		[25],[26],[27],[28],[29],[30],[31]))
		as PVT
end
go

--exec spuReporteAsistencia '2','A','SECUNDARIA','04'


alter procedure spuTDocente_Datos
	@CodUsuario INT
as
begin
	select ApPaterno+'-'+ApMaterno+'-'+Nombre as Nombre 
	from TDocente inner join TUsuario on TDocente.IdUsuario=TUsuario.Id
	where TUsuario.Id=@CodUsuario
end
go

---EXEC spuTDocente_Datos 9

create procedure TDocenteId
	@Nombre varchar (8)
as
begin
	select D.Id
	from TUsuario U inner join TDocente D on U.Id=d.Id
	where U.NombreUsuario=@Nombre
end

alter procedure spuTUsuarioRol
	@Nombreusuario varchar(10)
as
begin
	select Rol from TUsuario
	where NombreUsuario=@Nombreusuario
end

alter procedure spuTDocenteGrado
	@Id int
as
begin
	select distinct G.Grado
	from TCargaAcademica C inner join TGrado G ON C.CodGrado=G.Id
	where C.CodDocente=@Id
end

alter procedure spuTDocenteSeccion
	@Id int
as
begin
	select distinct G.Seccion
	from TCargaAcademica C inner join TGrado G ON C.CodGrado=G.Id
	where C.CodDocente=@Id
end

create procedure spuTDocenteNivel
	@Id int
as
begin
	select distinct G.Nivel
	from TCargaAcademica C inner join TGrado G ON C.CodGrado=G.Id
	where C.CodDocente=@Id
end
