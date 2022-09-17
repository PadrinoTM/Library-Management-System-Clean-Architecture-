using LibraryMgt.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Repositories
{
    public interface ILibraryMgtDbContext
    {
        DbSet <User> Users { get; set; }
        DbSet<Book> Books { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
