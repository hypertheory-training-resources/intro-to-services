using Microsoft.AspNetCore.Mvc;

namespace TopicsApi.Controllers
{
    [Route("topics")]
    public class TopicsController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
