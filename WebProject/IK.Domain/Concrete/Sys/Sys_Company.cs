using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Company : BaseEntity
    {
        public bool Status { get; set; }
        public string RegNumber { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }

        // relations
        public virtual ICollection<Sys_PersonCard> PersonCards { get; set; }
        public virtual ICollection<Sys_Department> SysDepartments { get; set; }
        public virtual ICollection<Gnl_Inventory> Inventories { get; set; }
    }
}
