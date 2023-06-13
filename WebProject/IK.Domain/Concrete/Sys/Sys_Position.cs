using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Position : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int? SyncID { get; set; }
        public int? ParentID { get; set; }//sor
        public ICollection<Gnl_PersonConPosition> PersonConPositions { get; set; }
    }
}