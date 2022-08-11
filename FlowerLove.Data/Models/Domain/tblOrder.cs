using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class tblOrder
    {
        [Key]

        public int OrderId { get; set; }
        public Nullable<int> ProID { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> InvoiceId { get; set; }

        public virtual tblProduct tblProduct { get; set; }
        public virtual tblInvoice tblInvoice { get; set; }
    }
}
