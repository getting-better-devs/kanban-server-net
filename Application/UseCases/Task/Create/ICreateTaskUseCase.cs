using Application.DTOs.Task;
using Domain.Primitives.Result;

namespace Application.UseCases.Task.Create;

public interface ICreateTaskUseCase
{
    Task<Result> ExecuteAsync(CreateTaskDto createTaskDto);
}