using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Services.IService;
using FlowerLove.Services.Service;
using Microsoft.AspNet.Identity;

namespace FlowerLove.Controllers
{
    public class HomeController : Controller
    {
        private IOrderService OrderService;
        private IFlowerService FlowerService;

        public HomeController()
        {

            OrderService = new OrderService();
            FlowerService = new FlowerService();
        }

        /* Add to Cart List use */
        List<Cart> li = new List<Cart>();

        #region home page in showing all products 

        public ActionResult Index()
        
        {

            if(Session["IsAuthenticated"] == "true")
            {
                Session["IsAuthenticated"] = "true";
            }
            else
                {
                Session["IsAuthenticated"] = "false";

            }

            if (TempData["cart"] != null)
            {
                int x = 0;

                List<Cart> li2 = TempData["cart"] as List<Cart>;
                foreach (var item in li2)
                {
                    x += item.bill;

                }
                TempData["total"] = x;
                TempData["item_count"] = li2.Count();
            }
            TempData.Keep();

            var query = FlowerService.GetAllProducts();
            return View(query);
        }

        #endregion

        #region add to cart

        public ActionResult AddtoCart(int id)
        {
            var query = FlowerService.GetProductById(id);
            return View(query);
        }

        [HttpPost]
        public ActionResult AddtoCart(int id, int qty)
        {
            tblProduct p = FlowerService.GetProductById(id);
            Cart c = new Cart();
            c.proid = id;
            c.proname = p.Name;
            c.price = Convert.ToInt32(p.Unit);
            c.qty = Convert.ToInt32(qty);
            c.bill = c.price * c.qty;
            if (TempData["cart"] == null)
            {
                li.Add(c);
                TempData["cart"] = li;
            }
            else
            {
                List<Cart> li2 = TempData["cart"] as List<Cart>;
                int flag = 0;
                foreach (var item in li2)
                {
                    if (item.proid == c.proid)
                    {
                        item.qty += c.qty;
                        item.bill += c.bill;
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    li2.Add(c);
                    //new item
                }
                TempData["cart"] = li2;

            }

            TempData.Keep();

            return RedirectToAction("Index");
        }

        #endregion

        #region remove cart item

        public ActionResult remove(int? id)
        {
            if (TempData["cart"] == null)
            {
                TempData.Remove("total");
                TempData.Remove("cart");
            }
            else
            {
                List<Cart> li2 = TempData["cart"] as List<Cart>;
                Cart c = li2.Where(x => x.proid == id).SingleOrDefault();
                li2.Remove(c);
                int s = 0;
                foreach (var item in li2)
                {
                    s += item.bill;
                }
                TempData["total"] = s;

            }

            return RedirectToAction("Index");
        }
        #endregion

        #region checkout code

        public ActionResult Checkout()
        {
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(string contact, string address)
        {
            if (ModelState.IsValid)
            {
                List<Cart> li2 = TempData["cart"] as List<Cart>;
                tblInvoice iv = new tblInvoice();
                iv.UserId = Convert.ToInt32(Session["uid"].ToString());
                iv.InvoiceDate = System.DateTime.Now;
                iv.Bill = (int)TempData["total"];
                iv.Payment = "Cash On Delivery";
                OrderService.SaveInvoices(iv);
                //order book
                foreach (var item in li2)
                {
                    tblOrder od = new tblOrder();
                    od.ProID = item.proid;
                    od.Contact = contact;
                    od.Address = address;
                    od.OrderDate = System.DateTime.Now;
                    od.InvoiceId = iv.InvoiceId;
                    od.Qty = item.qty;
                    od.Unit = item.price;
                    od.Total = item.bill;

                    OrderService.SaveOrder(od);

                }
                TempData.Remove("total");
                TempData.Remove("cart");
                // TempData["msg"] = "Order Book Successfully!!";
                return RedirectToAction("Index");
            }

            TempData.Keep();
            return View();
        }

        #endregion


        #region all orders for admin 

        public ActionResult GetAllOrderDetail()
        {
            var query = OrderService.GetAllOrders();
            return View(query);
        }

        #endregion

        #region  confirm order by admin

        public ActionResult ConfirmOrder(int InvoiceId)
        {
            var query = OrderService.GetOrderById(InvoiceId);
            return View(query);
        }

        [HttpPost]
        public ActionResult ConfirmOrder(getallorder o)
        {
            tblInvoice inv = new tblInvoice()
            {
                InvoiceId = o.InvoiceId,
                UserId = o.UserId,
                Bill = o.Bill,
                Payment = o.Payment,
                InvoiceDate = o.InvoiceDate,
                Status = 1,
            };

            OrderService.ConfirmOrder(inv);
            return View();

        }

        #endregion

        #region orders for only user

        public ActionResult OrderDetail(int id)
        {
            var query = OrderService.OrderDetail(id);
            return View(query);
        }

        #endregion


        #region  get all users 

        public ActionResult GetAllUser()
        {
            var query = OrderService.GetAllUsers();
            return View(query);
        }

        #endregion

        #region invoice for  user

        public ActionResult Invoice(int id)
        {
            var query = OrderService.Invoice(id);
            return View(query);
        }

        #endregion

    }
}