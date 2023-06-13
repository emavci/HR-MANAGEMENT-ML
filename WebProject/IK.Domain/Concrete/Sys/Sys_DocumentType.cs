using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_DocumentType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int MyProperty { get; set; }
        public short TypeID { get; set; } //SOR
        public ICollection<Sys_Document> PersonDocuments { get; set; }
    }
}