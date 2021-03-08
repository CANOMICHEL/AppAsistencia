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
            return new string[] { "CodDocente", "Contraseña", "DNI", "Nombre", "Direccion", "Telefono" };
        }

        public DataTable AulassDocente(string cod)
        {
            string consulta = "exec spuTMatricula_GradoPorDocente '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable NombreDocente(string cod)
        {
            string consulta = "exec spuTDocente_Datos '" + cod + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ListarDocentes()
        {
            string consulta = "exec spuTDocente_Listar";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ultimo()
        {
            string consulta = "exec spuTDocente_Ultimo";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
