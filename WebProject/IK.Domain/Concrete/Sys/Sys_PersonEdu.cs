using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_PersonEdu : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysEduTypeID { get; set; }
        public Gnl_EduType SysEduType { get; set; }
        public string InstitutionName { get; set; }
        public string SectionName { get; set; }
        public string LFile { get; set; }
        public int EndYear { get; set; }
    }
}