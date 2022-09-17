using LibraryMgt.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Services
{
    public interface IGenericService<T, Y, Z> where T : class
    {
        Task<GenericResponse<IEnumerable<T>>> GetAllAsync();
        GenericResponse<T> GetByIdAsync(string id);
        GenericResponse<bool> DeleteByIdA(string id);
        GenericResponse<bool> AddAsync(Y entity);
        GenericResponse<bool> UpdateAsync(Z entity);
    }

    
 
    
    
}
