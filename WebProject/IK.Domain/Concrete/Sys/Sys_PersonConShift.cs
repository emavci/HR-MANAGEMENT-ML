using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_PersonConShift : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysShiftID { get; set; }
        public Sys_Shift SysShift { get; set; }
        public short TypeID { get; set; } //????
        public DateOnly TargetedAt { get; set; }
    }
}