using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Module : BaseEntity
    {
        public int ParentID { get; set; } //??
        public short Status { get; set; }
        public short IsMain { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderNo { get; set; }
        public string Vers { get; set; }
        public string LangKey { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public ICollection<Sys_ModuleMenu> SysModuleMenus { get; set; }
        public ICollection<Gnl_PersonConModule> PersonConModules { get; set; }
    }
}
