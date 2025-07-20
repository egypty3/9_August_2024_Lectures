using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Lect1.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]
        [Display(Name = "الاسم")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        [Display(Name = "ميزانية")]
        [DataType(DataType.Currency)]
        [Column(TypeName ="money")]
        public decimal Budget { get; set; }
        [Display(Name = "تاريخ البدء")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Display(Name = "رئيس القسم")]
        public int? AdministratorID { get; set; }

        // Navigation properties
        public ICollection<Course> Courses { get; set; }

        // For display purposes

    }
}
