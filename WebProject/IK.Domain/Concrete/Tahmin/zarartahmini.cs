using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Tahmin
{
    public class zarartahmini : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int Yil { get; set; }
        public double TahminiZarar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
