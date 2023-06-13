using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Gnl_LeaveTypeDto : IEntityDto
    {
        public Gnl_LeaveTypeDto(Gnl_LeaveType leave)
        {
            Id = leave.Id;
            IsPaid = leave.IsPaid;
            IsDamaged = leave.IsDamaged;
            Status = leave.Status;
            Title = leave.Title;
            LangKey = leave.LangKey;
            SyncID = leave.SyncID;
        }

        public int Id { get; set; }
        public short IsPaid { get; set; }
        public short IsDamaged { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
    }
}
