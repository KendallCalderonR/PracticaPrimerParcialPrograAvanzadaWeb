using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionTrapecio
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double PerimetroTrapecio(double A, double B, double C, double D)
        {
            var Validacion = new Logica.Validacion.OperacionTrapecio();
            var resultado = 0.0;

            if (Validacion.LadosPositivos(A,B,C,D))
            {
                resultado = A + B + C + D;
            }
            else
            {
                MiListaDeErrores.Add("Uno o varios de los lados es negativo");
            }

            return resultado;
        }

        internal double AreaTrapecio(double Altura, double BMayor, double BMenor)
        {
            var Validacion = new Logica.Validacion.OperacionTrapecio();
            var resultado = 0.0;

            if (Validacion.AlturaYBasesPositiva(Altura, BMayor, BMenor))
            {
                resultado = ((BMayor + BMenor) / 2) * Altura; 
            }
            else
            {
                MiListaDeErrores.Add("Uno o varios de los valores ingresados son menores que cero");
            }

            return resultado;
        }
    }
}