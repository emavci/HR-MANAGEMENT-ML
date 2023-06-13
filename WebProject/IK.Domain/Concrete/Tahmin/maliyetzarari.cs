using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Tahmin
{
    public class maliyetzarari
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public int Yil { get; set; }
        public int Durum { get; set; }
        public double GunlukUcret { get; set; }
        public double Zarar { get; set; }
        public int DevamsizGun { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
