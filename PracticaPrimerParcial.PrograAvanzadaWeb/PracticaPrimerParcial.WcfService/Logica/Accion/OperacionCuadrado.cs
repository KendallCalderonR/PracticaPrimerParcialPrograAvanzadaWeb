using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionCuadrado
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }


        internal double PerimetroCuadrado(double lado)
        {
            var Validacion = new Logica.Validacion.OperacionCuadrado();
            var resultado = 0.0;

            if (Validacion.LadoPositivo(lado))
            {
                resultado = 4 * lado;
            }
            else
            {
                MiListaDeErrores.Add("El lado ingresado es negativo");
            }

            return resultado;

        }

        internal double AreaCuadrado(double lado)
        {
            var Validacion = new Logica.Validacion.OperacionCuadrado();
            var resultado = 0.0;

            if (Validacion.LadoPositivo(lado))
            {
                resultado = lado * lado;
            }
            else
            {
                MiListaDeErrores.Add("El lado ingresado es negativo");
            }

            return resultado;

        }



    }
}