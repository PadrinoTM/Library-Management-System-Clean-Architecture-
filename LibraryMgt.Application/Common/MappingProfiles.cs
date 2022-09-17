using AutoMapper;
using LibraryMgt.Application.DTOs;
using LibraryMgt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Common
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();    
            CreateMap<Book, CreateBookDTO>().ReverseMap();
            CreateMap<Book, UpdateBookDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<User, UpdateUserDTO>().ReverseMap();
        }

    }
}
