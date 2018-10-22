using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionPrisma
    {
        public bool PrismaValoresPositivos(double largo,double ancho, double altura)
        {
            var resultado = true;

            if (largo <= 0 || ancho <= 0 || altura <= 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}