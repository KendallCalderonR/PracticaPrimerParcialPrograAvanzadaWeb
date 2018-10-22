using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Validacion
{
    public class OperacionEsfera
    {
        public bool EsferaVolumenRadioPositivo(double radio)
        {

            var resultado = true;

            if (radio <= 0 )
            {
                resultado = false;
            }

            return resultado;
        }
    }
}