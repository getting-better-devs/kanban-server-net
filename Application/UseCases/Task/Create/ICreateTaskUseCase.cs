using Application.DTOs.Task;

namespace Application.UseCases.Task.Create;

public interface ICreateTaskUseCase
{
    Task<CreateTaskDto> ExecuteAsync(CreateTaskDto createTaskDto);
}