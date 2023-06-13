using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.DTOs
{
    public class Sys_UserDto : IEntityDto
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public int Utype { get; set; }
        public short Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Note { get; set; }

        public Sys_Person Person { get; set; }
        public ICollection<Sys_UserToken> SysUserTokens { get; set; }
    }
}
