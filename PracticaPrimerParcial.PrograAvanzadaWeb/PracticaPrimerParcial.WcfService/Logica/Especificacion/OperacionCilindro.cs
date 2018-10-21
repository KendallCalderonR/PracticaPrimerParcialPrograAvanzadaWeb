using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionCilindro
    {

        public double VolumenCilindro(double radio, double altura)
        {
            var laAccion = new Logica.Accion.OperacionCilindro();
            var resultado = laAccion.VolumenCilindro(radio, altura);
            return resultado;
        }
    }
}