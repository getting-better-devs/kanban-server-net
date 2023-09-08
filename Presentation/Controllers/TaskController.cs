using Application.DTOs;
using Application.DTOs.Task;
using Application.UseCases.Task.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("/")]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessExample))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(FailExample))]
    public async Task<IActionResult> Create(
        [FromServices] ICreateTaskUseCase createTask,
        [FromBody] CreateTaskDto task)
    {
        return Ok(await createTask.ExecuteAsync(task));
    }
}