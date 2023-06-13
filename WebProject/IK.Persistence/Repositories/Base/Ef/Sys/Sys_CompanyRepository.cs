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
    public class Sys_CompanyRepository : EfRepository<Sys_Company>, ISys_CompanyRepository
    {
        public readonly DbSet<Sys_Company> _dbSet;
        public readonly IKContext _dbContext;
        public Sys_CompanyRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Sys_Company>();
        }

        public IEnumerable<Sys_Company> GetAllAsync()
        {
            return _context.Sys_Companies;
        }
    }
}
