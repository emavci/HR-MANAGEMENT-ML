using IK.Application.Interfaces.Repositories.Gnl;
using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class TotalTahminService : ITotalTahminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<totaltahmin> _repository;
        private readonly ITotalTahminRepository _totalRepository;

        public TotalTahminService(IUnitOfWork unitOfWork, IRepository<totaltahmin> repository, ITotalTahminRepository totalRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _totalRepository = totalRepository;
        }

        public async Task<IEnumerable<totaltahmin>> GetAllAsync()
        {
            return _totalRepository.GetAllAsync();

        }


    }
}
