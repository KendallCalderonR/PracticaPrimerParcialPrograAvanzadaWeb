using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionEsfera
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double VolumenEsfera(double radio)
        {
            var Validacion = new Logica.Validacion.OperacionEsfera();
            var resultado = 0.0;
            var P = Math.PI;

            if (Validacion.EsferaVolumenRadioPositivo(radio))
            {
                resultado = (4 / 3) * P * (Math.Pow(radio, 3));
            }
            else
            {
                MiListaDeErrores.Add("El radio ingresado es menor o igual a cero");
            }

            return resultado;
        }
    }
}