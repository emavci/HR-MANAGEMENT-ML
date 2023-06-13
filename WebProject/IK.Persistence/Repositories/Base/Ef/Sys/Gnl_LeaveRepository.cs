using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Gnl_LeaveRepository : EfRepository<personleaves>, IGnl_LeaveRepository
    {
        public Gnl_LeaveRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<personleaves> GetAllAsync()
        {
            return _context.personleaves.ToList();

        }
        public IEnumerable<personleaves> GetById(int id)
        {
            return _context.personleaves.Where(x => x.PersonID == id).Include(x => x.SysLeaveType);
        }
    }
}
