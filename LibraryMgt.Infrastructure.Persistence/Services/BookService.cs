using AutoMapper;
using LibraryMgt.Application.DTOs;
using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Application.Interfaces.Services;
using LibraryMgt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Infrastructure.Persistence.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepo, IMapper mapper)
        {
            _bookRepo = bookRepo;
            _mapper = mapper;
        }
        public GenericResponse<bool> AddAsync(CreateBookDTO entity)
        {
            var book = _bookRepo.AddAsync(entity);

            if (book == null)
                return new GenericResponse<bool>()
                {
                    Data = false,
                    Status = false,
                    Message = "Book Not Added"
                };

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "Book Added Succesfully "

            };

        }



        public GenericResponse<bool> DeleteByIdA(string id)
        {
            var book = _bookRepo.DeleteById(id);

            if (book == false)

                return new GenericResponse<bool>()
                {
                    Data = false,
                    Status = false,
                    Message = "Book deleted Successfully"
                };

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "Book Added Succesfully "

            };

        }



        public async Task<GenericResponse<IEnumerable<BookDTO>>> GetAllAsync()
        {
            var Allbooks = await _bookRepo.GetAllAsync();

            return new GenericResponse<IEnumerable<BookDTO>>()
            {
                Data = Allbooks,
                Status = true,
                Message = "All Books returned"
            };


        }

        public async Task<GenericResponse<BookDTO>> GetAllByDesc(string desc)
        {
            var book = await _bookRepo.GetAllByDesc(desc);
            /*var bookObj = _mapper.Map<BookDTO>(book);*/

            return new GenericResponse<BookDTO>()
            {
                Data = book,
                Status = true,
                Message = "All Books returned"
            };


        }

        public async Task<GenericResponse<BookDTO>> GetByGenre(string category)
        {
            var bookObj = await _bookRepo.GetByGenre(category);
            var newBook = _mapper.Map<BookDTO>(bookObj);

            return new GenericResponse<BookDTO>()
            {
                Data = newBook,
                Status = true,
                Message = "Loaded book successfully"
            };



        }

        public GenericResponse<BookDTO> GetByIdAsync(string id)
        {
            var bookObj = _bookRepo.GetByIdAsync(id);
            var book = _mapper.Map<BookDTO>(bookObj);

            return new GenericResponse<BookDTO>()
            {
                Data = book,
                Status = true,
                Message = "Book returned"

            };



        }

        public GenericResponse<bool> UpdateAsync(UpdateBookDTO entity)
        {
            var BookObj = _bookRepo.UpdateAsync(entity);

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "Field update successfully"
            };

        }








        /*   public Task<IQueryable<Book>> GetByGenre(string category)
           {
               throw new NotImplementedException();
           }

           public Task<IQueryable<Book>> GetByIdAsync(string id)
           {
               throw new NotImplementedException();
           }

           public Task UpdateAsync(Book entity)
           {
               throw new NotImplementedException();
           }*/
    }

}
