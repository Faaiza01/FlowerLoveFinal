using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Models.Domain
{
    public class tblUser
    {
        public tblUser()
        {
            this.tblInvoices = new HashSet<tblInvoice>();
        }
        [Key]

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleType { get; set; }

        public virtual ICollection<tblInvoice> tblInvoices { get; set; }
    }
}
