using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionTrapecio
    {

        public bool LadosPositivos(double A, double B, double C, double D)
        {
            var resultado = true;

            if (A <= 0 || B <= 0 || C <= 0 || D <= 0)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool AlturaYBasesPositiva(double Altura,double BMayor,double BMenor)
        {
            var resultado = true;

            if (Altura <= 0 || BMayor <= 0 || BMenor <= 0)
            {
                resultado = false;
            }

            return resultado;
        }


    }
}