namespace ASP.NET_Core_Lect1.Models
{
    public enum Grade
    {
        A,B,C,D
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        // Navigation properties

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
