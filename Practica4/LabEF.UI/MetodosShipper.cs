using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.UI
{
    public class MetodosShipper
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        string mensaje = "Operación realizada correctamente.";
        public bool ListShipper()
        {
            try
            {
                foreach (var shipper in shippersLogic.GetAll())
                {
                    Console.WriteLine($"{shipper.ShipperID} -- {shipper.CompanyName} -- {shipper.Phone}");
                }
                Console.WriteLine(mensaje);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
                return false;
            }
        }

        public void InsertShipper(int idShipper, string nombreShipper)
        {
            try
            {
                shippersLogic.Add(new Shippers
                {
                    ShipperID = idShipper,
                    CompanyName = nombreShipper
                });
                Console.WriteLine(mensaje);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }

        public void UpdateShipper(int idUpdateShipper, string telUpdateShipper)
        {
            try
            {
                shippersLogic.Update(new Shippers
                {
                    ShipperID = idUpdateShipper,
                    Phone = telUpdateShipper
                });
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }

        public void DeleteShipper(int idDeleteShipper)
        {
            try
            {
                shippersLogic.Remove(idDeleteShipper);
                Console.WriteLine(mensaje);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }
    }
}
