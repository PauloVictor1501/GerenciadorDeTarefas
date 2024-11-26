using GerenciadorDeTareas.Comunication.Enum;

namespace GerenciadorDeTareas.Comunication.Responses;
public class ResponseCreateTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
}
