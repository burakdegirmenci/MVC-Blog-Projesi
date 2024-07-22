using HS14MVC.Domain.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncInsertableRepository<TEntity> : IAsyncRepository where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
    }  
}
