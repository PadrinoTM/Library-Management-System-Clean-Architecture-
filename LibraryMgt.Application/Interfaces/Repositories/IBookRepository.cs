using LibraryMgt.Application.DTOs;
using LibraryMgt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Repositories
{
    public interface IBookRepository : IGenericRepository<BookDTO, CreateBookDTO, UpdateBookDTO>
    {
        Task<BookDTO> GetAllByDesc(string desc);
        Task<BookDTO> GetByGenre(string category);
    }
}
