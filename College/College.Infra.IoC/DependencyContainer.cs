using College.Application.Interfaces;
using College.Application.Services;
using College.Domain.Interfaces;
using College.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Infra.IoC
{
    public class DependencyContainer 
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
