using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionRectangulo
    {
        public bool LadosPositivos(double Largo, double Ancho)
        {
            bool resultado = true;

            if (Largo <= 0 || Ancho <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}