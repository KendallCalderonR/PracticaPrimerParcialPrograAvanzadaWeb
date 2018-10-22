using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionPrisma
    {
        public double VolumenPrisma(double largo,double ancho, double altura)
        {
            var laAccion = new Logica.Accion.OperacionPrisma();
            var resultado = laAccion.VolumenPrisma(largo, ancho, altura);
            return resultado;
        }
    }
}