using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using FlowerLove.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.IDAO
{
    public interface IOrderDAO
    {
        void SaveOrder(FlowerLoveContext db, tblOrder tblOrder);
        void SaveInvoices(FlowerLoveContext db, tblInvoice tblInvoice);
        List<getallorder> GetAllOrders(FlowerLoveContext db);
        getallorder GetOrderById(FlowerLoveContext db, int Id);
        void ConfirmOrder(FlowerLoveContext db, tblInvoice tblInvoice);
        List<getallorderuser> OrderDetail(FlowerLoveContext db, int id);
        List<tblUser> GetAllUsers(FlowerLoveContext db);
        List<user_invoices> Invoice(FlowerLoveContext db, int id);
    }
}
