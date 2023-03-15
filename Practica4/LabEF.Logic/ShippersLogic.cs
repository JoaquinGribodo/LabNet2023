using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers shipper)
        {
            try
            {
                context.Shippers.Add(shipper);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                var shipperAEliminar = context.Shippers.Find(id);
                context.Shippers.Remove(shipperAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Shippers shipper)
        {
            try
            {
                var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
                if(shipperUpdate != null)
                {
                    shipperUpdate.Phone = shipper.Phone;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La ID que ingresó no existe.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
                throw ex;
            }
        }
    }
}
