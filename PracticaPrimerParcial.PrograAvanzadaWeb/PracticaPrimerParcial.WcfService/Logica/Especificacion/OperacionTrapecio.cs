using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionTrapecio
    {
        public double PerimetroTrapecio(double A, double B, double C, double D)
        {
            var laAccion = new Logica.Accion.OperacionTrapecio();
            var resultado = laAccion.PerimetroTrapecio(A,B,C,D);
            return resultado;
        }

        public double AreaTrapecio(double Altura, double BMayor, double BMenor)
        {
            var laAccion = new Logica.Accion.OperacionTrapecio();
            var resultado = laAccion.AreaTrapecio(Altura,BMayor,BMenor);
            return resultado;
        }
    }
}