using HS14MVC.Domain.Entities;
using HS14MVC.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Repositories.SubjectRepositories
{
    public interface ISubjectRepository: IAsyncRepository, IAsyncInsertableRepository<Subject>, IAsyncFindableRepository<Subject>, IAsyncQueryableRepository<Subject>, IAsyncDeletableRepository<Subject>, IAsyncUpdatableRepository<Subject>
    {
    }
}
