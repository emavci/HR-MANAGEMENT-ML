using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Sys
{
    public interface ISys_PositionRepository : IRepository<Sys_Position>
    {
        public IEnumerable<Sys_Position> GetAllAsync();

    }
}
