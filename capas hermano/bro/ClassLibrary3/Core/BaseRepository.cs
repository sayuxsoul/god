using School.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Core
{
    public class BaseRepository<T> where T : class
    {
        protected readonly SchoolContext _context;

        public BaseRepository(SchoolContext context)
        {
            _context = context;
        }
    }
}