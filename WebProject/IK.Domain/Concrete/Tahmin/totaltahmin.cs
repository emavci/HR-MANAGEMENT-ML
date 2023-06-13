using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Tahmin
{
    public class totaltahmin : BaseEntity
    {
        public int Yil { get; set; }
        public double TotalTahmin { get; set; }
        public int CalisilmayanGunler { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
