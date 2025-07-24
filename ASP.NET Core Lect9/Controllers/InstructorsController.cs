using ASP.NET_Core_Lect1.Data;
using ASP.NET_Core_Lect1.Models;
using ASP.NET_Core_Lect1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Lect1.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly SchoolContext _context;
        public InstructorsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id, int? courseID)
        {
            var viewModel = new VMInsturctorIndexData();

            viewModel.Instructors = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                    .ThenInclude(c => c.Course)
                    .ThenInclude(i => i.Department)
                .OrderBy(i => i.FirstMidName)
                .ToListAsync();

            if (id != null)
            {
                ViewData["InstructorID"] = id.Value;
                Instructor instructor = viewModel.Instructors
                    .Where(i => i.ID == id.Value).Single();
                viewModel.Courses = instructor.CourseAssignments.Select(s => s.Course);
            }
            if (courseID != null)
            {
                ViewData["CourseID"] = courseID.Value;
                var selectedCourse = viewModel.Courses
                    .Where(x => x.CourseID == courseID).Single();
                await _context.Entry(selectedCourse)
                    .Collection(x => x.Enrollments)
                    .LoadAsync();
                foreach (Enrollment enrollment in selectedCourse.Enrollments)
                {
                    await _context.Entry(enrollment)
                        .Reference(x => x.Student)
                        .LoadAsync();
                }
                viewModel.Enrollments = selectedCourse.Enrollments;

            }
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        public IActionResult Create()
        {
            var instructor = new Instructor();
            instructor.CourseAssignments = new List<CourseAssignment>();
            PopulateAssignedCourseData(instructor);
            return View();
        }

        private void PopulateAssignedCourseData(Instructor instructor)
        {
            var allCourses = _context.Courses;
            var instructorCourses = new HashSet<int>(instructor.CourseAssignments.Select(c => c.CourseID));
            var viewModel = new List<VMAssignedCourseData>();
            foreach (var course in allCourses)
            {
                viewModel.Add(new VMAssignedCourseData
                {
                    CourseID = course.CourseID,
                    Title = course.Title,
                    Assigned = instructorCourses.Contains(course.CourseID)
                });
            }
            ViewBag.Courses = viewModel;
        }
    }
}
