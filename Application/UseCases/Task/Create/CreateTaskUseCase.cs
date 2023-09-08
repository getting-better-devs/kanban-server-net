using Application.DTOs.Task;
using FluentValidation;
using FluentValidation.Results;

namespace Application.UseCases.Task.Create;

public class CreateTaskUseCase : ICreateTaskUseCase
{
    public async Task<CreateTaskDto> ExecuteAsync(CreateTaskDto createTaskDto)
    {
        await Validate(createTaskDto);
        
        return createTaskDto;
    }

    private async System.Threading.Tasks.Task Validate(CreateTaskDto createTaskDto)
    {
        var validator = new CreateTaskValidator();
        var result = await validator.ValidateAsync(createTaskDto);

        if (!result.IsValid)
            throw new ValidationException(result.Errors);
    }
}