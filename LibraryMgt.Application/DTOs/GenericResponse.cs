using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt.Application.DTOs
{
    public class GenericResponse <T>
    {
        public T Data { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
