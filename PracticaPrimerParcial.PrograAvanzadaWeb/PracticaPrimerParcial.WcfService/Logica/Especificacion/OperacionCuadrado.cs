using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionCuadrado
    {

        public double PerimetroCuadrado(double Lado)
        {
            var laAccion = new Logica.Accion.OperacionCuadrado();
            double resultado = laAccion.PerimetroCuadrado(Lado);
            return resultado;
        }

        public double AreaCuadrado(double Lado)
        {
            var laAccion = new Logica.Accion.OperacionCuadrado();
            double resultado = laAccion.AreaCuadrado(Lado);
            return resultado;
        }
    }
}