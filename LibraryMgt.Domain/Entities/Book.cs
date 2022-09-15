using LibraryMgt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Domain.Entities
{
    public class Book : BaseEntity <int> 
    {
        public List<string> Genres { get; set; } = new List<string>();   
        public string Description { get; set; }   
        public bool IsAvailable { get; set; }
        public int RemAmount { get; set; }
        public DateTime PostedOn  { get; set; }
        public string PostedBy { get; set; }    





    }
}
