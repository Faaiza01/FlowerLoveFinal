using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class getallorderuser
    {
        [Key]

        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public string user { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<byte> Status { get; set; }
    }
}
