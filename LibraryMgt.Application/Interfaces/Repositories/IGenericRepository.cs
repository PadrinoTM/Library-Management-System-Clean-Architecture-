using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<IQueryable <T>> GetAllAsync();
        Task<IQueryable<T>> GetByIdAsync(string id);
        Task DeleteByIdAsync(string id); 
        Task AddAsync (T entity);
        Task UpdateAsync (T entity);


    }
    
    
}
