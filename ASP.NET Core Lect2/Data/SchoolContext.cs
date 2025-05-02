using ASP.NET_Core_Lect1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Lect1.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().ToTable("ElDawrat");
            //modelBuilder.Entity<Student>().ToTable("ElTalba");
            //modelBuilder.Entity<Enrollment>().ToTable("ElEshtrakat");
        }

        // Dependency Injection
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {       
            
        }
    }
}
