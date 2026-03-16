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
    namespace School.Infrastructure.Repositories
    {
        public class CourseRepository : BaseRepository<Course>, ICourseRepository
        {
            public CourseRepository(SchoolContext context) : base(context)
            {
            }

            public IEnumerable<Course> GetAll()
            {
                return _context.Courses.ToList();
            }

            public Course GetById(int id)
            {
                return _context.Courses.Find(id);
            }
        }
    }
}