using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.TokenAbs;
using WebSite.Infrastructure.Services.TokenService;

namespace WebSite.Infrastructure
{
    public static class ServiceRegistations
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>(); 
        }
    }
}
