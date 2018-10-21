using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionRomboide
    {
        public bool LargoYAnchoPositivos(double Largo, double Ancho)
        {
            var resultado = true;

            if (Largo <= 0 || Ancho <= 0)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool BAseYAlturaPositivos(double Base, double Altura)
        {
            var resultado = true;

            if (Base <= 0 || Altura <= 0)
            {
                resultado = false;
            }

            return resultado;
        }

    }
}