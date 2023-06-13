using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Tahmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface ITotalTahminService
    {
        Task<IEnumerable<totaltahmin>> GetAllAsync();
    }

}
