using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonConPositionService
    {
        Task<IEnumerable<Gnl_PersonConPosition>> GetAllAsync();
        void Add(Gnl_PersonConPosition position, int personId);
    }
}
