using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibClases
{
    public class cAlumno : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cAlumno() : base("TAlumno")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"DNI", "Nombre", "Direccion", "Telefono" };
        }

        public DataTable ListarAlumnosGrado(string Grado, string Seccion, string Nivel)
        {
            string consulta = "exec spuAlumnosListar '"+Grado + "' ,'"+ Seccion +"', '"+Nivel+"'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
