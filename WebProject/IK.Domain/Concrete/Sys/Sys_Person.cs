using IK.Domain.Abstract;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Sys
{
    public class Sys_Person : BaseEntity
    {
        public int PersonTypeID { get; set; }
        public int? PersonFingerID { get; set; }
        //public PersonFinger? PersonFinger { get; set; }
        public string? Name { get; set; }
        public short Status { get; set; } = 1;
        public int? SyncID { get; set; }

        public Sys_PersonType PersonType { get; set; }
        public Gnl_PersonPassaport PersonPassaport { get; set; }
        public Sys_User SysUser { get; set; }
        public Sys_PersonCard PersonCard { get; set; }
        public ICollection<Sys_PersonVisa> PersonVisas { get; set; }
        public ICollection<Sys_Address> PersonAddresses { get; set; }
        public ICollection<Sys_PersonFinger> PersonFingers { get; set; }
        public ICollection<Sys_PersonEdu> PersonEdus { get; set; }
        public ICollection<Sys_Social> PersonSocials { get; set; }
        public ICollection<Sys_Document> PersonDocuments { get; set; }
        public ICollection<personleaves> PersonLeaves { get; set; }
        public ICollection<Gnl_Inventory> Inventories { get; set; }
        public ICollection<Sys_Demand> SysDemands { get; set; }
        public ICollection<Sys_Rollcall> SysRollcalls { get; set; }
        public ICollection<Gnl_PersonPepper> PersonPeppers { get; set; }
        public ICollection<Gnl_PersonConPerM> PersonConPerMs { get; set; }
        public ICollection<Gnl_PersonConModule> PersonConModules { get; set; }
        public ICollection<Gnl_PersonConModuleMenu> PersonConModuleMenus { get; set; }
        public ICollection<Gnl_PersonConShift> PersonConShifts { get; set; }
        public ICollection<Sys_PersonConShift> SysPersonConShifts { get; set; }
        public ICollection<Gnl_PersonConWorkGroup> PersonConWorkGroups { get; set; }
        public ICollection<Gnl_PersonConWorkTemp> PersonConWorkTemps { get; set; }
        public ICollection<Gnl_PersonConDashboard>  PersonConDashboards { get; set; }
        public ICollection<Gnl_PersonConPosition> PersonConPositions { get; set; }
        //public ICollection<Sys_Position> Positions { get; set; }
        public ICollection<Gnl_PersonConRollcallDepartment> PersonConRollcallDepartments { get; set; }
        public ICollection<Gnl_PersonConDepartment> PersonConDepartments { get; set; }
        public ICollection<maliyetzarari> Maliyetzarari { get; set; }
        public ICollection<zarartahmini> Zarartahmini { get; set; }
    }
}