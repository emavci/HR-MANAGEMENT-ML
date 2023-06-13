using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Gnl;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class PersonLeaveTypeService : IGnlLeaveTypeService
    {
        private readonly IGnl_LeaveTypeRepository _leaveTypeRepository;

        public PersonLeaveTypeService(IGnl_LeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<IEnumerable<Gnl_LeaveType>> GetAllAsync()
        {
            return _leaveTypeRepository.GetAllAsync();
        }
    }
}
