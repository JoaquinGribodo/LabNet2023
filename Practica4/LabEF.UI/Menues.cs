using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.UI
{
    public class Menues
    {
        public void Principal()
        {
            Console.WriteLine("Bievenido al menú de opciones.");
            Console.WriteLine("1- Categorías.");
            Console.WriteLine("2- Transportistas.");
            Console.WriteLine("3- Salir");
            Console.WriteLine("Por favor, ingrese una opción:");
        }

        public void MenuCategorias()
        {
            Console.WriteLine("1- Ver lista de Categorías.");
            Console.WriteLine("2- Insertar nueva Categoría.");
            Console.WriteLine("3- Actualizar Descripción de una Categoría.");
            Console.WriteLine("4- Eliminar una Categoría.");
            Console.WriteLine("5- Volver al Menú Principal");
        }

        public void MenuTransportistas()
        {
            Console.WriteLine("1- Ver lista de Transportistas.");
            Console.WriteLine("2- Insertar nuevo Transportista.");
            Console.WriteLine("3- Actualizar Transportista.");
            Console.WriteLine("4- Eliminar un Transportista.");
            Console.WriteLine("5- Volver al Menú Principal");
        }

        public void MenuGeneral()
        {
            MetodosCategory metodosCategoria = new MetodosCategory();
            MetodosShipper metodosShipper = new MetodosShipper();
            Validaciones validar = new Validaciones();
            Menues menu = new Menues();

            int opcGeneral = 0;
            int opcCategory = 0;
            int opcShipper = 0;
            int idCategoria = 0;
            int idUpdateCategoria = 0;
            int idDeleteCategoria = 0;
            int idShipper = 0;
            int idUpdateShipper = 0;
            int idDeleteShipper = 0;
            string telUpdateShipper = "";

            do
            {
                menu.Principal();

                opcGeneral = validar.ValidarEntero(opcGeneral);

                switch (opcGeneral)
                {
                    case 1:
                        do
                        {
                            menu.MenuCategorias();
                            opcCategory = validar.ValidarEntero(opcCategory);

                            if (opcCategory > 5)
                            {
                                Console.WriteLine("Por favor, ingrese una opción válida.");
                            }

                        } while (opcCategory > 5);

                        switch (opcCategory)
                        {
                            case 1:
                                metodosCategoria.ListCategory();
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el nombre de la nueva Categoría:");
                                string nombreCategoria = Console.ReadLine();

                                metodosCategoria.InsertCategoria(idCategoria, nombreCategoria);
                                break;

                            case 3:
                                Console.WriteLine("Ingrese ID de la Categoría a Actualizar:");
                                idUpdateCategoria = validar.ValidarEntero(idUpdateCategoria);

                                Console.WriteLine("Ingrese la nueva Descripción:");
                                string descripcionCategoria = Console.ReadLine();

                                metodosCategoria.UpdateCategoria(idUpdateCategoria, descripcionCategoria);
                                break;

                            case 4:
                                Console.WriteLine("Ingrese ID de la Categoría a Eliminar:");
                                idDeleteCategoria = validar.ValidarEntero(idDeleteCategoria);

                                metodosCategoria.DeleteCategoria(idDeleteCategoria);
                                break;

                            default:
                                Console.WriteLine("Menú Principal.");
                                break;
                        }
                        break;

                    case 2:
                        do
                        {
                            menu.MenuTransportistas();
                            opcShipper = validar.ValidarEntero(opcShipper);

                            if (opcShipper > 5)
                            {
                                Console.WriteLine("Por favor, ingrese una opción válida.");
                            }
                        } while (opcShipper > 5);


                        switch (opcShipper)
                        {
                            case 1:
                                metodosShipper.ListShipper();
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el Nombre del nuevo Transportista:");
                                string nombreShipper = Console.ReadLine();

                                metodosShipper.InsertShipper(idShipper, nombreShipper);
                                break;

                            case 3:
                                Console.WriteLine("Ingrese ID del Transportista a Actualizar:");
                                idUpdateShipper = validar.ValidarEntero(idUpdateShipper);

                                Console.WriteLine("Ingrese el nuevo Teléfono del Transportista:");
                                telUpdateShipper = validar.ValidarTelefono(telUpdateShipper);

                                metodosShipper.UpdateShipper(idUpdateShipper, telUpdateShipper);
                                break;

                            case 4:
                                Console.WriteLine("Ingrese ID del Transportista a Eliminar:");
                                idDeleteShipper = validar.ValidarEntero(idDeleteShipper);

                                metodosShipper.DeleteShipper(idDeleteShipper);
                                break;

                            default:
                                Console.WriteLine("Por favor, ingrese una opción válida.");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("El programa finalizó. Gracias por utilizar el software.");
                        break;

                    default:
                        Console.WriteLine("Por favor, ingrese una opción válida.");
                        break;
                }

            } while (opcGeneral != 3);
        }
    }
}
