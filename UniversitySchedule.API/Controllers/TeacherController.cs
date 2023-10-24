using Microsoft.AspNetCore.Mvc;
using UniversitySchedule.Application.Interfaces;

namespace UniversitySchedule.API.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService service;

        public TeacherController(ITeacherService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetTeachers());
        }
    }
}