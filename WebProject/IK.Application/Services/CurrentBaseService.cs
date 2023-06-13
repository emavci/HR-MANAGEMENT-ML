using AutoMapper;
using IK.Application.DTOs;
using IK.Application.InitData;
using IK.Application.Interfaces.Services;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class CurrentBaseService : ICurrentBaseService
    {
        private readonly IPersonTypeService _persontypeService;
        private readonly ISys_CompanyService _companyService;
        private readonly ISys_PositionService _positionService;
        private readonly ISocialService _socialService;
        private readonly IMapper _mapper;

        public CurrentBaseService(ISocialService socialService,IPersonTypeService persontypeService, IMapper mapper, ISys_CompanyService companyService, ISys_PositionService positionService)
        {
            _persontypeService = persontypeService;
            _companyService = companyService;
            _positionService = positionService;
            _socialService = socialService;
            _mapper = mapper;
        }

        public async Task<CurrentBaseInitData> Initialize()
        {
            ICollection<Sys_PersonType> tmpPersonType = new List<Sys_PersonType>();
            var initData = new CurrentBaseInitData
            {
                PersonType = (await _persontypeService.GetAllAsync()).ToList(),
                Companies = (await _companyService.GetAllAsync()).ToList(),
                Positions = (await _positionService.GetAllAsync()).ToList(),
                Socials = (await _socialService.GetAllAsync()).ToList(),

            };
            return initData;
        }
    }
}
