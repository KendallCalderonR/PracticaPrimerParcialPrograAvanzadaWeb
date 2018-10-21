using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionCuadrado
    {

        public bool LadoPositivo(double Lado)
        {
            bool resultado = true;

            if (Lado <= 0)
            {
                resultado = false;
            }

            return resultado;
        }

        

    }
}