using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1___POO
{
    public abstract class Transportes
    {
        private int cantidadPasajeros;

        public Transportes(int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        public abstract string Identificar();

    }

    public class Omnibus : Transportes
    {
        public int pasajerosOmnibus;
        public Omnibus(int CantidadPasajeros) : base(CantidadPasajeros)
        {
            pasajerosOmnibus = CantidadPasajeros;
        }
        public override string Avanzar()
        {
            return "El omnibus avanza.";
        }

        public override string Detenerse()
        {
            return "El omnibus se detiene.";
        }
        public override string ToString()
        {
            return pasajerosOmnibus.ToString();
        }

        public override string Identificar()
        {
            return "Omnibus";
        }
    }

    public class Taxi : Transportes
    {
        public int pasajerosTaxi;
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
            pasajerosTaxi = cantidadPasajeros;
        }

        public override string Avanzar()
        {
            return "El taxi avanza.";
        }

        public override string Detenerse()
        {
            return "El taxi se detiene.";
        }
        public override string ToString()
        {
            return pasajerosTaxi.ToString();
        }

        public override string Identificar()
        {
            return "Taxi";
        }

    }
}
