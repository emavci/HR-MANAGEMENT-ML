using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;

namespace IK.Domain.Concrete.Tahmin
{
    public class personleaves : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysLeaveTypeID { get; set; }
        public Gnl_LeaveType SysLeaveType { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int Status { get; set; }
        public string LFile { get; set; }
        public string Note { get; set; }
        public int SyncID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}