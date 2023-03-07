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
    public class ExcepcionPersonalizadaTests
    {
        [TestMethod()]
        public void MostrarTipoExcepcionTest()
        {
            ExcepcionPersonalizada excepcionPersonalizada = new ExcepcionPersonalizada();
            string resultado = excepcionPersonalizada.GetType().ToString();
            string resultadoEsperado = "Practica2.ExcepcionPersonalizada";

            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}