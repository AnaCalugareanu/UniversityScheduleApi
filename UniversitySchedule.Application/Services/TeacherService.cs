using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IUniversityScheduleDbContext context;

        public TeacherService(IUniversityScheduleDbContext context)
        {
            this.context = context;
        }

        public List<Teacher> GetTeachers()
        {
            var teacher = context.Teachers;

            return teacher.ToList();
        }
    }
}