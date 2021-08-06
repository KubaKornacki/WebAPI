using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class TestController:Controller
    {
        [HttpGet("api/user")]
        public IActionResult get()
        {
            return Ok(new {name = "Jakub"});
        }
    }
}