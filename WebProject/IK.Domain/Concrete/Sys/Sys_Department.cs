using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Department : BaseEntity
    {
        public int SysCompanyID { get; set; }
        public Sys_Company SysCompany { get; set; }
        public int SysWorkTempID { get; set; }
        //public SysWorkTemp SysWorkTemp { get; set; }
        public int ParentID { get; set; }
        public int SuperVisorID { get; set; }

        public string Title { get; set; }
        public string LangKey { get; set; }
        public short Status { get; set; }
        public int SyncID { get; set; }

        public ICollection<Sys_Shift> SysShifts { get; set; }
        public ICollection<Gnl_PersonConDepartment> PersonConDepartments { get; set; }
        public ICollection<Gnl_PersonConRollcallDepartment> PersonConRollcallDepartments { get; set; }
    }
}