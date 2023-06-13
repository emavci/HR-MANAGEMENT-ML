using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_Inventory : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysCompanyID { get; set; }
        public Sys_Company SysCompany { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string SpecialCode { get; set; }
        public ICollection<Gnl_InvTrans> InvTranses { get; set; }
        public ICollection<Gnl_InventoryConCategory> InventoryConCategories { get; set; }
    }
}