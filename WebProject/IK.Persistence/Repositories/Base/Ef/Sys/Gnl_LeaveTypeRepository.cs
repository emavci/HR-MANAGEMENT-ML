using IK.Application.Repositories.Gnl;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
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
    public class Gnl_LeaveTypeRepository : EfRepository<Gnl_LeaveType>, IGnl_LeaveTypeRepository
    {
        public readonly DbSet<Gnl_LeaveType> _dbSet;
        public readonly IKContext _dbContext;
        public Gnl_LeaveTypeRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Gnl_LeaveType>();
        }

        public IEnumerable<Gnl_LeaveType> GetAllAsync()
        {
            return _context.LeaveTypes;
        }
    }
}
