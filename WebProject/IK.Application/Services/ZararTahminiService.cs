using IK.Application.Interfaces.Repositories.Gnl;
using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class ZararTahminiService : IZararTahminiService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<zarartahmini> _repository;
        private readonly IZararTahminiRepository _zararRepository;

        public ZararTahminiService(IUnitOfWork unitOfWork, IRepository<zarartahmini> repository, IZararTahminiRepository zararRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _zararRepository = zararRepository;
        }

        public async Task<IEnumerable<zarartahmini>> GetAllAsync()
        {
            return _zararRepository.GetAllAsync();

        }


    }
}
