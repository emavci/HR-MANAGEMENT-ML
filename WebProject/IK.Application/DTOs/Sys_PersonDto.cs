using IK.Application.DTOs.Abstract;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;

namespace IK.Application.DTOs
{
    public class Sys_PersonDto : IEntityDto
    {
        public Sys_PersonDto()
        {

        }
        public Sys_PersonDto(Sys_Person person)
        {
            Id = person.Id;
            PersonTypeID = person.PersonTypeID;
            Name = person.Name;
            PersonCard = person.PersonCard;
            //PersonConPositions = person.PersonConPositions;
            //PersonConDepartments = person.PersonConDepartments;

            Status = 1;
            PersonFingerID = 1;
            SyncID = 1;
        }
        public int Id { get; set; }
        public int PersonTypeID { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }
        public int SyncID { get; set; }
        public int PersonFingerID { get; set; }

        //Relations
        public Sys_PersonCard PersonCard { get; set; }
        public Gnl_PersonPassaport PersonPassaport { get; set; }
        public string PersonConPositions { get; set; }
        public string PersonConDepartments { get; set; }
        public Sys_PersonType PersonType { get; set; }
        public string Zarartahmini { get; set; }
        public string enteredAt { get; set; }
        public string exitedAt { get; set; }

    }
}
