using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_InvCategory : BaseEntity
    {
        public int ParentID { get; set; }
        //public Inventory Inventory { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public ICollection<Gnl_InventoryConCategory> InventoryConCategories { get; set; }
    }
}