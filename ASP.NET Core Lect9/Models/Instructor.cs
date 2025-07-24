using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Lect1.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "الاسم الاول")]
        [StringLength(50)]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "الاسم الاخير")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "تاريخ التعيين")]
        public DateTime HireDate { get; set; }
        public string FullName => $"{FirstMidName} {LastName}";

        // Navigation properties
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }

    }
}
