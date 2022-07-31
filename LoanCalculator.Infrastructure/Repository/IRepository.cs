using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator.Infrastructure.Repository
{
    public interface IRepository<TEntity>
    {
        Task DeleteAsync(TEntity entityToDelete);

        Task DeleteAsync(object id);

        Task<IEnumerable<TEntity>> GetAync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", int? skip = null, int? take = null);

        Task<TEntity> GetByIdAsync(object id);

        Task<TEntity> InsertAsync(TEntity entity);

        Task InsertAsync(IEnumerable<TEntity> entity);

        Task<TEntity> UpdateAsync(TEntity entityToUpdate);

        Task SaveAsync();
    }
}
