using Microsoft.AspNetCore.Mvc;

namespace CowAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScanController : ControllerBase
    {
        // Endpoint that obtains 3 images and returns the result of the scan
        [HttpPost]
        public IActionResult Scan([FromForm] IFormFile[] images)
        {
            // generate random number
            Random random = new ();
            int randomNumber = random.Next(0, 2);

            string result = randomNumber % 2 == 0 ? "positive" : "negative";

            return Ok(result);
        }
    }
}
