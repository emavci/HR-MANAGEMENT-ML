using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.InitData
{
    public class CurrentBaseInitData
    {
        public ICollection<Sys_PersonType> PersonType { get; set; }
        public ICollection<Sys_Company> Companies { get; set; }
        public ICollection<Sys_Position> Positions { get; set; }
        public ICollection<Sys_Social> Socials { get; set; }

    }
}
