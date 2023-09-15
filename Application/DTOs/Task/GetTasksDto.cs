namespace Application.DTOs.Task;

public record GetTasksDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}