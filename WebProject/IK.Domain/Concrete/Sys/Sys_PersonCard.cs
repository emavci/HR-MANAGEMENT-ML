using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_PersonCard : BaseEntity
    {
        public int PersonID { get; set; }
        public int SysCompanyID { get; set; }
        public int? Gender { get; set; }
        public int? MilitaryStatus { get; set; }
        public int? MaritalStatus { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? Body { get; set; }
        public int? FootNumber { get; set; }
        public string? DriverLicense { get; set; }
        public string? BirthPlace { get; set; }
        public bool Status { get; set; }
        public DateOnly? BirthDate { get; set; }
        public int? ID_No { get; set; }
        public string? Serial_No { get; set; }
        public string? Nationality { get; set; }
        public string? MothersName { get; set; }
        public string? FathersName { get; set; }
        public string? LFile { get; set; }
        public DateTime? EnteredAt { get; set; }
        public DateTime? ExitedAt { get; set; }


        // relations
        public Sys_Person Person { get; set; }
        public Sys_Company SysCompany { get; set; }

    }
}
