using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class zarartahminiDto
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public int Yil { get; set; }
        public double TahminiZarar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
