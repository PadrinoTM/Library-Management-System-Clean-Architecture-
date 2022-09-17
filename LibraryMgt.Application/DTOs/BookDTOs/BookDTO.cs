using LibraryMgt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.DTOs
{
    public class BookDTO : BaseEntity<string>
    {
        public string Genres { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
