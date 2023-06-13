using IK.Application.DTOs;
using IK.Application.ViewModels;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IPersonLeaveService
    {
        Task<IEnumerable<personleaves>> GetAllAsync();
        void Add(Gnl_LeaveDto leave);
        Task<IEnumerable<personleaves>> GetById(int id);

    }
}
