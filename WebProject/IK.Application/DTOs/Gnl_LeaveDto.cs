using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Gnl_LeaveDto : IEntityDto
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysLeaveTypeID { get; set; }
        public Gnl_LeaveType SysLeaveType { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int Status { get; set; }
        public string LFile { get; set; }
        public string Note { get; set; }
        public int SyncID { get; set; }
        public int asd { get; set; }
        public FileInfo MyImage { set; get; }
    }
}
