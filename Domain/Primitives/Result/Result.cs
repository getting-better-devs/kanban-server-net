using System.Net;

namespace Domain.Primitives.Result;

public abstract class Result
{
    public bool Success { get; protected set; }
    public bool Failure => !Success;
    public HttpStatusCode Code { get; set; }
}