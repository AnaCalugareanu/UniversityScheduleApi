using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Application.ViewModels;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Services
{
    public class LectureService : ILectureService
    {
        private readonly IUniversityScheduleDbContext context;

        public LectureService(IUniversityScheduleDbContext context)
        {
            this.context = context;
        }

        public List<LectureViewModel> GetLectures()
        {
            var lectures = context.Lectures.Include(x => x.Group).Include(x => x.LectureRoom).Include(x => x.Teacher);

            return ConvertLectureToLectureViewModel(lectures.ToList());
        }

        public List<LectureViewModel> GetLecturesByGroupId(int id)
        {
            var lectures = context.Lectures.Include(x => x.Group).Include(x => x.LectureRoom).Include(x => x.Teacher).Where(x => x.Group.GroupId == id);

            return ConvertLectureToLectureViewModel(lectures.ToList());
        }

        public List<LectureViewModel> GetLecturesByTeacherId(int id)
        {
            var lectures = context.Lectures.Include(x => x.Group).Include(x => x.LectureRoom).Include(x => x.Teacher).Where(x => x.Teacher.TeacherId == id);

            return ConvertLectureToLectureViewModel(lectures.ToList());
        }

        public List<LectureViewModel> GetLecturesByLectureRoomId(int id)
        {
            var lectures = context.Lectures.Include(x => x.Group).Include(x => x.LectureRoom).Include(x => x.Teacher).Where(x => x.LectureRoom.LectureRoomId == id);

            return ConvertLectureToLectureViewModel(lectures.ToList());
        }

        private List<LectureViewModel> ConvertLectureToLectureViewModel(List<Lecture> lecturesToConvert)
        {
            var lecturesToReturn = new List<LectureViewModel>();

            foreach (var lecture in lecturesToConvert)
            {
                lecturesToReturn.Add(new LectureViewModel
                {
                    LectureId = lecture.LectureId,
                    Name = lecture.Name,
                    TimePeriod = lecture.TimePeriod,
                    DayOfTheWeek = lecture.DayOfTheWeek,
                    IsEvenWeek = lecture.IsEvenWeek,
                    LectureRoom = lecture.LectureRoom?.LectureRoomNumber,
                    Teacher = lecture.Teacher?.Name,
                    Group = lecture.Group?.Name
                });
            }

            return lecturesToReturn;
        }
    }
}