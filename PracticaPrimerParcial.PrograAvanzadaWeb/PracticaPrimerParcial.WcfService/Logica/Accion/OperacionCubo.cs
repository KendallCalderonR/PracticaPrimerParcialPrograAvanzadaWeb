using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionCubo
    {

        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double VolumenCubo(double arista)
        {
            var Validacion = new Logica.Validacion.OperacionCubo();
            var resultado = 0.0;
            var P = Math.PI;

            if (Validacion.AristaPositiva(arista))
            {
                resultado = Math.Pow(arista, 3);
            }
            else
            {
                MiListaDeErrores.Add("El valor ingresado es menor o igual a cero");
            }

            return resultado;


        }
    }
}