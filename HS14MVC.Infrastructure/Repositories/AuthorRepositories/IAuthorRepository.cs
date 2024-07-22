using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.AuthorRepositories
{
    public interface IAuthorRepository : IAsyncRepository, IAsyncInsertableRepository<Author>, IAsyncFindableRepository<Author>, IAsyncQueryableRepository<Author>, IAsyncDeletableRepository<Author>, IAsyncUpdatableRepository<Author>
    {
        Task<Author?> GetByIdentityId(string identityId);
    }
}
