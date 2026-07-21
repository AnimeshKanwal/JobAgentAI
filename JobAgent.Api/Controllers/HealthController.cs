using Microsoft.AspNetCore.Mvc;

namespace JobAgent.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "JobAgentAI is running",
            version = "1.0.0"
        });
    }
}