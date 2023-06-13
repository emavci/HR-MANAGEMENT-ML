using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonTypeService
    {
        Task<IEnumerable<Sys_PersonType>> GetAllAsync();
    }
}
