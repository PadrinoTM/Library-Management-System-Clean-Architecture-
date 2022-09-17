using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryMgt.Infrastructure.Persistence.DbContexts
{
    public class LibraryMgtDbContext : DbContext, ILibraryMgtDbContext
    {
        public LibraryMgtDbContext(DbContextOptions<LibraryMgtDbContext> options) :
            base(options) 
        {
        
        }
        public DbSet<Book>? Books { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("LibraryMgtDb",
                    builder => builder.EnableRetryOnFailure());
            }
    
                // optionsBuilder.EnableSensitiveDataLogging();
        }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              optionsBuilder.UseSqlServer(Configuration.GetConnectionString("connectionStringHere"));
              base.OnConfiguring(optionsBuilder);
          }*/

        /*   protected override void OnModelCreating(ModelBuilder builder)
           {
               builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

               base.OnModelCreating(builder);
           }*/
    }
}
