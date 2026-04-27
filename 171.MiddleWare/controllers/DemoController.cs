using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace YourProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult AdminData()
        {
            return Ok("Only Admin can access");
        }

        [HttpGet("user")]
        [Authorize(Roles = "User")]
        public IActionResult UserData()
        {
            return Ok("Only User can access");
        }
    }
}