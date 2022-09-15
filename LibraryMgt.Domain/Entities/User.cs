﻿using LibraryMgt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Domain.Entities
{
    public class User: BaseEntity<Guid>
    {
        public string UserName;
        public string Email { get; set; }
        public bool HasBorrowed { get; set; }    
        public string Address { get; set; } 





    }
}
