﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Domain.Common
{
    public class BaseEntity <T>
    {
        public T Id { get; set; }   
        public string Name { get; set; }
        
        

    }
}
