﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application
{
    public static class ServiceRegistration
    {
        public static void AddAplicationServices (this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));

        }
    }
}
