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

    public class Sys_CompanyService : ISys_CompanyService
    {
        private readonly ISys_CompanyRepository _companyRepository;

        public Sys_CompanyService(ISys_CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Sys_Company>> GetAllAsync()
        {
            return _companyRepository.GetAllAsync();
        }
    }
}
