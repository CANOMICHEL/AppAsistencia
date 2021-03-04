using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppControlAsistencia;
using LibClases;
using LibFormularios;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ValidarUsuarioOkUserOkPass_True()
        {
            string usuarioIngresado = "DP001";
            string contraseñaIngresado = "1234";
            bool estadoResultante = true;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioOkUserNotPass_False()
        {
            string usuarioIngresado = "DP001";
            string contraseñaIngresado = "1255";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioOkUserNullPass_False()
        {
            string usuarioIngresado = "DP001";
            string contraseñaIngresado = "";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioNotUserNotPass_False()
        {
            string usuarioIngresado = "DP031";
            string contraseñaIngresado = "1455";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioNullUserNotPass_False()
        {
            string usuarioIngresado = "";
            string contraseñaIngresado = "1255";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioNotUserokPass_False()
        {
            string usuarioIngresado = "DP111";
            string contraseñaIngresado = "1234";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioNullUserOkPass_False()
        {
            string usuarioIngresado = "";
            string contraseñaIngresado = "1234";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarUsuarioNullUserNullPass_False()
        {
            string usuarioIngresado = "";
            string contraseñaIngresado = "";
            bool estadoResultante = false;
            cDocente cAutenticacion = new cDocente();
            var result = cAutenticacion.RespuestaLogin(usuarioIngresado, contraseñaIngresado);
            Assert.AreEqual(estadoResultante, result);


        }
        [TestMethod]
        public void ValidarAlumnoOkCodAlumnoOkDNIOkNombre_True()
        {
            string CodAlumno = "A0004";
            string DNI = "72712946";
            string Nombre = "Fernando Calla";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = true;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOkCodAlumnoOkDNINullNombre_True()
        {
            string CodAlumno = "A0004";
            string DNI = "72712946";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOKCodAlumnoNullDNIOkNombre_True()
        {
            string CodAlumno = "A0004";
            string DNI = "";
            string Nombre = "Fernando Calla";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoNullCodAlumnoOkDNIOkNombre_True()
        {
            string CodAlumno = "";
            string DNI = "72712946";
            string Nombre = "Fernando Calla";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOkCodAlumnoNullDNINullNombre_True()
        {
            string CodAlumno = "A0004";
            string DNI = "";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoNullCodAlumnoOkDNINullNombre_True()
        {
            string CodAlumno = "";
            string DNI = "72712946";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }
            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoNullCodAlumnoNullDNIOkNombre_True()
        {
            string CodAlumno = "";
            string DNI = "";
            string Nombre = "Fernando Calla";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoNullCodAlumnoNullDNINullNombre_True()
        {
            string CodAlumno = "";
            string DNI = "";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result =false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOKExisteCodAlumnoOkDNIOkNombre_True()
        {
            string CodAlumno = "A0001";
            string DNI = "72712346";
            string Nombre = "Fernando Palca";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOKExisteCodAlumnoOkDNINullNombre_True()
        {
            string CodAlumno = "A0001";
            string DNI = "72712346";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOKExisteCodAlumnoNullDNIOkNombre_True()
        {
            string CodAlumno = "A0001";
            string DNI = "";
            string Nombre = "Fernando Palca";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        [TestMethod]
        public void ValidarAlumnoOKExisteCodAlumnoNullDNINullNombre_True()
        {
            string CodAlumno = "A0001";
            string DNI = "";
            string Nombre = "";
            string Direccion = "";
            string Numero = "";
            string[] a = new string[] { CodAlumno, DNI, Nombre, Direccion, Numero };
            cAlumno cAutenticacion = new cAlumno();

            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);

        }
        //=========REGISTRAR ASISTENCIA========================
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CTRUE_ATRUE_ETRUE()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "A0001";
            string AñoCurricular = "2020";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = true;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CFalse_AFalse_EFalse()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "c0001";
            string AñoCurricular = "2220";
            string Estado = "X";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        
        
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_Cfalse_ATRUE_Efalse()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "A";
            string AñoCurricular = "2020";
            string Estado = "false";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_Cfalse_Afalse_ETRUE()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "001";
            string AñoCurricular = "a";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CTRUE_Afalse_Efalse()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "A0001";
            string AñoCurricular = "a0";
            string Estado = "v";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_CTRUE_ATRUE_Efalse()
        {
            string Fecha = "01";
            string CodAlumno = "A0001";
            string AñoCurricular = "2020";
            string Estado = "y";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_Cfalse_ATRUE_ETRUE()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "er";
            string AñoCurricular = "2020";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_Cfalse_Afalse_ETRUE()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "rcc";
            string AñoCurricular = "a";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_Cfalse_ATRUE_Efalse()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "er";
            string AñoCurricular = "2020";
            string Estado = "e";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_CTRUE_Afalse_ETRUE()
        {
            string Fecha = "01";
            string CodAlumno = "A0001";
            string AñoCurricular = "er";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CTRUE_ATRUE_Efalse()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "A0001";
            string AñoCurricular = "2020";
            string Estado = "op";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_Ffalse_CTRUE_ATRUE_ETRUE()
        {
            string Fecha = "01";
            string CodAlumno = "A0001";
            string AñoCurricular = "2020";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_Cfalse_ATRUE_ETRUE()
        {
            string Fecha = "01/10/2020";
            string CodAlumno = "er";
            string AñoCurricular = "2020";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FNULL_CNULL_ANULL_ENULL()
        {
            string Fecha = "";
            string CodAlumno = "";
            string AñoCurricular = "";
            string Estado = "P";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CNULL_ANULL_ENULL()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "";
            string AñoCurricular = "";
            string Estado = "";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CTRUE_ANULL_ENULL()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "A0001";
            string AñoCurricular = "";
            string Estado = "";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);
        }
        [TestMethod]
        public void RegistrarAsistencia_FTRUE_CTRUE_ATRUE_ENULL()
        {
            string Fecha = "01/10/2016";
            string CodAlumno = "A0001";
            string AñoCurricular = "2020";
            string Estado = "";
            string Observacion = "";
            string[] a = new string[] { Fecha, CodAlumno, AñoCurricular, Estado, Observacion };
            cAsistenciaAlumno cAutenticacion = new cAsistenciaAlumno();
            bool estadoResultante = false;
            bool result;
            try
            {
                cAutenticacion.Insertar(a);
                result = false;
            }
            catch (Exception e)
            {
                result = true;
            }

            Assert.AreEqual(estadoResultante, result);
        }
    }
}
