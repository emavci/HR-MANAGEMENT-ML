using IK.Application.Repositories.Sys;
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
    public class Sys_PositionRepository : EfRepository<Sys_Position>, ISys_PositionRepository
    {
        public readonly DbSet<Sys_Position> _dbSet;
        public readonly IKContext _dbContext;
        public Sys_PositionRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Sys_Position>();
        }


        public IEnumerable<Sys_Position> GetAllAsync()
        {
            return _context.Sys_Position;
        }
    }
}
