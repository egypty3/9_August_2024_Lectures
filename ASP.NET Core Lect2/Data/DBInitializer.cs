using ASP.NET_Core_Lect1.Models;
namespace ASP.NET_Core_Lect1.Data
{
    public class DBInitializer
    {
        public static void Initialize(SchoolContext context)
        {
           context.Database.EnsureCreated();
           
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            var students = new Student[]
            {
                // property initialization
                new Student{FirstMidName="Carson", LastName="Alexander", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith", LastName="Alonso", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo", LastName="Anand", EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis", LastName="Barzdukas", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan", LastName="Li", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy", LastName="Justice", EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura", LastName="Norman", EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            //for (int i = 0; i < students.Length; i++)
            //{
            //    context.Students.Add(students[i]);
            //}

            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{Title="Chemistry", Credits=3},
                new Course{Title="Microeconomics", Credits=3},
                new Course{Title="Macroeconomics", Credits=3},
                new Course{Title="Calculus", Credits=4},
                new Course{Title="Trigonometry", Credits=4},
                new Course{Title="Composition", Credits=3},
                new Course{Title="Literature", Credits=4}
            };

            foreach (Course course in courses)
            {
                context.Courses.Add(course);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1, CourseID=1050, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=4022, Grade=Grade.C},
                new Enrollment{StudentID=1, CourseID=4041, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=1045, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=3141, Grade=Grade.F},
                new Enrollment{StudentID=3, CourseID=1050},
                new Enrollment{StudentID=4, CourseID=1050},
                new Enrollment{StudentID=4, CourseID=4022, Grade=Grade.F},
                new Enrollment{StudentID=5, CourseID=4041, Grade=Grade.C},
                new Enrollment{StudentID=6, CourseID=1045},
                new Enrollment{StudentID=7, CourseID=3141, Grade=Grade.A}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }


    }
}
