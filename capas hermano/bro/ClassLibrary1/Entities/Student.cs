using School.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entities
{
    public class Student: BaseEntity
    {
        public DateTime EnrollelmentDate { get; set; }
    }
}
