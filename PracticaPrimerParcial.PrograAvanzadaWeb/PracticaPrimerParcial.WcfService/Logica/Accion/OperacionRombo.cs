using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionRombo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double PerimetroRombo(double Lado)
        {
            var Validacion = new Logica.Validacion.OperacionRombo();
            var resultado = 0.0;

            if (Validacion.LadoPositivo(Lado))
            {
                resultado = 4 * Lado;
            }
            else
            {
                MiListaDeErrores.Add("El lado ingresado es negativo");
            }

            return resultado;
        }

        internal double AreaRombo(double DMayor, double DMenor)
        {
            var Validacion = new Logica.Validacion.OperacionRombo();
            var resultado = 0.0;

            if (Validacion.DiegonalesPositivas(DMayor,DMenor))
            {
                resultado = (DMayor*DMenor)/2;
            }
            else
            {
                MiListaDeErrores.Add("Las diagonales ingresadas son negativas");
            }

            return resultado;
        }
    }
}