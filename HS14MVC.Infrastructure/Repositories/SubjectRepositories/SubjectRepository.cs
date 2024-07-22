using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.AppContext;
using HS14MVC.Infrastructure.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.SubjectRepositories
{
    public class SubjectRepository : EFBaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context) : base(context)
        {
        }
    }
}
