using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Lect1.Models
{
    //[Table("ElDawrat")]
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
