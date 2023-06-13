using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Feedback : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int FixerID { get; set; }

        public int CategoryID { get; set; }
        public Sys_FeedbackCategory SysFeedbackCategory { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string LFile { get; set; }
        public int Priority { get; set; }
        public ICollection<Sys_FeedbackTrans> SysFeedbackTrans { get; set; }
    }
}