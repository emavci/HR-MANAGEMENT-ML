using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IK.Application.DTOs
{
    public class Sys_PersonTypeDto : IEntityDto
    {
        public Sys_PersonTypeDto(Sys_PersonType personType)
        {
            Id = personType.Id;
            Title = personType.Title;
            LangKey = personType.LangKey;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<Sys_Person> Persons { get; set; }
    }
}
