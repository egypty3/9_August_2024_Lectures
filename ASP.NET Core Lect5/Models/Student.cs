using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Lect1.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name ="الاسم الاول")]
        public string FirstMidName { get; set; }
        [Display(Name ="الاسم الاخير")]
        public string LastName { get; set; }
        [Display(Name ="تاريخ الالتحاق")]
        public DateTime EnrollmentDate { get; set; }
        

       
        [Display(Name ="الاشتراكات")]
        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
