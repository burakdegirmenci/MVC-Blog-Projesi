using AspNetCoreHero.ToastNotification;
using HS14MVC.Infrastructure.AppContext;
using Microsoft.AspNetCore.Identity;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace HS14MVC.UI.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUIServices(this IServiceCollection services)
        {

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            services.AddNotyf(config =>
            {
                config.HasRippleEffect = true;
                config.DurationInSeconds = 5;
                config.Position = NotyfPosition.BottomRight;

            });
            services.AddLocalization(opt => opt.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supCultures = new List<CultureInfo>() 
                { 

                    new CultureInfo("tr"), new CultureInfo("en")  
                
                };
                opt.DefaultRequestCulture = new RequestCulture("tr");
                opt.SupportedUICultures = supCultures;
            }
            );


            return services;
        }
    }
}
