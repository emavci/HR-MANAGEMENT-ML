using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Gnl;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class PersonConPositionService : IPersonConPositionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Gnl_PersonConPosition> _repository;
        private readonly IGnl_PersonConPositionRepository _personRepository;
        public PersonConPositionService(IUnitOfWork unitOfWork, IRepository<Gnl_PersonConPosition> repository, IGnl_PersonConPositionRepository personRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _personRepository = personRepository;
        }

        public void Add(Gnl_PersonConPosition person, int personId)
        {
            // dönüşüm
            // automapper
            person.PersonId = personId;
            _unitOfWork.Repository<Gnl_PersonConPosition>().Add(person);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Gnl_PersonConPosition>> GetAllAsync()
        {
            return _personRepository.GetAllAsync();

        }
    }

}
