using Microsoft.EntityFrameworkCore;
using Student_WEBAPI.Models;
using System;

namespace Student_WEBAPI.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
