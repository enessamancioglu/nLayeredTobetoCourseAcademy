namespace Entities.Concretes
{
    public class Instructor:Entity<Guid>
    {
        List<Course> Courses = new List<Course>();
        public string InstructorId { get; set; }
        public string InstructorName { get; set; }
      
    }
}