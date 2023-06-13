using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_UserToken : BaseEntity
    {
        public int SysUserID { get; set; }
        public Sys_User SysUser { get; set; }
        public string UserSign { get; set; }
        public string UserToken { get; set; }
        public DateTime EndAt { get; set; }
    }
}