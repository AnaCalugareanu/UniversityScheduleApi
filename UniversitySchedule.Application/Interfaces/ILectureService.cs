using UniversitySchedule.Application.ViewModels;

namespace UniversitySchedule.Application.Interfaces
{
    public interface ILectureService
    {
        List<LectureViewModel> GetLectures();

        List<LectureViewModel> GetLecturesByGroupId(int id);

        List<LectureViewModel> GetLecturesByTeacherId(int id);

        List<LectureViewModel> GetLecturesByLectureRoomId(int id);
    }
}