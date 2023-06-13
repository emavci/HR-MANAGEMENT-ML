using IK.Domain.Abstract;
using System.Linq.Expressions;

namespace IK.Application.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        void AddRange(IEnumerable<T> entities);
        Task AddRangeAsync(IEnumerable<T> entities);
        T Update(T entity);
        public void Remove(int id);
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, int pageSize = 20, int pageNumber = 0);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, int pageSize = 20, int pageNumber = 0);

    }
}
