using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonPepper : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public short PepperSys { get; set; }
        public string Type { get; set; }
        public string Lang { get; set; }
        public short Ccheck { get; set; } = 0;
        public short Scheck { get; set; } = 0;
        public short Vcheck { get; set; } = 0;
        public short Acheck { get; set; } = 0;
        public short IMcheck { get; set; } = 0;
        public short CMcheck { get; set; } = 0;
        public short VMcheck { get; set; } = 0;
        public short CHMcheck { get; set; } = 0;
        public short SMcheck { get; set; } = 0;
        public short IPcheck { get; set; } = 0;
        public short WDcheck { get; set; } = 0;
        public short LDProperty { get; set; } = 0;
        public short IMD { get; set; } = 0;
        public short CMD { get; set; } = 0;
        public short VMD { get; set; } = 0;
        public short CHMD { get; set; } = 0;
        public short SMD { get; set; } = 0;
        public string IP { get; set; }
        public string TermID { get; set; }
        public string WDDate { get; set; }
        public string LDDate { get; set; }
        public string Dashboard { get; set; }
        public string PGManager { get; set; }
        public string TLang { get; set; }
    }
}