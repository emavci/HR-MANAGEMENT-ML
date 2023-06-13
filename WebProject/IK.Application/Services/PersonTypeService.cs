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
    public class PersonTypeService : IPersonTypeService
    {
        private readonly ISys_PersonTypeRepository _personTypeRepository;

        public PersonTypeService(ISys_PersonTypeRepository personTypeRepository)
        {
            _personTypeRepository = personTypeRepository;
        }

        public async Task<IEnumerable<Sys_PersonType>> GetAllAsync()
        {
            return _personTypeRepository.GetAllAsync();
        }
    }
}
