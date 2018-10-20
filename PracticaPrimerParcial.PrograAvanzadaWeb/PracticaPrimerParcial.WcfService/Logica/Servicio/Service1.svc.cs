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
    }
}
