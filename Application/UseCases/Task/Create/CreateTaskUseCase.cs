using Application.DTOs.Task;
using Domain.Primitives.Result;
using Domain.Primitives.Result.SuccessResult;
using Domain.Primitives.Result.ValidationResult;


namespace Application.UseCases.Task.Create;

public class CreateTaskUseCase : ICreateTaskUseCase
{
    public async Task<Result> ExecuteAsync(CreateTaskDto createTaskDto)
    {
        var validate = await Validate(createTaskDto);
        
        if (validate.Failure)
            return validate;

        return new SuccessResult<CreateTaskDto>(createTaskDto);
    }

    private async Task<Result> Validate(CreateTaskDto createTaskDto)
    {
        var validator = new CreateTaskValidator();
        var result = await validator.ValidateAsync(createTaskDto);

        if (result.IsValid)
            return new SuccessResult();
        
        var errors = result.Errors
            .Select(x => x.ErrorMessage)
            .ToList();
        
        return new ValidationErrorResult("An error has occurred!", errors);
    }
}