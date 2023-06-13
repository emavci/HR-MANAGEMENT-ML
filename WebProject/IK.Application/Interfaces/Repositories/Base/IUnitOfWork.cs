using IK.Application.Repositories.Sys;
using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Repositories.Base
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        Task<int> CommitAsync();
        int Commit();
    }
}
