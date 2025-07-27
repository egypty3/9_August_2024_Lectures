using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Lect1.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "موقع المكتب")]
        public string Location { get; set; }

        
        // Navigation property
        
        public Instructor? Instructor { get; set; }

    }
}
