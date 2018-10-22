using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionPiramideCuadrada
    {

        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }


        public double VolumenPiramideCuadrada(double lado, double altura)
        {
            var Validacion = new Logica.Validacion.OperacionPiramideCuadrada();
            var resultado = 0.0;

            if (Validacion.PiramideCuadradaDatos(lado, altura))
            {
                var Ab = lado * lado;
                resultado = (Ab * altura)/3;
            }
            else
            {
                MiListaDeErrores.Add("El lado ingresado es negativo o igual a cero");
            }

            return resultado;

        }
    }
}