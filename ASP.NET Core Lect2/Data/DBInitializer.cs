﻿using ASP.NET_Core_Lect1.Models;
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
                new Student{ID=1,FirstMidName="Carson", LastName="Alexander", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{ID=2,FirstMidName="Meredith", LastName="Alonso", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{ID=3,FirstMidName="Arturo", LastName="Anand", EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{ID=4,FirstMidName="Gytis", LastName="Barzdukas", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{ID=5,FirstMidName="Yan", LastName="Li", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{ID=6,FirstMidName="Peggy", LastName="Justice", EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{ID=7,FirstMidName="Laura", LastName="Norman", EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{ID=8,FirstMidName="Nino", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2005-09-01")}
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
                new Course{CourseID=1050, Title="Chemistry", Credits=3},
                new Course{CourseID=4022, Title="Microeconomics", Credits=3},
                new Course{CourseID=4041, Title="Macroeconomics", Credits=3},
                new Course{CourseID=1045, Title="Calculus", Credits=4},
                new Course{CourseID=3141, Title="Trigonometry", Credits=4},
                new Course{CourseID=2021, Title="Composition", Credits=3},
                new Course{CourseID=2042, Title="Literature", Credits=4}

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
