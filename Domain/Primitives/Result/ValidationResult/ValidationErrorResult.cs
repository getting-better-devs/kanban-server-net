using System.Net;

namespace Domain.Primitives.Result.ValidationResult;

public class ValidationErrorResult : ErrorResult.ErrorResult
{
    public ValidationErrorResult(
        string message, 
        IReadOnlyCollection<string> errors) : base(message, errors, HttpStatusCode.BadRequest)
    { }
}