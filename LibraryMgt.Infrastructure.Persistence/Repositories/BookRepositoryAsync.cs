using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibraryMgt.Application.DTOs;
using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Infrastructure.Persistence.Repositories
{
    public class BookRepositoryAsync : IBookRepository
    {
        private readonly ILibraryMgtDbContext _context;
        private readonly IMapper _mapper;

        public BookRepositoryAsync(ILibraryMgtDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Save(CancellationToken cancellationToken)
        {
            return (await _context.SaveChangesAsync(cancellationToken) > 0);
        }
        public async Task AddAsync(CreateBookDTO entity)
        {
            var BookObj = _mapper.Map<Book>(entity);
            await _context.Books.AddAsync(BookObj);


        }

        public bool DeleteById(string id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return false;


            _context.Books.Remove(book);
            return true;
        }

        public async Task<IEnumerable<BookDTO>> GetAllAsync()
        {
            var BookList = await _context.Books
                .AsNoTracking().ProjectTo<BookDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return BookList;


        }

        public async Task<BookDTO> GetAllByDesc(string desc)
        {
            if (desc == null) return null;

            var book = await _context.Books.FirstOrDefaultAsync(x => x.Description.Contains(desc));
            var BookMap = _mapper.Map<BookDTO>(book);

            return BookMap;


        }

        public async Task<BookDTO> GetByGenre(string category)
        {
            if (category == null) return null;

            var book = await _context.Books.FirstOrDefaultAsync(x => x.Genres == category);
            var BookMap = _mapper.Map<BookDTO>(book);
            return BookMap;



        }

        public async Task<BookDTO> GetByIdAsync(string id)
        {
            var BookObj = await _context.Books.FindAsync(id);
            if (BookObj == null) return null;


            var BookDto = _mapper.Map<BookDTO>(BookObj);

            return BookDto;
        }

        public async Task UpdateAsync(UpdateBookDTO entity)
        {
            var BookObj = _mapper.Map<Book>(entity);
            await _context.Books.AddAsync(BookObj);
        }

       
    }
}
