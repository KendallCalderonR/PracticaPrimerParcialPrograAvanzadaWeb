using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionPiramideCuadrada
    {
        public bool PiramideCuadradaDatos(double lado, double altura)
        {
            var resultado = true;

            if (lado <= 0 || altura <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}