using UniversitySchedule.Application.Interfaces;
using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUniversityScheduleDbContext context;

        public GroupService(IUniversityScheduleDbContext context)
        {
            this.context = context;
        }

        public List<Group> GetGroups()
        {
            var groups = context.Groups;

            return groups.ToList();
        }
    }
}