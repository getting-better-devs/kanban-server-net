using System.Net;

namespace Domain.Primitives.Result;

public abstract class Result<T> : Result
{
    private T _data = default!;

    protected Result(T data) 
    {
        Data = data;
    }

    protected Result(T data, HttpStatusCode code) : this(data)
    {
        Code = code;
    }

    public T Data
    {
        get => Success 
            ? _data 
            : throw new InvalidOperationException($"You can't access {nameof(Data)} when {nameof(Success)} is false");
        set => _data = value;
    }
}