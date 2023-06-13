using AutoMapper;
using IK.Application.DTOs;
using IK.Application.InitData;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Profiles
{

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Sys_PersonDto, Sys_Person>();
            CreateMap<Sys_Person, Sys_PersonDto>()
            .ForMember(d => d.PersonConPositions, o => o.MapFrom(s => string.Join("-", s.PersonConPositions.Select(x => x.SysPosition.Title))))
            .ForMember(d => d.PersonConDepartments, o => o.MapFrom(s => string.Join("-", s.PersonConDepartments.Select(x => x.SysDepartment.Title))))
            .ForMember(d => d.Zarartahmini, o => o.MapFrom(s => string.Join("-", s.Zarartahmini.Select(x => x.TahminiZarar))))
            .ForMember(d => d.enteredAt, o => o.MapFrom(s => s.PersonCard.EnteredAt))
            .ForMember(d => d.exitedAt, o => o.MapFrom(s => s.PersonCard.ExitedAt));



            CreateMap<Sys_PersonCardDto, Sys_PersonCard>();
            CreateMap<Sys_PersonCard, Sys_PersonCardDto>();

            CreateMap<Gnl_PersonConPositionDto, Gnl_PersonConPosition>();
            CreateMap<Gnl_PersonConPosition, Gnl_PersonConPositionDto>();

            CreateMap<Gnl_PersonPassaportDto, Gnl_PersonPassaport>();
            CreateMap<Gnl_PersonPassaport, Gnl_PersonPassaportDto>();

            CreateMap<Sys_UserDto, Sys_User>();
            CreateMap<Sys_User, Sys_UserDto>();
            CreateMap<CurrentBaseInitData, CurrentBaseInitDataDto>();
            CreateMap<personleaves, Gnl_LeaveDto>();
            CreateMap<Gnl_LeaveDto, personleaves>();
            CreateMap<Gnl_LeaveType, Gnl_LeaveTypeDto>();
            CreateMap<Gnl_LeaveTypeDto, Gnl_LeaveType>();
            CreateMap<Sys_SocialDto, Sys_Social>();
            CreateMap<Sys_Social, Sys_SocialDto>();
            
            CreateMap<zarartahmini, zarartahminiDto>();
            CreateMap<totaltahmin, totaltahminDto>();

        }
    }
}
