using IK.Domain.Abstract;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_LeaveType : BaseEntity
    {
        public short IsPaid { get; set; }
        public short IsDamaged { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public ICollection<personleaves> PersonLeaves { get; set; }
    }
}