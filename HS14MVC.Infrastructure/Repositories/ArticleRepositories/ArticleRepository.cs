using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.AppContext;
using HS14MVC.Infrastructure.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.ArticleRepositories
{
    public class ArticleRepository: EFBaseRepository<Article>,IArticleRepository
    {
        public ArticleRepository(AppDbContext context): base(context)
        {
                
        }
    }
}
