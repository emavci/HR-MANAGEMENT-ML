using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_User : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int? Utype { get; set; } = 0;
        public short Status { get; set; } = 1;
        public string Username { get; set; }
        public string Password { get; set; }
		public string? Note { get; set; }
        public ICollection<Sys_UserToken> SysUserTokens { get; set; }
    }
}