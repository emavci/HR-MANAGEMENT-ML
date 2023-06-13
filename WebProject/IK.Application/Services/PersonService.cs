using AutoMapper;
using IK.Application.DTOs;
using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Sys;
using IK.Application.Utilities.Results;
using IK.Application.ViewModels;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<Sys_Person> _repository;
        private readonly ISys_PersonRepository _personRepository;
        private readonly ISys_PersonCardRepository _personCardRepository;

        private readonly IPersonCardService _personCardService;
        private readonly IPersonPassaportService _personPassaportService;
        private readonly IPersonConPositionService _personConPositionService;
        private readonly IUserService _userService;

        public PersonService(IUnitOfWork unitOfWork, IRepository<Sys_Person> repository, ISys_PersonRepository personRepository, ISys_PersonCardRepository personCardRepository, IMapper mapper,
            IPersonCardService personCardService, IPersonPassaportService personPassaportService, IPersonConPositionService personConPositionService, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
            _personRepository = personRepository;
            _personCardRepository = personCardRepository;
            _personCardService = personCardService;
            _personPassaportService = personPassaportService;
            _personConPositionService = personConPositionService;
            _userService = userService;
        }

        public void Add(PersonViewModel person)
        {
            var personData = _mapper.Map<Sys_PersonDto, Sys_Person>(person.Personel);
            personData.Status = 1;
            _unitOfWork.Repository<Sys_Person>().Add(personData);
            _unitOfWork.Commit();

            var cardData = _mapper.Map<Sys_PersonCardDto, Sys_PersonCard>(person.PersonelCard);
            cardData.Status = true;
            _personCardService.Add(cardData, personData.Id);

            var positionData = _mapper.Map<Gnl_PersonConPositionDto, Gnl_PersonConPosition>(person.PersonelPosition[0]);
            positionData.Status = true;
            _personConPositionService.Add(positionData, personData.Id);
            
            var passaportData = _mapper.Map<Gnl_PersonPassaportDto, Gnl_PersonPassaport>(person.PersonPassaport);
            passaportData.Status = true;
            _personPassaportService.Add(passaportData, personData.Id);
           
            var userData = _mapper.Map<Sys_UserDto, Sys_User>(person.User);
            userData.Status = 1;
            _userService.Add(userData, personData.Id);

        }


        public async Task<IEnumerable<Sys_Person>> GetAllAsync(int typeId)
        {
            return _personRepository.GetAllAsync(typeId);

        }

        public Sys_Person GetById(int id)
        {
            return _personRepository.GetById(id);
        }

        public void Update(PersonViewModel person)
        {
            var personData = _mapper.Map<Sys_PersonDto, Sys_Person>(person.Personel);
            personData.Status = 1;
            _unitOfWork.Repository<Sys_Person>().Update(personData);
            _unitOfWork.Commit();

            var cardData = _mapper.Map<Sys_PersonCardDto, Sys_PersonCard>(person.PersonelCard);
            cardData.Status = true;
            _unitOfWork.Repository<Sys_PersonCard>().Update(cardData);

            var positionData = _mapper.Map<Gnl_PersonConPositionDto, Gnl_PersonConPosition>(person.PersonelPosition[0]);
            positionData.Status = true;
            _unitOfWork.Repository<Gnl_PersonConPosition>().Update(positionData);
            var passaportData = _mapper.Map<Gnl_PersonPassaportDto, Gnl_PersonPassaport>(person.PersonPassaport);
            passaportData.Status = true;
            _unitOfWork.Repository<Gnl_PersonPassaport>().Update(passaportData);
            var userData = _mapper.Map<Sys_UserDto, Sys_User>(person.User);
            userData.Status = 1;
            _unitOfWork.Repository<Sys_User>().Update(userData);
        }
    }
}
