using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Interfaces
{
    public interface ILectureRoomService
    {
        List<LectureRoom> GetLectureRooms();
    }
}