using LabEF.Data;
using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public  class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void Add(Products newProducts)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products product)
        {
            throw new NotImplementedException();
        }
    }
}
