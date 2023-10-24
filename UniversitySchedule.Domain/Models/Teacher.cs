using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Domain.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Teacher Name is required")]
        [StringLength(50, ErrorMessage = "Teacher Name cannot be longer than 50 characters")]
        public string Name { get; set; }
    }
}