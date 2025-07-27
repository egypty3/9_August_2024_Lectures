using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Lect1.Models
{
    public enum Grade
    {
        A,B,C,D,E,F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "لا يوجد تقدير")]
        public Grade? Grade { get; set; }

        // Navigation properties

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
