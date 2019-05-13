using College.Domain.Interfaces;
using College.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private CollegeDBContext _context;

        public CourseRepository (CollegeDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
