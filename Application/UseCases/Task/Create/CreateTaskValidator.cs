using Application.DTOs.Task;
using FluentValidation;

namespace Application.UseCases.Task.Create;

public class CreateTaskValidator : AbstractValidator<CreateTaskDto>
{
    public CreateTaskValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title should not be empty")
            .NotNull()
            .WithMessage("Title should not be null")
            .MaximumLength(50)
            .WithMessage("Title must be between 1 and 50 characters");
        
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Description should not be empty")
            .NotNull()
            .WithMessage("Description should not be null")
            .MaximumLength(500)
            .WithMessage("Description must be between 1 and 500 characters");
    }
}