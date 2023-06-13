using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_WorkTemp : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; } // ??
        public short Status { get; set; }
        public ICollection<Sys_Department> SysDepartments { get; set; }
        public ICollection<Gnl_WorkTempItem> SysWorkTempItems { get; set; }
        public ICollection<Gnl_PersonConWorkTemp> PersonConWorkTemps { get; set; }
    }
}