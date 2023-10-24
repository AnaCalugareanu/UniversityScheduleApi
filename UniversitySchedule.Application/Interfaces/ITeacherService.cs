using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Interfaces
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();
    }
}