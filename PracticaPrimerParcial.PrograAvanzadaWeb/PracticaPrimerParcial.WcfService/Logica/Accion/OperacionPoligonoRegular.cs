using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.WcfService.Logica.Accion
{
    public class OperacionPoligonoRegular
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }


        internal double PerimetroPoligonoRegular(int CantidadLados, double Largo)
        {
            var Validacion = new Logica.Validacion.OperacionPoligonoRegular();
            var resultado = 0.0;

            if (Validacion.MayorCincoLados(CantidadLados) && Validacion.LadosYLargoPositivos(CantidadLados,Largo))
            {
                resultado = Largo * CantidadLados;
            }
            else
            {
                MiListaDeErrores.Add("La cantidad de lados es menor a 5 o el largo del lado es negativo");
            }

            return resultado;
        }

        internal double AreaPoligonoRegular(int CantidadLados, double Largo, double Apotema)
        {
            var Validacion = new Logica.Validacion.OperacionPoligonoRegular();
            var resultado = 0.0;
            var perimetro = PerimetroPoligonoRegular(CantidadLados, Largo);

            if (Validacion.ApotemaPositiva(Apotema))
            {
                resultado = (perimetro * Apotema) / 2;
            }
            else
            {
                MiListaDeErrores.Add("La apotema es menor que cero");
            }

            return resultado;
        }
    }
}