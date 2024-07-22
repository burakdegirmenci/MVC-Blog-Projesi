using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.AppContext;
using HS14MVC.Infrastructure.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.AuthorRepositories
{
    public class AuthorRepository : EFBaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Author?> GetByIdentityId(string identityId)
        {
            return _table.FirstOrDefaultAsync(a=>a.IdentityId==identityId);
        }
    }
}
