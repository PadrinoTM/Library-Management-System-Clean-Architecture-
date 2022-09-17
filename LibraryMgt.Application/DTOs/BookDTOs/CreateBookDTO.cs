using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.DTOs
{
    public class CreateBookDTO
    {
        public string Name { get; set; }   
        public string Genres { get; set; } 
        public string Description { get; set; }
        public bool IsAvailable { get; set; } = true;
        public DateTime PostedOn { get; set; } = DateTime.Now;  
        public string PostedBy { get; set; } 

    }
}
