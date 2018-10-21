﻿using System;
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

    }
}
