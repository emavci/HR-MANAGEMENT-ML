using IK.Application.DTOs;
using IK.Domain.Concrete.Gnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.ViewModels
{
    public class PersonViewModel
    {
        public Sys_PersonDto Personel { get; set; }
        public Sys_PersonCardDto PersonelCard { get; set; }
        public List<Gnl_PersonConPositionDto> PersonelPosition { get; set; }
        public List<Gnl_PersonConDepartment> PersonelDepartman { get; set; }
        public List<Sys_SocialDto> Sys_Socials { get; set; }
        public List<Sys_PersonTypeDto> PersonelType { get; set; }

        public Sys_UserDto User { get; set; }
        public Gnl_PersonPassaportDto PersonPassaport { get; set; }

    }
}
