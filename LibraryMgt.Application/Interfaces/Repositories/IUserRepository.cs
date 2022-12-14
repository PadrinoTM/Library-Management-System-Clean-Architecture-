using LibraryMgt.Application.DTOs;
using LibraryMgt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Repositories
{
    public interface IUserRepository: IGenericRepository<UserDTO, CreateUserDTO, UpdateUserDTO>
    {


    }
}
