using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PracticaPrimerParcial.WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public double AreaCuadrado(double Lado)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionCuadrado();
            var resultado = laEspecificacion.AreaCuadrado(Lado);
            return resultado;
        }

        public double AreaPoligonoRegular(int CantidadLados, double Largo, double Apotema)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionPoligonoRegular();
            var resultado = laEspecificacion.AreaPoligonoRegular(CantidadLados,Largo,Apotema);
            return resultado;
        }

        public double AreaRectangulo(double Largo, double Ancho)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRectangulo();
            var resultado = laEspecificacion.AreaTriangulo(Largo,Ancho);
            return resultado;
        }

        public double AreaRombo(double DMayor, double DMenor)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRombo();
            var resultado = laEspecificacion.AreaRombo(DMayor,DMenor);
            return resultado;
        }

        public double AreaRomboide(double Base, double Altura)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRomboide();
            var resultado = laEspecificacion.AreaRomboide(Base, Altura);
            return resultado;
        }

        public double AreaTrapecio(double Altura, double BMayor, double BMenor)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionTrapecio();
            var resultado = laEspecificacion.AreaTrapecio(Altura, BMayor,BMenor);
            return resultado;
        }

        public double AreaTriangulo(double L1, double L2, double L3)
        {
            Logica.Especificacion.OperacionTriangulo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionTriangulo();
            var resultado = laEspecificacion.AreaTriangulo(L1, L2, L3);
            return resultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double PerimetroCuadrado(double Lado)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionCuadrado();
            var resultado = laEspecificacion.PerimetroCuadrado(Lado);
            return resultado;
        }

        public double PerimetroPoligonoRegular(int CantidadLados, double Largo)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionPoligonoRegular();
            var resultado = laEspecificacion.PerimetroPoligonoRegular(CantidadLados, Largo);
            return resultado;
        }

        public double PerimetroRectangulo(double Largo, double Ancho)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRectangulo();
            var resultado = laEspecificacion.PerimetroTriangulo(Largo, Ancho);
            return resultado;
        }

        public double PerimetroRombo(double Lado)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRombo();
            var resultado = laEspecificacion.PerimetroRombo(Lado);
            return resultado;
        }

        public double PerimetroRomboide(double Largo, double Ancho)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionRomboide();
            var resultado = laEspecificacion.PerimetroRomboide(Largo, Ancho);
            return resultado;
        }

        public double PerimetroTrapecio(double A, double B, double C, double D)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionTrapecio();
            var resultado = laEspecificacion.PerimetroTrapecio(A,B,C,D);
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="L1">Primer lado ingresdado</param>
        /// <param name="L2">Segundo lado ingresado</param>
        /// <param name="L3">Tercer lado ingresado</param>
        /// <returns>Perimetro del triangulo</returns>
        public double PerimetroTriangulo(double L1, double L2, double L3)
        {
            Logica.Especificacion.OperacionTriangulo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionTriangulo();
            var resultado = laEspecificacion.PerimetroTriangulo(L1, L2, L3);
            return resultado;
        }

        public double VolumenCilindro(double radio, double altura)
        {
            var laEspecificacion = new Logica.Especificacion.OperacionCilindro();
            var resultado = laEspecificacion.VolumenCilindro(radio, altura);
            return resultado;
        }
    }
}
