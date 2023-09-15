using Application.DTOs.Task;
using Domain.Primitives.Result;
using Domain.Primitives.Result.PagedSuccessResult;

namespace Application.UseCases.Task.GetAll;

public interface IGetAllTasksUseCase
{
    Task<Result> ExecuteAsync(int page, int pageSize);
}