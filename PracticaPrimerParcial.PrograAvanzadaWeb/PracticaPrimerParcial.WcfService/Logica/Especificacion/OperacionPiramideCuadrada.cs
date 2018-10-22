using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionPiramideCuadrada
    {
        public double VolumenPiramideCuadrada(double lado, double altura)
        {
            var laAccion = new Logica.Accion.OperacionPiramideCuadrada();
            var resultado = laAccion.VolumenPiramideCuadrada(lado, altura);
            return resultado;
        }
    }
}