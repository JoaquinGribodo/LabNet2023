using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Logic
    {
        FormatException excepcionFormato = new FormatException();
        public string MostrarExcepcion()
        {
            return excepcionFormato.Message;
        }

        public string MostrarTipoExcepcion()
        {
            return excepcionFormato.GetType().ToString();
        }

    }
}
