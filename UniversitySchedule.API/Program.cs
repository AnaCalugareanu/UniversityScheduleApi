using Microsoft.OpenApi.Models;
using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Application.Services;
using UniversitySchedule.Persistance;

namespace UniversitySchedule.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            builder.Services.AddScoped<IUniversityScheduleDbContext, UniversityScheduleDbContext>();
            builder.Services.AddScoped<IGroupService, GroupService>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();
            builder.Services.AddScoped<ILectureRoomService, LectureRoomService>();
            builder.Services.AddScoped<ILectureService, LectureService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "University Schedule API");
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}