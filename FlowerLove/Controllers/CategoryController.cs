using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using FlowerLove.Data.Models;
using FlowerLove.Services.Service;
using FlowerLove.Services.IService;
using FlowerLove.Data.Models.Domain;

namespace FlowerLove.Controllers
{
    public class CategoryController : Controller
    {
        private IFlowerService FlowerService;
        public CategoryController()
        {
            FlowerService = new FlowerService();
        }

        #region showing categories for admin

        public ActionResult Index()
        {
            var query = FlowerService.GetAllCategories();

            return View(query);
        }

        #endregion


        #region add categories

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblCategory c)
        {
            if (ModelState.IsValid)
            {
                FlowerService.AddCategory(c);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Not Inserted Category";
            }
            return View();
        }

        #endregion


        #region edit category

        public ActionResult Edit(int id)
        {
            var query = FlowerService.GetCategoryById(id);
            return View(query);
        }

        [HttpPost]
        public ActionResult Edit(tblCategory c)
        {
            try
            {
                FlowerService.EditCategory(c);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex;
            }
            return RedirectToAction("Index");
        }

        #endregion

        #region delete category

        public ActionResult Delete(int id)
        {
            var query = FlowerService.GetCategoryById(id);
            FlowerService.DeleteCategory(query);
            return RedirectToAction("Index");
        }



        #endregion


    }
}