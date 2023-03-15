using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.UI
{
    public class MetodosCategory
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();
        string mensaje = "Operación realizada correctamente.";
        public void ListCategory()
        {
            try
            {
                foreach (var category in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{category.CategoryID} -- {category.CategoryName} -- {category.Description}");
                }
                Console.WriteLine(mensaje);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }

        public void InsertCategoria(int id, string nombreCategoria)
        {
            try
            {
                categoriesLogic.Add(new Categories
                {
                    CategoryID = id,
                    CategoryName = nombreCategoria
                });
                Console.WriteLine(mensaje);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }

        public void UpdateCategoria(int idUpdateCategoria, string descripcionCategoria)
        {
            try
            {
                categoriesLogic.Update(new Categories
                {
                    CategoryID = idUpdateCategoria,
                    Description = descripcionCategoria
                });
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }

        public void DeleteCategoria(int idDeleteCategoria)
        {
            try
            {
                categoriesLogic.Remove(idDeleteCategoria);
                Console.WriteLine(mensaje);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error. No se pudo completar la acción.");
            }
        }

    }
}
