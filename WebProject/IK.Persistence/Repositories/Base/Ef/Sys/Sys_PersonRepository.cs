using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Sys_PersonRepository : EfRepository<Sys_Person>, ISys_PersonRepository
    {
        public readonly DbSet<Sys_Person> _dbSet;
        public readonly IKContext _dbContext;
        public Sys_PersonRepository(IKContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Sys_Person>();
        }

        public IEnumerable<Sys_Person> GetAllAsync(int typeId)
        {
            return _context.Sys_Persons.Where(x => x.PersonTypeID == typeId).Include(x => x.PersonCard)
                .Include(x => x.PersonConDepartments)
                .ThenInclude(x => x.SysDepartment).Include(x => x.Zarartahmini)
                .Include(x => x.PersonConPositions)
                .ThenInclude(x => x.SysPosition).ToList();
        }
        public Sys_Person GetById(int id)
        {
            var data = _dbSet.Find(id);
            //var data1 = (TEntity)_dbContext.Entry(data).GetDatabaseValues().ToObject();
            //return data1;
            return _dbSet.Find(id);
        }

    }
}
