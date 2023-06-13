using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Rollcall : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int Status { get; set; }
        public DateOnly CheckedAt { get; set; }

        // rollcall stsatus ile baglanti???
    }
}
