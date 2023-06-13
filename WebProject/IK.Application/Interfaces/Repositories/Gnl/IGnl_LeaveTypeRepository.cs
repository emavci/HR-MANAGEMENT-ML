using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Gnl
{
    public interface IGnl_LeaveTypeRepository : IRepository<Gnl_LeaveType>
    {
        public IEnumerable<Gnl_LeaveType> GetAllAsync();

    }
}
