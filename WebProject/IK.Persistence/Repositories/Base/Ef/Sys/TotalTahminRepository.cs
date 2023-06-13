using IK.Application.Interfaces.Repositories.Gnl;
using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Tahmin;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.Sys
{
    public class TotalTahminRepository : EfRepository<totaltahmin>, ITotalTahminRepository
    {
        public TotalTahminRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<totaltahmin> GetAllAsync()
        {
            return _context.totaltahmin.ToList();
        }
    }

}
