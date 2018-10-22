using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionPrisma
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double VolumenPrisma(double largo, double ancho, double altura)
        {
            var Validacion = new Logica.Validacion.OperacionPrisma();
            var resultado = 0.0;
            

            if (Validacion.PrismaValoresPositivos(largo,ancho,altura))
            {
                var Ab = largo * ancho;
                resultado = Ab * altura;
            }
            else
            {
                MiListaDeErrores.Add("Uno o mas de los valores ingresados son menores o iguales a cero");
            }

            return resultado;


        }
    }
}