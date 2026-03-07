using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksV2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents() {
            string[] studentNames = new string[] { "John", "Jane", "Mark", "Emily", "David"};
            return Ok(studentNames);
        }
    }
}
