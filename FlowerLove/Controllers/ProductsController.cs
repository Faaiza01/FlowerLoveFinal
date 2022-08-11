using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using FlowerLove.Data.Models;
using FlowerLove.Services.IService;
using FlowerLove.Services.Service;
using FlowerLove.Data.Models.Domain;

namespace FlowerLove.Controllers
{
    public class ProductsController : Controller
    {
        private IFlowerService FlowerService;
        public ProductsController()
        {
            FlowerService = new FlowerService();
        }

        #region showing all products for admin 

        public ActionResult Index()
        {
            var query = FlowerService.GetAllProducts();
            return View(query);
        }

        #endregion


        #region products add for admin

        public ActionResult Create()
        {
            List<tblCategory> list = FlowerService.GetAllCategories();
            ViewBag.CatList = new SelectList(list, "CatId", "Name");
            return View();
        }



        [HttpPost]
        public ActionResult Create(tblProduct p, HttpPostedFileBase Image)
        {
            List<tblCategory> list = FlowerService.GetAllCategories();
            ViewBag.CatList = new SelectList(list, "CatId", "Name");

            if (ModelState.IsValid)
            {
                tblProduct pro = new tblProduct();
                pro.Name = p.Name;
                pro.Description = p.Description;
                pro.Unit = p.Unit;
                pro.Image = Image.FileName.ToString();
                pro.CatId = p.CatId;

                //image upload
                var folder = Server.MapPath("~/Uploads/");
                Image.SaveAs(Path.Combine(folder, Image.FileName.ToString()));

                FlowerService.AddProduct(pro);

                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["msg"] = "Product Not Upload";
            }
            return View();
        }


        #endregion


        #region edit products

        public ActionResult Edit(int id)
        {

            List<tblCategory> list = FlowerService.GetAllCategories();
            ViewBag.CatList = new SelectList(list, "CatId", "Name");
            var query = FlowerService.GetProductById(id);
            return View(query);
        }


        [HttpPost]
        public ActionResult Edit(tblProduct p, HttpPostedFileBase Image)
        {
            List<tblCategory> list = FlowerService.GetAllCategories();
            ViewBag.CatList = new SelectList(list, "CatId", "Name");

            try
            {

                p.Image = Image.FileName.ToString();
                var folder = Server.MapPath("~/Uploads/");
                Image.SaveAs(Path.Combine(folder, Image.FileName.ToString()));
                FlowerService.EditProduct(p);

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex;
            }

            return RedirectToAction("Index");

        }

        #endregion


        #region delete product 

        public ActionResult Delete(int id)
        {
            var query = FlowerService.GetProductById(id);
            FlowerService.DeleteProduct(query);
            return RedirectToAction("Index");
        }

        #endregion

    }
}