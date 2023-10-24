using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Services
{
    public class LectureRoomService : ILectureRoomService
    {
        private readonly IUniversityScheduleDbContext context;

        public LectureRoomService(IUniversityScheduleDbContext context)
        {
            this.context = context;
        }

        public List<LectureRoom> GetLectureRooms()
        {
            var lectureRoom = context.LectureRooms;

            return lectureRoom.ToList();
        }
    }
}