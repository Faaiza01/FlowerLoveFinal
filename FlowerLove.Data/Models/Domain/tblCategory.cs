using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class tblCategory
    {
        public tblCategory()
        {
            this.tblProducts = new HashSet<tblProduct>();
        }

        [Key]
        public int CatId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
