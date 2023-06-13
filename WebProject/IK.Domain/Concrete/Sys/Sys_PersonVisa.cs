using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Abstract;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_PersonVisa : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysVisaTypeID { get; set; }
        public Sys_VisaType SysVisaType { get; set; }
        public string Title { get; set; }
        public short Status { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public int SyncID { get; set; }
    }
}
