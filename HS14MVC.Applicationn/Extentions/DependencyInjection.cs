using HS14MVC.Applicationn.Services.AccountServices;
using HS14MVC.Applicationn.Services.ArticleServices;
using HS14MVC.Applicationn.Services.AuthorServices;
using HS14MVC.Applicationn.Services.MailServices;
using HS14MVC.Applicationn.Services.SubjectServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Applicationn.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IArticleService, ArticleService>();
           
            return services;
        }
    }
}
