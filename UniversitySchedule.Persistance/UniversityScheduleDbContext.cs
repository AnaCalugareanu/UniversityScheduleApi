using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Persistance
{
    public class UniversityScheduleDbContext : DbContext, IUniversityScheduleDbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<LectureRoom> LectureRooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            var dbPath = Path.Join(path, "blogging.db");
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}