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
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath = System.IO.Path.Join(path, "blogging.db");
            Console.WriteLine(dbPath);
            // connect to sqlite database
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}