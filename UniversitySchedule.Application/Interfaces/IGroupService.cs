using UniversitySchedule.Domain.Models;

namespace UniversitySchedule.Application.Interfaces
{
    public interface IGroupService
    {
        List<Group> GetGroups();
    }
}