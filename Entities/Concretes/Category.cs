using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:Entity<Guid>
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        List<Course>Courses = new List<Course>();
    }
}
