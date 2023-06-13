using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface ISys_PositionService
    {
        Task<IEnumerable<Sys_Position>> GetAllAsync();

    }
}
