using Microsoft.AspNetCore.Mvc;
using UniversitySchedule.Application.Interfaces;

namespace UniversitySchedule.API.Controllers
{
    [Route("api/lectures")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService service;

        public LectureController(ILectureService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetLectures());
        }

        [HttpGet("group/{id}")]
        public IActionResult GetByGroupId(int id)
        {
            return Ok(service.GetLecturesByGroupId(id));
        }

        [HttpGet("teacher/{id}")]
        public IActionResult GetByTeacherId(int id)
        {
            return Ok(service.GetLecturesByTeacherId(id));
        }

        [HttpGet("lectureroom/{id}")]
        public IActionResult GetByLectureRoomId(int id)
        {
            return Ok(service.GetLecturesByLectureRoomId(id));
        }
    }
}