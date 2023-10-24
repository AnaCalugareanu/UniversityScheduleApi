using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Interfaces
{
    public interface IUniversityScheduleDbContext
    {
        DbSet<Group> Groups { get; set; }
        DbSet<Lecture> Lectures { get; set; }
        DbSet<LectureRoom> LectureRooms { get; set; }
        DbSet<Teacher> Teachers { get; set; }
    }
}