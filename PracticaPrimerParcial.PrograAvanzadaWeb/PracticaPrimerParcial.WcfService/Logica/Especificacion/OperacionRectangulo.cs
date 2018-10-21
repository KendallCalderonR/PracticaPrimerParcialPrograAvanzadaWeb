using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionRectangulo
    {

        public double PerimetroTriangulo(double Largo,double Ancho)
        {
            var laAccion = new Logica.Accion.OperacionRectangulo();
            var resultado = laAccion.PerimetroRectangulo(Largo,Ancho);
            return resultado;
        }

        public double AreaTriangulo(double Largo, double Ancho)
        {
            var laAccion = new Logica.Accion.OperacionRectangulo();
            var resultado = laAccion.AreaRectangulo(Largo, Ancho);
            return resultado;
        }

    }
}