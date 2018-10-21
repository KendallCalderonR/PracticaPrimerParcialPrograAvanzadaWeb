using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaPrimerParcial.WcfService;

namespace PracticaPrimerParcial.UnitTest
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void TrianguloPerimetroLadosPositivos()
        {
            var L1 = 2;
            var L2 = 4;
            var L3 = 5;
            var ValorEsperado = 11;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroTriangulo(L1,L2,L3);

            Assert.AreEqual(ValorEsperado,ValorReal);
            

        }

        [TestMethod]
        public void TrianguloPerimetroLadosNegativos()
        {
            var L1 = 2;
            var L2 = -4;
            var L3 = 5;
            var ValorEsperado = 0.0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroTriangulo(L1, L2, L3);

            Assert.AreEqual(ValorEsperado, ValorReal);


        }

        [TestMethod]
        public void TrianguloAreaLadosPositivos()
        {
            var L1 = 15;
            var L2 = 20;
            var L3 = 30;
            var ValorEsperado = 133.31705629813465;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaTriangulo(L1, L2, L3);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void TrianguloAreaLadosNegativos()
        {
            var L1 = -15;
            var L2 = 20;
            var L3 = 30;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaTriangulo(L1, L2, L3);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void CuadradoPerimetroLadoPositivos()
        {
            var L1 = 15;
            var ValorEsperado = 60;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroCuadrado(L1);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void CuadradoPerimetroLadoNegativos()
        {
            var L1 = -15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroCuadrado(L1);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void CuadradoAreaLadoPositivos()
        {
            var L1 = 15;
            var ValorEsperado = 225;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaCuadrado(L1);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void CuadradoAreaLadoNegativos()
        {
            var L1 = -15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaCuadrado(L1);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }


        [TestMethod]
        public void RectanguloPerimetroLadoPositivos()
        {
            var Largo = 30;
            var Ancho = 15;
            var ValorEsperado = 90;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRectangulo(Largo,Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RectanguloPerimetroLadosNegativos()
        {
            var Largo = -30;
            var Ancho = 15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRectangulo(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RectanguloAreaLadoPositivos()
        {
            var Largo = 30;
            var Ancho = 15;
            var ValorEsperado = 450;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRectangulo(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RectanguloAreaLadosNegativos()
        {
            var Largo = -30;
            var Ancho = 15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRectangulo(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RomboPerimetroLadoPositivo()
        {
            var Lado = 30;    
            var ValorEsperado = 120;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRombo(Lado);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RomboPerimetroLadoNegativo()
        {
            var Lado = -30;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRombo(Lado);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RomboAreaDiagonalesPositivas()
        {
            var Dmayor = 30;
            var DMenor = 15;
            var ValorEsperado = 225;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRombo(Dmayor,DMenor);

            Assert.AreEqual(ValorEsperado, ValorReal);

        }

        [TestMethod]
        public void RomboAreaDiagonalesNegativas()
        {
            var Dmayor = -30;
            var DMenor = 15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRombo(Dmayor, DMenor);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularPerimetroladosPositivos()
        {
            var CantidadLados = 6;
            var LargoLados = 7;
            var ValorEsperado = 42;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroPoligonoRegular(CantidadLados, LargoLados);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularPerimetroladosNegativos()
        {
            var CantidadLados = -6;
            var LargoLados = 7;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroPoligonoRegular(CantidadLados, LargoLados);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularPerimetroLargoLadosNegativos()
        {
            var CantidadLados = 6;
            var LargoLados = -7;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroPoligonoRegular(CantidadLados, LargoLados);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularArealadosPositivos()
        {
            var CantidadLados = 6;
            var LargoLados = 7;
            var Apotema = 5;
            var ValorEsperado = 105;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaPoligonoRegular(CantidadLados, LargoLados,Apotema);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularAreaCantidadLadosNegativa()
        {
            var CantidadLados = -6;
            var LargoLados = 7;
            var Apotema = 5;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaPoligonoRegular(CantidadLados, LargoLados, Apotema);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularAreaLargoLadosNegativa()
        {
            var CantidadLados = 6;
            var LargoLados = -7;
            var Apotema = 5;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaPoligonoRegular(CantidadLados, LargoLados, Apotema);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PoligonoRegularAreaApotemaNegativa()
        {
            var CantidadLados = 6;
            var LargoLados = 7;
            var Apotema = -5;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaPoligonoRegular(CantidadLados, LargoLados, Apotema);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

    }
}
