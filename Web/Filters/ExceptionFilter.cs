using System.Net;
using Domain.Primitives.Result.ErrorResult;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.Filters;

public class ExceptionFilter : IExceptionFilter
{
    private readonly IHostEnvironment _env;

    public ExceptionFilter(IHostEnvironment env)
    {
        _env = env;
    }
    
    public void OnException(ExceptionContext context)
    {
        var message = _env.IsDevelopment()
            ? context.Exception.StackTrace ?? string.Empty
            : "An unknown error occurred.";
        
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Result = new ObjectResult(new ErrorResult(message));
    }
}