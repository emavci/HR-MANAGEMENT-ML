using IK.Application.Repositories.Sys;
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
    public class Sys_PersonCardRepository : EfRepository<Sys_PersonCard>, ISys_PersonCardRepository
    {
        public Sys_PersonCardRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<Sys_PersonCard> GetAllAsync()
        {
            //return _context.Sys_Persons.Where(x => x.Name == "burak").ToList();
            return _context.Sys_PersonCard.ToList();
        }
    }
}
