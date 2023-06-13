using IK.Application.ViewModels;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IGnlLeaveTypeService
    {
        Task<IEnumerable<Gnl_LeaveType>> GetAllAsync();
        //void Add(PersonViewModel person);
        //Gnl_LeaveType GetById(int id);

    }
}
