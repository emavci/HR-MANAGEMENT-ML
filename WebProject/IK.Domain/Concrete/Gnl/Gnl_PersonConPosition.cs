using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonConPosition : BaseEntity
    {
        public int PersonId { get; set; }
        public int SysPositionID { get; set; }
        public bool Status { get; set; }

        public Sys_Person Person { get; set; }
        public Sys_Position SysPosition { get; set; }
    }
}