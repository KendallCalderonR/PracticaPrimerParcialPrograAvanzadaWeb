using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PracticaPrimerParcial.WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double PerimetroTriangulo(double L1, double L2, double L3);

        [OperationContract]
        double AreaTriangulo(double L1, double L2, double L3);

        [OperationContract]
        double PerimetroCuadrado(double Lado);

        [OperationContract]
        double AreaCuadrado(double Lado);

        [OperationContract]
        double PerimetroRectangulo(double Largo, double Ancho);

        [OperationContract]
        double AreaRectangulo(double Largo, double Ancho);

        [OperationContract]
        double PerimetroRombo(double Lado);

        [OperationContract]
        double AreaRombo(double DMayor, double DMenor);

        [OperationContract]
        double PerimetroPoligonoRegular(int CantidadLados, double Largo);

        [OperationContract]
        double AreaPoligonoRegular(int CantidadLados, double Largo, double Apotema);

        [OperationContract]
        double PerimetroTrapecio(double A, double B, double C, double D);

        [OperationContract]
        double AreaTrapecio(double Altura, double BMayor, double BMenor);

        [OperationContract]
        double PerimetroRomboide(double Largo, double Ancho);

        [OperationContract]
        double AreaRomboide(double Base, double Altura);

        [OperationContract]
        double VolumenCilindro(double radio, double altura);

        [OperationContract]
        double VolumenEsfera(double radio);

        [OperationContract]
        double VolumenCono(double radio,double altura);

        [OperationContract]
        double VolumenCubo(double arista);


        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
