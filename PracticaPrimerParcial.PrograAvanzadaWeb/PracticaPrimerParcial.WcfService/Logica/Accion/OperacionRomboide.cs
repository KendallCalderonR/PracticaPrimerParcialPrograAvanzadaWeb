using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionRomboide
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double PerimetroRomboide(double Largo,double Ancho)
        {
            var Validacion = new Logica.Validacion.OperacionRomboide();
            var resultado = 0.0;

            if (Validacion.LargoYAnchoPositivos(Largo,Ancho))
            {
                resultado = 2 * (Largo + Ancho);
            }
            else
            {
                MiListaDeErrores.Add("Uno o mas valores ingresados son menores o iguales a cero");
            }

            return resultado;
        }

        internal double AreaRomboide(double Base, double Altura)
        {
            var Validacion = new Logica.Validacion.OperacionRomboide();
            var resultado = 0.0;

            if (Validacion.BAseYAlturaPositivos(Base, Altura))
            {
                resultado = Base * Altura;
            }
            else
            {
                MiListaDeErrores.Add("Uno o mas valores ingresados son menores o iguales a cero");
            }

            return resultado;
        }
    }
}