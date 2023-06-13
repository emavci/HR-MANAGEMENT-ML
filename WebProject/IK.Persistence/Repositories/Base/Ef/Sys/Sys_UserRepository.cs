using IK.Application.Repositories.Gnl;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Sys_UserRepository : EfRepository<Sys_User>, ISys_UserRepository
    {
        public Sys_UserRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<Sys_User> GetAllAsync()
        {
            return _context.Sys_Users.ToList();
        }
    }
}
