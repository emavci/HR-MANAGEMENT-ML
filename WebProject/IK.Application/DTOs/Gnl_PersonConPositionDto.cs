using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Gnl_PersonConPositionDto : IEntityDto
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysPositionID { get; set; }
        public Sys_Position SysPosition { get; set; }
    }
}
