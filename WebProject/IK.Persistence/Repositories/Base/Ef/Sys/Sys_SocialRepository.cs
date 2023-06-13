using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using Microsoft.EntityFrameworkCore;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Sys_SocialRepository : EfRepository<Sys_Social>, ISys_SocialRepository
    {
        public readonly DbSet<Sys_Social> _dbSet;
        public readonly IKContext _dbContext;
        public Sys_SocialRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Sys_Social>();
        }

        public IEnumerable<Sys_Social> GetAllAsync()
        {
            return _context.sys_Socials;       
                }
    }
}
