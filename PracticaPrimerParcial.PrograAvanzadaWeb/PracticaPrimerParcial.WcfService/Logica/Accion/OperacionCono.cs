using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionCono
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double ConoVolumen(double radio, double altura)
        {
            var Validacion = new Logica.Validacion.OperacionCono();
            var resultado = 0.0;
            double P = Math.PI;

            if (Validacion.ConoVolumenRadioAlturaPositivos(radio,altura))
            {
                resultado = (P * (Math.Pow(radio, 2) * altura)) / 3;
            }
            else
            {
                MiListaDeErrores.Add("Uno o mas de los valores ingresados son menores o iguales a cero");
            }

            return resultado;
        }
    }
}