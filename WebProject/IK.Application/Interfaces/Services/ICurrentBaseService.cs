using IK.Application.InitData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface ICurrentBaseService
    {
        Task<CurrentBaseInitData> Initialize();

    }
}
