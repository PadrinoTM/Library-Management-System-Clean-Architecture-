using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T, Y, Z> where T : class 
    {
        Task<IEnumerable <T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        bool DeleteById(string id); 
        Task AddAsync (Y entity);
        Task UpdateAsync (Z entity);
        Task<bool> Save(CancellationToken cancellationToken);


    }

  
   


}
