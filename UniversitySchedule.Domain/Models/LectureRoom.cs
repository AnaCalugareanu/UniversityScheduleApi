using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Domain.Models
{
    public class LectureRoom
    {
        [Key]
        public int LectureRoomId { get; set; }

        [Required(ErrorMessage = "Lecture Room Number is required")]
        [StringLength(5, ErrorMessage = "Lecture Room Number cannot be longer than 5 characters")]
        [RegularExpression(@"\d-\d\d\d", ErrorMessage = "Example of format: 3-104")]
        public string LectureRoomNumber { get; set; }
    }
}