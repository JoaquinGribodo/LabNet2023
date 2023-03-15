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
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void UpdateTest()
        {
            ShippersLogic shippersLogic = new ShippersLogic();

            string resultadoEsperado = "La ID que ingresó no existe.";
            string resultadoObtenido = shippersLogic.Update(null);

        }
    }
}