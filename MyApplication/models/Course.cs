using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Instructor { get; set; }
    }
}