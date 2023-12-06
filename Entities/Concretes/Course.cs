
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<Guid>
    {
        public string CourseId { get; set; }
        public string InstructorId { get; set; }
        public Instructor ? CourseInstructor { get; set; }
        public Category ? CourseCategory { get; set; }
        public string CategoryId { get; set; }      
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
    }
}
