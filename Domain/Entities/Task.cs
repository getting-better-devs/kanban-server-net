using Domain.Primitives;

namespace Domain.Entities;

public class Task : Entity
{
    public string Name { get; set; } = string.Empty;
}