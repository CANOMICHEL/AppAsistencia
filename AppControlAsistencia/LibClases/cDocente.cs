using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibClases
{
    public class cDocente : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cDocente() : base("TDocente")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "Id", "IdUsuario", "DNI", "Nombre","ApPaterno","ApMaterno", "Direccion", "Telefono" };
        }

        public DataTable GradoDocente(int cod)
        {
            string consulta = "exec spuTDocenteGrado '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable SeccionDocente(int cod)
        {
            string consulta = "exec spuTDocenteSeccion '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public string NombreDocente(int cod)
        {
            string consulta = "exec spuTDocente_Datos '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            string doc = aConexion.Datos.Tables[0].Rows[0][0].ToString();
            if (doc != "")
                return doc;
            else
                return "";
        }
        public string Nivel(int cod)
        {
            string consulta = "exec spuTDocenteNivel '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            string doc = aConexion.Datos.Tables[0].Rows[0][0].ToString();
            if (doc != "")
                return doc;
            else
                return "";
        }


        public DataTable ListarDocentes()
        {
            string consulta = "exec spuTDocente_Listar";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public string IdDocente(string usuario)
        {
            string consulta = "exec TDocenteId '" + usuario + "'";
            aConexion.EjecutarSelect(consulta);
            string Iddoc = aConexion.Datos.Tables[0].Rows[0][0].ToString();
            if (Iddoc != "")
                return Iddoc;
            else
                return "";
        }

        public DataTable ReporteAlumnos(string Grado, string Seccion, string Nivel, String Mes)
        {
            string mesp;
            switch (Mes)
            {
                case "ENERO": mesp = "01"; break;
                case "FEBRERO": mesp = "02"; break;
                case "MARZO": mesp = "03"; break;
                case "ABRIL": mesp = "04"; break;
                case "MAYO": mesp = "05"; break;
                case "JUNIO": mesp = "06"; break;
                case "JULIO": mesp = "07"; break;
                case "AGOSTO": mesp = "08"; break;
                case "SETIEMBRE": mesp = "09"; break;
                case "OCTUBRE": mesp = "10"; break;
                case "NOVIEMBRE": mesp = "11"; break;
                default: mesp = "12"; break;

            }
            string consulta = "exec spuReporteAsistencia '" + Grado + "' ,'" + Seccion + "', '" + Nivel + "','" + mesp + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }


    }
}
