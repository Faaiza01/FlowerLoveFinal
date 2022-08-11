using FlowerLove.Data.DAO;
using FlowerLove.Data.IDAO;
using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using FlowerLove.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Services.Service
{
    public class OrderService : IOrderService
    {
        IOrderDAO orderDAO;
        public OrderService()
        {
            orderDAO = new OrderDAO();
        }

        public void SaveOrder(tblOrder tblOrder)
        {
            using (var db = new FlowerLoveContext())
            {
                orderDAO.SaveOrder(db, tblOrder);
            }
        }

        public void SaveInvoices(tblInvoice tblInvoice)
        {
            using (var db = new FlowerLoveContext())
            {
                orderDAO.SaveInvoices(db, tblInvoice);
            }
        }
        public List<getallorder> GetAllOrders()
        {
            using (var db = new FlowerLoveContext())
            {
                return orderDAO.GetAllOrders(db);
            }
        }
        public getallorder GetOrderById(int invoiceId)
        {
            using (var db = new FlowerLoveContext())
            {
                return orderDAO.GetOrderById(db, invoiceId);
            }
        }

        public void ConfirmOrder(tblInvoice tblInvoice)
        {
            using (var db = new FlowerLoveContext())
            {
                orderDAO.ConfirmOrder(db, tblInvoice);
            }
        }
        public List<getallorderuser> OrderDetail(int id)
        {
            using (var db = new FlowerLoveContext())
            {
                return orderDAO.OrderDetail(db, id);
            }
        }
        public List<tblUser> GetAllUsers()
        {
            using (var db = new FlowerLoveContext())
            {
                return orderDAO.GetAllUsers(db);
            }
        }

        public List<user_invoices> Invoice(int id)
        {
            using (var db = new FlowerLoveContext())
            {
                return orderDAO.Invoice(db, id);
            }
        }


    }
}
