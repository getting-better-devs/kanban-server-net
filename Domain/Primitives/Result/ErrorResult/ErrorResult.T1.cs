﻿using System.Net;
using Domain.Interfaces.Primitives;

namespace Domain.Primitives.Result.ErrorResult;

public class ErrorResult<T> : Result<T>, IErrorResult
{
    public ErrorResult(string message) : this(message, Array.Empty<string>())
    { }
    
    public ErrorResult(
        string message, 
        IReadOnlyCollection<string> errors,
        HttpStatusCode code = HttpStatusCode.InternalServerError) : base(default!)
    {
        Code = code;
        Message = message;
        Success = false;
        Errors = errors;
    }
    
    public string Message { get; }
    public IReadOnlyCollection<string> Errors { get; }
}