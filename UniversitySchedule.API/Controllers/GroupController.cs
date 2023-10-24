using Microsoft.AspNetCore.Mvc;
using UniversitySchedule.Application.Interfaces;

namespace UniversitySchedule.API.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService service;

        public GroupController(IGroupService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetGroups());
        }
    }
}