using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Gnl
{
    public interface IGnl_PersonConPositionRepository : IRepository<Gnl_PersonConPosition>
    {
        public IEnumerable<Gnl_PersonConPosition> GetAllAsync();
    }
}
