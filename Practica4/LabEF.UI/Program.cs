using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            string mensajeError = "Ocurrió un error.";

            try
            {
                ejercicios.Ejercicio1();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }

            try
            {
                ejercicios.Ejercicio2();

            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio3();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio4();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio5();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio6();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio7();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio8();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio9();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio10();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio11();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio12();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }
            
            try
            {
                ejercicios.Ejercicio13();
            }
            catch (Exception)
            {
                Console.WriteLine(mensajeError);
                throw;
            }

            Console.ReadKey();
        }

    }
}
