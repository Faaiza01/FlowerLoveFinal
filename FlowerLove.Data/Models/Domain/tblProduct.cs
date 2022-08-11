using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class tblProduct
    {
        public tblProduct()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }
        [Key]

        public int ProID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Unit { get; set; }
        public string Image { get; set; }
        public Nullable<int> CatId { get; set; }

        public virtual tblCategory tblCategory { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
