using Microsoft.AspNetCore.Mvc;

namespace DiscordBot.Api.Controllers;


[ApiController]
[Route("api")]
public class HomeController : ControllerBase
{
    public IActionResult Get() => Ok("Hello World");
}
