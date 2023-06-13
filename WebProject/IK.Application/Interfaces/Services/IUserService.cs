using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<Sys_User>> GetAllAsync();
        void Add(Sys_User user, int personId);
    }

}
