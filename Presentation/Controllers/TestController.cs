using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("/")]
public class TestController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessExample))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(FailExample))]
    public IActionResult Get()
    {
        return new OkResult();
    }
}