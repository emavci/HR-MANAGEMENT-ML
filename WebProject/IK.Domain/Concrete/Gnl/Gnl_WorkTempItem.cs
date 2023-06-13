using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_WorkTempItem : BaseEntity
    {
        public int SysWorkTempID { get; set; }
        public Gnl_WorkTemp SysWorkTemp { get; set; }
        public int dayid { get; set; } // ???

        public short Status { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public ICollection<Sys_Feedback> SysFeedbacks { get; set; }
    }
}