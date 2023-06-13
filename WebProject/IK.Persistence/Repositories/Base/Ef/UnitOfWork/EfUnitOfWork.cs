using IK.Application.Repositories;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Sys;
using IK.Domain.Abstract;
using IK.Persistence.Context;
using IK.Persistence.Repositories.Base.Ef.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Repositories.Base.Ef.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork 
                                                                       
    {
        private readonly IKContext _context;
        private IDictionary<Type, dynamic> _repositories;
            

        public EfUnitOfWork(IKContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, dynamic>();

        }

        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            var entityType = typeof(T);
            if (_repositories.ContainsKey(entityType))
            {
                return _repositories[entityType];
            }

            var repositoryType = typeof(EfRepository<>);
            //var repository = Activator.CreateInstance(repositoryType.MakeGenericType(new Type[] { typeof(T), typeof(TContext) } ), _context);
            var repository = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);

            _repositories.Add(entityType, repository);
            return (IRepository<T>)repository;
        }


        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

       
    }
}
