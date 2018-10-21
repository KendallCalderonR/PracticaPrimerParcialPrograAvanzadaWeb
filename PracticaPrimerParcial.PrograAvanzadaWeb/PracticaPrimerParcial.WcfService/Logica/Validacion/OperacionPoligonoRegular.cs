using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionPoligonoRegular
    {
        public bool MayorCincoLados(int CantidadLados)
        {
            var resultado = true;

            if (CantidadLados <= 5)
            {
                resultado = false;
            }

            return resultado;

        }

        public bool LadosYLargoPositivos(int CantidadLados,double Largo)
        {
            var resultado = true;

            if (CantidadLados <= 0 || Largo <= 0)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ApotemaPositiva(double Apotema)
        {
            var resultado = true;

            if (Apotema <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}