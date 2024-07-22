using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.ArticleRepositories
{
    public interface IArticleRepository: IAsyncRepository, IAsyncInsertableRepository<Article>, IAsyncFindableRepository<Article>, IAsyncQueryableRepository<Article>, IAsyncDeletableRepository<Article>, IAsyncUpdatableRepository<Article>,IAsyncOrderableRepository<Article>
    {
    }
}
