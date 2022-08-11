using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class user_invoices
    {
        [Key]

        public int InvoiceId { get; set; }
        public string Customer { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
    }
}
