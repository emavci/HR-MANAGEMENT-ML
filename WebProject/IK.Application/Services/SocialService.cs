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
    public class SocialService : ISocialService
    {
        private readonly ISys_SocialRepository _socialRepository;

        public SocialService(ISys_SocialRepository socialRepository)
        {
            _socialRepository = socialRepository;
        }

        public async Task<IEnumerable<Sys_Social>> GetAllAsync()
        {
            return _socialRepository.GetAllAsync();
        }
    }
}
