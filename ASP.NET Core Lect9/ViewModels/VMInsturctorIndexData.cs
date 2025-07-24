using ASP.NET_Core_Lect1.Models;

namespace ASP.NET_Core_Lect1.ViewModels
{
    public class VMInsturctorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; } = new List<Instructor>();
        public IEnumerable<Course> Courses { get; set; } 
        public IEnumerable<Enrollment> Enrollments { get; set; } 
    }
}
