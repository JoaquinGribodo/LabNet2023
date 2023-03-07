using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada() : base("Ejemplo de excepción personalizada.") 
        { 
        
        }
        public string MostrarTipoExcepcion()
        {
            ExcepcionPersonalizada excepcionPersonalizada = new ExcepcionPersonalizada();
            return excepcionPersonalizada.GetType().ToString();
        }
        public override string Message => $"Ocurrió el siguiente error: {base.Message}";
    }
}
