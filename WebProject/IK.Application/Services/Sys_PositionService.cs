using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class Sys_PositionService : ISys_PositionService
    {
        private readonly ISys_PositionRepository _positionRepository;

        public Sys_PositionService(ISys_PositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task<IEnumerable<Sys_Position>> GetAllAsync()
        {
            return _positionRepository.GetAllAsync();
        }

    }
}
