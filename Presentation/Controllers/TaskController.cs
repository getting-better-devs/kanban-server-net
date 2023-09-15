using Application.DTOs.Task;
using Application.UseCases.Task.Create;
using Application.UseCases.Task.GetAll;
using Domain.Primitives.Result.PagedSuccessResult;
using Domain.Primitives.Result.SuccessResult;
using Domain.Primitives.Result.ValidationResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("/")]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResult<CreateTaskDto>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResult))]
    public async Task<IActionResult> Create(
        [FromServices] ICreateTaskUseCase createTask,
        [FromBody] CreateTaskDto task)
    {
        var result = await createTask.ExecuteAsync(task);

        return result switch
        {
            SuccessResult<CreateTaskDto> successResult => new OkObjectResult(successResult),
            ValidationErrorResult errorResult => new BadRequestObjectResult(errorResult),
            _ => new StatusCodeResult(StatusCodes.Status500InternalServerError)
        };
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PagedSuccessResult<List<GetTasksDto>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResult))]
    public async Task<IActionResult> Get(
        [FromServices] IGetAllTasksUseCase getAllTasks,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10)
    {
        var result = await getAllTasks.ExecuteAsync(page, pageSize);

        return result switch
        {
            PagedSuccessResult<List<GetTasksDto>> successResult => new OkObjectResult(successResult),
            ValidationErrorResult errorResult => new BadRequestObjectResult(errorResult),
            _ => new StatusCodeResult(StatusCodes.Status500InternalServerError)
        };
    }
}