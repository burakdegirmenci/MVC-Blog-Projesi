using HS14MVC.Domain.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncFindableRepository<TEntity> where TEntity : BaseEntity
    {
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<TEntity?> GetByIdAsync(Guid id, bool tracking = true);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true);
    }   
}
