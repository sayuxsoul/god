using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Core;
using School.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class DepartmentRepository : BaseRepository<Deparment>, IDepartmentRepository
    {
        public DepartmentRepository(SchoolContext context) : base(context)
        {
        }

        public IEnumerable<Deparment> GetAll()
        {
            return _context.Departments.ToList();
        }

        public  Deparment GetById(int id)
        {
            return _context.Departments.Find(id);
        }
    }
}