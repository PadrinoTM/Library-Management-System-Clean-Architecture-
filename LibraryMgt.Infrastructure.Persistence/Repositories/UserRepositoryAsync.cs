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
    public class UserRepositoryAsync : IUserRepository
    {
        private readonly ILibraryMgtDbContext _context;
        private readonly IMapper _mapper;

        public UserRepositoryAsync(IMapper mapper, ILibraryMgtDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task AddAsync(CreateUserDTO entity)
        {
            var user = _mapper.Map<User>(entity);
            await _context.Users.AddAsync(user);

        }

        public bool DeleteById(string id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return false;


            _context.Books.Remove(book);
            return true;

        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var UserList = await _context.Users
                .AsNoTracking()
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return UserList;
        }

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            var UserDto = await _context.Users.FindAsync(id);
            if (UserDto == null) return null;


            var User = _mapper.Map<UserDTO>(UserDto);

            return User;

        }

        public Task<bool> Save(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(UpdateUserDTO entity)
        {
            var updateUser = _mapper.Map<Book>(entity);
            await _context.Books.AddAsync(updateUser);
        }
    }
}
