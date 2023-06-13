using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonPassaport : BaseEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? type { get; set; }
        public string? code { get; set; }
        public string? country { get; set; }
        public string? nation { get; set; }
        public bool Status { get; set; }
        public DateTime? startAt { get; set; }
        public DateTime? endAt { get; set; }
        public DateTime? updatedAt { get; set; }=DateTime.UtcNow;

        public Sys_Person Person { get; set; }

    }
}
