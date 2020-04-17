using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Logica
{
   public class Logica
    {
        Sentencias sn = new Sentencias();
        /*OBTENER COD SIGUIENTE*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

    }
}
