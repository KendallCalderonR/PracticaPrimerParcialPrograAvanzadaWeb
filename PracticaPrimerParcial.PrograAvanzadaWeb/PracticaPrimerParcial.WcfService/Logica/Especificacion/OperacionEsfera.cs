using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionEsfera
    {
        public double VolumenEsfera(double Radio)
        {
            var laAccion = new Logica.Accion.OperacionEsfera();
            var resultado = laAccion.VolumenEsfera(Radio);
            return resultado;
        }
    }
}