
using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(18, 120)]
        public int Age { get; set; }
    }
}