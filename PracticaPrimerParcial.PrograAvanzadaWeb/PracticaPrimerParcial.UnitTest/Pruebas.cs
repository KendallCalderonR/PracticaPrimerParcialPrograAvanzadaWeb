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

        [TestMethod]
        public void TrapecioPerimetroLadosPositivos()
        {
            var A = 5;
            var B = 8;
            var C = 7;
            var D = 12;
            var ValorEsperado = 32;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroTrapecio(A,B,C,D);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void TrapecioPerimetroLadosNegativos()
        {
            var A = -5;
            var B = 8;
            var C = 7;
            var D = 12;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroTrapecio(A, B, C, D);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void TrapecioAreaTodoPositivos()
        {
            var Altura = 5;
            var BMayor = 12;
            var BMenor = 7;
            
            var ValorEsperado = 47.5;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaTrapecio(Altura,BMayor,BMenor);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void TrapecioAreaAlturaNegativa()
        {
            var Altura = -5;
            var BMayor = 12;
            var BMenor = 7;

            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaTrapecio(Altura, BMayor, BMenor);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void TrapecioAreaBMayorCero()
        {
            var Altura = 5;
            var BMayor = 0;
            var BMenor = 7;

            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaTrapecio(Altura, BMayor, BMenor);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboidePerimetroLargoAnchoPositivos()
        {
            var Largo = 10;
            var Ancho = 7;
            var ValorEsperado = 34;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRomboide(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboidePerimetroLargoNegativo()
        {
            var Largo = -10;
            var Ancho = 7;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRomboide(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboidePerimetroAnchoNegativo()
        {
            var Largo = 10;
            var Ancho = -7;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.PerimetroRomboide(Largo, Ancho);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboideAreaBaseAlturaPositivos()
        {
            var Base = 10;
            var Altura = 5;
            var ValorEsperado = 50;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRomboide(Base, Altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboideAreaBaseNegativos()
        {
            var Base = -10;
            var Altura = 5;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRomboide(Base, Altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void RomboideAreaAlturaNegativos()
        {
            var Base = 10;
            var Altura = -5;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.AreaRomboide(Base, Altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void CilindroVolumenRadioAlturaPositivos()
        {//3.14159265358979000000
            var Radio = 10;
            var Altura = 15;
            var ValorEsperado = 4712.38898038469;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCilindro(Radio, Altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void CilindroVolumenRadioAlturaNegativos()
        {//3.14159265358979000000
            var Radio = -10;
            var Altura = 15;
            var ValorEsperado = 0;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCilindro(Radio, Altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void EsferaVolumenRadioPositivo()
        {//3.14159265358979000000
            var Radio = 10;
            var ValorEsperado = 3141.5926535897929;
;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenEsfera(Radio);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void EsferaVolumenRadioNegativo()
        {//3.14159265358979000000
            var Radio = -10;
            var ValorEsperado = 0;
            ;
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenEsfera(Radio);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void ConoVolumenRadioAlturaPositivos()
        {
            var Radio = 7;
            var altura = 10;
            var ValorEsperado = 513.12680008633288;
            
            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCono(Radio,altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void ConoVolumenRadioNegativo()
        {
            var Radio = -7;
            var altura = 10;
            var ValorEsperado = 0;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCono(Radio, altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void ConoVolumenAlturaNegativo()
        {
            var Radio = 7;
            var altura = -10;
            var ValorEsperado = 0;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCono(Radio, altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void CuboVolumenAristaPositiva()
        {
            var arista = 10;
            
            var ValorEsperado = 1000;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCubo(arista);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void CuboVolumenAristaNegativo()
        {
            var arista = -10;

            var ValorEsperado = 0;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenCubo(arista);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PrismaVolumenDatosPositivos()
        {
            var largo = 10;
            var ancho = 5;
            var altura = 20;
            var ValorEsperado = 1000;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenPrisma(largo,ancho,altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void PrismaVolumenDatosNegativos()
        {
            var largo = -10;
            var ancho = 5;
            var altura = 20;
            var ValorEsperado = 0;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenPrisma(largo, ancho, altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void VolumenPiramideCuadradaDatosPositivos()
        {
            var lado = 10;
            var altura = 20;
            var ValorEsperado = 666.66666666666663;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenPiramideCuadrada(lado, altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void VolumenPiramideCuadradaDatosNegativos()
        {
            var lado = -10;
            var altura = 20;
            var ValorEsperado = 0;

            var ValorReal = 0.0;

            var elServicio = new WcfService.Service1();
            ValorReal = elServicio.VolumenPiramideCuadrada(lado, altura);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

    }
}
