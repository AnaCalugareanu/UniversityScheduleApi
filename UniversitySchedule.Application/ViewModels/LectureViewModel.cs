using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.ViewModels
{
    public class LectureViewModel
    {
        public int LectureId { get; set; }

        public string Name { get; set; }

        public int TimePeriod { get; set; }

        public DayOfTheWeek DayOfTheWeek { get; set; }

        public bool? IsEvenWeek { get; set; }
        public string LectureRoom { get; set; }
        public string Teacher { get; set; }
        public string Group { get; set; }
    }
}