using College.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
