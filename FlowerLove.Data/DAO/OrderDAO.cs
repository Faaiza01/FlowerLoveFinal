using FlowerLove.Data.IDAO;
using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.DAO
{
    public class OrderDAO : IOrderDAO
    {
        public void SaveOrder(FlowerLoveContext db, tblOrder tblOrder)
        {
            db.tblOrders.Add(tblOrder);
            db.SaveChanges();
        }

        public void SaveInvoices(FlowerLoveContext db, tblInvoice tblInvoice)
        {
            db.tblInvoices.Add(tblInvoice);
            db.SaveChanges();
        }

        public List<getallorder> GetAllOrders(FlowerLoveContext db)
        {
            return db.getallorders.ToList();
        }

        public getallorder GetOrderById(FlowerLoveContext db, int Id)
        {
            return db.getallorders.SingleOrDefault(m => m.InvoiceId == Id);

        }

        public void ConfirmOrder(FlowerLoveContext db, tblInvoice tblInvoice)
        {
            db.Entry(tblInvoice).State = EntityState.Modified;
            db.SaveChanges();
        }
        public List<getallorderuser> OrderDetail(FlowerLoveContext db, int id)
        {
            return db.getallorderusers.Where(m => m.UserId == id).ToList();
        }
        public List<tblUser> GetAllUsers(FlowerLoveContext db)
        {
            return db.tblUsers.ToList();
        }
        public List<user_invoices> Invoice(FlowerLoveContext db, int id)
        {
            return db.user_invoices.Where(m => m.InvoiceId == id).ToList();
        }
    }
}

