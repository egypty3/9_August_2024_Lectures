using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Lect1.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        [Required]
        [Display(Name ="الاسم الاول")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        [Display(Name ="الاسم الاخير")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="تاريخ الالتحاق")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name ="الاسم")]
        public string FullName
        {
            get {
                return FirstMidName + ", " + LastName; 
            }
            
        }



        [Display(Name ="الاشتراكات")]
        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
