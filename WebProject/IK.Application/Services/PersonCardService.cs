using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class PersonCardService : IPersonCardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Sys_Person> _repository;
        private readonly ISys_PersonRepository _personRepository;
        private readonly ISys_PersonCardRepository _personCardRepository;
        public PersonCardService(IUnitOfWork unitOfWork, IRepository<Sys_Person> repository, ISys_PersonRepository personRepository, ISys_PersonCardRepository personCardRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _personRepository = personRepository;
            _personCardRepository = personCardRepository;
        }

        public void Add(Sys_PersonCard person,int personId)
        {
            // dönüşüm
            // automapper
            person.PersonID = personId;
            _unitOfWork.Repository<Sys_PersonCard>().Add(person);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Sys_PersonCard>> GetAllAsync()
        {
            return _personCardRepository.GetAllAsync();

        }
    }
}
