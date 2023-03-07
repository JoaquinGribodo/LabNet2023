using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Tests
{
    [TestClass()]
    public class ExtensionMethodsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCeroMuestraErrorTest()
        {
            int numero1 = 10;

            numero1.DividirPorCero(0);
        }


        [TestMethod()]
        public void DividirDosNumerosTest1()
        {
            decimal numero1 = 50;
            decimal numero2 = 2.2M;
            decimal resultadoEsperado = 22.727272727272727272727272727M;
            decimal resultadoObtenido;

            resultadoObtenido = numero1.DividirDosNumeros(numero2);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
    }
}