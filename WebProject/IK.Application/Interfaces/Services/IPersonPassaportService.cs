using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonPassaportService
    {
        Task<IEnumerable<Gnl_PersonPassaport>> GetAllAsync();
        void Add(Gnl_PersonPassaport passaport, int personId);
    }

}
