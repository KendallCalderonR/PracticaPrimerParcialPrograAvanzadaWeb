using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionTriangulo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores { get
            {
                return MiListaDeErrores;
            } }

        internal double PerimetroTriangulo (double L1, double L2, double L3)
        {
            var Validacion = new Logica.Validacion.OperacionTriengulo();
            double resultado = 0.0;
            if (Validacion.LosLadosSonCorrectos(L1,L2,L3))
            {
                resultado = L1 + L2 + L3;
            }
            else
            {
                MiListaDeErrores.Add("Las suma de los lados menores es mayor que el valor del lado mayor");
            }
            return resultado;
        }

    }
}