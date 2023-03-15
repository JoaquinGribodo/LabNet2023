using LabEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories category)
        {
            try
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public List<Categories> GetAll()
        {
            try
            {
                return context.Categories.ToList();
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
                var categoriaAEliminar = context.Categories.Find(id);
                context.Categories.Remove(categoriaAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Categories category)
        {
            try
            {
                var categoryUpdate = context.Categories.Find(category.CategoryID);
                if(categoryUpdate != null)
                {
                    categoryUpdate.Description = category.Description;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La ID que ingresó no existe.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
