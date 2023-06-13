using IK.Application.Utilities.Results;
using IK.Application.ViewModels;
using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Sys_Person>> GetAllAsync(int typeId);
        void Add(PersonViewModel person);
        Sys_Person GetById(int id);
        void Update(PersonViewModel person);

    }

}
