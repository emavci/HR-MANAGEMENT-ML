using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Shift : BaseEntity
    {
        public int SysDepartmentID { get; set; }
        public string Title { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public Sys_Department SysDepartment { get; set; }
        public ICollection<Gnl_PersonConShift> PersonConShifts { get; set; }
        public ICollection<Sys_PersonConShift> SysPersonConShifts { get; set; }
    }
}
