using Domain.Primitives.Result;

namespace Domain.Interfaces.Primitives;

public interface IErrorResult
{
    string Message { get; }
    IReadOnlyCollection<string> Errors { get; }
}