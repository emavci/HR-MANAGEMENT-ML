using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Gnl_PersonPassaportDto : IEntityDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string country { get; set; }
        public string nation { get; set; }
        public DateTime startAt { get; set; }
        public DateTime endAt { get; set; }

        public Sys_Person Person { get; set; }
    }
}
