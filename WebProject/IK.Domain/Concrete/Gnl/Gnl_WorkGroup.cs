using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_WorkGroup : BaseEntity
    {
        public int ParentID { get; set; } // ??
        public string Title { get; set; }
        public string Code { get; set; }
        public ICollection<Gnl_PersonConWorkGroup> PersonConWorkGroups { get; set; }
    }
}