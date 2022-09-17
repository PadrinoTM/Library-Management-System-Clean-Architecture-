using AutoMapper;
using LibraryMgt.Application.DTOs;
using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Infrastructure.Persistence.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public GenericResponse<bool> AddAsync(CreateUserDTO entity)
        {
            var user = _userRepo.AddAsync(entity);

            if (user == null)
                return new GenericResponse<bool>()
                {
                    Data = false,
                    Status = false,
                    Message = "User Not Added"
                };

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "User Added Succesfully "

            };

        }



        public GenericResponse<bool> DeleteByIdA(string id)
        {
            var book = _userRepo.DeleteById(id);

            if (book == false)

                return new GenericResponse<bool>()
                {
                    Data = false,
                    Status = false,
                    Message = "User deleted Successfully"
                };

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "user Added Succesfully "

            };

        }



        public async Task<GenericResponse<IEnumerable<UserDTO>>> GetAllAsync()
        {
            var AllUsers = await _userRepo.GetAllAsync();

            return new GenericResponse<IEnumerable<UserDTO>>()
            {
                Data = AllUsers,
                Status = true,
                Message = "All Userd returned"
            };


        }

       

        public GenericResponse<UserDTO> GetByIdAsync(string id)
        {
            var userObj = _userRepo.GetByIdAsync(id);
            var user = _mapper.Map<UserDTO>(userObj);

            return new GenericResponse<UserDTO>()
            {
                Data = user,
                Status = true,
                Message = "User returned"

            };



        }

        public GenericResponse<bool> UpdateAsync(UpdateUserDTO entity)
        {
            var BookObj = _userRepo.UpdateAsync(entity);

            return new GenericResponse<bool>()
            {
                Data = true,
                Status = true,
                Message = "Field updated successfully"
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

    

