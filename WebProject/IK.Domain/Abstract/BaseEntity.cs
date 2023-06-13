using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        //public bool Status { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //public int CreatedUserId { get; set; } = 1;
    }
}
