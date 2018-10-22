using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionCubo
    {
        public bool AristaPositiva(double arista)
        {
            bool resultado = true;

            if (arista <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}