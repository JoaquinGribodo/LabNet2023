using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class Validaciones
    {
        public int ValidarEntero(int opcion)
        {
            bool esEntero = true;
            do
            {
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    esEntero = true;
                }
                catch (Exception)
                {
                    esEntero = false;
                    Console.WriteLine("Debe ingresar un número entero.");
                }

            } while (!esEntero);

            return opcion;
        }

        public string ValidarTelefono(string telefono)
        {
            bool esTelefono;
            int longitudTelefono = telefono.Length;

            do
            {
                try
                {
                    Console.WriteLine("Por favor, ingrese un número de teléfono: ");
                    telefono = Console.ReadLine();
                    string caracteres = "[QWERTYUIOPASDFGHJKLZXCVBNMÑqwertyuiopasdfghjklzxcvbnmñ/*{}´.,!|@$%&/=]";
                    //Perdón por lo "hardcodeado" de la validación, pero nunca había utilizado las expresiones regulares.
                    //Seguramente se puede hacer mejor, pero se me ocurrió esta validación.
                    esTelefono = Regex.IsMatch(telefono, caracteres);

                    if (esTelefono)
                    {
                        Console.WriteLine("No se pueden ingresar letras o símbolos que no correspondan.");
                    }
                    else if (esTelefono && (longitudTelefono < 8 || longitudTelefono > 24))
                    {
                        Console.WriteLine("La cantidad de dígitos tiene que ser mayor que 8 y menor que 24.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
                    throw;
                }
                
            } while (esTelefono);

            return telefono;
        }
    }
}
