using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Abstract;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_PersonType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<Sys_Person> Persons { get; set; }
    }
}