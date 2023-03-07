using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1 ejercicio1 = new Ejercicio1();   CONSULTA: ¿ES VÁLIDO HACER ESTO CON TODOS LOS EJERCICIOS PARA DEJAR EL MAIN MÁS LIMPIO
            //ejercicio1.PrimerEjercicio();               O NO ES RECOMENDABLE POR EL TEMA DE LOS CONSOLE.WRITELINE EN LOS MÉTODOS DE LAS CLASES?

            int resultadoEjercicio1;
            int numeroEjercicio1 = 0;
            bool esEntero;

            Console.WriteLine("Por favor, ingrese un número entero: ");
            do
            {
                try
                {
                    numeroEjercicio1 = int.Parse(Console.ReadLine());
                    esEntero = true;
                }
                catch (Exception)
                {
                    esEntero = false;
                    Console.WriteLine("Debe ingresar un número entero.");
                }

            } while (!esEntero);

            try
            {
                resultadoEjercicio1 = numeroEjercicio1.DividirPorCero(0); //El 0 está hardcodeado porque el ejercicio dice que la división es por cero. Por lo tanto, el usuario no ingresa ese dato.
                Console.WriteLine(resultadoEjercicio1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La operación finalizó.");
            }

            Console.WriteLine("Finalizó el ejercicio 1\nPresione una tecla para continuar....");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Comienzo del ejercicio 2");

            decimal dividendo = 0;
            decimal divisor = 0;
            decimal resultadoEjercicio2;
            bool dividendoEsNumero = false;
            bool divisorEsNumero = false;
            bool esNumero = false;

            do
            {
                try
                {
                    if(!dividendoEsNumero)
                    {
                        Console.WriteLine("Por favor, ingrese un número entero (dividendo): ");
                        dividendo = decimal.Parse(Console.ReadLine());
                        dividendoEsNumero = true;
                    }

                    if (!divisorEsNumero)
                    {
                        Console.WriteLine("Por favor, ingrese un número entero (divisor): ");
                        divisor = decimal.Parse(Console.ReadLine());
                        divisorEsNumero = true;
                    }
                    
                    if (dividendoEsNumero && divisorEsNumero) 
                    {
                        esNumero = true;
                    }
                }
                catch (FormatException)
                {
                    esNumero = false;
                    Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
                }

            } while (!esNumero);

            try
            {
                resultadoEjercicio2 = dividendo.DividirDosNumeros(divisor);
                Console.WriteLine(string.Format("El resultado es: {0} ", resultadoEjercicio2));
            }
            catch (DivideByZeroException excepcionZero)
            {
                Console.WriteLine("¡Sólo Chuck Norris divide por cero!");
                Console.WriteLine(excepcionZero.Message);
            }
            finally
            {
                Console.WriteLine("La operación finalizó.");
            }

            Console.WriteLine("Finalizó el ejercicio 2\nPresione una tecla para continuar....");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Comienzo del ejercicio 3");

            Logic excepcion = new Logic(); /*Según la consigna, hay que crear un método que dispare una excepción. Por lo que entiendo, no hay que pedirle al usuario que ingrese un dato.
                                           Por ese motivo, generé el método que dispare la excepción directamente.*/
         
            Console.WriteLine($"Mensaje de la excepción: {excepcion.MostrarExcepcion()}");
            Console.WriteLine($"Tipo de la excepción: {excepcion.MostrarTipoExcepcion()}");


            Console.WriteLine("\nFinalizó el ejercicio 3\nPresione una tecla para continuar....");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Comienzo del ejercicio 4");

            ExcepcionPersonalizada personalizada = new ExcepcionPersonalizada(); //Opté por crear el objeto en lugar de crear los métodos como static

            Console.WriteLine($"Tipo de excepción: {personalizada.MostrarTipoExcepcion()}");
            Console.WriteLine($"Mensaje de la excepción: {personalizada.Message}");
            MessageBox.Show(personalizada.Message, "Ejemplo de excepción personalizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}
