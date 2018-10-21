using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionRombo
    {
        public double PerimetroRombo (double Lado)
        {
            var laAccion = new Logica.Accion.OperacionRombo();
            var resultado = laAccion.PerimetroRombo(Lado);
            return resultado;
        }

        public double AreaRombo(double DMayor, double DMenor)
        {
            var laAccion = new Logica.Accion.OperacionRombo();
            var resultado = laAccion.AreaRombo(DMayor,DMenor);
            return resultado;
        }
    }
}