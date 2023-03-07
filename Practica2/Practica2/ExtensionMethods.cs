using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public static class ExtensionMethods
    {
        public static int DividirPorCero(this int valor, int valor2)
        {
            try
            {
                return valor / valor2;
            }
            catch (DivideByZeroException ex) 
            {
                throw ex;
            }   
        }

        public static decimal DividirDosNumeros(this decimal dividendo, decimal divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch (DivideByZeroException excepcionZero)
            {
                throw excepcionZero;
            }
        }
    }
}
