using IK.Application.DTOs;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.ViewModels
{
    public class TahminViewModel
    {
        public ICollection<zarartahmini> zarartahmini { get; set; }
        public totaltahminDto totaltahmin { get; set; }
    }
}
