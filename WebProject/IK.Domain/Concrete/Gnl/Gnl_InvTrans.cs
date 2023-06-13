using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_InvTrans : BaseEntity
    {
        public int InventoryID { get; set; }
        public Gnl_Inventory Inventory { get; set; }
        public int FromID { get; set; }
        //public Inventory Inventory { get; set; }
        public int ToID { get; set; }
        //public Inventory Inventory { get; set; }
    }
}
