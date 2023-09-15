using Application.DTOs.Task;
using Domain.Primitives.Result;
using Domain.Primitives.Result.PagedSuccessResult;
using Domain.Primitives.Result.ValidationResult;

namespace Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase : IGetAllTasksUseCase
{
    public async Task<Result> ExecuteAsync(int page, int pageSize)
    {
        List<GetTasksDto> tasks = new()
        {
            new GetTasksDto { Id = 1, Name = "Task 1" },
            new GetTasksDto { Id = 2, Name = "Task 2" },
            new GetTasksDto { Id = 3, Name = "Task 3" },
            new GetTasksDto { Id = 4, Name = "Task 4" },
            new GetTasksDto { Id = 5, Name = "Task 5" },
            new GetTasksDto { Id = 6, Name = "Task 6" },
            new GetTasksDto { Id = 7, Name = "Task 7" },
            new GetTasksDto { Id = 8, Name = "Task 8" },
            new GetTasksDto { Id = 9, Name = "Task 9" },
            new GetTasksDto { Id = 10, Name = "Task 10" },
            new GetTasksDto { Id = 11, Name = "Task 11" },
            new GetTasksDto { Id = 12, Name = "Task 12" },
            new GetTasksDto { Id = 13, Name = "Task 13" },
            new GetTasksDto { Id = 14, Name = "Task 14" },
            new GetTasksDto { Id = 15, Name = "Task 15" },
            new GetTasksDto { Id = 16, Name = "Task 16" },
            new GetTasksDto { Id = 17, Name = "Task 17" },
            new GetTasksDto { Id = 18, Name = "Task 18" },
            new GetTasksDto { Id = 19, Name = "Task 19" },
            new GetTasksDto { Id = 20, Name = "Task 20" },
            new GetTasksDto { Id = 21, Name = "Task 21" },
            new GetTasksDto { Id = 22, Name = "Task 22" },
            new GetTasksDto { Id = 23, Name = "Task 23" },
            new GetTasksDto { Id = 24, Name = "Task 24" },
            new GetTasksDto { Id = 25, Name = "Task 25" },
            new GetTasksDto { Id = 26, Name = "Task 26" }
        };
        
        return new ValidationErrorResult("An error has occurred!", new List<string>() { "Error 1", "Error 2" });
        
        return new PagedSuccessResult<List<GetTasksDto>>(tasks, tasks.Count);
    }
}