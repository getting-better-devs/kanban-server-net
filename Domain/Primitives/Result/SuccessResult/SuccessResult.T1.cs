using System.Net;

namespace Domain.Primitives.Result.SuccessResult;

public class SuccessResult<T> : Result<T>
{
    public SuccessResult(T data, HttpStatusCode code = HttpStatusCode.OK) : base(data, code) => Success = true;
}
