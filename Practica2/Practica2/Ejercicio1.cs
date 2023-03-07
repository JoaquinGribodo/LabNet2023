using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Ejercicio1
    {
        public void PrimerEjercicio()
        {
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

        }
    }
}
