using GerenciadorDeTareas.Comunication.Enum;

namespace GerenciadorDeTareas.Comunication.Responses;
public class ResponseTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public Enum.TaskStatus Status { get; set; }  
}
