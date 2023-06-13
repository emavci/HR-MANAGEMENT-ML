using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Social : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int CTypeID { get; set; } //sor
        public int STypeID { get; set; } //sor
        public short Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}