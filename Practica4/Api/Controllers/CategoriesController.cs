using Lab.EF.MVC.Models;
using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Api.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesLogic logica = new CategoriesLogic();
        
        //GET
        public IEnumerable<CategoriesView> Get()
        {
            try
            {
                List<LabEF.Entities.Categories> categories = logica.GetAll();
                List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
                {
                    Id = c.CategoryID,
                    Nombre = c.CategoryName,
                    Descripcion = c.Description
                }).ToList();
                return categoriesView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST
        public bool Post([FromBody] CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryID = categoriesView.Id,
                    CategoryName = categoriesView.Nombre,
                    Description = categoriesView.Descripcion
                };

                if (ModelState.IsValid)
                {
                    logica.Add(categoryEntity);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //UPDATE CON POST
        public void Update(int id)
        {
            try
            {
                var entity = logica.GetAll().Where(e => e.CategoryID == id).FirstOrDefault();
                CategoriesView model = new CategoriesView
                {
                    Id = entity.CategoryID,
                    Nombre = entity.CategoryName,
                    Descripcion = entity.Description
                };

                logica.Update(new Categories { CategoryID = model.Id, CategoryName = model.Nombre, Description = model.Descripcion });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //DELETE
        public void Delete(int id)
        {
            try
            {
                logica.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}