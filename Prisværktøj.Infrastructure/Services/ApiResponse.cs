using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisværktøj.Infrastructure.Services
{
    public class ApiResponse<T>
    {

        //public List<T> Data { get; set; }
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
