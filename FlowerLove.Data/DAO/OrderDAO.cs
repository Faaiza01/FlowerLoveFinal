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
            var Invoices = db.tblInvoices.ToList();
            List<getallorder> getallorderusers = new List<getallorder>();
            foreach (var item in Invoices)
            {
                var userInfo = db.tblUsers.Where(x => x.UserId == item.UserId).FirstOrDefault();
                getallorder getallorderuser = new getallorder();
                getallorderuser.user = userInfo.Name;
                getallorderuser.Bill = item.Bill;
                getallorderuser.Payment = item.Payment;
                getallorderuser.InvoiceDate = item.InvoiceDate;
                getallorderuser.Status = item.Status;
                getallorderuser.InvoiceId = item.InvoiceId;

                getallorderusers.Add(getallorderuser);
            }

            return getallorderusers;
        }

        public getallorder GetOrderById(FlowerLoveContext db, int Id)
        {
            getallorder getallorderuser = new getallorder();
            var Invoices = db.tblInvoices.Where(d => d.InvoiceId == Id).SingleOrDefault();
            var userInfo = db.tblUsers.Where(x => x.UserId == Invoices.UserId).FirstOrDefault();

            getallorderuser.user = userInfo.Name;
            getallorderuser.Bill = Invoices.Bill;
            getallorderuser.Payment = Invoices.Payment;
            getallorderuser.InvoiceDate = Invoices.InvoiceDate;
            getallorderuser.Status = Invoices.Status;
            getallorderuser.InvoiceId = Invoices.InvoiceId;
            getallorderuser.UserId = userInfo.UserId;
            return getallorderuser;

        }

        public void ConfirmOrder(FlowerLoveContext db, tblInvoice tblInvoice)
        {
            db.Entry(tblInvoice).State = EntityState.Modified;
            db.SaveChanges();
        }
        public List<getallorderuser> OrderDetail(FlowerLoveContext db, int id)
        {
            var Invoice = db.tblInvoices.Where(x => x.UserId == id).ToList();
            var userInfo = db.tblUsers.Where(x => x.UserId == id).FirstOrDefault();
            List<getallorderuser> getallorderusers = new List<getallorderuser>();
            foreach (var item in Invoice)
            {
               getallorderuser getallorderuser = new getallorderuser();
               getallorderuser.user = userInfo.Name;
               getallorderuser.Bill = item.Bill;
               getallorderuser.Payment = item.Payment;
               getallorderuser.InvoiceDate = item.InvoiceDate;
               getallorderuser.Status = item.Status;
               getallorderusers.Add(getallorderuser);
            }

            return getallorderusers;
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

