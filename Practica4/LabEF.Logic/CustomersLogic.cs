using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public void Add(Customers Tnombre)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            try
            {
                return context.Customers.ToList();
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

        public void Update(Customers Tnombre)
        {
            throw new NotImplementedException();
        }
    }
}
