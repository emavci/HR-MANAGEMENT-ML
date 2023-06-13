using IK.Application.Interfaces.Repositories.Gnl;
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

    public class ZararTahminiRepository : EfRepository<zarartahmini>, IZararTahminiRepository
    {
        public ZararTahminiRepository(IKContext context) : base(context)
        {
        }
        public IEnumerable<zarartahmini> GetAllAsync()
        {
            return _context.zarartahmini.ToList();
        }
    }
}
