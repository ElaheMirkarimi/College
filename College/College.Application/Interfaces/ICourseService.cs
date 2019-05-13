using College.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
