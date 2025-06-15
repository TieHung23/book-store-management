using Microsoft.AspNetCore.Mvc;

namespace bsm.Presentation
{
    [ApiController]
    [Route( "api/[controller]" )]
    public class TestPresentationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( "Hello from the Presentation layer!" );
        }
    }
}
