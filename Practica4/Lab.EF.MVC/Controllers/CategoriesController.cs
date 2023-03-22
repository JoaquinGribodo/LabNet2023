using Lab.EF.MVC.Models;
using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            try
            {
                List<LabEF.Entities.Categories> categories = logic.GetAll();
                List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
                {
                    Id = c.CategoryID,
                    Nombre = c.CategoryName,
                    Descripcion = c.Description
                }).ToList();

                return View(categoriesView);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
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
                    logic.Add(categoryEntity);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(categoriesView);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var entity = logic.GetAll().Where(e => e.CategoryID == id).FirstOrDefault();
                CategoriesView model = new CategoriesView
                {
                    Id = entity.CategoryID,
                    Nombre = entity.CategoryName,
                    Descripcion = entity.Description
                };

                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(CategoriesView categoriesView)
        {
            try
            {
                logic.Update(new Categories { CategoryID = categoriesView.Id, CategoryName = categoriesView.Nombre, Description = categoriesView.Descripcion });
                                                                              //El nombre nuevo se pasa bien, pero no se modifica en la tabla
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            } 
        }
    }
}