using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Lect1.Models
{
    //[Table("ElDawrat")]
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="رقم الكورس")]
        public int CourseID { get; set; }
        [StringLength(50,MinimumLength =3)]
        public string Title { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }


        // Navigation properties
       
        public Department? Department { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
