using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionCilindro
    {
        public bool CilindroRadioAlturaPositivos(double radio, double altura)
        {
            var resultado = true;

            if (radio <= 0 || altura <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}