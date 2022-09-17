using LibraryMgt.Application.DTOs;
using LibraryMgt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Services
{
    public interface IBookService : IGenericService<BookDTO, CreateBookDTO, UpdateBookDTO>
    {
        Task<GenericResponse<BookDTO>> GetAllByDesc(string desc);
        Task<GenericResponse<BookDTO>> GetByGenre(string category);
    }
}
