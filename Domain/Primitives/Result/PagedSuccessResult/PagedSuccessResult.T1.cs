using System.Net;
using Domain.Primitives.Result.SuccessResult;

namespace Domain.Primitives.Result.PagedSuccessResult;

public class PagedSuccessResult<T> : SuccessResult<T>
{
    public int TotalItens { get; set; }

    public PagedSuccessResult(T data, int totalItens, HttpStatusCode code = HttpStatusCode.OK) : base(data, code)
    {
        TotalItens = totalItens;
    }
}