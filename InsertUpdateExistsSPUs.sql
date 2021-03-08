-- ==========================INSERT TUsuario==========================
CREATE PROCEDURE spuTUsuario_Insert
	@NombreUsuario VARCHAR(10),
	@Contraseña VARCHAR(8),
	@Rol VARCHAR(20)
AS
INSERT INTO TUsuario(NombreUsuario,Contraseña,Rol )
	VALUES(@NombreUsuario,@Contraseña,@Rol )
GO

-- ==========================UPDATE TUsuario==================================
CREATE PROCEDURE spuTUsuario_Update
	@Id INT,
	@NombreUsuario VARCHAR(10),
	@Contraseña VARCHAR(8),
	@Rol VARCHAR(20)
AS
    UPDATE TUsuario SET 
		NombreUsuario = @NombreUsuario,
		Contraseña = @Contraseña,
		Rol = @Rol
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TUsuario==================================
CREATE PROCEDURE spuTUsuario_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TUsuario
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TDocente==========================
CREATE PROCEDURE spuTDocente_Insert
	@IdUsuario INT,
	@DNI VARCHAR(8),
	@Nombre VARCHAR(20),
	@ApPaterno VARCHAR(20),
	@ApMaterno VARCHAR(20),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
INSERT INTO TDocente(IdUsuario,DNI,Nombre,ApPaterno,ApMaterno,Direccion,Telefono )
	VALUES(@IdUsuario,@DNI,@Nombre,@ApPaterno,@ApMaterno,@Direccion,@Telefono )
GO

-- ==========================UPDATE TDocente==================================
CREATE PROCEDURE spuTDocente_Update
	@Id INT,
	@IdUsuario INT,
	@DNI VARCHAR(8),
	@Nombre VARCHAR(20),
	@ApPaterno VARCHAR(20),
	@ApMaterno VARCHAR(20),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
    UPDATE TDocente SET 
		IdUsuario = @IdUsuario,
		DNI = @DNI,
		Nombre = @Nombre,
		ApPaterno = @ApPaterno,
		ApMaterno = @ApMaterno,
		Direccion = @Direccion,
		Telefono = @Telefono
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TDocente==================================
CREATE PROCEDURE spuTDocente_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TDocente
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TPersonal==========================
CREATE PROCEDURE spuTPersonal_Insert
	@IdUsuario INT,
	@DNI VARCHAR(8),
	@Nombre VARCHAR(20),
	@ApPaterno VARCHAR(20),
	@ApMaterno VARCHAR(20),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
INSERT INTO TPersonal(IdUsuario,DNI,Nombre,ApPaterno,ApMaterno,Direccion,Telefono )
	VALUES(@IdUsuario,@DNI,@Nombre,@ApPaterno,@ApMaterno,@Direccion,@Telefono )
GO

-- ==========================UPDATE TPersonal==================================
CREATE PROCEDURE spuTPersonal_Update
	@Id INT,
	@IdUsuario INT,
	@DNI VARCHAR(8),
	@Nombre VARCHAR(20),
	@ApPaterno VARCHAR(20),
	@ApMaterno VARCHAR(20),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
    UPDATE TPersonal SET 
		
		IdUsuario = @IdUsuario,
		DNI = @DNI,
		Nombre = @Nombre,
		ApPaterno = @ApPaterno,
		ApMaterno = @ApMaterno,
		Direccion = @Direccion,
		Telefono = @Telefono
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TPersonal==================================
CREATE PROCEDURE spuTPersonal_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TPersonal
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TAsignatura==========================
CREATE PROCEDURE spuTAsignatura_Insert
	@NombreAsignatura VARCHAR(50)
AS
INSERT INTO TAsignatura(NombreAsignatura )
	VALUES(@NombreAsignatura )
GO

-- ==========================UPDATE TAsignatura==================================
CREATE PROCEDURE spuTAsignatura_Update
	@Id INT,
	@NombreAsignatura VARCHAR(50)
AS
    UPDATE TAsignatura SET 
		NombreAsignatura = @NombreAsignatura
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TAsignatura==================================
CREATE PROCEDURE spuTAsignatura_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TAsignatura
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TGrado==========================
CREATE PROCEDURE spuTGrado_Insert
	@Grado VARCHAR(2),
	@Seccion VARCHAR(20),
	@Nivel VARCHAR(8)
AS
INSERT INTO TGrado(Grado,Seccion,Nivel )
	VALUES(@Grado,@Seccion,@Nivel )
GO

-- ==========================UPDATE TGrado==================================
CREATE PROCEDURE spuTGrado_Update
	@Id INT,
	@Grado VARCHAR(2),
	@Seccion VARCHAR(20),
	@Nivel VARCHAR(8)
AS
    UPDATE TGrado SET 
		Grado = @Grado,
		Seccion = @Seccion,
		Nivel = @Nivel
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TGrado==================================
CREATE PROCEDURE spuTGrado_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TGrado
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TCargaAcademica==========================
CREATE PROCEDURE spuTCargaAcademica_Insert
	@CodDocente INT,
	@CodAsignatura INT,
	@CodGrado INT
AS
INSERT INTO TCargaAcademica(CodDocente,CodAsignatura,CodGrado )
	VALUES(@CodDocente,@CodAsignatura,@CodGrado )
GO

-- ==========================UPDATE TCargaAcademica==================================
CREATE PROCEDURE spuTCargaAcademica_Update
	@Id INT,
	@CodDocente INT,
	@CodAsignatura INT,
	@CodGrado INT
AS
    UPDATE TCargaAcademica SET 
		CodDocente = @CodDocente,
		CodAsignatura = @CodAsignatura,
		CodGrado = @CodGrado
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TCargaAcademica==================================
CREATE PROCEDURE spuTCargaAcademica_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TCargaAcademica
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TAlumno==========================
CREATE PROCEDURE spuTAlumno_Insert
	@DNI VARCHAR(8),
	@Nombre VARCHAR(100),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
INSERT INTO TAlumno(DNI,Nombre,Direccion,Telefono )
	VALUES(@DNI,@Nombre,@Direccion,@Telefono )
GO

-- ==========================UPDATE TAlumno==================================
CREATE PROCEDURE spuTAlumno_Update
	@Id INT,
	@DNI VARCHAR(8),
	@Nombre VARCHAR(100),
	@Direccion VARCHAR(100),
	@Telefono VARCHAR(10)
AS
    UPDATE TAlumno SET 
		
		DNI = @DNI,
		Nombre = @Nombre,
		Direccion = @Direccion,
		Telefono = @Telefono
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TAlumno==================================
CREATE PROCEDURE spuTAlumno_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TAlumno
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TPadresFamilia==========================
CREATE PROCEDURE spuTPadresFamilia_Insert
	@DNIPadre VARCHAR(8),
	@DNIMadre VARCHAR(8),
	@NombresPadre VARCHAR(100),
	@NombresMadre VARCHAR(100),
	@TelefonoPadre VARCHAR(10),
	@TelefonoMadre VARCHAR(10),
	@CodHijo INT
AS
INSERT INTO TPadresFamilia(DNIPadre,DNIMadre,NombresPadre,NombresMadre,TelefonoPadre,TelefonoMadre,CodHijo )
	VALUES(@DNIPadre,@DNIMadre,@NombresPadre,@NombresMadre,@TelefonoPadre,@TelefonoMadre,@CodHijo )
GO

-- ==========================UPDATE TPadresFamilia==================================
CREATE PROCEDURE spuTPadresFamilia_Update
	@Id INT,
	@DNIPadre VARCHAR(8),
	@DNIMadre VARCHAR(8),
	@NombresPadre VARCHAR(100),
	@NombresMadre VARCHAR(100),
	@TelefonoPadre VARCHAR(10),
	@TelefonoMadre VARCHAR(10),
	@CodHijo INT
AS
    UPDATE TPadresFamilia SET 
		
		DNIPadre = @DNIPadre,
		DNIMadre = @DNIMadre,
		NombresPadre = @NombresPadre,
		NombresMadre = @NombresMadre,
		TelefonoPadre = @TelefonoPadre,
		TelefonoMadre = @TelefonoMadre,
		CodHijo = @CodHijo
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TPadresFamilia==================================
CREATE PROCEDURE spuTPadresFamilia_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TPadresFamilia
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TMatricula==========================
CREATE PROCEDURE spuTMatricula_Insert
	@CodAlumno INT,
	@CodGrado INT,
	@AñoCurricular VARCHAR(8)
AS
INSERT INTO TMatricula(CodAlumno,CodGrado,AñoCurricular )
	VALUES(@CodAlumno,@CodGrado,@AñoCurricular )
GO

-- ==========================UPDATE TMatricula==================================
CREATE PROCEDURE spuTMatricula_Update
	@Id INT,
	@CodAlumno INT,
	@CodGrado INT,
	@AñoCurricular VARCHAR(8)
AS
    UPDATE TMatricula SET 
		
		CodAlumno = @CodAlumno,
		CodGrado = @CodGrado,
		AñoCurricular = @AñoCurricular
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TMatricula==================================
CREATE PROCEDURE spuTMatricula_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TMatricula
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TAsistenciaAlumno==========================
CREATE PROCEDURE spuTAsistenciaAlumno_Insertar
	@Fecha DATE,
	@CodAlumno INT,
	@CodUsuario INT,
	@AñoCurricular VARCHAR(8),
	@Estado VARCHAR(8),
	@Observacion VARCHAR(50)
AS
INSERT INTO TAsistenciaAlumno(Fecha,CodAlumno,CodUsuario,AñoCurricular,Estado,Observacion )
	VALUES(@Fecha,@CodAlumno,@CodUsuario,@AñoCurricular,@Estado,@Observacion )
GO

-- ==========================UPDATE TAsistenciaAlumno==================================
CREATE PROCEDURE spuTAsistenciaAlumno_Update
	@Id INT,
	@Fecha DATE,
	@CodAlumno INT,
	@CodUsuario INT,
	@AñoCurricular VARCHAR(8),
	@Estado VARCHAR(8),
	@Observacion VARCHAR(50)
AS
    UPDATE TAsistenciaAlumno SET 
		Fecha = @Fecha,
		CodAlumno = @CodAlumno,
		CodUsuario = @CodUsuario,
		AñoCurricular = @AñoCurricular,
		Estado = @Estado,
		Observacion = @Observacion
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TAsistenciaAlumno==================================
CREATE PROCEDURE spuTAsistenciaAlumno_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TAsistenciaAlumno
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TIncidencias==========================
CREATE PROCEDURE spuTIncidencias_Insert
	@CodAlumno INT,
	@CodDocente INT,
	@Fecha DATETIME,
	@Descripcion VARCHAR(255)
AS
INSERT INTO TIncidencias(CodAlumno,CodDocente,Fecha,Descripcion )
	VALUES(@CodAlumno,@CodDocente,@Fecha,@Descripcion )
GO

-- ==========================UPDATE TIncidencias==================================
CREATE PROCEDURE spuTIncidencias_Update
	@Id INT,
	@CodAlumno INT,
	@CodDocente INT,
	@Fecha DATETIME,
	@Descripcion VARCHAR(255)
AS
    UPDATE TIncidencias SET 
		CodAlumno = @CodAlumno,
		CodDocente = @CodDocente,
		Fecha = @Fecha,
		Descripcion = @Descripcion
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TIncidencias==================================
CREATE PROCEDURE spuTIncidencias_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TIncidencias
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

-- ==========================INSERT TJustificaciones==========================
CREATE PROCEDURE spuTJustificaciones_Insert
	@CodAlumno INT,
	@Responsable VARCHAR(100),
	@Motivo VARCHAR(100),
	@Fecha DATETIME,
	@Descripcion VARCHAR(255),
	@DocSustentatorio VARCHAR(255)
AS
INSERT INTO TJustificaciones(CodAlumno,Responsable,Motivo,Fecha,Descripcion,DocSustentatorio )
	VALUES(@CodAlumno,@Responsable,@Motivo,@Fecha,@Descripcion,@DocSustentatorio )
GO

-- ==========================UPDATE TJustificaciones==================================
CREATE PROCEDURE spuTJustificaciones_Update
	@Id INT,
	@CodAlumno INT,
	@Responsable VARCHAR(100),
	@Motivo VARCHAR(100),
	@Fecha DATETIME,
	@Descripcion VARCHAR(255),
	@DocSustentatorio VARCHAR(255)
AS
    UPDATE TJustificaciones SET 
		CodAlumno = @CodAlumno,
		Responsable = @Responsable,
		Motivo = @Motivo,
		Fecha = @Fecha,
		Descripcion = @Descripcion,
		DocSustentatorio = @DocSustentatorio
    WHERE (@Id=Id)
GO

-- ==========================EXISTS TJustificaciones==================================
CREATE PROCEDURE spuTJustificaciones_Exists
	@Id INT,
	@exists BIT OUT
AS
    IF EXISTS ( SELECT *
		FROM TJustificaciones
		WHERE (@Id=Id)
	)
	SET @exists = 1
	ELSE SET @exists = 0
GO

