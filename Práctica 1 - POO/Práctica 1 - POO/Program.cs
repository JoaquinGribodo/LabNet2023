using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1___POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transportes> listaTransportes = new List<Transportes>();
            List<Transportes> listaOmnibus = new List<Transportes>();
            List<Transportes> listaTaxi = new List<Transportes>();

            Menu menu = new Menu();
            Validaciones validar = new Validaciones();
            int opcion = 0;

            do
            {
                Console.WriteLine(menu.MenuPrincipal());
                opcion = validar.ValidarEnteros(opcion, "Por favor, ingrese una opción válida: ");

                switch (opcion)
                {
                    case 1:
                        for (int o = 0; o < 5; o++)
                        {
                            if (listaOmnibus.Count < 5)
                            {
                                Console.WriteLine($"Por favor, ingrese la cantidad de pasajeros del Ómnibus {o + 1}: ");

                                int pasajerosOmnibus1 = 0;
                                pasajerosOmnibus1 = validar.ValidarEnteros(pasajerosOmnibus1, $"Ingrese la cantidad de pasajeros del Ómnibus {o + 1}: ");
                                int pasajerosOmnibus = validar.ValidarCantidadOmnibus(pasajerosOmnibus1);

                                Omnibus bus = new Omnibus(pasajerosOmnibus);
                                listaOmnibus.Add(bus);
                            }
                            else
                            {
                                Console.WriteLine("No puede ingresar más de 5 ómnibus");
                                break;
                            }
                        }
                        break;

                    case 2:
                        for (int t = 0; t < 5; t++)
                        {
                            if (listaTaxi.Count < 5)
                            {
                                Console.WriteLine($"Por favor, ingrese la cantidad de pasajeros del Taxi {t + 1}: ");

                                int pasajerosTaxi1 = 0;
                                pasajerosTaxi1 = validar.ValidarEnteros(pasajerosTaxi1, $"Ingrese la cantidad de pasajeros del Taxi {t + 1}: ");
                                int pasajerosTaxi = validar.ValidarCantidadTaxi(pasajerosTaxi1);

                                Taxi taxi = new Taxi(pasajerosTaxi);
                                listaTaxi.Add(taxi);
                            }
                            else
                            {
                                Console.WriteLine("No puede ingresar más de 5 taxis");
                                break;
                            }
                        }
                        break;

                    case 3:
                        listaTransportes = listaOmnibus.Concat(listaTaxi).ToList();
                        Console.WriteLine("Lista de Transportes:");

                        int contadorOmnibus = 1;
                        int contadorTaxi = 1;

                        foreach (var transporte in listaTransportes)
                        {
                            if (transporte.Identificar() == "Omnibus")
                            {
                                Console.WriteLine($"Ómnibus {contadorOmnibus} : {transporte}");
                                contadorOmnibus++;
                            }
                            else
                            {
                                Console.WriteLine($"Taxi {contadorTaxi} : {transporte}");
                                contadorTaxi++;
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("El programa ha finalizado. Gracias por utilizar el software.");
                        break;

                    default:
                        Console.WriteLine("Por favor, ingrese una opción válida");
                        break;
                }
            } while (opcion != 4);

            Console.ReadKey();
        }

    }
}
