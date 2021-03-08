using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cAsistenciaAlumno : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cAsistenciaAlumno() : base("TAsistenciaAlumno")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"Fecha", "CodAlumno","CodDocente", "AñoCurricular", "Estado" , "Observacion"};
        }
        public void insert(string[] datos)
        {
            string CadenaInsertar = "exec spuTAsistenciaAlumno_Insertar '"+datos[0]+ "', '"+ datos[1] + "', '"+ datos[2] + "','"+ datos[3] + "','"+ datos[4] + "','"+ datos[5] + "'";
            aConexion.EjecutarSelect(CadenaInsertar);
        }

       
    }
}
