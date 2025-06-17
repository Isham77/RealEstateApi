using Microsoft.AspNetCore.Mvc;

namespace RealEstateApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("✅ Swagger and API working!");
    }
}
