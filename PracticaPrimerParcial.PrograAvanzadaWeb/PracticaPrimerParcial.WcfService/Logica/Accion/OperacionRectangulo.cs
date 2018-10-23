using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionRectangulo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double PerimetroRectangulo(double Largo, double Ancho)
        {
            var Validacion = new Logica.Validacion.OperacionRectangulo();
            var resultado = 0.0;

            if (Validacion.LadosPositivos(Largo,Ancho))
            {
                resultado = 2 * (Largo+Ancho);
            }
            else
            {
                MiListaDeErrores.Add("El largo o el ancho son negativos");
            }

            return resultado;
        
        }

        internal double AreaRectangulo(double Largo, double Ancho)
        {
            var Validacion = new Logica.Validacion.OperacionRectangulo();
            var resultado = 0.0;

            if (Validacion.LadosPositivos(Largo, Ancho))
            {
                resultado = Largo * Ancho;
            }
            else
            {
                MiListaDeErrores.Add("El largo o el ancho son negativos");
            }

            return resultado;

        }
    }
}