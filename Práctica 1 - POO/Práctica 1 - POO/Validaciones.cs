using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1___POO
{
    public class Validaciones
    {
        public int ValidarEnteros(int valor, string mensaje = "")
        {
            while (!Int32.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Debe ingresar un número entero válido.");
                Console.WriteLine(mensaje);
            }

            return valor;
        }

        public int ValidarCantidadTaxi(int cantidadPasajerosTaxi)
        {
            while ((cantidadPasajerosTaxi > 5 || cantidadPasajerosTaxi < 1))
            {
                Console.WriteLine("Debe ingresar un valor menor o igual a 5 y mayor o igual a 1.\nIngrese nuevamente la cantidad de pasajeros: ");
                cantidadPasajerosTaxi = ValidarEnteros(cantidadPasajerosTaxi);
            }

            return cantidadPasajerosTaxi;
        }

        public int ValidarCantidadOmnibus(int cantidadPasajerosOmnibus)
        {
            while ((cantidadPasajerosOmnibus > 40 || cantidadPasajerosOmnibus < 1))
            {
                Console.WriteLine("Debe ingresar un valor menor o igual a 40 y mayor o igual a 1.\nIngrese nuevamente la cantidad de pasajeros: ");
                cantidadPasajerosOmnibus = ValidarEnteros(cantidadPasajerosOmnibus);
            }

            return cantidadPasajerosOmnibus;
        }
    }
}
