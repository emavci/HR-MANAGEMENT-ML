using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_FeedbackTrans : BaseEntity
    {
        public int SysFeedbackID { get; set; }
        public Sys_Feedback SysFeedback { get; set; }
        public short Status { get; set; }
        public string Note { get; set; }
    }
}
