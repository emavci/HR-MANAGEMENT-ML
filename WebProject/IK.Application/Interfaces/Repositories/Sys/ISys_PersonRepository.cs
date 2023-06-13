using IK.Application.Repositories.Base;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Sys
{
    public interface ISys_PersonRepository : IRepository<Sys_Person>
    {
        public IEnumerable<Sys_Person> GetAllAsync(int typeId);
        public Sys_Person GetById(int id);
    }
}
