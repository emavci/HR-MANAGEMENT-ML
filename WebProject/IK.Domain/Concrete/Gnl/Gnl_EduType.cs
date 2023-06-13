using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_EduType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<Sys_PersonEdu> PersonEdus { get; set; }
    }
}