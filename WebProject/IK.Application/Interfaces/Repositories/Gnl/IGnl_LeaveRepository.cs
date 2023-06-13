using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Gnl
{
    public interface IGnl_LeaveRepository : IRepository<personleaves>
    {
        public IEnumerable<personleaves> GetAllAsync();
        public IEnumerable<personleaves> GetById(int id);


    }
}
