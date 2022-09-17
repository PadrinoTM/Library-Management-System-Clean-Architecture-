using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.DTOs
{
    public class UpdateUserDTO
    {
        public string Name { get; set; }

        public string UserName { get; set; }    
        public string Email { get; set; }
        public bool HasBorrowed { get; set; } = false;
        public string Address { get; set; }

    }
}
