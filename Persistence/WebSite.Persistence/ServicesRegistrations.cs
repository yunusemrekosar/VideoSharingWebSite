using Microsoft.Extensions.DependencyInjection;
using WebSite.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using WebSite.Persistence.Concretes.UserRepository;
using WebSite.Application.ITablesRepositories.IUserRepository;

namespace WebSite.Persistence
{
    public static class ServicesRegistrations
    {

        public static void AddPersistenceRegistrations(this IServiceCollection services)
        {
            

            services.AddDbContext<WebSiteDbContext>(options=> options.UseSqlServer(ConfigurationsMine.GetConnectionString), ServiceLifetime.Singleton);

            services.AddSingleton<IUserRead, UserRead>();
            services.AddSingleton<IUserWrite, UserWrite>();

        }
    }
}
