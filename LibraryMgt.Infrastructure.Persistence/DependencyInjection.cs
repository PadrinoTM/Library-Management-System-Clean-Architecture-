using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Application.Interfaces.Services;
using LibraryMgt.Infrastructure.Persistence.DbContexts;
using LibraryMgt.Infrastructure.Persistence.Repositories;
using LibraryMgt.Infrastructure.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, 
            IConfiguration config)
        {
            services.AddDbContext<LibraryMgtDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("LibraryMgtDb"),
                b => b.MigrationsAssembly(typeof(LibraryMgtDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<ILibraryMgtDbContext>(provider => provider.GetService<LibraryMgtDbContext>());
            services.AddScoped<IUserRepository, UserRepositoryAsync>();
            services.AddScoped<IBookRepository, BookRepositoryAsync>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IUserService, UserService>();    
            return services;    
        }





    }
}
