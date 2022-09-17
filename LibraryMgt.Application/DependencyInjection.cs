using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
           //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
