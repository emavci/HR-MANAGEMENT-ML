using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_InventoryConCategory : BaseEntity
    {
        public int InventoryID { get; set; }
        public Gnl_Inventory Inventory { get; set; }
        public int InvCategoryID { get; set; }
        public Gnl_InvCategory InvCategory { get; set; }
    }
}