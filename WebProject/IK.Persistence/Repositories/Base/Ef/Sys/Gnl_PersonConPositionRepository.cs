using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Gnl;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class Gnl_PersonConPositionRepository : EfRepository<Gnl_PersonConPosition>, IGnl_PersonConPositionRepository
    {
        public Gnl_PersonConPositionRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<Gnl_PersonConPosition> GetAllAsync()
        {
            return _context.Gnl_PersonConPositions.ToList();
        }
    }
}
