using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_DemandType : BaseEntity
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<Sys_Demand> SysDemands { get; set; }
    }
}