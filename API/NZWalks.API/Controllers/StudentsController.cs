using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //localhost:portnumber/api/students
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudentDetails()
        {
            string[] studentdetails = new string[] { "hemanth", "vinay", "nithin" };
            return Ok(studentdetails);
        }
    }
}
