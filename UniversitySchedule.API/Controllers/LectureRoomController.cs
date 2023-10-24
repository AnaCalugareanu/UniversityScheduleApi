using Microsoft.AspNetCore.Mvc;
using UniversitySchedule.Application.Interfaces;

namespace UniversitySchedule.API.Controllers
{
    [Route("api/lecturerooms")]
    [ApiController]
    public class LectureRoomController : ControllerBase
    {
        private readonly ILectureRoomService service;

        public LectureRoomController(ILectureRoomService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetLectureRooms());
        }
    }
}