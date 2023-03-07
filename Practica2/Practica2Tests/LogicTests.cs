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
    public class LogicTests
    {
        [TestMethod()]
        public void MostrarExcepcionTest()
        {
            FormatException excepcionFormato = new FormatException();
            string resultado = excepcionFormato.Message;
            string resultadoEsperado = "One of the identified items was in an invalid format.";
            //Si escribo en español el resultadoEsperado, el test falla porque espera que el texto esté en inglés, por eso lo cambié.
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod()]
        public void MostrarTipoExcepcionTest()
        {
            FormatException excepcionFormato = new FormatException();
            string resultado = excepcionFormato.GetType().ToString();
            string resultadoEsperado = "System.FormatException";

            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}