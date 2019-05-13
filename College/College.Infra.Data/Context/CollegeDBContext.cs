using College.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Infra.Data
{
    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
