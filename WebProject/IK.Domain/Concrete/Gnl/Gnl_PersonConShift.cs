using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonConShift : BaseEntity
    {
        public int PersonID { get; set; }
        public int SysShiftID { get; set; }
        public DateOnly TargetedAt { get; set; }

        //
        public Sys_Person Person { get; set; }
        public Sys_Shift SysShift { get; set; }
    }
}
