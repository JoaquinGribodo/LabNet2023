using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic.Tests
{
    [TestClass()]
    public class ValidacionesTests
    {

        [TestMethod()]
        public void ValidarTelefonoTest()
        {
            Validaciones validar = new Validaciones();  //Creo que el test nunca se deja de ejecutar porque está esperando 
                                                        //el telefono = Console.ReadLine() del método, pero no sé cómo solucionarlo.
                                                        //Pasa lo mismo con el método ValidarEntero
                                                        //Intenté hacer varios Tests con Mock, pero siempre aparecía algún error. No terminé de entender bien cómo se implementa.

            string telefono = "123456789";
            string resultadoEsperado = telefono;
            string resultadoObtenido = validar.ValidarTelefono(telefono);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}