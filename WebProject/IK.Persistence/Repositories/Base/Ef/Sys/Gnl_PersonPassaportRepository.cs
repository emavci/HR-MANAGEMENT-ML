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

    public class Gnl_PersonPassaportRepository : EfRepository<Gnl_PersonPassaport>, IGnl_PersonPassaportRepository
    {
        public Gnl_PersonPassaportRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<Gnl_PersonPassaport> GetAllAsync()
        {
            return _context.Gnl_PersonPassaports.ToList();
        }
    }
}
