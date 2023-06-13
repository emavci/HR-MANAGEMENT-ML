using IK.Application.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Interfaces.Services
{
    public interface IBusinessService<TEntity> where TEntity : class
    {
        Task<IDataResult<TEntity>> GetByIdAsync(int id);
        IDataResult<TEntity> GetById(int id);
        Task<IDataResult<List<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);
        //
        IDataResult<List<TEntity>> GetAllWithDetail(Expression<Func<TEntity, object>> predicate);
        IDataResult<List<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        IResult Add(TEntity entity);
        IResult Remove(int id);
        IResult Update(TEntity entity);
    }
}
