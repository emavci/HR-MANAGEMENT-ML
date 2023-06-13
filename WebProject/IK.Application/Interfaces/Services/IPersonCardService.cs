using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonCardService
    {
        Task<IEnumerable<Sys_PersonCard>> GetAllAsync();
        void Add(Sys_PersonCard personCard, int personId);
    }
}
