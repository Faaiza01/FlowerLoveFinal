using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class tblInvoice
    {
        public tblInvoice()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }

        [Key]
        public int InvoiceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<byte> Status { get; set; }

        public virtual tblUser tblUser { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
