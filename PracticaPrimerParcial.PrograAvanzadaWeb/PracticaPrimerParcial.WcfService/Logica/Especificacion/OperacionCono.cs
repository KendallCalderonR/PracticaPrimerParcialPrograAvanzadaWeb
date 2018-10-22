using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionCono
    {
        public double ConoVolumen(double radio,double altura)
        {
            var laAccion = new Logica.Accion.OperacionCono();
            var resultado = laAccion.ConoVolumen(radio, altura);
            return resultado;
        }

        
    }
}