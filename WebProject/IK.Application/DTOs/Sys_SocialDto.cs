using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Sys_SocialDto : BaseEntity
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int CTypeID { get; set; } //sor
        public int STypeID { get; set; } //sor
        public short Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}