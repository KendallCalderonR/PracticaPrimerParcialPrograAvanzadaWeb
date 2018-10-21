using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Especificacion
{
    public class OperacionPoligonoRegular
    {
        public double PerimetroPoligonoRegular(int CantidadLados,double Largo)
        {
            var laAccion = new Logica.Accion.OperacionPoligonoRegular();
            var resultado = laAccion.PerimetroPoligonoRegular(CantidadLados,Largo);
            return resultado;
        }

        public double AreaPoligonoRegular(int CantidadLados, double Largo, double Apotema)
        {
            var laAccion = new Logica.Accion.OperacionPoligonoRegular();
            var resultado = laAccion.AreaPoligonoRegular(CantidadLados, Largo, Apotema);
            return resultado;
        }
    }
}