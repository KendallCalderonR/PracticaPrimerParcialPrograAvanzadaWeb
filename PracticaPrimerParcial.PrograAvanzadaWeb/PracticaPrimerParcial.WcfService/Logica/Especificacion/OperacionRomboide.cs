using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionRomboide
    {

        public double PerimetroRomboide(double Largo, double Ancho)
        {
            var laAccion = new Logica.Accion.OperacionRomboide();
            var resultado = laAccion.PerimetroRomboide(Largo,Ancho);
            return resultado;
        }

        public double AreaRomboide(double Base, double Altura)
        {
            var laAccion = new Logica.Accion.OperacionRomboide();
            var resultado = laAccion.AreaRomboide(Base, Altura);
            return resultado;
        }
    }
}