using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionCilindro
    {

        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double VolumenCilindro(double radio, double altura)
        {
            var Validacion = new Logica.Validacion.OperacionCilindro();
            var resultado = 0.0;
            var P = Math.PI;

            if (Validacion.CilindroRadioAlturaPositivos(radio,altura))
            {
                resultado = P * (Math.Pow(radio, 2) * altura);
            }
            else
            {
                MiListaDeErrores.Add("Uno o mas de los valores ingresados son menores o iguales a cero");
            }

            return resultado;


        }
    }
}