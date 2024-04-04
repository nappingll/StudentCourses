using System.ComponentModel.DataAnnotations;
namespace Student_WEBAPI.Models
{
    public class StudentCourses
    {
        [Key]
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Students Student { get; set; }
        public Courses Course { get; set; }
    }
}
