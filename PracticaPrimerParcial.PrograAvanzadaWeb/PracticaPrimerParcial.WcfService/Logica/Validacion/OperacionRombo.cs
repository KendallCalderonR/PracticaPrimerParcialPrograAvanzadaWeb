using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionRombo
    {
        public bool LadoPositivo(double Lado)
        {
            bool resultado = true;
            if (Lado <= 0 )
            {
                resultado = false;
            }

            return resultado;
        }

        public bool DiegonalesPositivas(double DMAyor, double DMenor)
        {
            bool resultado = true;
            if (DMAyor <= 0 || DMenor <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}