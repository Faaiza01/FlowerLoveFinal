using FlowerLove.Data.Models;
using FlowerLove.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Services.IService
{
    public interface IOrderService
    {
        void SaveOrder(tblOrder tblOrder);
        void SaveInvoices(tblInvoice tblInvoice);
        List<getallorder> GetAllOrders();
        getallorder GetOrderById(int invoiceId);
        void ConfirmOrder(tblInvoice tblInvoice);
        List<getallorderuser> OrderDetail(int id);
        List<tblUser> GetAllUsers();
        List<user_invoices> Invoice(int id);
    }
}
