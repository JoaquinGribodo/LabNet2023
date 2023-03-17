using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders>
    {
        public void Add(Orders Tnombre)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            try
            {
                return context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders Tnombre)
        {
            throw new NotImplementedException();
        }
    }
}
