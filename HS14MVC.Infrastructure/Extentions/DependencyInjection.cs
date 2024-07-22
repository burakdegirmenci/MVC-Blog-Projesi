using HS14MVC.Infrastructure.AppContext;
using HS14MVC.Infrastructure.Repositories.ArticleRepositories;
using HS14MVC.Infrastructure.Repositories.AuthorRepositories;
using HS14MVC.Infrastructure.Repositories.SubjectRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Infrastructure.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(configuration.GetConnectionString(AppDbContext.DevConnectionString));
            });

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();

            return services;
        }
    }
}
