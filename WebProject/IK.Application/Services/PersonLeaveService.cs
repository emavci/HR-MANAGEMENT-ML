using AutoMapper;
using IK.Application.DTOs;
using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class PersonLeaveService : IPersonLeaveService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<personleaves> _repository;
        private readonly IGnl_LeaveRepository _leaveRepository;

        public PersonLeaveService(IUnitOfWork unitOfWork, IMapper mapper, IRepository<personleaves> repository, IGnl_LeaveRepository leaveRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
            _leaveRepository = leaveRepository;
        }

        public void Add(Gnl_LeaveDto leave)
        {
            var data = _mapper.Map<Gnl_LeaveDto, personleaves>(leave);
            _unitOfWork.Repository<personleaves>().Add(data);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<personleaves>> GetAllAsync()
        {
            return _leaveRepository.GetAllAsync();
        }


        public async Task<IEnumerable<personleaves>> GetById(int id)
        {
            return _leaveRepository.GetById(id);
        }
    }
}
