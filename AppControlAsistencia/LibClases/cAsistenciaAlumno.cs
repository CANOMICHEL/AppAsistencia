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
            return new string[] {"Id", "Fecha", "CodAlumno","CodDocente", "AñoCurricular", "Estado" , "Observacion"};
        }

       
    }
}
