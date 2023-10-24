using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Domain.Models
{
    public class Lecture
    {
        [Key]
        public int LectureId { get; set; }

        [Required(ErrorMessage = "Lecture Name is required")]
        [StringLength(50, ErrorMessage = "Lecture Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Time Period is required")]
        public int TimePeriod { get; set; }

        [Required(ErrorMessage = "Day of the week is required")]
        public DayOfTheWeek DayOfTheWeek { get; set; }

        public bool? IsEvenWeek { get; set; }
        public LectureRoom LectureRoom { get; set; }
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
    }
}