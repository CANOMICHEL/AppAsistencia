using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibClases
{
    public class cUsuario : cEntidad
    {
        public cUsuario() : base("TUsuario")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "Id", "NombreUsuario", "Contraseña", "Rol" };
        }

        public DataTable RolUsuario(string Id)
        {
            string consulta = "exec spuTUsuarioRol '" + Id + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public Boolean RespuestaLogin(string pUsuario, string pContraseña)
        {
            string Consulta = "exec spuTUsuario_Validar '" + pUsuario + "' ,'" + pContraseña + "'";
            //Console.WriteLine(Consulta);

            aConexion.EjecutarSelect(Consulta);
            if (aConexion.Datos.Tables[0].Rows[0][0].ToString() == "0")
                return true;
            else
                return false;
        }

        public String RolLogin(string pUsuario)
        {
            string Consulta = "exec spuTUsuarioRol '" + pUsuario + "'";
            //Console.WriteLine(Consulta);

            aConexion.EjecutarSelect(Consulta);
            //string Id = aConexion.Datos.Tables[0].Rows[0][0].ToString();
            string Rol = aConexion.Datos.Tables[0].Rows[0][0].ToString();
            if (Rol != "")
                return Rol;
            else
                return "";
        }
    }
}
