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
    public class PersonPassaportService : IPersonPassaportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Gnl_PersonPassaport> _repository;
        private readonly IGnl_PersonPassaportRepository _personRepository;
        public PersonPassaportService(IUnitOfWork unitOfWork, IRepository<Gnl_PersonPassaport> repository, IGnl_PersonPassaportRepository personRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _personRepository = personRepository;
        }

        public void Add(Gnl_PersonPassaport person, int personId)
        {
            // dönüşüm
            // automapper
            person.PersonId = personId;
            _unitOfWork.Repository<Gnl_PersonPassaport>().Add(person);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Gnl_PersonPassaport>> GetAllAsync()
        {
            return _personRepository.GetAllAsync();

        }
    }

}
