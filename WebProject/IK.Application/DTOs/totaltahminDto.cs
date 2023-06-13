using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class totaltahminDto
    {
        public int Id { get; set; }
        public int Yil { get; set; }
        public double TotalTahmin { get; set; }
        public int CalisilmayanGunler { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
