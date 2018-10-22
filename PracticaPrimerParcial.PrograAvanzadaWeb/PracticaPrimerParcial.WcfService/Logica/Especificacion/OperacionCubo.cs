using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionCubo
    {

        public double VolumenCubo(double arista)
        {
            var laAccion = new Logica.Accion.OperacionCubo();
            var resultado = laAccion.VolumenCubo(arista);
            return resultado;
        }
    }
}