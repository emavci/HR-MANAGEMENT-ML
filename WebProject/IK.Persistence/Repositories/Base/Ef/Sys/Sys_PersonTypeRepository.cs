using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using Microsoft.EntityFrameworkCore;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Sys_PersonTypeRepository : EfRepository<Sys_PersonType>, ISys_PersonTypeRepository
    {
        public readonly DbSet<Sys_PersonType> _dbSet;
        public readonly IKContext _dbContext;
        public Sys_PersonTypeRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Sys_PersonType>();
        }

        public IEnumerable<Sys_PersonType> GetAllAsync()
        {
            return _context.Sys_PersonTypes;       
                }
    }
}
