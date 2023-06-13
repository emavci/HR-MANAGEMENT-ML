using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_FeedbackCategory : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int Typeid { get; set; }

        public int sysid { get; set; }

        public ICollection<Sys_Feedback> SysFeedbacks { get; set; }
    }
}