using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Document : BaseEntity
    {
        public int TypeID { get; set; }
        public Sys_DocumentType SysDocumentType { get; set; }
        public int PersonID { get; set; }//SOR PERSON MU RefID
        public Sys_Person Person { get; set; }
        public string LFile { get; set; }//sor
    }
}