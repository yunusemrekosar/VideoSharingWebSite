using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.StorageAbs;
using WebSite.Application.Abstractions.TokenAbs;
using WebSite.Infrastructure.Services.Storage;
using WebSite.Infrastructure.Services.TokenService;

namespace WebSite.Infrastructure
{
    public static class ServiceRegistations
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddScoped<IStorageService, StorageService>();
        }

        public static void AddStorage<T> (this IServiceCollection services) where T: class, IStorage
        {
            services.AddScoped<IStorage, T>(); 
        }
    }
}
