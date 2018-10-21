using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaPrimerParcial.WcfService;

namespace PracticaPrimerParcial.UnitTest
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void PerimetroLadosPositivos()
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
        public void PerimetroLadosNegativos()
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
        public void AreaLadosPositivos()
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
        public void AreaLadosNegativos()
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
    }
}
