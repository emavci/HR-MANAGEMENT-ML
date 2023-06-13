using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonConWorkTemp : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysWorkTempID { get; set; }
        public Gnl_WorkTemp SysWorkTemp { get; set; }
        public string YearSection { get; set; }
    }
}