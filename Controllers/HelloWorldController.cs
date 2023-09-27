using Microsoft.AspNetCore.Mvc;

namespace curso_apis_.net.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;
    private readonly ILogger<HelloworldService> _Logger;

    public HelloWorldController(IHelloWorldService helloWorld, ILogger<HelloworldService> Logger)
    {
        helloWorldService = helloWorld;
        _Logger = Logger;
    }
    [HttpGet]
    public IActionResult Get()
    {
        _Logger.LogInformation("[Information] Llamado a Get de HelloWorld");
        _Logger.LogDebug("[Debug] Llamado a Get de HelloWorld");
        return Ok(helloWorldService.GetHelloWorld());
    }
}